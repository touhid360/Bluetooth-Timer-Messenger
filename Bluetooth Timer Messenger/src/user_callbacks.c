
#include "user_callbacks.h"
#include "main.h"
#include <glib.h>
#include <app_control.h>
#include <string.h>

#define TIME_STRING_FORMAT_BUFFER_SIZE 10

GList *devices_list = NULL;
Evas_Object *ap_name_entry = NULL;
Evas_Object *message_entry = NULL;
Evas_Object *label_success = NULL;
Evas_Object *time_entry = NULL;
Evas_Object *label_current_time = NULL;
Evas_Object *password_entry = NULL;

int my_socket_fd = -1, server_socket_fd = -1;
bt_advertiser_h advertiser = NULL;
bt_gatt_client_h client;

typedef struct _Eo_Opaque Ecore_Timer;

/* Enable or disable bluetooth */
int bt_onoff_operation(void)
{
    int ret = 0;
    app_control_h service = NULL;
    app_control_create(&service);

    if (service == NULL) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "service_create failed!\n");
        return -1;
    }

    app_control_set_operation(service, "http://tizen.org/appcontrol/operation/edit");
    app_control_set_mime(service, "application/x-bluetooth-on-off");
    ret = app_control_send_launch_request(service, NULL, NULL);

    app_control_destroy(service);
    if (ret == APP_CONTROL_ERROR_NONE) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded to Bluetooth On/Off app!\n");
        return 0;
    } else {
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to relaunch Bluetooth On/Off app!\n");
        return -1;
    }
}

char *remote_server_address = NULL; // Server address for connecting

/* Called when you get bonded devices repeatedly */
bool adapter_bonded_device_cb(bt_device_info_s *device_info, void *user_data)
{
    if (device_info == NULL)
        return true;

    if (!strcmp(device_info->remote_name, (char *)user_data)) {
        dlog_print(DLOG_DEBUG, LOG_TAG,
                   "The server device is found in bonded device list. Address(%s)",
                   device_info->remote_address);
        remote_server_address = strdup(device_info->remote_address);
        }

    /* Get information about bonded device */
    static int count_of_bonded_device = 1;

    dlog_print(DLOG_DEBUG, LOG_TAG, "Get information about the bonded device(%d)",
               count_of_bonded_device);
    dlog_print(DLOG_DEBUG, LOG_TAG, "remote address = %s.", device_info->remote_address);
    dlog_print(DLOG_DEBUG, LOG_TAG, "remote name = %s.", device_info->remote_name);
    dlog_print(DLOG_DEBUG, LOG_TAG, "service count = %d.", device_info->service_count);
    dlog_print(DLOG_DEBUG, LOG_TAG, "bonded %s.", device_info->is_bonded ? "true" : "false");
    dlog_print(DLOG_DEBUG, LOG_TAG, "connected %s.", device_info->is_connected ? "true" : "false");
    dlog_print(DLOG_DEBUG, LOG_TAG, "authorized %s.",
               device_info->is_authorized ? "true" : "false");

    elm_entry_entry_set(ap_name_entry, device_info->remote_address);

    dlog_print(DLOG_DEBUG, LOG_TAG, "major_device_class %d.",
               device_info->bt_class.major_device_class);
    dlog_print(DLOG_DEBUG, LOG_TAG, "minor_device_class %d.",
               device_info->bt_class.minor_device_class);
    dlog_print(DLOG_DEBUG, LOG_TAG, "major_service_class_mask %d.",
               device_info->bt_class.major_service_class_mask);
    count_of_bonded_device++;   // Keep iterating

    return true;
}

/* Called when the process of creating bond finishes */
void device_bond_created_cb(int result, bt_device_info_s *device_info, void *user_data)
{
    if (result != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_device_bond_created_cb] Failed. result(%d).", result);
        return;
    }

    if (remote_server_address != NULL && device_info != NULL
            && !strcmp(device_info->remote_address, remote_server_address)) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: A bond with chat_server is created.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: The number of service - %d.",
                   device_info->service_count);
        dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: is_bonded - %d.", device_info->is_bonded);
        dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: is_connected - %d.", device_info->is_connected);
    } else {
    	dlog_print(DLOG_ERROR, LOG_TAG, "Callback: A bond with another device is created.");
    }
}

