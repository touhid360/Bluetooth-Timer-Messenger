S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 25198
Date: 2016-09-10 16:59:36+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25198, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb7120018
r2   = 0xb42d1000, r3   = 0xb42d1000
r4   = 0xbeb325bc, r5   = 0xb69d00f4
r6   = 0xb69cf310, r7   = 0xbeb3241c
r8   = 0xb69d00f4, r9   = 0xb69d00f4
r10  = 0xb69de20c, fp   = 0x00000000
ip   = 0xb29c4a74, sp   = 0xbeb31798
lr   = 0xb29ba1ff, pc   = 0xb66b36f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     56852 KB
Buffers:     29040 KB
Cached:     262700 KB
VmPeak:     120240 KB
VmSize:     112380 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25360 KB
VmRSS:       25360 KB
VmData:      43976 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 25198 TID = 25198
25198 25201 25869 25871 

Maps Information
b0a01000 b1200000 rw-p [stack:25871]
b1d10000 b250f000 rw-p [stack:25869]
b250f000 b2520000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2530000 b2535000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25c1000 b25c9000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25da000 b25db000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25eb000 b25ff000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2613000 b2614000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2624000 b2627000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2638000 b2639000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2649000 b264b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b265b000 b265d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b266d000 b267d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b268d000 b2699000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28aa000 b28c1000 r-xp /usr/lib/libnetwork.so.0.0.0
b28d2000 b2910000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2921000 b2928000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2939000 b2948000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2958000 b298d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29a0000 b29a6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29b6000 b29bd000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ade000 b2bc1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bf8000 b2c20000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c32000 b3431000 rw-p [stack:25201]
b3431000 b3433000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3443000 b344d000 r-xp /lib/libnss_files-2.20-2014.11.so
b345e000 b3467000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3478000 b3489000 r-xp /lib/libnsl-2.20-2014.11.so
b349c000 b34a2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34b3000 b34b4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34dc000 b34e3000 r-xp /usr/lib/libminizip.so.1.0.0
b34f3000 b34f8000 r-xp /usr/lib/libstorage.so.0.1
b3508000 b355d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3573000 b3587000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3597000 b35db000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35eb000 b35f3000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3603000 b3633000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3646000 b36ff000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3713000 b3767000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3778000 b3793000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37a3000 b3864000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3877000 b3889000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3899000 b389d000 r-xp /usr/lib/libogg.so.0.7.1
b38ad000 b38cf000 r-xp /usr/lib/libvorbis.so.0.4.3
b38df000 b39c3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39df000 b39ec000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39fd000 b3a40000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a55000 b3a9c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3aad000 b3ab3000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ac4000 b3acb000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3adb000 b3b1b000 r-xp /usr/lib/libmdm.so.1.2.10
b3b2b000 b3b33000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b42000 b3b52000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b73000 b3bd3000 r-xp /usr/lib/libasound.so.2.0.0
b3be5000 b3c1b000 r-xp /usr/lib/libpulse.so.0.16.2
b3c2c000 b3c2f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c3f000 b3c42000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c52000 b3c57000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c67000 b3c68000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c78000 b3c83000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c97000 b3c9e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cae000 b3cb4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cc4000 b3cc9000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cd9000 b3cf4000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d04000 b3d0b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d1b000 b3d1e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d2f000 b3d5d000 r-xp /usr/lib/libidn.so.11.5.44
b3d6d000 b3d83000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d94000 b3d9e000 r-xp /usr/lib/libcares.so.2.1.0
b3dae000 b3db8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dc8000 b3dca000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dda000 b3ddb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3deb000 b3def000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e00000 b3e28000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e39000 b3e62000 r-xp /usr/lib/libturbojpeg.so
b3e82000 b3e88000 r-xp /usr/lib/libgif.so.4.1.6
b3e98000 b3ede000 r-xp /usr/lib/libcurl.so.4.3.0
b3eef000 b3f10000 r-xp /usr/lib/libexif.so.12.3.3
b3f2b000 b3f40000 r-xp /usr/lib/libtts.so
b3f51000 b3f59000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f69000 b4029000 r-xp /usr/lib/libdali-core.so.0.0.0
b4034000 b4127000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4147000 b4221000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4238000 b423a000 r-xp /usr/lib/libboost_system.so.1.51.0
b424a000 b4250000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4260000 b4283000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4294000 b4296000 r-xp /usr/lib/libappsvc.so.0.1.0
b42a6000 b42a8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42b9000 b42be000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42d5000 b42d7000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42e7000 b42ee000 r-xp /usr/lib/libsensord-share.so
b42fe000 b4316000 r-xp /usr/lib/libsensor.so.1.1.0
b4327000 b432a000 r-xp /usr/lib/libXv.so.1.0.0
b433a000 b433f000 r-xp /usr/lib/libutilX.so.1.1.0
b434f000 b4354000 r-xp /usr/lib/libappcore-common.so.1.1
b4364000 b436b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b437e000 b4382000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4393000 b445d000 r-xp /usr/lib/libCOREGL.so.4.0
b4474000 b4477000 r-xp /usr/lib/libuuid.so.1.3.0
b4488000 b449f000 r-xp /usr/lib/libblkid.so.1.1.0
b44b0000 b44b2000 r-xp /usr/lib/libXau.so.6.0.0
b44c2000 b44c5000 r-xp /usr/lib/libEGL.so.1.4
b44cd000 b44d3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44e3000 b44e5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44f6000 b4504000 r-xp /usr/lib/libGLESv2.so.2.0
b450d000 b456f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4584000 b459c000 r-xp /usr/lib/libmount.so.1.1.0
b45ad000 b45c1000 r-xp /usr/lib/libxcb.so.1.1.0
b45d2000 b45d9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4611000 b4622000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4633000 b4635000 r-xp /usr/lib/libiri.so
b4645000 b4650000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4661000 b4676000 r-xp /lib/libexpat.so.1.5.2
b4688000 b4746000 r-xp /usr/lib/libcairo.so.2.11200.14
b4759000 b4761000 r-xp /usr/lib/libdrm.so.2.4.0
b4771000 b4774000 r-xp /usr/lib/libdri2.so.0.0.0
b4785000 b47d3000 r-xp /usr/lib/libssl.so.1.0.0
b47e8000 b47f4000 r-xp /usr/lib/libeeze.so.1.13.0
b4804000 b480d000 r-xp /usr/lib/libethumb.so.1.13.0
b481d000 b4820000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4830000 b49e7000 r-xp /usr/lib/libcrypto.so.1.0.0
b563e000 b5647000 r-xp /usr/lib/libXi.so.6.1.0
b5657000 b5659000 r-xp /usr/lib/libXgesture.so.7.0.0
b5669000 b566d000 r-xp /usr/lib/libXtst.so.6.1.0
b567d000 b5683000 r-xp /usr/lib/libXrender.so.1.3.0
b5693000 b5699000 r-xp /usr/lib/libXrandr.so.2.2.0
b56aa000 b56ac000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bc000 b56bf000 r-xp /usr/lib/libXfixes.so.3.1.0
b56cf000 b56da000 r-xp /usr/lib/libXext.so.6.4.0
b56ea000 b56ec000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fc000 b56fe000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570f000 b57f1000 r-xp /usr/lib/libX11.so.6.3.0
b5804000 b580b000 r-xp /usr/lib/libXcursor.so.1.0.2
b581b000 b5833000 r-xp /usr/lib/libudev.so.1.6.0
b5835000 b5838000 r-xp /lib/libattr.so.1.1.0
b5848000 b5868000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b586a000 b586f000 r-xp /usr/lib/libffi.so.6.0.2
b587f000 b5897000 r-xp /lib/libz.so.1.2.8
b58a7000 b58a9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b9000 b598e000 r-xp /usr/lib/libxml2.so.2.9.2
b59a3000 b5a3e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a5a000 b5a5d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6d000 b5a86000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a97000 b5aa8000 r-xp /lib/libresolv-2.20-2014.11.so
b5abc000 b5b36000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4b000 b5b4d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5d000 b5b64000 r-xp /usr/lib/libembryo.so.1.13.0
b5b74000 b5b8c000 r-xp /usr/lib/libpng12.so.0.50.0
b5b9d000 b5bc0000 r-xp /usr/lib/libjpeg.so.8.0.2
b5be1000 b5bf5000 r-xp /usr/lib/libector.so.1.13.0
b5c06000 b5c1e000 r-xp /usr/lib/liblua-5.1.so
b5c2f000 b5c86000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c9a000 b5cc2000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cd3000 b5ce6000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf7000 b5d2e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d3f000 b5d4d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d5d000 b5d65000 r-xp /usr/lib/libtbm.so.1.0.0
b5d75000 b5d82000 r-xp /usr/lib/libeio.so.1.13.0
b5d92000 b5d94000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da4000 b5da9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5db9000 b5dd0000 r-xp /usr/lib/libefreet.so.1.13.0
b5de2000 b5e02000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e12000 b5e32000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e34000 b5e3a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e4a000 b5e5b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e6c000 b5e73000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e83000 b5e92000 r-xp /usr/lib/libeo.so.1.13.0
b5ea3000 b5eb5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ec6000 b5ecb000 r-xp /usr/lib/libecore_file.so.1.13.0
b5edb000 b5ef4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f04000 b5f21000 r-xp /usr/lib/libeet.so.1.13.0
b5f3a000 b5f82000 r-xp /usr/lib/libeina.so.1.13.0
b5f93000 b5fa3000 r-xp /usr/lib/libefl.so.1.13.0
b5fb4000 b6099000 r-xp /usr/lib/libicuuc.so.51.1
b60b6000 b61f6000 r-xp /usr/lib/libicui18n.so.51.1
b620d000 b6245000 r-xp /usr/lib/libecore_x.so.1.13.0
b6257000 b625a000 r-xp /lib/libcap.so.2.21
b626a000 b6293000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a4000 b62ab000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62bd000 b62f4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6305000 b63f0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6403000 b647c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b648e000 b6493000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a3000 b64ad000 r-xp /usr/lib/libvconf.so.0.2.45
b64bd000 b64bf000 r-xp /usr/lib/libvasum.so.0.3.1
b64cf000 b64d1000 r-xp /usr/lib/libttrace.so.1.1
b64e1000 b64e4000 r-xp /usr/lib/libiniparser.so.0
b64f4000 b651a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b652a000 b652f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6540000 b6557000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6568000 b65d3000 r-xp /lib/libm-2.20-2014.11.so
b65e4000 b65ea000 r-xp /lib/librt-2.20-2014.11.so
b65fb000 b6608000 r-xp /usr/lib/libunwind.so.8.0.1
b663e000 b6762000 r-xp /lib/libc-2.20-2014.11.so
b6777000 b6790000 r-xp /lib/libgcc_s-4.9.so.1
b67a0000 b6882000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6893000 b68bd000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ce000 b690a000 r-xp /usr/lib/libsystemd.so.0.4.0
b690c000 b698e000 r-xp /usr/lib/libedje.so.1.13.0
b69a1000 b69bf000 r-xp /usr/lib/libecore.so.1.13.0
b69df000 b6b66000 r-xp /usr/lib/libevas.so.1.13.0
b6b9b000 b6baf000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc3000 b6df8000 r-xp /usr/lib/libelementary.so.1.13.0
b6e26000 b6e2a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e3a000 b6e41000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e51000 b6e53000 r-xp /usr/lib/libdlog.so.0.0.0
b6e63000 b6e66000 r-xp /usr/lib/libbundle.so.0.1.22
b6e76000 b6e78000 r-xp /lib/libdl-2.20-2014.11.so
b6e89000 b6ea1000 r-xp /usr/lib/libaul.so.0.1.0
b6eb5000 b6eba000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ecb000 b6ed8000 r-xp /usr/lib/liblptcp.so
b6eea000 b6eee000 r-xp /usr/lib/libsys-assert.so
b6eff000 b6f1f000 r-xp /lib/ld-2.20-2014.11.so
b6f30000 b6f35000 r-xp /usr/bin/launchpad-loader
b70bb000 b73ea000 rw-p [heap]
beb12000 beb33000 rw-p [stack]
b70bb000 b73ea000 rw-p [heap]
beb12000 beb33000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25198)
Call Stack Count: 1
 0: (0xb66b36f0) [/lib/libc.so.6] + 0x756f0
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
 > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 16:59:21.424+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 16:59:21.424+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 16:59:21.424+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 16:59:21.434+0600 I/MESSAGE_PORT(  871): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:59:21.434+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:59:21.434+0600 E/MESSAGE_PORT(26330): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 16:59:21.434+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 16:59:21.434+0600 I/MESSAGE_PORT(26330): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:59:21.444+0600 I/MESSAGE_PORT(  977): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 16:59:21.444+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:59:21.444+0600 E/MESSAGE_PORT(26330): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 30.000000[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.500000[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473492158[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 16:59:21.444+0600 E/weather-common(26330): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 16:59:21.444+0600 E/weather-agent(26330): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 16:59:21.444+0600 E/weather-agent(26330): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 16:59:21.444+0600 I/MESSAGE_PORT(26330): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 16:59:21.444+0600 I/MESSAGE_PORT(26330): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:59:21.474+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:59:21.515+0600 E/weather-widget(  977): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 16:59:21.515+0600 E/weather-widget(  977): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 16:59:21.695+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4764955
09-10 16:59:21.765+0600 I/CAPI_NETWORK_CONNECTION(  977): connection.c: connection_create(442) > New handle created[0xb8bac5d8]
09-10 16:59:21.765+0600 I/CAPI_NETWORK_CONNECTION(  977): connection.c: connection_get_type(496) > Connected Network = 0
09-10 16:59:21.765+0600 E/weather-common(  977): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 16:59:21.765+0600 E/weather-common(  977): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 16:59:21.765+0600 I/CAPI_NETWORK_CONNECTION(  977): connection.c: connection_destroy(460) > Destroy handle: 0xb8bac5d8
09-10 16:59:21.765+0600 E/weather-common(  977): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 16:59:21.775+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:21.775+0600 W/LOCKSCREEN(  871): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80001:VIEW_GESTURED
09-10 16:59:21.775+0600 W/LOCKSCREEN(  871): daemon.c: _event_route(839) > [_event_route:839:W] event:80001 event_info:0
09-10 16:59:21.775+0600 W/LOCKSCREEN(  871): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 16:59:21.775+0600 W/LOCKSCREEN(  871): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
09-10 16:59:21.775+0600 W/LOCKSCREEN(  871): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
09-10 16:59:21.775+0600 W/LOCKSCREEN(  871): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
09-10 16:59:21.775+0600 W/LOCATION(  977): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 16:59:21.775+0600 E/weather-common(  977): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 16:59:21.775+0600 E/weather-widget(  977): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 16:59:21.795+0600 E/weather-widget(  977): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 16:59:21.795+0600 I/CAPI_WIDGET_APPLICATION(  977): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 16:59:21.805+0600 E/EFL     (  977): edje<977> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:59:21.815+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4765071
09-10 16:59:21.815+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:21.815+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:21.845+0600 E/EFL     (  977): evas_main<977> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800bc201 is not stable during recalc loop
09-10 16:59:21.905+0600 E/EFL     (  977): evas_main<977> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800bc201 is not stable during recalc loop
09-10 16:59:21.905+0600 E/EFL     (  977): edje<977> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:59:21.925+0600 E/cluster-home(  876): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 16:59:22.165+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4765426
09-10 16:59:22.255+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4765513
09-10 16:59:22.255+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:22.255+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:22.395+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4765649
09-10 16:59:22.445+0600 E/weather-agent(26330): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 16:59:22.455+0600 I/CAPI_APPFW_APPLICATION(26330): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 16:59:22.455+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4765704
09-10 16:59:22.455+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:22.455+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:22.455+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:59:22.455+0600 E/weather-agent(26330): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 16:59:22.455+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:59:22.556+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4765809
09-10 16:59:22.616+0600 W/AUL_AMD (  653): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 16:59:22.616+0600 I/Tizen::App( 1395): (243) > App[com.samsung.weather-m-agent] pid[26330] terminate event is forwarded
09-10 16:59:22.616+0600 I/Tizen::System( 1395): (256) > osp.accessorymanager.service provider is found.
09-10 16:59:22.616+0600 I/Tizen::System( 1395): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 26330, ]
09-10 16:59:22.616+0600 I/Tizen::System( 1395): (256) > osp.system.service provider is found.
09-10 16:59:22.616+0600 I/Tizen::App( 1395): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 16:59:22.616+0600 I/Tizen::App( 1395): (512) > Not registered pid(26330)
09-10 16:59:22.616+0600 I/Tizen::System( 1395): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 16:59:22.616+0600 I/Tizen::Io( 1395): (729) > Entry not found
09-10 16:59:22.616+0600 I/ESD     ( 1003): esd_main.c: __esd_app_dead_handler(1773) > pid: 26330
09-10 16:59:22.626+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4765881
09-10 16:59:22.626+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:22.626+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:22.626+0600 I/Tizen::System( 1395): (157) > change brightness system value.
09-10 16:59:22.626+0600 I/Tizen::App( 1395): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 26330.
09-10 16:59:22.646+0600 W/AUL_AMD (  653): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26330
09-10 16:59:22.646+0600 E/RESOURCED(  694): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 16:59:22.746+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4766001
09-10 16:59:22.806+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4766057
09-10 16:59:22.806+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:22.806+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:22.816+0600 E/LOCKSCREEN(  871): password-verification.c: __password_verification_check_phone_password(291) > [__password_verification_check_phone_password:291:E] incorrect password!
09-10 16:59:22.816+0600 W/LOCKSCREEN(  871): simple-password.c: _pwd_verify_result_cb(519) > [_pwd_verify_result_cb:519:W] event:4
09-10 16:59:22.816+0600 W/LOCKSCREEN(  871): simple-password.c: _handler_pwd_incorrect(489) > [_handler_pwd_incorrect:489:W] Do nothing
09-10 16:59:26.710+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4769958
09-10 16:59:26.780+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4770027
09-10 16:59:26.780+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:26.780+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:26.980+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4770237
09-10 16:59:27.050+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4770307
09-10 16:59:27.060+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:27.060+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:27.160+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4770412
09-10 16:59:27.240+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4770492
09-10 16:59:27.250+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:27.250+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:27.370+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4770619
09-10 16:59:27.430+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4770679
09-10 16:59:27.430+0600 E/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:59:27.430+0600 W/LOCKSCREEN(  871): progress_circle.c: unlock_mouse_up(435) > [unlock_mouse_up:435:W] already unlocked
09-10 16:59:27.450+0600 E/LOCKSCREEN(  871): password-verification.c: __password_verification_check_phone_password(280) > [__password_verification_check_phone_password:280:E] correct password!
09-10 16:59:27.450+0600 W/LOCKSCREEN(  871): simple-password.c: _pwd_verify_result_cb(519) > [_pwd_verify_result_cb:519:W] event:3
09-10 16:59:27.450+0600 E/LOCKSCREEN(  871): default-unlock.c: device_block_time_init(232) > [device_block_time_init:232:E] 
09-10 16:59:27.450+0600 W/LOCKSCREEN(  871): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:4:LKD_EVT_WILL_UNLOCK
09-10 16:59:27.450+0600 W/LOCKSCREEN(  871): daemon.c: _event_route(839) > [_event_route:839:W] event:4 event_info:0
09-10 16:59:27.450+0600 W/LOCKSCREEN(  871): daemon.c: lockd_event_delay(1042) > [lockd_event_delay:1042:W] dealyed event:2:UNLOCK wait for:0.330000
09-10 16:59:27.460+0600 W/AUL_AMD (  653): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:59:27.791+0600 W/LOCKSCREEN(  871): daemon.c: _event_route(839) > [_event_route:839:W] event:2 event_info:0
09-10 16:59:27.791+0600 W/LOCKSCREEN(  871): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:7
09-10 16:59:27.791+0600 W/LOCKSCREEN(  871): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
09-10 16:59:27.791+0600 E/LOCKSCREEN(  871): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 16:59:27.801+0600 E/EFL     (  297): eo<297> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:59:27.801+0600 E/EFL     (  297): eo<297> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:59:27.831+0600 W/AUL_AMD (  653): amd_launch.c: __e17_status_handler(3367) > pid(871) status(4)
09-10 16:59:27.831+0600 W/AUL     (  653): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(871)
09-10 16:59:27.831+0600 W/AUL     (  653): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 871, appid: com.samsung.lockscreen, status: bg
09-10 16:59:27.841+0600 W/AUL_AMD (  653): amd_launch.c: __e17_status_handler(3367) > pid(25198) status(3)
09-10 16:59:27.841+0600 W/AUL_AMD (  653): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:59:27.841+0600 W/AUL_AMD (  653): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:59:27.841+0600 W/AUL     (  653): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(25198)
09-10 16:59:27.841+0600 W/AUL     (  653): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 25198, appid: org.example.bluetooth, status: fg
09-10 16:59:27.841+0600 E/AUL     (  653): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:59:27.861+0600 I/Tizen::System( 1395): (259) > Active app [org.exampl], current [com.samsun] 
09-10 16:59:27.861+0600 I/Tizen::Io( 1395): (729) > Entry not found
09-10 16:59:27.861+0600 W/LOCKSCREEN(  871): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [invisible]
09-10 16:59:27.861+0600 W/LOCKSCREEN(  871): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10002:WIN_BECOME_INVISIBLE
09-10 16:59:27.861+0600 W/LOCKSCREEN(  871): daemon.c: _event_route(839) > [_event_route:839:W] event:10002 event_info:0
09-10 16:59:27.871+0600 E/QUICKPANEL(  957): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:59:27.871+0600 E/QUICKPANEL(  957): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:59:27.871+0600 E/QUICKPANEL(  957): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:59:27.871+0600 W/QUICKPANEL(  957): NotificationItemModel.cpp: updateNotification(376) > [0;35mOngoing notification is updated.[0;m
09-10 16:59:27.871+0600 E/VCONF   (25273): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:59:27.871+0600 E/VCONF   (25273): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:59:27.881+0600 E/LOCKSCREEN(  871): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
09-10 16:59:27.881+0600 I/APP_CORE(  871): appcore-efl.c: __do_app(520) > [APP 871] Event: PAUSE State: RUNNING
09-10 16:59:27.881+0600 I/CAPI_APPFW_APPLICATION(  871): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:59:27.881+0600 E/LOCKSCREEN(  871): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:59:27.881+0600 W/LOCKSCREEN(  871): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 16:59:27.881+0600 W/LOCKSCREEN(  871): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 16:59:27.881+0600 E/LOCKSCREEN(  871): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 16:59:27.891+0600 I/Tizen::System( 1395): (157) > change brightness system value.
09-10 16:59:27.921+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:59:27.941+0600 I/APP_CORE(  871): appcore-efl.c: __do_app(520) > [APP 871] Event: MEM_FLUSH State: PAUSED
09-10 16:59:27.961+0600 I/APP_CORE(25198): appcore-efl.c: __do_app(520) > [APP 25198] Event: RESUME State: PAUSED
09-10 16:59:27.961+0600 I/CAPI_APPFW_APPLICATION(25198): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:59:27.981+0600 W/LOCKSCREEN(  871): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-10 16:59:27.981+0600 E/LOCKSCREEN(  871): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 16:59:27.981+0600 E/LOCKSCREEN(  871): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:59:27.981+0600 W/LOCKSCREEN(  871): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 16:59:27.981+0600 W/LOCKSCREEN(  871): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 16:59:28.001+0600 E/LOCKSCREEN(  871): background-view.c: background_image_next_set(309) > [background_image_next_set:309:E] fopen wallpaper txt file failed.
09-10 16:59:32.876+0600 I/APP_CORE(  871): appcore-efl.c: __do_app(520) > [APP 871] Event: MEM_FLUSH State: PAUSED
09-10 16:59:33.106+0600 E/EFL     (25198): ecore_x<25198> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4776337
09-10 16:59:33.326+0600 E/EFL     (25198): ecore_x<25198> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4776583
09-10 16:59:34.657+0600 E/EFL     (25198): ecore_x<25198> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=4777913
09-10 16:59:34.657+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=4777913
09-10 16:59:34.657+0600 W/STARTER (  752): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 16:59:34.657+0600 W/STARTER (  752): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 16:59:34.667+0600 E/AUL     (  752): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:59:34.958+0600 I/SYSPOPUP(  956): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:59:34.968+0600 E/STARTER (  752): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:59:34.968+0600 E/STARTER (  752): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:59:34.968+0600 E/STARTER (  752): )
09-10 16:59:34.968+0600 I/SYSPOPUP(  956): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:59:34.968+0600 E/VOLUME  (  956): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:59:34.968+0600 E/VOLUME  (  956): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:59:34.978+0600 W/AUL     (  752): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 16:59:34.978+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:59:34.978+0600 I/AUL     (  653): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 16:59:34.978+0600 E/AUL_AMD (  653): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:59:34.978+0600 W/AUL_AMD (  653): amd_launch.c: _start_app(2527) > caller pid : 752
09-10 16:59:34.978+0600 E/AUL_AMD (  653): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:59:34.988+0600 E/RESOURCED(  694): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:59:34.998+0600 W/AUL_AMD (  653): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:59:34.998+0600 I/SHAREDRULE_CLIENT(  653): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:59:34.998+0600 I/SHAREDRULE_CLIENT(  653): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 16:59:34.998+0600 I/SHAREDRULE_CLIENT(  653): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:59:34.998+0600 W/AUL_AMD (  653): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:59:34.998+0600 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:59:34.998+0600 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:59:35.008+0600 E/CAPI_APPFW_APPLICATION(24085): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:59:35.008+0600 E/CAPI_APPFW_APPLICATION(24085): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:59:35.008+0600 E/CAPI_APPFW_APPLICATION(24085): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:59:35.008+0600 E/CAPI_APPFW_APPLICATION(24085): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:59:35.008+0600 E/CAPI_APPFW_APPLICATION(24085): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:59:35.008+0600 I/CAPI_APPFW_APPLICATION(24085): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:59:35.018+0600 I/CAPI_APPFW_APPLICATION(24085): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:59:35.038+0600 I/MALI    (  297): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7af8fd0), gem(7), surface(0xb7af9990)
09-10 16:59:35.038+0600 I/MALI    (  297): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7af8fd0), gem(7), surface(0xb7b35f98)
09-10 16:59:35.038+0600 I/GXT_SIB (  297): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:59:35.038+0600 E/UXT     (  297): uxt_theme.c: uxt_theme_set_color_table(729) > failed to get color table item
09-10 16:59:35.048+0600 E/EFL     (  297): eo<297> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bc8b21 in class 'Edje_Object'.
09-10 16:59:35.048+0600 E/UXT     (  297): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 16:59:35.098+0600 I/MALI    (  297): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7ac5e90), gem(24), surface(0xb7b70aa0)
09-10 16:59:35.098+0600 W/AUL     (  653): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 24085, appid: com.samsung.task-mgr
09-10 16:59:35.098+0600 E/AUL     (  653): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:59:35.108+0600 W/AUL     (  752): launch.c: app_request_to_launchpad(425) > request cmd(0) result(24085)
09-10 16:59:35.108+0600 E/AUL     (  653): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:59:35.148+0600 W/TASK_MGR_LITE(24085): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 16:59:35.148+0600 E/RESOURCED(  694): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 16:59:35.158+0600 I/GXT_SIB (24085): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:59:35.198+0600 E/PKGMGR_INFO(24085): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_label(1960) > (ret == PMINFO_R_OK) sat ui(org.tizen.sat-ui) is enabled
09-10 16:59:35.208+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:59:35.208+0600 E/RUA     (24085): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 22, ncols : 5
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 16:59:35.208+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:59:35.208+0600 W/AUL_AMD (  653): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 25198
09-10 16:59:35.208+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:59:35.208+0600 E/EFL     (  297): eo<297> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:59:35.208+0600 E/EFL     (  297): eo<297> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.call-ui) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.ciss) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsungaccount.samsungaccountupdate) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsungaccount.samsungaccountservice) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.saf-servie) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 16:59:35.208+0600 E/TASK_MGR_LITE(24085): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 16:59:35.228+0600 I/Tizen::System( 1395): (259) > Active app [com.samsun], current [org.exampl] 
09-10 16:59:35.228+0600 I/Tizen::Io( 1395): (729) > Entry not found
09-10 16:59:35.268+0600 I/Tizen::System( 1395): (157) > change brightness system value.
09-10 16:59:35.278+0600 I/TIZEN_N_SOUND_MANAGER(25704): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=3, ret=0x0
09-10 16:59:35.278+0600 E/TIZEN_N_SOUND_MANAGER(25704): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:59:35.288+0600 I/TIZEN_N_SOUND_MANAGER(25704): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 16:59:35.288+0600 E/TIZEN_N_SOUND_MANAGER(25704): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:59:35.288+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:59:35.308+0600 I/APP_CORE(24085): appcore-efl.c: __do_app(520) > [APP 24085] Event: RESET State: CREATED
09-10 16:59:35.308+0600 I/CAPI_APPFW_APPLICATION(24085): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:59:35.318+0600 E/EFL     (24085): edje<24085> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:59:35.318+0600 E/EFL     (24085): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:59:35.318+0600 E/EFL     (24085): edje<24085> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:59:35.318+0600 E/EFL     (24085): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:59:35.318+0600 W/APP_CORE(24085): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00003
09-10 16:59:35.318+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 16:59:35.358+0600 E/EFL     (  871): ecore_x<871> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=4778616
09-10 16:59:35.358+0600 W/STARTER (  752): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 16:59:35.358+0600 E/EFL     (25198): ecore_x<25198> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=4778616
09-10 16:59:35.368+0600 E/STARTER (  752): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:59:35.368+0600 E/STARTER (  752): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:59:35.368+0600 E/STARTER (  752): )
09-10 16:59:35.368+0600 I/SYSPOPUP(  956): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:59:35.368+0600 I/SYSPOPUP(  956): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:59:35.368+0600 E/VOLUME  (  956): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:59:35.368+0600 E/VOLUME  (  956): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:59:35.388+0600 I/MALI    (24085): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb7123e10)
09-10 16:59:35.398+0600 I/MALI    (24085): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:59:35.398+0600 I/MALI    (  297): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7ab2320), gem(30), surface(0xb7b27a88)
09-10 16:59:35.408+0600 W/AUL_AMD (  653): amd_launch.c: __e17_status_handler(3367) > pid(24085) status(0)
09-10 16:59:35.418+0600 I/APP_CORE(24085): appcore-efl.c: __do_app(520) > [APP 24085] Event: RESUME State: CREATED
09-10 16:59:35.418+0600 E/AUL     (  653): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:59:35.428+0600 I/APP_CORE(25198): appcore-efl.c: __do_app(520) > [APP 25198] Event: PAUSE State: RUNNING
09-10 16:59:35.428+0600 I/CAPI_APPFW_APPLICATION(25198): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:59:35.428+0600 I/TIZEN_N_EFL_UTIL_WINDOW(25198): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 16:59:35.428+0600 E/APP_CORE(25198): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:59:35.428+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:59:35.428+0600 W/AUL_AMD (  653): amd_launch.c: __e17_status_handler(3367) > pid(25198) status(4)
09-10 16:59:35.428+0600 W/AUL     (  653): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(25198)
09-10 16:59:35.428+0600 W/AUL     (  653): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 25198, appid: org.example.bluetooth, status: bg
09-10 16:59:35.438+0600 W/AUL_AMD (  653): amd_launch.c: __e17_status_handler(3367) > pid(24085) status(3)
09-10 16:59:35.438+0600 W/AUL_AMD (  653): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:59:35.438+0600 W/AUL_AMD (  653): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:59:35.438+0600 W/AUL     (  653): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(24085)
09-10 16:59:35.438+0600 W/AUL     (  653): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 24085, appid: com.samsung.task-mgr, status: fg
09-10 16:59:35.438+0600 E/AUL     (  653): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:59:35.438+0600 I/MALI    (  297): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7b4e158), gem(29), surface(0xb7af9990)
09-10 16:59:35.438+0600 I/APP_CORE(24085): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 16:59:35.438+0600 I/APP_CORE(24085): appcore-efl.c: __do_app(637) > [APP 24085] Initial Launching, call the resume_cb
09-10 16:59:35.438+0600 I/CAPI_APPFW_APPLICATION(24085): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:59:35.858+0600 E/EFL     (24085): ecore_x<24085> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=4779110
09-10 16:59:35.909+0600 E/EFL     (24085): ecore_x<24085> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=4779168
09-10 16:59:35.919+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:59:35.919+0600 W/AUL_AMD (  653): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 25198
09-10 16:59:35.919+0600 W/AUL     (24085): launch.c: app_request_to_launchpad(396) > request cmd(4) to(25198)
09-10 16:59:35.919+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 16:59:35.929+0600 W/AUL_AMD (  653): amd_launch.c: __reply_handler(1102) > listen fd(26) , send fd(25), pid(25198), cmd(4)
09-10 16:59:35.929+0600 W/AUL     (24085): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 16:59:35.929+0600 I/APP_CORE(25198): appcore-efl.c: __do_app(520) > [APP 25198] Event: TERMINATE State: PAUSED
09-10 16:59:35.929+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:59:35.929+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:59:35.929+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:59:35.929+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:59:35.929+0600 I/TIZEN_N_EFL_UTIL_WINDOW(25198): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 16:59:35.929+0600 E/APP_CORE(25198): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:59:35.929+0600 W/AUL_AMD (  653): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:59:35.929+0600 E/APP_CORE(25198): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 16:59:35.939+0600 I/CAPI_APPFW_APPLICATION(25198): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:59:35.939+0600 E/CAPI_NETWORK_BLUETOOTH(25198): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 16:59:36.019+0600 E/CAPI_NETWORK_BLUETOOTH(25198): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 16:59:36.019+0600 E/CAPI_NETWORK_BLUETOOTH(25198): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 16:59:36.019+0600 E/bluetooth(25198): [bt_adapter_le_destroy_advertiser] Failed.
09-10 16:59:36.019+0600 I/CAPI_NETWORK_WIFI(25198): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:59:36.019+0600 E/bluetooth(25198): [wifi_deinitialize] Success.
09-10 16:59:36.089+0600 E/EFL     (25198): elementary<25198> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 16:59:36.169+0600 I/Tizen::App( 1395): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 16:59:36.169+0600 I/Tizen::App( 1395): (733) > Finished invoking application event listener for com.samsung.task-mgr, 24085.
09-10 16:59:36.339+0600 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 25198 pgid = 25198
09-10 16:59:36.339+0600 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(25198)
09-10 16:59:36.399+0600 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:59:36.399+0600 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:59:36.399+0600 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
09-10 16:59:36.399+0600 I/ESD     ( 1003): esd_main.c: __esd_app_dead_handler(1773) > pid: 25198
09-10 16:59:36.399+0600 I/Tizen::App( 1395): (243) > App[org.example.bluetooth] pid[25198] terminate event is forwarded
09-10 16:59:36.399+0600 I/Tizen::System( 1395): (256) > osp.accessorymanager.service provider is found.
09-10 16:59:36.399+0600 I/Tizen::System( 1395): (196) > Accessory Owner is removed [org.example.bluetooth, 25198, ]
09-10 16:59:36.399+0600 I/Tizen::System( 1395): (256) > osp.system.service provider is found.
09-10 16:59:36.399+0600 I/Tizen::App( 1395): (506) > TerminatedApp(org.example.bluetooth)
09-10 16:59:36.399+0600 I/Tizen::App( 1395): (512) > Not registered pid(25198)
09-10 16:59:36.399+0600 I/Tizen::System( 1395): (246) > Terminated app [org.example.bluetooth]
09-10 16:59:36.399+0600 I/Tizen::Io( 1395): (729) > Entry not found
09-10 16:59:36.409+0600 I/MALI    (24085): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:59:36.409+0600 W/AUL_AMD (  653): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25198
09-10 16:59:36.419+0600 I/MALI    (24085): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:59:36.429+0600 I/MALI    (24085): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:59:36.439+0600 E/RESOURCED(  694): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 16:59:36.439+0600 I/Tizen::System( 1395): (157) > change brightness system value.
09-10 16:59:36.439+0600 I/Tizen::App( 1395): (782) > Finished invoking application event listener for org.example.bluetooth, 25198.
09-10 16:59:36.529+0600 W/CRASH_MANAGER(26405): worker.c: worker_job(1199) > 1125198626162147350517
