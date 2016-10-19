S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 9944
Date: 2016-09-10 16:15:27+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 9944, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000026d8
r2   = 0x00000006, r3   = 0xb44924c0
r4   = 0x00000002, r5   = 0xb4492000
r6   = 0xb679709c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb69df300
ip   = 0x00000000, sp   = 0xbea4bf0c
lr   = 0xb668df18, pc   = 0xb668cb84
cpsr = 0x200d0010

Memory Information
MemTotal:   730440 KB
MemFree:     56472 KB
Buffers:     43044 KB
Cached:     288328 KB
VmPeak:     111388 KB
VmSize:     105012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25472 KB
VmRSS:       25452 KB
VmData:      35100 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36228 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9944 TID = 9944
9944 9948 10072 

Maps Information
b1d31000 b2530000 rw-p [stack:10072]
b2530000 b2541000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2551000 b2556000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25e2000 b25ea000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25fb000 b25fc000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b260c000 b2620000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2634000 b2635000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2645000 b2648000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2659000 b265a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b266a000 b266c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b267c000 b267e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b268e000 b269e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26ae000 b26ba000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28cb000 b28e2000 r-xp /usr/lib/libnetwork.so.0.0.0
b28f3000 b2931000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2942000 b2949000 r-xp /usr/lib/libefl-extension.so.0.1.0
b295a000 b2969000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2979000 b29ae000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29c1000 b29c7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29d7000 b29e0000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b01000 b2be4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c1b000 b2c43000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c55000 b3454000 rw-p [stack:9948]
b3454000 b3456000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3466000 b3470000 r-xp /lib/libnss_files-2.20-2014.11.so
b3481000 b348a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b349b000 b34ac000 r-xp /lib/libnsl-2.20-2014.11.so
b34bf000 b34c5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34d6000 b34d7000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34ff000 b3506000 r-xp /usr/lib/libminizip.so.1.0.0
b3516000 b351b000 r-xp /usr/lib/libstorage.so.0.1
b352b000 b3580000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3596000 b35aa000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35ba000 b35fe000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b360e000 b3616000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3626000 b3656000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3669000 b3722000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3736000 b378a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b379b000 b37b6000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37c6000 b3887000 r-xp /usr/lib/libprotobuf.so.9.0.1
b389a000 b38ac000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38bc000 b38c0000 r-xp /usr/lib/libogg.so.0.7.1
b38d0000 b38f2000 r-xp /usr/lib/libvorbis.so.0.4.3
b3902000 b39e6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a02000 b3a0f000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a20000 b3a63000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a78000 b3abf000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ad0000 b3ad6000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ae7000 b3aee000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3afe000 b3b3e000 r-xp /usr/lib/libmdm.so.1.2.10
b3b4e000 b3b56000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b65000 b3b75000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b96000 b3bf6000 r-xp /usr/lib/libasound.so.2.0.0
b3c08000 b3c3e000 r-xp /usr/lib/libpulse.so.0.16.2
b3c4f000 b3c52000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c62000 b3c65000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c75000 b3c7a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c8a000 b3c8b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c9b000 b3ca6000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cba000 b3cc1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cd1000 b3cd7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3ce7000 b3cec000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cfc000 b3d17000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d27000 b3d2e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d3e000 b3d41000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d52000 b3d80000 r-xp /usr/lib/libidn.so.11.5.44
b3d90000 b3da6000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3db7000 b3dc1000 r-xp /usr/lib/libcares.so.2.1.0
b3dd1000 b3ddb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3deb000 b3ded000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dfd000 b3dfe000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e0e000 b3e12000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e23000 b3e4b000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e5c000 b3e85000 r-xp /usr/lib/libturbojpeg.so
b3ea5000 b3eab000 r-xp /usr/lib/libgif.so.4.1.6
b3ebb000 b3f01000 r-xp /usr/lib/libcurl.so.4.3.0
b3f12000 b3f33000 r-xp /usr/lib/libexif.so.12.3.3
b3f4e000 b3f63000 r-xp /usr/lib/libtts.so
b3f74000 b3f7c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f8c000 b404c000 r-xp /usr/lib/libdali-core.so.0.0.0
b4057000 b414a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b416a000 b4244000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b425b000 b425d000 r-xp /usr/lib/libboost_system.so.1.51.0
b426d000 b4273000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4283000 b42a6000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42b7000 b42b9000 r-xp /usr/lib/libappsvc.so.0.1.0
b42c9000 b42cb000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42dc000 b42e1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42f8000 b42fa000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b430a000 b4311000 r-xp /usr/lib/libsensord-share.so
b4321000 b4339000 r-xp /usr/lib/libsensor.so.1.1.0
b434a000 b434d000 r-xp /usr/lib/libXv.so.1.0.0
b435d000 b4362000 r-xp /usr/lib/libutilX.so.1.1.0
b4372000 b4377000 r-xp /usr/lib/libappcore-common.so.1.1
b4387000 b438e000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43a1000 b43a5000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43b6000 b4480000 r-xp /usr/lib/libCOREGL.so.4.0
b4497000 b449a000 r-xp /usr/lib/libuuid.so.1.3.0
b44ab000 b44c2000 r-xp /usr/lib/libblkid.so.1.1.0
b44d3000 b44d5000 r-xp /usr/lib/libXau.so.6.0.0
b44e5000 b44e8000 r-xp /usr/lib/libEGL.so.1.4
b44f0000 b44f6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4506000 b4508000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4519000 b4527000 r-xp /usr/lib/libGLESv2.so.2.0
b4530000 b4592000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45a7000 b45bf000 r-xp /usr/lib/libmount.so.1.1.0
b45d0000 b45e4000 r-xp /usr/lib/libxcb.so.1.1.0
b45f5000 b45fc000 r-xp /lib/libcrypt-2.20-2014.11.so
b4634000 b4645000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4656000 b4658000 r-xp /usr/lib/libiri.so
b4668000 b4673000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4684000 b4699000 r-xp /lib/libexpat.so.1.5.2
b46ab000 b4769000 r-xp /usr/lib/libcairo.so.2.11200.14
b477c000 b4784000 r-xp /usr/lib/libdrm.so.2.4.0
b4794000 b4797000 r-xp /usr/lib/libdri2.so.0.0.0
b47a8000 b47f6000 r-xp /usr/lib/libssl.so.1.0.0
b480b000 b4817000 r-xp /usr/lib/libeeze.so.1.13.0
b4827000 b4830000 r-xp /usr/lib/libethumb.so.1.13.0
b4840000 b4843000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4853000 b4a0a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5661000 b566a000 r-xp /usr/lib/libXi.so.6.1.0
b567a000 b567c000 r-xp /usr/lib/libXgesture.so.7.0.0
b568c000 b5690000 r-xp /usr/lib/libXtst.so.6.1.0
b56a0000 b56a6000 r-xp /usr/lib/libXrender.so.1.3.0
b56b6000 b56bc000 r-xp /usr/lib/libXrandr.so.2.2.0
b56cd000 b56cf000 r-xp /usr/lib/libXinerama.so.1.0.0
b56df000 b56e2000 r-xp /usr/lib/libXfixes.so.3.1.0
b56f2000 b56fd000 r-xp /usr/lib/libXext.so.6.4.0
b570d000 b570f000 r-xp /usr/lib/libXdamage.so.1.1.0
b571f000 b5721000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5732000 b5814000 r-xp /usr/lib/libX11.so.6.3.0
b5827000 b582e000 r-xp /usr/lib/libXcursor.so.1.0.2
b583e000 b5856000 r-xp /usr/lib/libudev.so.1.6.0
b5858000 b585b000 r-xp /lib/libattr.so.1.1.0
b586b000 b588b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b588d000 b5892000 r-xp /usr/lib/libffi.so.6.0.2
b58a2000 b58ba000 r-xp /lib/libz.so.1.2.8
b58ca000 b58cc000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58dc000 b59b1000 r-xp /usr/lib/libxml2.so.2.9.2
b59c6000 b5a61000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a7d000 b5a80000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a90000 b5aa9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aba000 b5acb000 r-xp /lib/libresolv-2.20-2014.11.so
b5adf000 b5b59000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b6e000 b5b70000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b80000 b5b87000 r-xp /usr/lib/libembryo.so.1.13.0
b5b97000 b5baf000 r-xp /usr/lib/libpng12.so.0.50.0
b5bc0000 b5be3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c04000 b5c18000 r-xp /usr/lib/libector.so.1.13.0
b5c29000 b5c41000 r-xp /usr/lib/liblua-5.1.so
b5c52000 b5ca9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cbd000 b5ce5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cf6000 b5d09000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d1a000 b5d51000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d62000 b5d70000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d80000 b5d88000 r-xp /usr/lib/libtbm.so.1.0.0
b5d98000 b5da5000 r-xp /usr/lib/libeio.so.1.13.0
b5db5000 b5db7000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc7000 b5dcc000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5ddc000 b5df3000 r-xp /usr/lib/libefreet.so.1.13.0
b5e05000 b5e25000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e35000 b5e55000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e57000 b5e5d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e6d000 b5e7e000 r-xp /usr/lib/libemotion.so.1.13.0
b5e8f000 b5e96000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea6000 b5eb5000 r-xp /usr/lib/libeo.so.1.13.0
b5ec6000 b5ed8000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee9000 b5eee000 r-xp /usr/lib/libecore_file.so.1.13.0
b5efe000 b5f17000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f27000 b5f44000 r-xp /usr/lib/libeet.so.1.13.0
b5f5d000 b5fa5000 r-xp /usr/lib/libeina.so.1.13.0
b5fb6000 b5fc6000 r-xp /usr/lib/libefl.so.1.13.0
b5fd7000 b60bc000 r-xp /usr/lib/libicuuc.so.51.1
b60d9000 b6219000 r-xp /usr/lib/libicui18n.so.51.1
b6230000 b6268000 r-xp /usr/lib/libecore_x.so.1.13.0
b627a000 b627d000 r-xp /lib/libcap.so.2.21
b628d000 b62b6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c7000 b62ce000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62e0000 b6317000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6328000 b6413000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6426000 b649f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64b1000 b64b6000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c6000 b64d0000 r-xp /usr/lib/libvconf.so.0.2.45
b64e0000 b64e2000 r-xp /usr/lib/libvasum.so.0.3.1
b64f2000 b64f4000 r-xp /usr/lib/libttrace.so.1.1
b6504000 b6507000 r-xp /usr/lib/libiniparser.so.0
b6517000 b653d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b654d000 b6552000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6563000 b657a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b658b000 b65f6000 r-xp /lib/libm-2.20-2014.11.so
b6607000 b660d000 r-xp /lib/librt-2.20-2014.11.so
b661e000 b662b000 r-xp /usr/lib/libunwind.so.8.0.1
b6661000 b6785000 r-xp /lib/libc-2.20-2014.11.so
b679a000 b67b3000 r-xp /lib/libgcc_s-4.9.so.1
b67c3000 b68a5000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b6000 b68e0000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68f1000 b692d000 r-xp /usr/lib/libsystemd.so.0.4.0
b692f000 b69b1000 r-xp /usr/lib/libedje.so.1.13.0
b69c4000 b69e2000 r-xp /usr/lib/libecore.so.1.13.0
b6a02000 b6b89000 r-xp /usr/lib/libevas.so.1.13.0
b6bbe000 b6bd2000 r-xp /lib/libpthread-2.20-2014.11.so
b6be6000 b6e1b000 r-xp /usr/lib/libelementary.so.1.13.0
b6e49000 b6e4d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e5d000 b6e64000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e74000 b6e76000 r-xp /usr/lib/libdlog.so.0.0.0
b6e86000 b6e89000 r-xp /usr/lib/libbundle.so.0.1.22
b6e99000 b6e9b000 r-xp /lib/libdl-2.20-2014.11.so
b6eac000 b6ec4000 r-xp /usr/lib/libaul.so.0.1.0
b6ed8000 b6edd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eee000 b6efb000 r-xp /usr/lib/liblptcp.so
b6f0d000 b6f11000 r-xp /usr/lib/libsys-assert.so
b6f22000 b6f42000 r-xp /lib/ld-2.20-2014.11.so
b6f53000 b6f58000 r-xp /usr/bin/launchpad-loader
b788b000 b7c1c000 rw-p [heap]
bea2c000 bea4d000 rw-p [stack]
b788b000 b7c1c000 rw-p [heap]
bea2c000 bea4d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9944)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb668cb84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.bluetooth
Package ID : org.example.bluetooth
Version: 1.0.0
Package Type: tpk
App Name: Timer Messenger
App ID: org.example.bluetooth
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
c: __request_handler(912) > __request_handler: 15
09-10 16:05:56.091+0600 I/MESSAGE_PORT(10401): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:05:56.091+0600 I/MESSAGE_PORT(10401): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 16:05:56.091+0600 I/MESSAGE_PORT(10401): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 16:05:56.091+0600 I/MESSAGE_PORT(10401): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:05:56.101+0600 E/MESSAGE_PORT(10401): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:05:56.101+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 16:05:56.101+0600 I/MESSAGE_PORT(10401): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:05:56.101+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:05:56.101+0600 E/MESSAGE_PORT(10401): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 16:05:56.101+0600 E/weather-common(10401): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 16:05:56.101+0600 E/weather-agent(10401): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 16:05:56.101+0600 E/weather-agent(10401): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 16:05:56.111+0600 I/MESSAGE_PORT(10401): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 16:05:56.111+0600 I/MESSAGE_PORT(10401): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:05:56.141+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:05:56.191+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 16:05:56.191+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 16:05:56.371+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8366388]
09-10 16:05:56.371+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 16:05:56.371+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 16:05:56.371+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 16:05:56.371+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8366388
09-10 16:05:56.371+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 16:05:56.381+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 16:05:56.381+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 16:05:56.381+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 16:05:56.381+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 16:05:56.381+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 16:05:56.401+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:05:56.421+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80177421 is not stable during recalc loop
09-10 16:05:56.491+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80177421 is not stable during recalc loop
09-10 16:05:56.501+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:05:56.511+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 16:05:57.112+0600 E/weather-agent(10401): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 16:05:57.112+0600 I/CAPI_APPFW_APPLICATION(10401): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 16:05:57.112+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:05:57.112+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:05:57.112+0600 E/weather-agent(10401): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 16:05:57.262+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 16:05:57.262+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10401
09-10 16:05:57.262+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[10401] terminate event is forwarded
09-10 16:05:57.262+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:05:57.262+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10401, ]
09-10 16:05:57.262+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:05:57.262+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 16:05:57.262+0600 I/Tizen::App( 1366): (512) > Not registered pid(10401)
09-10 16:05:57.262+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 16:05:57.262+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:05:57.262+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 10401
09-10 16:05:57.262+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 16:05:57.262+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:05:57.262+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10401.
09-10 16:06:00.065+0600 I/APP_CORE( 9944): appcore-efl.c: __do_app(520) > [APP 9944] Event: MEM_FLUSH State: PAUSED
09-10 16:06:02.117+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 400 is changed to 0
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:400
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:400
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 800 is changed to 5
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:800
09-10 16:06:14.839+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:800
09-10 16:06:14.849+0600 E/INDICATOR(  685): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
09-10 16:06:14.849+0600 E/INDICATOR(  685): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
09-10 16:06:14.849+0600 I/SYNCSERVICE( 1063): SyncManager_BatteryStatusListener.cpp: OnBatteryStatusChanged(37) > OnBatteryStatusChanged Starts
09-10 16:06:14.849+0600 I/SYNCSERVICE( 1063): SyncManager_SyncManager.cpp: OnBatteryStatusChanged(376) > SyncManager::OnBatteryStatusChanged Starts
09-10 16:06:14.849+0600 I/SYNCSERVICE( 1063): SyncManager_SyncManager.cpp: OnBatteryStatusChanged(394) > SyncManager::OnBatteryStatusChanged Ends
09-10 16:06:14.849+0600 I/SYNCSERVICE( 1063): SyncManager_BatteryStatusListener.cpp: OnBatteryStatusChanged(43) > OnBatteryStatusChanged Ends
09-10 16:06:14.859+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[event] (status:1)
09-10 16:06:14.859+0600 W/LOCKSCREEN(  869): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
09-10 16:06:14.859+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30001:LCD_ON
09-10 16:06:14.859+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30001 event_info:0
09-10 16:06:14.859+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 16:06:14.859+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
09-10 16:06:14.869+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:06:14.879+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 16:06:14.879+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 16:06:14.889+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 4:06 p.m.
09-10 16:06:14.889+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 4:06 p.m."
09-10 16:06:14.889+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 4:06 p.m."
09-10 16:06:14.889+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 16:06:14.889+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145508174 Time: <font_size=31> </font_size> <font_size=31> 4:06 p.m.</font_size></font>"
09-10 16:06:14.889+0600 E/INDICATOR(  685): battery.c: show_digits(405) > show_digits[405]	 "Show digits: 100"
09-10 16:06:14.889+0600 I/INDICATOR(  685): battery.c: show_battery_icon(376) > "Percentage:(1) / Level:(10) / batt_Full:(1) / battery_charging(0)"
09-10 16:06:14.889+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 16:06:14.889+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:06:14.889+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:06:14.889+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:06:14.889+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:06:14.889+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:06:15.370+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:4
09-10 16:06:15.370+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
09-10 16:06:15.380+0600 W/APP_CORE(  869): appcore-efl.c: __cmsg_cb(1046) > LCD On. Resume the topmost app
09-10 16:06:15.380+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: RESUME State: PAUSED
09-10 16:06:15.380+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:06:15.380+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20004:APP_RESUME
09-10 16:06:15.380+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20004 event_info:0
09-10 16:06:15.380+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_set(725) > [_lcd_timeout_timer_set:725:W] lcd off timer set:30.000000
09-10 16:06:15.380+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 16:06:15.380+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:06:15.380+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 16:06:15.380+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 16:06:15.390+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 16:06:15.390+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:06:15.390+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 16:06:15.390+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:06:15.390+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 10495
09-10 16:06:15.390+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:06:15.440+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 10495
09-10 16:06:15.440+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 10495, appid: com.samsung.weather-m-agent
09-10 16:06:15.460+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10495)
09-10 16:06:15.470+0600 I/Tizen::System( 1366): (280) > The screen has been turned on.
09-10 16:06:15.470+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:06:15.500+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
09-10 16:06:15.510+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:06:15.530+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 16:06:15.530+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 10495.
09-10 16:06:15.840+0600 I/AUL     (10497): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 16:06:15.850+0600 E/weather-agent(10495): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 16:06:15.850+0600 I/AUL     (10497): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 16:06:15.860+0600 E/weather-common(10495): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 16:06:15.860+0600 I/AUL     (10497): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 16:06:15.860+0600 E/weather-agent(10495): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 16:06:15.870+0600 I/AUL     (10497): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 16:06:15.870+0600 E/CAPI_APPFW_APP_MANAGER(10497): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 16:06:15.880+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:06:15.890+0600 I/MESSAGE_PORT(10495): message-port.c: __initialize(872) > initialize
09-10 16:06:15.890+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:06:15.910+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:06:15.910+0600 I/MESSAGE_PORT(10495): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 16:06:15.920+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:06:15.920+0600 E/CAPI_APPFW_APP_MANAGER(  769): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 16:06:15.970+0600 I/AUL     (10146): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:06:15.990+0600 E/LOCKSCREEN(  869): notification-panel.c: __notification_panel_detailed_changed_cb(239) > [__notification_panel_detailed_changed_cb:239:E] Failed to get noti box
09-10 16:06:15.990+0600 I/AUL     (10146): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:06:16.020+0600 I/AUL     (10146): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:06:16.020+0600 I/AUL     (10146): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:06:16.020+0600 E/CAPI_APPFW_APP_MANAGER(10146): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 16:06:16.030+0600 E/QUICKPANEL(  991): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
09-10 16:06:16.030+0600 I/QUICKPANEL(  991): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 1[0;m
09-10 16:06:16.040+0600 E/INDICATOR(  685): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
09-10 16:06:16.040+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:06:16.040+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:06:16.040+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:06:16.040+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:06:16.040+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
09-10 16:06:16.040+0600 W/QUICKPANEL(  991): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
09-10 16:06:16.040+0600 E/EFL     (  991): eo<991> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
09-10 16:06:16.040+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 16:06:16.050+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 16:06:16.050+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 16:06:16.050+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 16:06:16.050+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:06:16.060+0600 E/MESSAGE_PORT(10495): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:06:16.060+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 16:06:16.060+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:06:16.060+0600 E/MESSAGE_PORT(10495): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 16:06:16.060+0600 E/weather-common(10495): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 16:06:16.060+0600 E/weather-agent(10495): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 16:06:16.060+0600 E/weather-agent(10495): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 16:06:16.060+0600 I/MESSAGE_PORT(10495): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:06:16.090+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:06:16.130+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 16:06:16.130+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 16:06:16.280+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8328c00]
09-10 16:06:16.280+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 16:06:16.280+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 16:06:16.280+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 16:06:16.280+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8328c00
09-10 16:06:16.290+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 16:06:16.290+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 16:06:16.290+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 16:06:16.290+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 16:06:16.300+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 16:06:16.300+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 16:06:16.310+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:06:16.340+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80199d35 is not stable during recalc loop
09-10 16:06:16.411+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80199d35 is not stable during recalc loop
09-10 16:06:16.421+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:06:16.431+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 16:06:17.061+0600 E/weather-agent(10495): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 16:06:17.061+0600 I/CAPI_APPFW_APPLICATION(10495): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 16:06:17.071+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:06:17.071+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:06:17.071+0600 E/weather-agent(10495): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 16:06:17.291+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 16:06:17.291+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10495
09-10 16:06:17.301+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[10495] terminate event is forwarded
09-10 16:06:17.301+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:06:17.301+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10495, ]
09-10 16:06:17.301+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:06:17.301+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 16:06:17.301+0600 I/Tizen::App( 1366): (512) > Not registered pid(10495)
09-10 16:06:17.301+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 16:06:17.301+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:06:17.301+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 10495
09-10 16:06:17.301+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 16:06:17.301+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:06:17.301+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10495.
09-10 16:06:20.485+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:06:20.485+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:1389c50
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => WILL PAUSE
09-10 16:06:20.505+0600 W/APP_CORE(  869): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 16:06:20.505+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 16:06:20.505+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:06:20.505+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:06:20.505+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 16:06:20.505+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 16:06:20.505+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 16:06:20.525+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 16:06:20.605+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 16:06:20.605+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 16:06:20.605+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:06:20.605+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 16:06:20.605+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 16:06:21.065+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:06:21.065+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:06:21.085+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 16:06:21.085+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 16:06:21.085+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 16:06:21.085+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 16:06:21.085+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 16:06:21.085+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 16:06:22.076+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:06:25.519+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 16:10:25.253+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 4903): media_content.c: media_content_disconnect(940) > [32m[4903]ref count changed to: 0
09-10 16:10:25.253+0600 I/CAPI_NETWORK_WIFI( 4903): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:10:25.273+0600 E/ALARM_MANAGER( 4903): alarm-lib-stub.c: _send_alarm_delete_all(434) > alarm_manager_call_alarm_delete_all_sync() failed. return_code[0]
09-10 16:10:25.273+0600 E/ALARM_MANAGER( 4903): alarm-lib-stub.c: _send_alarm_delete_all(436) > dbus error message: The connection is closed
09-10 16:15:27.608+0600 E/PKGMGR_SERVER(12344): pkgmgr-server.c: main(2414) > package manager server start
09-10 16:15:27.668+0600 E/PKGMGR  (12342): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 9944
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:15:27.718+0600 W/AUL     (12348): launch.c: app_request_to_launchpad(396) > request cmd(5) to(9944)
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 16:15:27.718+0600 I/APP_CORE( 9944): appcore-efl.c: __do_app(520) > [APP 9944] Event: TERMINATE State: PAUSED
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(9944), cmd(4)
09-10 16:15:27.718+0600 W/AUL     (12348): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:15:27.718+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 16:15:27.728+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 9944): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 16:15:27.728+0600 E/APP_CORE( 9944): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:15:27.728+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:15:27.728+0600 E/APP_CORE( 9944): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 16:15:27.728+0600 I/CAPI_APPFW_APPLICATION( 9944): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:15:27.728+0600 E/CAPI_NETWORK_BLUETOOTH( 9944): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 16:15:27.738+0600 E/PKGMGR_SERVER(12344): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12348]
09-10 16:15:27.818+0600 E/CAPI_NETWORK_BLUETOOTH( 9944): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 16:15:27.818+0600 E/CAPI_NETWORK_BLUETOOTH( 9944): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 16:15:27.818+0600 E/bluetooth( 9944): [bt_adapter_le_destroy_advertiser] Failed.
09-10 16:15:27.818+0600 I/CAPI_NETWORK_WIFI( 9944): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:15:27.818+0600 E/bluetooth( 9944): [wifi_deinitialize] Success.
09-10 16:15:27.829+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 16:15:27.829+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:15:27.829+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:15:27.829+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 16:15:27.829+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 16:15:27.839+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:15:27.859+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77a55a8), gem(23), surface(0xb78ae800)
09-10 16:15:27.869+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:15:27.869+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77a55a8), gem(23), surface(0xb78ba300)
09-10 16:15:27.879+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7877170), gem(19), surface(0xb78bff90)
09-10 16:15:27.879+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7753c30), gem(15), surface(0xb782fa90)
09-10 16:15:27.919+0600 E/EFL     ( 9944): ecore<9944> lib/ecore/ecore_main.c:1552 _ecore_main_fd_handlers_bads_rem() Removing bad fds
09-10 16:15:27.919+0600 E/EFL     ( 9944): ecore<9944> lib/ecore/ecore_main.c:1561 _ecore_main_fd_handlers_bads_rem() Found bad fd at index 23
09-10 16:15:27.919+0600 E/EFL     ( 9944): ecore<9944> lib/ecore/ecore_main.c:1564 _ecore_main_fd_handlers_bads_rem() Fd set for error! calling user
09-10 16:15:28.059+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9944 pgid = 9944
09-10 16:15:28.059+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(9944)
09-10 16:15:28.129+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:15:28.129+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:15:28.129+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:15:28.129+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[9944] terminate event is forwarded
09-10 16:15:28.129+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:15:28.129+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 9944, ]
09-10 16:15:28.129+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:15:28.129+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 16:15:28.129+0600 I/Tizen::App( 1366): (512) > Not registered pid(9944)
09-10 16:15:28.129+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 16:15:28.129+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:15:28.139+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 9944
09-10 16:15:28.139+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9944
09-10 16:15:28.159+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 16:15:28.159+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:15:28.159+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 9944.
09-10 16:15:28.219+0600 W/CRASH_MANAGER(12351): worker.c: worker_job(1199) > 0609944626162147350252
