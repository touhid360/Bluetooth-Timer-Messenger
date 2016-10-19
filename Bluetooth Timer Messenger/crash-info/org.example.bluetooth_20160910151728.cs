S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 26708
Date: 2016-09-10 15:17:28+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 26708, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb872f110
r2   = 0xb42a0000, r3   = 0xb42a0000
r4   = 0xb870dc38, r5   = 0xbeb825bc
r6   = 0xb699e310, r7   = 0xbeb8241c
r8   = 0xb699f0f4, r9   = 0xb699f0f4
r10  = 0xb69ad20c, fp   = 0x00000000
ip   = 0xb2993654, sp   = 0xbeb80770
lr   = 0xb2987cc3, pc   = 0xb66826f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     60260 KB
Buffers:     41064 KB
Cached:     284452 KB
VmPeak:     106496 KB
VmSize:     103140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25164 KB
VmRSS:       25164 KB
VmData:      34720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36232 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 26708 TID = 26708
26708 26712 27563 

Maps Information
b1cdc000 b24db000 rw-p [stack:27563]
b24db000 b24ec000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b24fc000 b2501000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b258d000 b2595000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25a6000 b25a7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25b7000 b25cb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25df000 b25e0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25f0000 b25f3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2604000 b2605000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2615000 b2617000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2627000 b2629000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2639000 b2649000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2659000 b2665000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2876000 b288d000 r-xp /usr/lib/libnetwork.so.0.0.0
b289e000 b28dc000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b28ed000 b28f4000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2905000 b2914000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2924000 b2959000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b296c000 b2972000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2982000 b298c000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2aad000 b2b90000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bc7000 b2bef000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c01000 b3400000 rw-p [stack:26712]
b3400000 b3402000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3412000 b341c000 r-xp /lib/libnss_files-2.20-2014.11.so
b342d000 b3436000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3447000 b3458000 r-xp /lib/libnsl-2.20-2014.11.so
b346b000 b3471000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3482000 b3483000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34ab000 b34b2000 r-xp /usr/lib/libminizip.so.1.0.0
b34c2000 b34c7000 r-xp /usr/lib/libstorage.so.0.1
b34d7000 b352c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3542000 b3556000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3566000 b35aa000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35ba000 b35c2000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35d2000 b3602000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3615000 b36ce000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36e2000 b3736000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3747000 b3762000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3772000 b3833000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3846000 b3858000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3868000 b386c000 r-xp /usr/lib/libogg.so.0.7.1
b387c000 b389e000 r-xp /usr/lib/libvorbis.so.0.4.3
b38ae000 b3992000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39ae000 b39bb000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39cc000 b3a0f000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a24000 b3a6b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a7c000 b3a82000 r-xp /usr/lib/libjson-c.so.2.0.1
b3a93000 b3a9a000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3aaa000 b3aea000 r-xp /usr/lib/libmdm.so.1.2.10
b3afa000 b3b02000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b11000 b3b21000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b42000 b3ba2000 r-xp /usr/lib/libasound.so.2.0.0
b3bb4000 b3bea000 r-xp /usr/lib/libpulse.so.0.16.2
b3bfb000 b3bfe000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c0e000 b3c11000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c21000 b3c26000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c36000 b3c37000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c47000 b3c52000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c66000 b3c6d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c7d000 b3c83000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3c93000 b3c98000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3ca8000 b3cc3000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cd3000 b3cda000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3cea000 b3ced000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3cfe000 b3d2c000 r-xp /usr/lib/libidn.so.11.5.44
b3d3c000 b3d52000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d63000 b3d6d000 r-xp /usr/lib/libcares.so.2.1.0
b3d7d000 b3d87000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3d97000 b3d99000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3da9000 b3daa000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dba000 b3dbe000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3dcf000 b3df7000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e08000 b3e31000 r-xp /usr/lib/libturbojpeg.so
b3e51000 b3e57000 r-xp /usr/lib/libgif.so.4.1.6
b3e67000 b3ead000 r-xp /usr/lib/libcurl.so.4.3.0
b3ebe000 b3edf000 r-xp /usr/lib/libexif.so.12.3.3
b3efa000 b3f0f000 r-xp /usr/lib/libtts.so
b3f20000 b3f28000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f38000 b3ff8000 r-xp /usr/lib/libdali-core.so.0.0.0
b4003000 b40f6000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4116000 b41f0000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4207000 b4209000 r-xp /usr/lib/libboost_system.so.1.51.0
b4219000 b421f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b422f000 b4252000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4263000 b4265000 r-xp /usr/lib/libappsvc.so.0.1.0
b4275000 b4277000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4288000 b428d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42a4000 b42a6000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42b6000 b42bd000 r-xp /usr/lib/libsensord-share.so
b42cd000 b42e5000 r-xp /usr/lib/libsensor.so.1.1.0
b42f6000 b42f9000 r-xp /usr/lib/libXv.so.1.0.0
b4309000 b430e000 r-xp /usr/lib/libutilX.so.1.1.0
b431e000 b4323000 r-xp /usr/lib/libappcore-common.so.1.1
b4333000 b433a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b434d000 b4351000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4362000 b442c000 r-xp /usr/lib/libCOREGL.so.4.0
b4443000 b4446000 r-xp /usr/lib/libuuid.so.1.3.0
b4457000 b446e000 r-xp /usr/lib/libblkid.so.1.1.0
b447f000 b4481000 r-xp /usr/lib/libXau.so.6.0.0
b4491000 b4494000 r-xp /usr/lib/libEGL.so.1.4
b449c000 b44a2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44b2000 b44b4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44c5000 b44d3000 r-xp /usr/lib/libGLESv2.so.2.0
b44dc000 b453e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4553000 b456b000 r-xp /usr/lib/libmount.so.1.1.0
b457c000 b4590000 r-xp /usr/lib/libxcb.so.1.1.0
b45a1000 b45a8000 r-xp /lib/libcrypt-2.20-2014.11.so
b45e0000 b45f1000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4602000 b4604000 r-xp /usr/lib/libiri.so
b4614000 b461f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4630000 b4645000 r-xp /lib/libexpat.so.1.5.2
b4657000 b4715000 r-xp /usr/lib/libcairo.so.2.11200.14
b4728000 b4730000 r-xp /usr/lib/libdrm.so.2.4.0
b4740000 b4743000 r-xp /usr/lib/libdri2.so.0.0.0
b4754000 b47a2000 r-xp /usr/lib/libssl.so.1.0.0
b47b7000 b47c3000 r-xp /usr/lib/libeeze.so.1.13.0
b47d3000 b47dc000 r-xp /usr/lib/libethumb.so.1.13.0
b47ec000 b47ef000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b47ff000 b49b6000 r-xp /usr/lib/libcrypto.so.1.0.0
b560d000 b5616000 r-xp /usr/lib/libXi.so.6.1.0
b5626000 b5628000 r-xp /usr/lib/libXgesture.so.7.0.0
b5638000 b563c000 r-xp /usr/lib/libXtst.so.6.1.0
b564c000 b5652000 r-xp /usr/lib/libXrender.so.1.3.0
b5662000 b5668000 r-xp /usr/lib/libXrandr.so.2.2.0
b5679000 b567b000 r-xp /usr/lib/libXinerama.so.1.0.0
b568b000 b568e000 r-xp /usr/lib/libXfixes.so.3.1.0
b569e000 b56a9000 r-xp /usr/lib/libXext.so.6.4.0
b56b9000 b56bb000 r-xp /usr/lib/libXdamage.so.1.1.0
b56cb000 b56cd000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56de000 b57c0000 r-xp /usr/lib/libX11.so.6.3.0
b57d3000 b57da000 r-xp /usr/lib/libXcursor.so.1.0.2
b57ea000 b5802000 r-xp /usr/lib/libudev.so.1.6.0
b5804000 b5807000 r-xp /lib/libattr.so.1.1.0
b5817000 b5837000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5839000 b583e000 r-xp /usr/lib/libffi.so.6.0.2
b584e000 b5866000 r-xp /lib/libz.so.1.2.8
b5876000 b5878000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5888000 b595d000 r-xp /usr/lib/libxml2.so.2.9.2
b5972000 b5a0d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a29000 b5a2c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a3c000 b5a55000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a66000 b5a77000 r-xp /lib/libresolv-2.20-2014.11.so
b5a8b000 b5b05000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b1a000 b5b1c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b2c000 b5b33000 r-xp /usr/lib/libembryo.so.1.13.0
b5b43000 b5b5b000 r-xp /usr/lib/libpng12.so.0.50.0
b5b6c000 b5b8f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb0000 b5bc4000 r-xp /usr/lib/libector.so.1.13.0
b5bd5000 b5bed000 r-xp /usr/lib/liblua-5.1.so
b5bfe000 b5c55000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c69000 b5c91000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca2000 b5cb5000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc6000 b5cfd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0e000 b5d1c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d2c000 b5d34000 r-xp /usr/lib/libtbm.so.1.0.0
b5d44000 b5d51000 r-xp /usr/lib/libeio.so.1.13.0
b5d61000 b5d63000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d73000 b5d78000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d88000 b5d9f000 r-xp /usr/lib/libefreet.so.1.13.0
b5db1000 b5dd1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de1000 b5e01000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e03000 b5e09000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e19000 b5e2a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e3b000 b5e42000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e52000 b5e61000 r-xp /usr/lib/libeo.so.1.13.0
b5e72000 b5e84000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e95000 b5e9a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eaa000 b5ec3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed3000 b5ef0000 r-xp /usr/lib/libeet.so.1.13.0
b5f09000 b5f51000 r-xp /usr/lib/libeina.so.1.13.0
b5f62000 b5f72000 r-xp /usr/lib/libefl.so.1.13.0
b5f83000 b6068000 r-xp /usr/lib/libicuuc.so.51.1
b6085000 b61c5000 r-xp /usr/lib/libicui18n.so.51.1
b61dc000 b6214000 r-xp /usr/lib/libecore_x.so.1.13.0
b6226000 b6229000 r-xp /lib/libcap.so.2.21
b6239000 b6262000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6273000 b627a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b628c000 b62c3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d4000 b63bf000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d2000 b644b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645d000 b6462000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6472000 b647c000 r-xp /usr/lib/libvconf.so.0.2.45
b648c000 b648e000 r-xp /usr/lib/libvasum.so.0.3.1
b649e000 b64a0000 r-xp /usr/lib/libttrace.so.1.1
b64b0000 b64b3000 r-xp /usr/lib/libiniparser.so.0
b64c3000 b64e9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f9000 b64fe000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650f000 b6526000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6537000 b65a2000 r-xp /lib/libm-2.20-2014.11.so
b65b3000 b65b9000 r-xp /lib/librt-2.20-2014.11.so
b65ca000 b65d7000 r-xp /usr/lib/libunwind.so.8.0.1
b660d000 b6731000 r-xp /lib/libc-2.20-2014.11.so
b6746000 b675f000 r-xp /lib/libgcc_s-4.9.so.1
b676f000 b6851000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6862000 b688c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689d000 b68d9000 r-xp /usr/lib/libsystemd.so.0.4.0
b68db000 b695d000 r-xp /usr/lib/libedje.so.1.13.0
b6970000 b698e000 r-xp /usr/lib/libecore.so.1.13.0
b69ae000 b6b35000 r-xp /usr/lib/libevas.so.1.13.0
b6b6a000 b6b7e000 r-xp /lib/libpthread-2.20-2014.11.so
b6b92000 b6dc7000 r-xp /usr/lib/libelementary.so.1.13.0
b6df5000 b6df9000 r-xp /usr/lib/libsmack.so.1.0.0
b6e09000 b6e10000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e20000 b6e22000 r-xp /usr/lib/libdlog.so.0.0.0
b6e32000 b6e35000 r-xp /usr/lib/libbundle.so.0.1.22
b6e45000 b6e47000 r-xp /lib/libdl-2.20-2014.11.so
b6e58000 b6e70000 r-xp /usr/lib/libaul.so.0.1.0
b6e84000 b6e89000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e9a000 b6ea7000 r-xp /usr/lib/liblptcp.so
b6eb9000 b6ebd000 r-xp /usr/lib/libsys-assert.so
b6ece000 b6eee000 r-xp /lib/ld-2.20-2014.11.so
b6eff000 b6f04000 r-xp /usr/bin/launchpad-loader
b86cc000 b89fe000 rw-p [heap]
beb62000 beb83000 rw-p [stack]
b86cc000 b89fe000 rw-p [heap]
beb62000 beb83000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26708)
Call Stack Count: 1
 0: (0xb66826f0) [/lib/libc.so.6] + 0x756f0
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
ayer.c: player_destroy(1265) > [player_destroy] End
09-10 15:17:05.716+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:05.716+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:05.746+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 15:17:05.746+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:17:05.746+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 15:17:05.746+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:17:05.746+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:17:05.756+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb773cc98), gem(27), surface(0xb78ae1a0)
09-10 15:17:05.766+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7725910), gem(21), surface(0xb7808968)
09-10 15:17:05.766+0600 W/APP_CORE(27569): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200006
09-10 15:17:05.766+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 15:17:05.786+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 15:17:05.796+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:17:05.796+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(27569) status(3)
09-10 15:17:05.796+0600 I/APP_CORE(27569): appcore-efl.c: __do_app(520) > [APP 27569] Event: RESUME State: CREATED
09-10 15:17:05.796+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:17:05.796+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:17:05.796+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:17:05.796+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.bt-syspopup(27569)
09-10 15:17:05.796+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27569, appid: com.samsung.bt-syspopup, status: fg
09-10 15:17:05.806+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:17:05.816+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb789be00), gem(26), surface(0xb7780d10)
09-10 15:17:05.826+0600 I/APP_CORE(27569): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 15:17:05.826+0600 I/APP_CORE(27569): appcore-efl.c: __do_app(637) > [APP 27569] Initial Launching, call the resume_cb
09-10 15:17:05.826+0600 I/CAPI_APPFW_APPLICATION(27569): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 15:17:05.886+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.bt-syspopup)
09-10 15:17:05.886+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.bt-syspopup, 27569.
09-10 15:17:06.427+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77857c0), gem(32), surface(0xb78ba300)
09-10 15:17:06.437+0600 E/EFL     (27569): ecore_x<27569> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10473467
09-10 15:17:06.497+0600 E/EFL     (27569): ecore_x<27569> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10473528
09-10 15:17:06.537+0600 D/bluetooth(26708): Callback: Socket of connection - 45.
09-10 15:17:06.537+0600 D/bluetooth(26708): Callback: Role of connection - 1.
09-10 15:17:06.537+0600 D/bluetooth(26708): Callback: Address of connection - 90:00:DB:03:35:2E.
09-10 15:17:06.537+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:06.557+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:06.567+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:17:06.577+0600 I/Tizen::System( 1366): (259) > Active app [org.exampl], current [com.samsun] 
09-10 15:17:06.577+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:17:06.587+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:17:06.597+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:17:06.597+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:17:06.597+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.bt-syspopup(27569)
09-10 15:17:06.597+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27569, appid: com.samsung.bt-syspopup, status: bg
09-10 15:17:06.597+0600 I/CAPI_APPFW_APPLICATION(27569): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:17:06.597+0600 I/CAPI_APPFW_APPLICATION(27569): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:17:06.607+0600 D/bluetooth(26708): Socket fd: 45
09-10 15:17:06.607+0600 D/bluetooth(26708): Data: gsgsgsgdhdhdhx
09-10 15:17:06.607+0600 D/bluetooth(26708): Size: 30
09-10 15:17:06.737+0600 I/TIZEN_N_SOUND_MANAGER(27569): sound_manager.c: __sound_manager_finalize(715) > <ENTER>
09-10 15:17:06.737+0600 I/TIZEN_N_SOUND_MANAGER(27569): sound_manager.c: __sound_manager_finalize(721) > <LEAVE>
09-10 15:17:06.757+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 27569 pgid = 27569
09-10 15:17:06.757+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(27569)
09-10 15:17:06.837+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:17:06.837+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:17:06.837+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:17:06.837+0600 I/Tizen::App( 1366): (243) > App[com.samsung.bt-syspopup] pid[27569] terminate event is forwarded
09-10 15:17:06.837+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:17:06.837+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.bt-syspopup, 27569, ]
09-10 15:17:06.837+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:17:06.837+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.bt-syspopup)
09-10 15:17:06.837+0600 I/Tizen::App( 1366): (512) > Not registered pid(27569)
09-10 15:17:06.837+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.bt-syspopup]
09-10 15:17:06.837+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:17:06.837+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 27569
09-10 15:17:06.837+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 27569
09-10 15:17:06.837+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 27569
09-10 15:17:06.847+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:17:06.847+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:17:06.847+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.bt-syspopup, 27569.
09-10 15:17:07.037+0600 I/UXT     (27713): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 15:17:09.630+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:17:10.821+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10477846
09-10 15:17:10.871+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10477896
09-10 15:17:10.881+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:17:10.881+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x40 value =0x1[0m
09-10 15:17:10.891+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5400002 FAILED!
09-10 15:17:10.891+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5400002 FAILED!
09-10 15:17:10.891+0600 I/ISE_MULTI(  821): isemain.cpp: slot_set_caps_mode(792) > [0;36m[hidden state:true] mode=1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff02 value =0x1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff03 value =0x1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff04 value =0x1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff05 value =0x1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff06 value =0x0[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff07 value =0x1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff08 value =0x1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff09 value =0x0[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff0a value =0x1[0m
09-10 15:17:10.901+0600 I/IME_LITE(  734): selectpage.cpp: ResetSelection(28) > [0;36m[0m
09-10 15:17:10.911+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:17:10.911+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:17:10.911+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:17:10.911+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:17:10.911+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:17:10.911+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xe0 value =0x0[0m
09-10 15:17:10.911+0600 E/IME_LITE(  734): isf_xt9_imengine.cpp: process_helper_event(2481) > [0;31munknow cmd=0xe0[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff02 value =0x1[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff03 value =0x1[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff04 value =0x1[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff05 value =0x1[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff06 value =0x0[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff07 value =0x1[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff08 value =0x1[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff09 value =0x0[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff0a value =0x1[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): selectpage.cpp: ResetSelection(28) > [0;36m[0m
09-10 15:17:10.981+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x1[0m
09-10 15:17:11.061+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7767f70), gem(21), surface(0xb7808968)
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:17:11.121+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:17:11.131+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=0[0m
09-10 15:17:11.141+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77857c0), gem(27), surface(0xb78ae1a0)
09-10 15:17:11.181+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7816748), gem(19), surface(0xb78a7f60)
09-10 15:17:11.181+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7767f70), gem(21), surface(0xb78ba300)
09-10 15:17:11.191+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7816748), gem(19), surface(0xb78780a0)
09-10 15:17:11.191+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(821) status(3)
09-10 15:17:11.251+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
09-10 15:17:11.251+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
09-10 15:17:11.341+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77cea20), gem(29), surface(0xb78a3058)
09-10 15:17:11.602+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 15:17:12.813+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:17:13.373+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10480359
09-10 15:17:13.383+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10480398
09-10 15:17:13.383+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:17:13.383+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 15:17:13.403+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x1[0m
09-10 15:17:13.413+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5400002 FAILED!
09-10 15:17:13.514+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7767f70), gem(21), surface(0xb78ae1a0)
09-10 15:17:13.514+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7816748), gem(19), surface(0xb78ae510)
09-10 15:17:13.534+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 15:17:20.020+0600 D/bluetooth(26708): Socket fd: 45
09-10 15:17:20.020+0600 D/bluetooth(26708): Data: gsgs
09-10 15:17:20.020+0600 D/bluetooth(26708): Size: 4
09-10 15:17:24.714+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10491730
09-10 15:17:24.815+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10491835
09-10 15:17:24.825+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:17:24.825+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 15:17:24.825+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:17:24.825+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:17:25.245+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10492268
09-10 15:17:25.305+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10492329
09-10 15:17:25.445+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10492462
09-10 15:17:25.515+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10492546
09-10 15:17:26.807+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10493834
09-10 15:17:26.807+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10493834
09-10 15:17:26.807+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 15:17:26.807+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 15:17:26.817+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:17:27.117+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 15:17:27.117+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 15:17:27.117+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 15:17:27.117+0600 E/STARTER (  763): )
09-10 15:17:27.117+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 15:17:27.117+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:17:27.117+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:17:27.127+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 15:17:27.127+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 15:17:27.127+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 15:17:27.137+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 15:17:27.137+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 15:17:27.137+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 15:17:27.137+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 15:17:27.147+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 15:17:27.147+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 15:17:27.147+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 15:17:27.147+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 15:17:27.147+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 15:17:27.147+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 15:17:27.147+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 15:17:27.157+0600 E/CAPI_APPFW_APPLICATION(26818): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:17:27.157+0600 E/CAPI_APPFW_APPLICATION(26818): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:17:27.157+0600 E/CAPI_APPFW_APPLICATION(26818): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:17:27.157+0600 E/CAPI_APPFW_APPLICATION(26818): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:17:27.157+0600 E/CAPI_APPFW_APPLICATION(26818): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:17:27.157+0600 I/CAPI_APPFW_APPLICATION(26818): app_main.c: ui_app_main(789) > app_efl_main
09-10 15:17:27.167+0600 I/CAPI_APPFW_APPLICATION(26818): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 15:17:27.187+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7853298), gem(21), surface(0xb78ae1a0)
09-10 15:17:27.187+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7853298), gem(21), surface(0xb7808968)
09-10 15:17:27.187+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 15:17:27.197+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 15:17:27.197+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 15:17:27.237+0600 W/TASK_MGR_LITE(26818): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 15:17:27.247+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 26818, appid: com.samsung.task-mgr
09-10 15:17:27.247+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 15:17:27.247+0600 I/GXT_SIB (26818): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 15:17:27.257+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:17:27.257+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(26818)
09-10 15:17:27.307+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:27.307+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:27.317+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 15:17:27.317+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:17:27.327+0600 E/RUA     (26818): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 18, ncols : 5
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 15:17:27.327+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:17:27.327+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 26708
09-10 15:17:27.327+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 15:17:27.327+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 15:17:27.337+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 15:17:27.337+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:17:27.357+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:17:27.377+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 15:17:27.377+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:17:27.387+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 15:17:27.387+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:17:27.387+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:17:27.417+0600 I/APP_CORE(26818): appcore-efl.c: __do_app(520) > [APP 26818] Event: RESET State: CREATED
09-10 15:17:27.417+0600 I/CAPI_APPFW_APPLICATION(26818): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 15:17:27.427+0600 E/EFL     (26818): edje<26818> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:17:27.427+0600 E/EFL     (26818): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:17:27.427+0600 E/EFL     (26818): edje<26818> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:17:27.427+0600 E/EFL     (26818): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:17:27.437+0600 W/APP_CORE(26818): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00003
09-10 15:17:27.437+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 15:17:27.437+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76ffd58), gem(32), surface(0xb78a7f60)
09-10 15:17:27.497+0600 I/MALI    (26818): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb7276f88)
09-10 15:17:27.517+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768eb50), gem(33), surface(0xb77af500)
09-10 15:17:27.517+0600 I/MALI    (26818): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:17:27.517+0600 I/APP_CORE(26708): appcore-efl.c: __do_app(520) > [APP 26708] Event: PAUSE State: RUNNING
09-10 15:17:27.517+0600 I/CAPI_APPFW_APPLICATION(26708): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:17:27.527+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(26818) status(3)
09-10 15:17:27.527+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:17:27.527+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:17:27.527+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(26818)
09-10 15:17:27.527+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 26818, appid: com.samsung.task-mgr, status: fg
09-10 15:17:27.527+0600 I/APP_CORE(26818): appcore-efl.c: __do_app(520) > [APP 26818] Event: RESUME State: CREATED
09-10 15:17:27.527+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:17:27.537+0600 I/TIZEN_N_EFL_UTIL_WINDOW(26708): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 14
09-10 15:17:27.537+0600 E/APP_CORE(26708): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 15:17:27.537+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:17:27.557+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77ae020), gem(29), surface(0xb7808968)
09-10 15:17:27.557+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(26818) status(0)
09-10 15:17:27.567+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:17:27.567+0600 I/APP_CORE(26818): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 15:17:27.567+0600 I/APP_CORE(26818): appcore-efl.c: __do_app(637) > [APP 26818] Initial Launching, call the resume_cb
09-10 15:17:27.567+0600 I/CAPI_APPFW_APPLICATION(26818): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 15:17:27.647+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10494676
09-10 15:17:27.647+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 15:17:27.647+0600 E/EFL     (26708): ecore_x<26708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10494676
09-10 15:17:27.647+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 15:17:27.647+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 15:17:27.647+0600 E/STARTER (  763): )
09-10 15:17:27.657+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 15:17:27.657+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 15:17:27.657+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:17:27.657+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:17:28.228+0600 E/EFL     (26818): ecore_x<26818> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10495247
09-10 15:17:28.298+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1454
09-10 15:17:28.308+0600 E/EFL     (26818): ecore_x<26818> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10495329
09-10 15:17:28.308+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:17:28.308+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 26708
09-10 15:17:28.308+0600 W/AUL     (26818): launch.c: app_request_to_launchpad(396) > request cmd(4) to(26708)
09-10 15:17:28.308+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 15:17:28.308+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(26708), cmd(4)
09-10 15:17:28.308+0600 I/APP_CORE(26708): appcore-efl.c: __do_app(520) > [APP 26708] Event: TERMINATE State: PAUSED
09-10 15:17:28.318+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:17:28.318+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:17:28.318+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:17:28.318+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:17:28.318+0600 I/TIZEN_N_EFL_UTIL_WINDOW(26708): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 15:17:28.318+0600 E/APP_CORE(26708): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 15:17:28.318+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:17:28.318+0600 E/APP_CORE(26708): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 15:17:28.318+0600 I/CAPI_APPFW_APPLICATION(26708): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:17:28.318+0600 E/CAPI_NETWORK_BLUETOOTH(26708): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 15:17:28.318+0600 W/AUL     (26818): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 15:17:28.328+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 15:17:28.328+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 26818.
09-10 15:17:28.378+0600 I/MALI    (26818): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:17:28.388+0600 I/MALI    (26818): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:17:28.408+0600 I/MALI    (26818): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:17:28.468+0600 E/CAPI_NETWORK_BLUETOOTH(26708): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 15:17:28.468+0600 E/CAPI_NETWORK_BLUETOOTH(26708): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 15:17:28.468+0600 E/bluetooth(26708): [bt_adapter_le_destroy_advertiser] Failed.
09-10 15:17:28.468+0600 I/CAPI_NETWORK_WIFI(26708): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 15:17:28.478+0600 E/bluetooth(26708): [wifi_deinitialize] Success.
09-10 15:17:28.548+0600 E/EFL     (26708): elementary<26708> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 15:17:28.628+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:17:28.628+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:17:28.628+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(26818)
09-10 15:17:28.628+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 26818, appid: com.samsung.task-mgr, status: bg
09-10 15:17:28.628+0600 I/CAPI_APPFW_APPLICATION(26818): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:17:28.628+0600 W/TASK_MGR_LITE(26818): task-mgr-lite.c: _pause_app(406) > 
09-10 15:17:28.628+0600 I/CAPI_APPFW_APPLICATION(26818): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:17:28.648+0600 E/TASK_MGR_LITE(26818): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 15:17:28.658+0600 E/APP_CORE(26818): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 15:17:28.658+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:28.668+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 15:17:28.668+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:17:28.668+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:17:28.668+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 15:17:28.668+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 15:17:28.678+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:17:28.688+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7853298), gem(13), surface(0xb78ae1a0)
09-10 15:17:28.688+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], Loading state:[1]
09-10 15:17:28.708+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7853298), gem(13), surface(0xb7808968)
09-10 15:17:28.738+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7703b00), gem(21), surface(0xb78a7f60)
09-10 15:17:28.748+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7703b00), gem(21), surface(0xb787ffb0)
09-10 15:17:28.758+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26708 pgid = 26708
09-10 15:17:28.758+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(26708)
09-10 15:17:28.768+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:17:28.778+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 15:17:28.778+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 15:17:28.778+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 15:17:28.788+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:17:28.818+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 15:17:28.818+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 15:17:28.859+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78bf8c0), gem(18), surface(0xb78b9638)
09-10 15:17:28.869+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:17:28.869+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:17:28.869+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:17:28.869+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[26708] terminate event is forwarded
09-10 15:17:28.869+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:17:28.869+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 26708, ]
09-10 15:17:28.869+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:17:28.869+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 15:17:28.869+0600 I/Tizen::App( 1366): (512) > Not registered pid(26708)
09-10 15:17:28.869+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 15:17:28.869+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:17:28.879+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 26708
09-10 15:17:28.879+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26708
09-10 15:17:28.889+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1455
09-10 15:17:28.919+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:17:28.919+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:17:28.919+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 26708.
09-10 15:17:28.949+0600 I/MALI    (26818): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 15:17:28.949+0600 I/MALI    (26818): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=26818   close drm_fd=29 
09-10 15:17:28.949+0600 I/MALI    (26818): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 15:17:29.039+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb778ae60), gem(18), surface(0xb7808968)
09-10 15:17:29.049+0600 W/CRASH_MANAGER(27795): worker.c: worker_job(1199) > 1126708626162147349904