/* Bluetooth visibility setting application to change visibility mode */
int bt_set_visibility_operation(void *data, Evas_Object *obj, void *event_info)
{
    int ret = 0;
    app_control_h service = NULL;
    app_control_create(&service);

    if (service == NULL) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "service_create failed!\n");
        return 0;
    }

    app_control_set_operation(service, "http://tizen.org/appcontrol/operation/edit");
    app_control_set_mime(service, "application/x-bluetooth-visibility");
    ret = app_control_send_launch_request(service, NULL, NULL);

    app_control_destroy(service);
    if (ret == APP_CONTROL_ERROR_NONE) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded to Bluetooth On/Off app!\n");
        return 0;
    } else {
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to relaunch Bluetooth On/Off app!\n");
        return -1;
    }
}

/* Finding other devices */
void _bluetooth_finding_devices_cb(appdata_s *ad, Evas_Object *obj, void *event_info)
{
    /* Start discovery devices */
    int ret = bt_adapter_start_device_discovery();
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_adapter_start_discover_device] Failed.");
    }

    /* Check the current visibility of your device */
    bt_adapter_visibility_mode_e mode;
    int duration = 1;
    bt_adapter_get_visibility(&mode, &duration);

    if (mode == BT_ADAPTER_VISIBILITY_MODE_NON_DISCOVERABLE) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "The device is not discoverable.");
    } else {
        dlog_print(DLOG_DEBUG, LOG_TAG, "The device is discoverable for a set period of time.");
    }

    char *remote_server_name = "server device";

    /* Querying bonded devices */
    ret = bt_adapter_foreach_bonded_device(adapter_bonded_device_cb, remote_server_name);
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_adapter_foreach_bonded_device] Failed!");
        free(remote_server_address);
        return;
    }

    /* Get notified when the bonding has finished */
    ret = bt_device_set_bond_created_cb(device_bond_created_cb, NULL);
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_device_set_bond_created_cb] failed.");
        free(remote_server_address);
        return;
    }
}

/* Connecting to Other Devices Using SPP */

const char *my_uuid = "00001101-0000-1000-8000-00805F9B34FB";

/* Called when the socket connection state changes */
void socket_connection_state_changed(int result, bt_socket_connection_state_e connection_state,
                                     bt_socket_connection_s *connection, void *user_data)
{
    if (result != BT_ERROR_NONE) {
    	dlog_print(DLOG_ERROR, LOG_TAG, "[socket_connection_state_changed_cb] Failed. result = %d.",
                   result);
        return;
    }

    /* Share data between devices after establishing a connection */
    if (connection_state == BT_SOCKET_CONNECTED) {

        if (connection != NULL) {
            dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: Socket of connection - %d.",
                       connection->socket_fd);
            dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: Role of connection - %d.",
                       connection->local_role);
            dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: Address of connection - %s.",
                       connection->remote_address);

            /* Disconnect unused socket */
            if (server_socket_fd != -1)
                bt_socket_disconnect_rfcomm(server_socket_fd);

            /* socket_fd is used for sending data and disconnecting a device */
            server_socket_fd = connection->socket_fd;

            PRINT_MSG("Sending message...");
            //char data[] = "Sending test";
            char *message = elm_entry_entry_get(message_entry);
            PRINT_MSG(message);
            /* Send data */
            int ret = bt_socket_send_data(server_socket_fd, message,30);
            if (ret < 0) {
                PRINT_MSG("[bt_socket_send_data] failed.");
                dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_send_data] failed.");
                return;
            }
        } else {
            dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: No connection data");
        }
    } else {
    	server_socket_fd = -1;
        dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: Disconnected.");

        if (connection != NULL) {
        	dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: Socket of disconnection - %d.",
                       connection->socket_fd);
            dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: Address of connection - %s.",
                       connection->remote_address);
        } else {
            dlog_print(DLOG_DEBUG, LOG_TAG, "Callback: No connection data");
        }
    }
}

/* Called when data received */
void _bt_socket_data_received_cb(bt_socket_received_data_s *data, void *user_data)
{
    if (data == NULL) {
        PRINT_MSG("No received data!");
        dlog_print(DLOG_DEBUG, LOG_TAG, "No received data!");
        return;
    }

    PRINT_MSG("Received Data: %s", data->data);
    dlog_print(DLOG_DEBUG, LOG_TAG, "Socket fd: %d", data->socket_fd);
    dlog_print(DLOG_DEBUG, LOG_TAG, "Data: %s", data->data);
    dlog_print(DLOG_DEBUG, LOG_TAG, "Size: %d", data->data_size);
}

