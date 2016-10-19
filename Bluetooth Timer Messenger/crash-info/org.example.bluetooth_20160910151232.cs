S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 25083
Date: 2016-09-10 15:12:32+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25083, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb8d1c3a0
r2   = 0xb435f000, r3   = 0xb435f000
r4   = 0xb8c21c38, r5   = 0xbe8065bc
r6   = 0xb6a5d310, r7   = 0xbe80641c
r8   = 0xb6a5e0f4, r9   = 0xb6a5e0f4
r10  = 0xb6a6c20c, fp   = 0x00000000
ip   = 0xb2a52388, sp   = 0xbe804770
lr   = 0xb2a4672b, pc   = 0xb67416f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     64072 KB
Buffers:     40732 KB
Cached:     283752 KB
VmPeak:     106692 KB
VmSize:     104116 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25900 KB
VmRSS:       25900 KB
VmData:      35616 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36248 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 25083 TID = 25083
25083 25089 25189 

Maps Information
b1d29000 b1d2e000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1d9b000 b259a000 rw-p [stack:25189]
b259a000 b25ab000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25bb000 b25c0000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b264c000 b2654000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2665000 b2666000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2676000 b268a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b269e000 b269f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26af000 b26b2000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26c3000 b26c4000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26d4000 b26d6000 r-xp /usr/lib/libxcb-present.so.0.0.0
b26e6000 b26e8000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26f8000 b2708000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2718000 b2724000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2935000 b294c000 r-xp /usr/lib/libnetwork.so.0.0.0
b295d000 b299b000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29ac000 b29b3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29c4000 b29d3000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b29e3000 b2a18000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a2b000 b2a31000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a41000 b2a4a000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b6c000 b2c4f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c86000 b2cae000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cc0000 b34bf000 rw-p [stack:25089]
b34bf000 b34c1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34d1000 b34db000 r-xp /lib/libnss_files-2.20-2014.11.so
b34ec000 b34f5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3506000 b3517000 r-xp /lib/libnsl-2.20-2014.11.so
b352a000 b3530000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3541000 b3542000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b356a000 b3571000 r-xp /usr/lib/libminizip.so.1.0.0
b3581000 b3586000 r-xp /usr/lib/libstorage.so.0.1
b3596000 b35eb000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3601000 b3615000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3625000 b3669000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3679000 b3681000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3691000 b36c1000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36d4000 b378d000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37a1000 b37f5000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3806000 b3821000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3831000 b38f2000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3905000 b3917000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3927000 b392b000 r-xp /usr/lib/libogg.so.0.7.1
b393b000 b395d000 r-xp /usr/lib/libvorbis.so.0.4.3
b396d000 b3a51000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a6d000 b3a7a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a8b000 b3ace000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ae3000 b3b2a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b3b000 b3b41000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b52000 b3b59000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b69000 b3ba9000 r-xp /usr/lib/libmdm.so.1.2.10
b3bb9000 b3bc1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bd0000 b3be0000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c01000 b3c61000 r-xp /usr/lib/libasound.so.2.0.0
b3c73000 b3ca9000 r-xp /usr/lib/libpulse.so.0.16.2
b3cba000 b3cbd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3ccd000 b3cd0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3ce0000 b3ce5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cf5000 b3cf6000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d06000 b3d11000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d25000 b3d2c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d3c000 b3d42000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d52000 b3d57000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d67000 b3d82000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d92000 b3d99000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3da9000 b3dac000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3dbd000 b3deb000 r-xp /usr/lib/libidn.so.11.5.44
b3dfb000 b3e11000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e22000 b3e2c000 r-xp /usr/lib/libcares.so.2.1.0
b3e3c000 b3e46000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e56000 b3e58000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e68000 b3e69000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e79000 b3e7d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e8e000 b3eb6000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ec7000 b3ef0000 r-xp /usr/lib/libturbojpeg.so
b3f10000 b3f16000 r-xp /usr/lib/libgif.so.4.1.6
b3f26000 b3f6c000 r-xp /usr/lib/libcurl.so.4.3.0
b3f7d000 b3f9e000 r-xp /usr/lib/libexif.so.12.3.3
b3fb9000 b3fce000 r-xp /usr/lib/libtts.so
b3fdf000 b3fe7000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ff7000 b40b7000 r-xp /usr/lib/libdali-core.so.0.0.0
b40c2000 b41b5000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41d5000 b42af000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42c6000 b42c8000 r-xp /usr/lib/libboost_system.so.1.51.0
b42d8000 b42de000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42ee000 b4311000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4322000 b4324000 r-xp /usr/lib/libappsvc.so.0.1.0
b4334000 b4336000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4347000 b434c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4363000 b4365000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4375000 b437c000 r-xp /usr/lib/libsensord-share.so
b438c000 b43a4000 r-xp /usr/lib/libsensor.so.1.1.0
b43b5000 b43b8000 r-xp /usr/lib/libXv.so.1.0.0
b43c8000 b43cd000 r-xp /usr/lib/libutilX.so.1.1.0
b43dd000 b43e2000 r-xp /usr/lib/libappcore-common.so.1.1
b43f2000 b43f9000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b440c000 b4410000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4421000 b44eb000 r-xp /usr/lib/libCOREGL.so.4.0
b4502000 b4505000 r-xp /usr/lib/libuuid.so.1.3.0
b4516000 b452d000 r-xp /usr/lib/libblkid.so.1.1.0
b453e000 b4540000 r-xp /usr/lib/libXau.so.6.0.0
b4550000 b4553000 r-xp /usr/lib/libEGL.so.1.4
b455b000 b4561000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4571000 b4573000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4584000 b4592000 r-xp /usr/lib/libGLESv2.so.2.0
b459b000 b45fd000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4612000 b462a000 r-xp /usr/lib/libmount.so.1.1.0
b463b000 b464f000 r-xp /usr/lib/libxcb.so.1.1.0
b4660000 b4667000 r-xp /lib/libcrypt-2.20-2014.11.so
b469f000 b46b0000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46c1000 b46c3000 r-xp /usr/lib/libiri.so
b46d3000 b46de000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46ef000 b4704000 r-xp /lib/libexpat.so.1.5.2
b4716000 b47d4000 r-xp /usr/lib/libcairo.so.2.11200.14
b47e7000 b47ef000 r-xp /usr/lib/libdrm.so.2.4.0
b47ff000 b4802000 r-xp /usr/lib/libdri2.so.0.0.0
b4813000 b4861000 r-xp /usr/lib/libssl.so.1.0.0
b4876000 b4882000 r-xp /usr/lib/libeeze.so.1.13.0
b4892000 b489b000 r-xp /usr/lib/libethumb.so.1.13.0
b48ab000 b48ae000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48be000 b4a75000 r-xp /usr/lib/libcrypto.so.1.0.0
b56cc000 b56d5000 r-xp /usr/lib/libXi.so.6.1.0
b56e5000 b56e7000 r-xp /usr/lib/libXgesture.so.7.0.0
b56f7000 b56fb000 r-xp /usr/lib/libXtst.so.6.1.0
b570b000 b5711000 r-xp /usr/lib/libXrender.so.1.3.0
b5721000 b5727000 r-xp /usr/lib/libXrandr.so.2.2.0
b5738000 b573a000 r-xp /usr/lib/libXinerama.so.1.0.0
b574a000 b574d000 r-xp /usr/lib/libXfixes.so.3.1.0
b575d000 b5768000 r-xp /usr/lib/libXext.so.6.4.0
b5778000 b577a000 r-xp /usr/lib/libXdamage.so.1.1.0
b578a000 b578c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b579d000 b587f000 r-xp /usr/lib/libX11.so.6.3.0
b5892000 b5899000 r-xp /usr/lib/libXcursor.so.1.0.2
b58a9000 b58c1000 r-xp /usr/lib/libudev.so.1.6.0
b58c3000 b58c6000 r-xp /lib/libattr.so.1.1.0
b58d6000 b58f6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58f8000 b58fd000 r-xp /usr/lib/libffi.so.6.0.2
b590d000 b5925000 r-xp /lib/libz.so.1.2.8
b5935000 b5937000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5947000 b5a1c000 r-xp /usr/lib/libxml2.so.2.9.2
b5a31000 b5acc000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ae8000 b5aeb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5afb000 b5b14000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b25000 b5b36000 r-xp /lib/libresolv-2.20-2014.11.so
b5b4a000 b5bc4000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bd9000 b5bdb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5beb000 b5bf2000 r-xp /usr/lib/libembryo.so.1.13.0
b5c02000 b5c1a000 r-xp /usr/lib/libpng12.so.0.50.0
b5c2b000 b5c4e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c6f000 b5c83000 r-xp /usr/lib/libector.so.1.13.0
b5c94000 b5cac000 r-xp /usr/lib/liblua-5.1.so
b5cbd000 b5d14000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d28000 b5d50000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d61000 b5d74000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d85000 b5dbc000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dcd000 b5ddb000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5deb000 b5df3000 r-xp /usr/lib/libtbm.so.1.0.0
b5e03000 b5e10000 r-xp /usr/lib/libeio.so.1.13.0
b5e20000 b5e22000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e32000 b5e37000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e47000 b5e5e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e70000 b5e90000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ea0000 b5ec0000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ec2000 b5ec8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed8000 b5ee9000 r-xp /usr/lib/libemotion.so.1.13.0
b5efa000 b5f01000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f11000 b5f20000 r-xp /usr/lib/libeo.so.1.13.0
b5f31000 b5f43000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f54000 b5f59000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f69000 b5f82000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f92000 b5faf000 r-xp /usr/lib/libeet.so.1.13.0
b5fc8000 b6010000 r-xp /usr/lib/libeina.so.1.13.0
b6021000 b6031000 r-xp /usr/lib/libefl.so.1.13.0
b6042000 b6127000 r-xp /usr/lib/libicuuc.so.51.1
b6144000 b6284000 r-xp /usr/lib/libicui18n.so.51.1
b629b000 b62d3000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e5000 b62e8000 r-xp /lib/libcap.so.2.21
b62f8000 b6321000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6332000 b6339000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b634b000 b6382000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6393000 b647e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6491000 b650a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b651c000 b6521000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6531000 b653b000 r-xp /usr/lib/libvconf.so.0.2.45
b654b000 b654d000 r-xp /usr/lib/libvasum.so.0.3.1
b655d000 b655f000 r-xp /usr/lib/libttrace.so.1.1
b656f000 b6572000 r-xp /usr/lib/libiniparser.so.0
b6582000 b65a8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b8000 b65bd000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ce000 b65e5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f6000 b6661000 r-xp /lib/libm-2.20-2014.11.so
b6672000 b6678000 r-xp /lib/librt-2.20-2014.11.so
b6689000 b6696000 r-xp /usr/lib/libunwind.so.8.0.1
b66cc000 b67f0000 r-xp /lib/libc-2.20-2014.11.so
b6805000 b681e000 r-xp /lib/libgcc_s-4.9.so.1
b682e000 b6910000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6921000 b694b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b695c000 b6998000 r-xp /usr/lib/libsystemd.so.0.4.0
b699a000 b6a1c000 r-xp /usr/lib/libedje.so.1.13.0
b6a2f000 b6a4d000 r-xp /usr/lib/libecore.so.1.13.0
b6a6d000 b6bf4000 r-xp /usr/lib/libevas.so.1.13.0
b6c29000 b6c3d000 r-xp /lib/libpthread-2.20-2014.11.so
b6c51000 b6e86000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb4000 b6eb8000 r-xp /usr/lib/libsmack.so.1.0.0
b6ec8000 b6ecf000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6edf000 b6ee1000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef1000 b6ef4000 r-xp /usr/lib/libbundle.so.0.1.22
b6f04000 b6f06000 r-xp /lib/libdl-2.20-2014.11.so
b6f17000 b6f2f000 r-xp /usr/lib/libaul.so.0.1.0
b6f43000 b6f48000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f59000 b6f66000 r-xp /usr/lib/liblptcp.so
b6f78000 b6f7c000 r-xp /usr/lib/libsys-assert.so
b6f8d000 b6fad000 r-xp /lib/ld-2.20-2014.11.so
b6fbe000 b6fc3000 r-xp /usr/bin/launchpad-loader
b8be0000 b8fdc000 rw-p [heap]
be7e6000 be807000 rw-p [stack]
be7e6000 be807000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25083)
Call Stack Count: 1
 0: (0xb67416f0) [/lib/libc.so.6] + 0x756f0
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
25083> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10146711
09-10 15:11:39.748+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10146771
09-10 15:11:39.788+0600 E/bluetooth(25083): [bt_adapter_start_discover_device] Failed.
09-10 15:11:39.818+0600 D/bluetooth(25083): The device is not discoverable.
09-10 15:11:40.278+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10147303
09-10 15:11:40.369+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10147387
09-10 15:11:40.529+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10147550
09-10 15:11:40.709+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10147611
09-10 15:11:40.759+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10147775
09-10 15:11:40.829+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10147858
09-10 15:11:40.989+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10148000
09-10 15:11:41.049+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10148074
09-10 15:11:41.219+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10148228
09-10 15:11:41.249+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10148268
09-10 15:11:41.660+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10148625
09-10 15:11:41.660+0600 E/EFL     (25083): ecore_x<25083> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10148677
09-10 15:11:41.680+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 15:11:41.680+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:11:41.680+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:11:41.680+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 15:11:41.680+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 15:11:41.680+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:11:41.700+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76a91b8), gem(13), surface(0xb787ea40)
09-10 15:11:41.710+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 36
09-10 15:11:41.710+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:11:41.720+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7805ab0), gem(18), surface(0xb78ae1a0)
09-10 15:11:41.750+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(21), surface(0xb7808968)
09-10 15:11:41.750+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(21), surface(0xb7891a08)
09-10 15:11:41.760+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:11:41.770+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:11:41.780+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 15:11:41.780+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 15:11:41.780+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 15:11:41.800+0600 I/APP_CORE(25083): appcore-efl.c: __do_app(520) > [APP 25083] Event: PAUSE State: RUNNING
09-10 15:11:41.800+0600 I/CAPI_APPFW_APPLICATION(25083): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:11:41.800+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(25083) status(4)
09-10 15:11:41.800+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(25083)
09-10 15:11:41.800+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 25083, appid: org.example.bluetooth, status: bg
09-10 15:11:41.800+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7703b00), gem(22), surface(0xb78b9638)
09-10 15:11:41.830+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76a91b8), gem(13), surface(0xb7808968)
09-10 15:11:41.830+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 15:11:41.840+0600 I/TIZEN_N_EFL_UTIL_WINDOW(25083): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 38
09-10 15:11:41.840+0600 E/APP_CORE(25083): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 15:11:41.840+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:11:41.880+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 15:11:41.910+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:11:41.910+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:11:41.930+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 15:11:41.940+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 15:11:41.940+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:11:41.950+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 15:11:41.950+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:11:41.950+0600 E/EFL     (  873): ecore_x<873> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10148905
09-10 15:11:41.950+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
09-10 15:11:41.950+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:11:41.950+0600 E/EFL     (  873): ecore_x<873> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10148969
09-10 15:11:41.950+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
09-10 15:11:41.960+0600 W/cluster-home(  873): cluster-data-provider.cpp: OnMainScrollStarted(4740) >  Main Scroll Started
09-10 15:11:41.960+0600 W/cluster-home(  873): cluster-data-provider.cpp: OnMainScrollStarted(4742) >  Main Scroll Started Done
09-10 15:11:41.990+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 15:11:42.000+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8339348]
09-10 15:11:42.000+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 15:11:42.000+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 15:11:42.000+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 15:11:42.000+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8339348
09-10 15:11:42.020+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 15:11:42.020+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-10 15:11:42.020+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-10 15:11:42.020+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 15:11:42.020+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 15:11:42.020+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 15:11:42.050+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 15:11:42.050+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 15:11:42.050+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 15:11:42.090+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7767f70), gem(18), surface(0xb78ae1a0)
09-10 15:11:42.130+0600 W/cluster-home(  873): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed
09-10 15:11:42.130+0600 W/cluster-home(  873): cluster-data-provider.cpp: OnMainScrollCompleted(4753) >  Main Scroll Completed Done
09-10 15:11:42.150+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 15:11:42.180+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776f350), gem(21), surface(0xb7808968)
09-10 15:11:42.180+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:11:42.190+0600 E/EFL     (25083): edje<25083> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:11:42.190+0600 E/EFL     (25083): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:11:42.190+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 15:11:42.190+0600 E/EFL     (25083): edje<25083> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:11:42.190+0600 E/EFL     (25083): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:11:42.200+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:11:42.200+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 15:11:42.220+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8358758]
09-10 15:11:42.220+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 15:11:42.220+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 15:11:42.220+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 15:11:42.220+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8358758
09-10 15:11:42.220+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 15:11:42.220+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-10 15:11:42.220+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-10 15:11:42.220+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 15:11:42.220+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 15:11:42.220+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 15:11:42.961+0600 I/Tizen::System( 1366): (150) > Battery Warn Level is changed
09-10 15:11:42.961+0600 I/Tizen::System( 1366): (182) > Battery Level event is forwarded
09-10 15:11:42.961+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 96
09-10 15:11:42.961+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 15:11:42.961+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
09-10 15:11:42.961+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
09-10 15:11:42.971+0600 E/INDICATOR(  685): battery.c: show_digits(405) > show_digits[405]	 "Show digits: 96"
09-10 15:11:42.971+0600 I/INDICATOR(  685): battery.c: show_battery_icon(376) > "Percentage:(1) / Level:(9) / batt_Full:(0) / battery_charging(1)"
09-10 15:11:42.971+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 15:11:42.971+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:11:42.971+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:11:42.971+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:11:42.971+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 15:11:42.971+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 15:11:46.805+0600 I/APP_CORE(25083): appcore-efl.c: __do_app(520) > [APP 25083] Event: MEM_FLUSH State: PAUSED
09-10 15:12:00.578+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 15:12:00.578+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 3:12 p.m.
09-10 15:12:00.578+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 3:12 p.m."
09-10 15:12:00.578+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 3:12 p.m."
09-10 15:12:00.578+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 15:12:00.578+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145499395 Time: <font_size=31> </font_size> <font_size=31> 3:12 p.m.</font_size></font>"
09-10 15:12:04.022+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 15:12:11.008+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:12:11.008+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:12:11.038+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 15:12:11.038+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 15:12:11.038+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 15:12:11.038+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 15:12:11.038+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 15:12:11.038+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 15:12:11.038+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:1389c80
09-10 15:12:11.038+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 15:12:11.038+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 15:12:11.048+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 15:12:11.048+0600 W/APP_CORE(  873): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 15:12:11.048+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: RUNNING
09-10 15:12:11.048+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:12:11.048+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 15:12:11.058+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 15:12:11.088+0600 E/VCONF   (15121): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:12:11.088+0600 E/VCONF   (15121): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:12:11.088+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 15:12:11.109+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 15:12:11.609+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:12:11.609+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:12:11.609+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 15:12:11.619+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77ae8c8), gem(14), surface(0xb787ea40)
09-10 15:12:11.659+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: PAUSED
09-10 15:12:11.659+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 15:12:11.679+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7737e90), gem(13), surface(0xb78ae1a0)
09-10 15:12:11.679+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:12:11.679+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:12:11.689+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:12:11.689+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:12:11.689+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 15:12:11.689+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 15:12:11.709+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 15:12:11.709+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 15:12:11.719+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 15:12:11.719+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 15:12:11.719+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 15:12:11.719+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 15:12:11.719+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:12:11.759+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78306d8), gem(18), surface(0xb78b9638)
09-10 15:12:11.759+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 15:12:11.819+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 15:12:11.819+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 15:12:11.829+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78448e8), gem(15), surface(0xb78c6778)
09-10 15:12:11.829+0600 E/VCONF   (15121): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:12:11.829+0600 E/VCONF   (15121): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:12:11.829+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 15:12:11.829+0600 E/VCONF   (  869): vconf.c: _vconf_set_key_filesys(1436) > file(memory/lockscreen/visibility) lock owner(685)
09-10 15:12:11.829+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 15:12:11.839+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 15:12:11.839+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 15:12:11.849+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:12:11.849+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:12:11.849+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:12:11.849+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:12:11.849+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 15:12:11.849+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 15:12:11.849+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 15:12:11.849+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 15:12:11.849+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:12:11.859+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 15:12:11.859+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 15:12:11.859+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 15:12:11.859+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 15:12:11.859+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 25542
09-10 15:12:11.859+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 15:12:11.909+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 25542
09-10 15:12:11.909+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 25542, appid: com.samsung.weather-m-agent
09-10 15:12:11.929+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(25542)
09-10 15:12:11.939+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 15:12:11.939+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 25542.
09-10 15:12:11.949+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 15:12:11.949+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 15:12:11.949+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 15:12:11.949+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 15:12:11.949+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 15:12:11.949+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 15:12:11.959+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 15:12:11.959+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 15:12:11.959+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 15:12:11.959+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 15:12:11.959+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 15:12:12.079+0600 E/weather-agent(25542): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 15:12:12.079+0600 E/weather-common(25542): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 15:12:12.079+0600 E/weather-agent(25542): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 15:12:12.089+0600 I/MESSAGE_PORT(25542): message-port.c: __initialize(872) > initialize
09-10 15:12:12.099+0600 I/MESSAGE_PORT(25542): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 15:12:12.120+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 15:12:12.120+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 15:12:12.120+0600 I/MESSAGE_PORT(25542): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:12:12.120+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 15:12:12.120+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 15:12:12.120+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 15:12:12.130+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 15:12:12.130+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 15:12:12.130+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:12:12.130+0600 E/MESSAGE_PORT(25542): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 15:12:12.130+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 15:12:12.130+0600 I/MESSAGE_PORT(25542): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 15:12:12.140+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 15:12:12.140+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:12:12.140+0600 E/MESSAGE_PORT(25542): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 15:12:12.140+0600 E/weather-common(25542): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 15:12:12.140+0600 E/weather-agent(25542): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 15:12:12.140+0600 E/weather-agent(25542): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 15:12:12.140+0600 I/MESSAGE_PORT(25542): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 15:12:12.140+0600 I/MESSAGE_PORT(25542): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 15:12:12.170+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:12:12.210+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 15:12:12.210+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 15:12:12.410+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb831b930]
09-10 15:12:12.410+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 15:12:12.410+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 15:12:12.410+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 15:12:12.410+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb831b930
09-10 15:12:12.410+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 15:12:12.420+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 15:12:12.420+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 15:12:12.420+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 15:12:12.430+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 15:12:12.430+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 15:12:12.440+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 15:12:12.470+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801badb8 is not stable during recalc loop
09-10 15:12:12.530+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801badb8 is not stable during recalc loop
09-10 15:12:12.530+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 15:12:12.540+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 15:12:13.151+0600 E/weather-agent(25542): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 15:12:13.151+0600 I/CAPI_APPFW_APPLICATION(25542): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 15:12:13.151+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:12:13.151+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:12:13.151+0600 E/weather-agent(25542): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 15:12:13.291+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 15:12:13.291+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25542
09-10 15:12:13.291+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[25542] terminate event is forwarded
09-10 15:12:13.291+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:12:13.291+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 25542, ]
09-10 15:12:13.291+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:12:13.291+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 15:12:13.291+0600 I/Tizen::App( 1366): (512) > Not registered pid(25542)
09-10 15:12:13.291+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 15:12:13.291+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:12:13.301+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 25542
09-10 15:12:13.301+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:12:13.311+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:12:13.311+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 25542.
09-10 15:12:13.311+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 15:12:16.063+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: MEM_FLUSH State: PAUSED
09-10 15:12:18.155+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 15:12:32.449+0600 E/PKGMGR_SERVER(25680): pkgmgr-server.c: main(2414) > package manager server start
09-10 15:12:32.509+0600 E/PKGMGR  (25678): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 25083
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:12:32.559+0600 W/AUL     (25685): launch.c: app_request_to_launchpad(396) > request cmd(5) to(25083)
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(25083), cmd(4)
09-10 15:12:32.559+0600 W/AUL     (25685): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 25083
09-10 15:12:32.559+0600 I/APP_CORE(25083): appcore-efl.c: __do_app(520) > [APP 25083] Event: TERMINATE State: PAUSED
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:12:32.559+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:12:32.569+0600 I/TIZEN_N_EFL_UTIL_WINDOW(25083): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 15:12:32.569+0600 E/APP_CORE(25083): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 15:12:32.569+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:12:32.569+0600 E/APP_CORE(25083): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 15:12:32.569+0600 I/CAPI_APPFW_APPLICATION(25083): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:12:32.569+0600 E/CAPI_NETWORK_BLUETOOTH(25083): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 15:12:32.630+0600 E/CAPI_NETWORK_BLUETOOTH(25083): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 15:12:32.630+0600 E/CAPI_NETWORK_BLUETOOTH(25083): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 15:12:32.630+0600 E/bluetooth(25083): [bt_adapter_le_destroy_advertiser] Failed.
09-10 15:12:32.630+0600 I/CAPI_NETWORK_WIFI(25083): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 15:12:32.630+0600 E/bluetooth(25083): [wifi_deinitialize] Success.
09-10 15:12:32.660+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:12:32.660+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 15:12:32.670+0600 E/PKGMGR_SERVER(25680): pkgmgr-server.c: sighandler(417) > child NORMAL exit [25685]
09-10 15:12:32.680+0600 E/EFL     (25083): eo<25083> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x800e934d's acvie is  NULL, entry: 0xb3565a68, 0xb8f104a0, 0
09-10 15:12:32.680+0600 E/EFL     (25083): eo<25083> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x800e934d is not pointing to a valid object. Maybe it has already been freed.
09-10 15:12:32.680+0600 E/EFL     (25083): eo<25083> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800e934d) is an invalid ref.
09-10 15:12:32.720+0600 E/EFL     (25083): elementary<25083> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 15:12:32.880+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 25083 pgid = 25083
09-10 15:12:32.880+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(25083)
09-10 15:12:32.920+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:12:32.920+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:12:32.920+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:12:32.920+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[25083] terminate event is forwarded
09-10 15:12:32.920+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:12:32.920+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 25083, ]
09-10 15:12:32.920+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:12:32.920+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 15:12:32.920+0600 I/Tizen::App( 1366): (512) > Not registered pid(25083)
09-10 15:12:32.920+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 15:12:32.920+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:12:32.930+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 25083
09-10 15:12:32.930+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25083
09-10 15:12:32.940+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:12:32.940+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:12:32.940+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 25083.
09-10 15:12:32.980+0600 W/CRASH_MANAGER(25692): worker.c: worker_job(1199) > 1125083626162147349875