/* Connecting as a server */
void _bluetooth_services_init()
{
    /* To establish a connection, create a RFCOMM Bluetooth socket */
    int ret = bt_socket_create_rfcomm(my_uuid, &my_socket_fd);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("bt_socket_create_rfcomm() failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "bt_socket_create_rfcomm() failed.");
        return;
    }

    /* Get notified about which device connects to your device */
    ret = bt_socket_set_connection_state_changed_cb(socket_connection_state_changed, NULL);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("[bt_socket_set_connection_state_changed_cb] failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_set_connection_state_changed_cb] failed.");
        return;
    }

    /* Listen for an incoming connection */
    ret = bt_socket_listen_and_accept_rfcomm(my_socket_fd, 5);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("[bt_socket_listen_and_accept_rfcomm] failed. %d", ret);
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_listen_and_accept_rfcomm] failed.");
        return;
    }

    /* Read data from other devices */
    ret = bt_socket_set_data_received_cb(_bt_socket_data_received_cb, NULL);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("[bt_socket_set_data_received_cb] failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_set_data_received_cb] failed.");
        return;
    }
}

//get the current time from system and display as HH:MM:SS
static char* _get_current_time(void) {
	char *time_buff = (char *) calloc(TIME_STRING_FORMAT_BUFFER_SIZE,
			sizeof(char));
	time_t current_time;

	time(&current_time);
	strftime(time_buff, TIME_STRING_FORMAT_BUFFER_SIZE, "%H:%M:%S",
			localtime(&current_time));
	return time_buff;
}

/* Connecting as a client */
void _bluetooth_serial_port_cb(appdata_s *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
		const char *input,*currenttime;
		input = elm_object_text_get(ad->timebox);
		currenttime = _get_current_time();
		elm_object_text_set(ad->label,  currenttime);
		if (strcmp(input, currenttime) == 0) {

		    const char *service_uuid = "00001101-0000-1000-8000-00805F9B34FB";
		    elm_object_text_set(obj, "Send message through socket");

		    /* Send message if already connected to the server */
		    if (server_socket_fd != -1) {
		        PRINT_MSG("Sending message...");
		        const char *message = elm_entry_entry_get(message_entry);
		        PRINT_MSG(message);
		        /* Send data */
		        int ret = bt_socket_send_data(server_socket_fd, message, 30);
		        if (ret < 0) {
		            dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_send_data] failed.");
		        } else
		            return;
		    } else {
		        const char *remote_server_address = elm_entry_entry_get(ap_name_entry);

		        if (!strcmp(remote_server_address, "")) {
		        	return;
		        }

		        /* Request a connection to the Bluetooth server */
		        PRINT_MSG("Connecting to the server...");
		        int ret = bt_socket_connect_rfcomm(remote_server_address, service_uuid);
		        if (ret != BT_ERROR_NONE) {
		            dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_connect_rfcomm] failed.");
		            return;
		        } else {
		            dlog_print(DLOG_DEBUG, LOG_TAG,
		                       "[bt_socket_connect_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.");
		        }
		    }
		}
}

bt_error_e ret;
const char *file_name = "tempfile";

/* Called when a file is being transfered. */
void bt_opp_server_transfer_progress_cb_for_opp(const char *file, long long size, int percent,
        void *user_data)
{
    dlog_print(DLOG_DEBUG, LOG_TAG, "size: %ld", (long)size);
    dlog_print(DLOG_DEBUG, LOG_TAG, "percent: %d", percent);
    dlog_print(DLOG_DEBUG, LOG_TAG, "file: %s", file);
}

/* Called when a file is finished. */
void bt_opp_server_transfer_finished_cb_for_opp(int result, const char *file, long long size,
        void *user_data)
{
    if (result < 0) {
        PRINT_MSG("Failed");
        return;
    }

    PRINT_MSG("Succeeded");
    dlog_print(DLOG_DEBUG, LOG_TAG, "size: %ld", (long)size);
    dlog_print(DLOG_DEBUG, LOG_TAG, "file: %s", file);
}

/* Called when an OPP connection is requested */
void connection_requested_cb_for_opp_server(const char *remote_address, void *user_data)
{
    dlog_print(DLOG_DEBUG, LOG_TAG, "remote_address: %s", remote_address);
    /* Accept a file push request */
    ret = bt_opp_server_accept(bt_opp_server_transfer_progress_cb_for_opp,
                               bt_opp_server_transfer_finished_cb_for_opp, file_name, NULL, NULL);
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_opp_server_accept] Failed.");
    }
}

/* Notified when the Bluetooth adapter has enabled or disabled */
void adapter_state_changed_cb(int result, bt_adapter_state_e adapter_state, void *user_data)
{
    if (result != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[adapter_state_changed_cb] Failed! result=%d", result);
        return;
    }

    if (adapter_state == BT_ADAPTER_ENABLED) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "[adapter_state_changed_cb] Bluetooth is enabled!");

        /* Get information about Bluetooth adapter */
        char *local_address = NULL;
        bt_adapter_get_address(&local_address);
        dlog_print(DLOG_DEBUG, LOG_TAG, "[adapter_state_changed_cb] Adapter address: %s.",
                   local_address);
        free(local_address);
        char *local_name = NULL;
        bt_adapter_get_name(&local_name);
        dlog_print(DLOG_DEBUG, LOG_TAG, "[adapter_state_changed_cb] Adapter name: %s.", local_name);
        free(local_name);

        /* Visibility mode of the Bluetooth device */
        bt_adapter_visibility_mode_e mode;
        int duration = 1;       // Duration until the visibility mode is changed so that other devices cannot find your device
        bt_adapter_get_visibility(&mode, &duration);

        switch (mode) {
        case BT_ADAPTER_VISIBILITY_MODE_NON_DISCOVERABLE:
            dlog_print(DLOG_DEBUG, LOG_TAG,
                       "[adapter_state_changed_cb] Visibility: NON_DISCOVERABLE");
            break;

        case BT_ADAPTER_VISIBILITY_MODE_GENERAL_DISCOVERABLE:
            dlog_print(DLOG_DEBUG, LOG_TAG,
                       "[adapter_state_changed_cb] Visibility: GENERAL_DISCOVERABLE");
            break;

        case BT_ADAPTER_VISIBILITY_MODE_LIMITED_DISCOVERABLE:
            dlog_print(DLOG_DEBUG, LOG_TAG,
                       "[adapter_state_changed_cb] Visibility: LIMITED_DISCOVERABLE");
            break;
        }

        char *directory = NULL;
        storage_get_directory(0, STORAGE_DIRECTORY_DOWNLOADS, &directory);

        /* Initialize OPP server */
        int ret = bt_opp_server_initialize_by_connection_request(directory,
                  connection_requested_cb_for_opp_server,
                  NULL);
        free(directory);
        if (ret != BT_ERROR_NONE) {
            dlog_print(DLOG_ERROR, LOG_TAG,
                       "[bt_opp_server_initialize_by_connection_request] Failed.");
        }
        _bluetooth_services_init();

    } else {
        dlog_print(DLOG_DEBUG, LOG_TAG, "[adapter_state_changed_cb] Bluetooth is disabled!");
    }
}


/* Called when each file is being transfered */
void __bt_opp_client_push_progress_cb(const char *file,
                                      long long size, int percent, void *user_data)
{
    dlog_print(DLOG_DEBUG, LOG_TAG, "size: %ld", (long)size);
    dlog_print(DLOG_DEBUG, LOG_TAG, "percent: %d", percent);
    dlog_print(DLOG_DEBUG, LOG_TAG, "file: %s", file);
}

/* Called when the push request is finished */
void __bt_opp_client_push_finished_cb(int result, const char *remote_address, void *user_data)
{
    PRINT_MSG("Finished");
    dlog_print(DLOG_DEBUG, LOG_TAG, "result: %d", result);
    dlog_print(DLOG_DEBUG, LOG_TAG, "remote_address: %s", remote_address);

    /* Delete file info */
    int ret = bt_opp_client_clear_files();
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "bt_opp_client_clear_files() failed");
        return;
    }
}

/* Called when OPP server responds to the push request */
void __bt_opp_client_push_responded_cb(int result, const char *remote_address, void *user_data)
{
    if (result < 0) {
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed with result: %d", result);
    } else {
        dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded");
        PRINT_MSG("Succeeded");
    }

    dlog_print(DLOG_DEBUG, LOG_TAG, "remote_address: %s", remote_address);
}

/* Client Role */
void _bluetooth_opp_cb(appdata_s *ad, Evas_Object *obj, void *event_info)
{
    remote_server_address = strdup(elm_object_part_text_get(ap_name_entry, NULL));

    if (!strcmp(remote_server_address, "")) {
        return;
    }

    bt_opp_client_deinitialize();
    /* Initialize the client */
    bt_error_e ret;
    ret = bt_opp_client_initialize();
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "bt_opp_client_initialize() failed");
    }

    /* Get the information of a file that can be sent to the server device */
    char file_path[100] = { '\0', };
    char *resource_path = app_get_shared_resource_path();
    snprintf(file_path, sizeof(file_path) - 1, "%s/bluetooth.png", resource_path);
    free(resource_path);

    ret = bt_opp_client_add_file(file_path);
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "bt_opp_client_add_file() failed");
        return;
    }

    /* Send the files to the server */
    ret = bt_opp_client_push_files(remote_server_address, __bt_opp_client_push_responded_cb,
                                   __bt_opp_client_push_progress_cb,
                                   __bt_opp_client_push_finished_cb, NULL);
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_opp_client_push_files] Failed.");
    } else {
        dlog_print(DLOG_DEBUG, LOG_TAG, "[bt_opp_client_push_files] Succeeded.");
    }
}

void __write_completed_cb(int result, bt_gatt_h request_handle, void *user_data)
{
    dlog_print(DLOG_DEBUG, LOG_TAG, "[__write_completed_cb] has been invoked");
}

Evas_Object *services_list;

Eina_Bool _bluetooth_le_stop_scan(void *data)
{
    ret = bt_adapter_le_stop_scan();
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_adapter_le_stop_scan] Failed with error %d.", ret);
    }

    return EINA_FALSE;
}

void _display_destroy_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
    int i;
    for (i = 0; i < g_list_length(devices_list); i++) {
        void *device_info = g_list_nth_data(devices_list, i);
        free(device_info);
    }
}

void _activate_bluetooth() {

	    /* Send message if already connected to the server */
	    if (server_socket_fd != -1) {
	        PRINT_MSG("Sending message...");
	        char data[] = "Sending test message";

	        /* Send data */
	        int ret = bt_socket_send_data(server_socket_fd, data,30);
	        if (ret < 0) {
	            dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_send_data] failed.");
	        } else
	            return;
	    }
}

/* Called when entry text is changed. It allows to change peer device */
void _entry_changed(void *data, Evas_Object *obj, void *event_info)
{
    if (server_socket_fd != -1)
        bt_socket_disconnect_rfcomm(server_socket_fd);
    server_socket_fd = -1;
}

// bluetooth timer
void ecore_timer_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	const char *input,*currenttime;
	input = elm_object_text_get(ad->timebox);
	currenttime = _get_current_time();
	elm_object_text_set(ad->label,  currenttime);
	if (strcmp(input, currenttime) == 0) {
		_activate_bluetooth(ad);
	}
}

Eina_Bool _pop_cb(void *data, Elm_Object_Item *item)
{
    Evas_Object *pop_win = (Evas_Object *)evas_object_data_get(services_list, "inwin");

    if ((int)(evas_object_visible_get(pop_win)))
        evas_object_del(pop_win);
    else
        elm_win_lower(((appdata_s *)data)->win);

    return EINA_FALSE;
}

/* Called after wifi_activate() is completed */
static void _wifi_activated_cb(wifi_error_e result, void *user_data)
{
    if (result == WIFI_ERROR_NONE) {
        PRINT_MSG("Succeeded to activate Wi-Fi");
        dlog_print(DLOG_DEBUG, LOG_TAG, "[_wifi_activated_cb] Succeeded to activate Wi-Fi device");
    }
}

void _wifi_scenario(appdata_s *ad, Evas_Object *obj, void *event_info)
{
    int error_code;
    bool wifi_activated = false;

    /* Check Wi-Fi connection */
    error_code = wifi_is_activated(&wifi_activated);
    if (error_code != WIFI_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_is_activated] failed");
    }

    if (wifi_activated) {
        PRINT_MSG("Wi-Fi is activated.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded to get Wi-Fi device state.");
    } else {
        PRINT_MSG("Wi-Fi is not activated.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to get Wi-Fi device state.");

        /* Activate Wi-Fi */
        PRINT_MSG("Activating Wi-Fi");
        error_code = wifi_activate(_wifi_activated_cb, NULL);
        if (error_code != WIFI_ERROR_NONE) {
            PRINT_MSG("Activation failed %d", error_code);
            dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_activate] failed %d", error_code);
        }
        return;
    }
}

void create_buttons_in_main_window(appdata_s *ad)
{
	 wifi_deactivate(NULL, NULL);
	    Evas_Object *display = _create_new_cd_display(ad, "", _pop_cb);
	    evas_object_event_callback_add(display, EVAS_CALLBACK_FREE, _display_destroy_cb, NULL);

	        bt_error_e ret;
	        int error_code;

	 /* Initializing Wi-Fi */
	    error_code = wifi_initialize();
	    if (error_code == WIFI_ERROR_NOT_SUPPORTED) {
	        dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_initialize] Failed.");
	        return;
	    } else if (error_code != WIFI_ERROR_NONE) {
	        dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_initialize] Failed.");
	        return;
	    } else {
	        dlog_print(DLOG_DEBUG, LOG_TAG, "[wifi_initialize] Success.");
	    }

    /* Initializing bluetooth */
    ret = bt_initialize();
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_initialize] Failed.");
        return;
    }

    /* Track state changes */
    ret = bt_adapter_set_state_changed_cb(adapter_state_changed_cb, NULL);
    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_adapter_set_state_changed_cb()] Failed.");
    }

    /* Check whether the Bluetooth Service is enabled */
    bt_adapter_state_e state;
    bt_adapter_get_state(&state);


    if (state == BT_ADAPTER_ENABLED) {

        /* Initialize OPP server */
        char *directory = NULL;
        storage_get_directory(ad->internal_storage_id, STORAGE_DIRECTORY_DOWNLOADS, &directory);

        int ret = bt_opp_server_initialize_by_connection_request(directory,
                  connection_requested_cb_for_opp_server,
                  NULL);
        free(directory);
        if (ret != BT_ERROR_NONE) {
            dlog_print(DLOG_ERROR, LOG_TAG,
                       "[bt_opp_server_initialize_by_connection_request] Failed.");
        }
        _bluetooth_services_init();
    } else {
        ret = bt_onoff_operation();
        if (ret != 0) {
      return;
        }
    }
    // timer
    Ecore_Timer *timer = ecore_timer_add(1, _bluetooth_serial_port_cb, ad);

    //top three buttons
    _new_button(ad, display, "Activate Wi-Fi", _wifi_scenario);
    _new_button(ad, display, "Change visibility", bt_set_visibility_operation);
    _new_button(ad, display, "Get the MAC address of paired device", _bluetooth_finding_devices_cb);

    //MAC address box
    ap_name_entry = elm_entry_add(display);
    elm_object_part_text_set(ap_name_entry, "guide", "MAC address of paired device");
    evas_object_smart_callback_add(ap_name_entry, "changed", _entry_changed, NULL);
    elm_box_pack_end(display, ap_name_entry);
    evas_object_size_hint_weight_set(ap_name_entry, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(ap_name_entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_show(ap_name_entry);

    //message entry box
    message_entry = elm_entry_add(display);
    elm_object_part_text_set(message_entry, "guide", "Enter the Text Message here...");
    evas_object_smart_callback_add(message_entry, "changed", NULL, NULL);
    elm_box_pack_end(display, message_entry);
    evas_object_size_hint_weight_set(message_entry, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(message_entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_show(message_entry);

    //time enrty box
    ad->timebox = elm_entry_add(display);
    elm_object_part_text_set(ad->timebox, "guide", "Enter the Time here...");
    elm_box_pack_end(display, ad->timebox);
    evas_object_size_hint_weight_set(ad->timebox, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(ad->timebox, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_show(ad->timebox);

    ad->label = elm_label_add(display);
    elm_box_pack_end(display, ad->label);
    evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(ad->label, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_show(ad->label);

    label_success = elm_label_add(display);
    elm_box_pack_end(display, label_success);
    evas_object_size_hint_weight_set(label_success, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(label_success, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_show(label_success);
}
