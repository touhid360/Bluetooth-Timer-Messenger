S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 8242
Date: 2016-09-10 16:04:14+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8242, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb7a8c0e0
r2   = 0xb4343000, r3   = 0xb4343000
r4   = 0xb7a64c38, r5   = 0xbe8be5bc
r6   = 0xb6a41310, r7   = 0xbe8be41c
r8   = 0xb6a420f4, r9   = 0xb6a420f4
r10  = 0xb6a5020c, fp   = 0x00000000
ip   = 0xb2a36cec, sp   = 0xbe8bc770
lr   = 0xb2a2b4db, pc   = 0xb67256f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     53812 KB
Buffers:     42824 KB
Cached:     287284 KB
VmPeak:     108280 KB
VmSize:     108276 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25528 KB
VmRSS:       25528 KB
VmData:      35216 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36228 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 8242 TID = 8242
8242 8246 9086 

Maps Information
b1d80000 b257f000 rw-p [stack:9086]
b257f000 b2590000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25a0000 b25a5000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2631000 b2639000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b264a000 b264b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b265b000 b266f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2683000 b2684000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2694000 b2697000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26a8000 b26a9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26b9000 b26bb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b26cb000 b26cd000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26dd000 b26ed000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26fd000 b2709000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b291a000 b2931000 r-xp /usr/lib/libnetwork.so.0.0.0
b2942000 b2980000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2991000 b2998000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29a9000 b29b8000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b29c8000 b29fd000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a10000 b2a16000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a26000 b2a2f000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b50000 b2c33000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c6a000 b2c92000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ca4000 b34a3000 rw-p [stack:8246]
b34a3000 b34a5000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34b5000 b34bf000 r-xp /lib/libnss_files-2.20-2014.11.so
b34d0000 b34d9000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34ea000 b34fb000 r-xp /lib/libnsl-2.20-2014.11.so
b350e000 b3514000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3525000 b3526000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b354e000 b3555000 r-xp /usr/lib/libminizip.so.1.0.0
b3565000 b356a000 r-xp /usr/lib/libstorage.so.0.1
b357a000 b35cf000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35e5000 b35f9000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3609000 b364d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b365d000 b3665000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3675000 b36a5000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36b8000 b3771000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3785000 b37d9000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37ea000 b3805000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3815000 b38d6000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38e9000 b38fb000 r-xp /usr/lib/libefl-assist.so.0.1.0
b390b000 b390f000 r-xp /usr/lib/libogg.so.0.7.1
b391f000 b3941000 r-xp /usr/lib/libvorbis.so.0.4.3
b3951000 b3a35000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a51000 b3a5e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a6f000 b3ab2000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ac7000 b3b0e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b1f000 b3b25000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b36000 b3b3d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b4d000 b3b8d000 r-xp /usr/lib/libmdm.so.1.2.10
b3b9d000 b3ba5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bb4000 b3bc4000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3be5000 b3c45000 r-xp /usr/lib/libasound.so.2.0.0
b3c57000 b3c8d000 r-xp /usr/lib/libpulse.so.0.16.2
b3c9e000 b3ca1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cb1000 b3cb4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cc4000 b3cc9000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cd9000 b3cda000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cea000 b3cf5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d09000 b3d10000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d20000 b3d26000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d36000 b3d3b000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d4b000 b3d66000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d76000 b3d7d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d8d000 b3d90000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3da1000 b3dcf000 r-xp /usr/lib/libidn.so.11.5.44
b3ddf000 b3df5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e06000 b3e10000 r-xp /usr/lib/libcares.so.2.1.0
b3e20000 b3e2a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e3a000 b3e3c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e4c000 b3e4d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e5d000 b3e61000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e72000 b3e9a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eab000 b3ed4000 r-xp /usr/lib/libturbojpeg.so
b3ef4000 b3efa000 r-xp /usr/lib/libgif.so.4.1.6
b3f0a000 b3f50000 r-xp /usr/lib/libcurl.so.4.3.0
b3f61000 b3f82000 r-xp /usr/lib/libexif.so.12.3.3
b3f9d000 b3fb2000 r-xp /usr/lib/libtts.so
b3fc3000 b3fcb000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fdb000 b409b000 r-xp /usr/lib/libdali-core.so.0.0.0
b40a6000 b4199000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41b9000 b4293000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42aa000 b42ac000 r-xp /usr/lib/libboost_system.so.1.51.0
b42bc000 b42c2000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42d2000 b42f5000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4306000 b4308000 r-xp /usr/lib/libappsvc.so.0.1.0
b4318000 b431a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b432b000 b4330000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4347000 b4349000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4359000 b4360000 r-xp /usr/lib/libsensord-share.so
b4370000 b4388000 r-xp /usr/lib/libsensor.so.1.1.0
b4399000 b439c000 r-xp /usr/lib/libXv.so.1.0.0
b43ac000 b43b1000 r-xp /usr/lib/libutilX.so.1.1.0
b43c1000 b43c6000 r-xp /usr/lib/libappcore-common.so.1.1
b43d6000 b43dd000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43f0000 b43f4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4405000 b44cf000 r-xp /usr/lib/libCOREGL.so.4.0
b44e6000 b44e9000 r-xp /usr/lib/libuuid.so.1.3.0
b44fa000 b4511000 r-xp /usr/lib/libblkid.so.1.1.0
b4522000 b4524000 r-xp /usr/lib/libXau.so.6.0.0
b4534000 b4537000 r-xp /usr/lib/libEGL.so.1.4
b453f000 b4545000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4555000 b4557000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4568000 b4576000 r-xp /usr/lib/libGLESv2.so.2.0
b457f000 b45e1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45f6000 b460e000 r-xp /usr/lib/libmount.so.1.1.0
b461f000 b4633000 r-xp /usr/lib/libxcb.so.1.1.0
b4644000 b464b000 r-xp /lib/libcrypt-2.20-2014.11.so
b4683000 b4694000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46a5000 b46a7000 r-xp /usr/lib/libiri.so
b46b7000 b46c2000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46d3000 b46e8000 r-xp /lib/libexpat.so.1.5.2
b46fa000 b47b8000 r-xp /usr/lib/libcairo.so.2.11200.14
b47cb000 b47d3000 r-xp /usr/lib/libdrm.so.2.4.0
b47e3000 b47e6000 r-xp /usr/lib/libdri2.so.0.0.0
b47f7000 b4845000 r-xp /usr/lib/libssl.so.1.0.0
b485a000 b4866000 r-xp /usr/lib/libeeze.so.1.13.0
b4876000 b487f000 r-xp /usr/lib/libethumb.so.1.13.0
b488f000 b4892000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48a2000 b4a59000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b0000 b56b9000 r-xp /usr/lib/libXi.so.6.1.0
b56c9000 b56cb000 r-xp /usr/lib/libXgesture.so.7.0.0
b56db000 b56df000 r-xp /usr/lib/libXtst.so.6.1.0
b56ef000 b56f5000 r-xp /usr/lib/libXrender.so.1.3.0
b5705000 b570b000 r-xp /usr/lib/libXrandr.so.2.2.0
b571c000 b571e000 r-xp /usr/lib/libXinerama.so.1.0.0
b572e000 b5731000 r-xp /usr/lib/libXfixes.so.3.1.0
b5741000 b574c000 r-xp /usr/lib/libXext.so.6.4.0
b575c000 b575e000 r-xp /usr/lib/libXdamage.so.1.1.0
b576e000 b5770000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5781000 b5863000 r-xp /usr/lib/libX11.so.6.3.0
b5876000 b587d000 r-xp /usr/lib/libXcursor.so.1.0.2
b588d000 b58a5000 r-xp /usr/lib/libudev.so.1.6.0
b58a7000 b58aa000 r-xp /lib/libattr.so.1.1.0
b58ba000 b58da000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58dc000 b58e1000 r-xp /usr/lib/libffi.so.6.0.2
b58f1000 b5909000 r-xp /lib/libz.so.1.2.8
b5919000 b591b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b592b000 b5a00000 r-xp /usr/lib/libxml2.so.2.9.2
b5a15000 b5ab0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5acc000 b5acf000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5adf000 b5af8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b09000 b5b1a000 r-xp /lib/libresolv-2.20-2014.11.so
b5b2e000 b5ba8000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bbd000 b5bbf000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bcf000 b5bd6000 r-xp /usr/lib/libembryo.so.1.13.0
b5be6000 b5bfe000 r-xp /usr/lib/libpng12.so.0.50.0
b5c0f000 b5c32000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c53000 b5c67000 r-xp /usr/lib/libector.so.1.13.0
b5c78000 b5c90000 r-xp /usr/lib/liblua-5.1.so
b5ca1000 b5cf8000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d0c000 b5d34000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d45000 b5d58000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d69000 b5da0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db1000 b5dbf000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dcf000 b5dd7000 r-xp /usr/lib/libtbm.so.1.0.0
b5de7000 b5df4000 r-xp /usr/lib/libeio.so.1.13.0
b5e04000 b5e06000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e16000 b5e1b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e2b000 b5e42000 r-xp /usr/lib/libefreet.so.1.13.0
b5e54000 b5e74000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e84000 b5ea4000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea6000 b5eac000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ebc000 b5ecd000 r-xp /usr/lib/libemotion.so.1.13.0
b5ede000 b5ee5000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef5000 b5f04000 r-xp /usr/lib/libeo.so.1.13.0
b5f15000 b5f27000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f38000 b5f3d000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f4d000 b5f66000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f76000 b5f93000 r-xp /usr/lib/libeet.so.1.13.0
b5fac000 b5ff4000 r-xp /usr/lib/libeina.so.1.13.0
b6005000 b6015000 r-xp /usr/lib/libefl.so.1.13.0
b6026000 b610b000 r-xp /usr/lib/libicuuc.so.51.1
b6128000 b6268000 r-xp /usr/lib/libicui18n.so.51.1
b627f000 b62b7000 r-xp /usr/lib/libecore_x.so.1.13.0
b62c9000 b62cc000 r-xp /lib/libcap.so.2.21
b62dc000 b6305000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6316000 b631d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b632f000 b6366000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6377000 b6462000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6475000 b64ee000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6500000 b6505000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6515000 b651f000 r-xp /usr/lib/libvconf.so.0.2.45
b652f000 b6531000 r-xp /usr/lib/libvasum.so.0.3.1
b6541000 b6543000 r-xp /usr/lib/libttrace.so.1.1
b6553000 b6556000 r-xp /usr/lib/libiniparser.so.0
b6566000 b658c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b659c000 b65a1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b2000 b65c9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65da000 b6645000 r-xp /lib/libm-2.20-2014.11.so
b6656000 b665c000 r-xp /lib/librt-2.20-2014.11.so
b666d000 b667a000 r-xp /usr/lib/libunwind.so.8.0.1
b66b0000 b67d4000 r-xp /lib/libc-2.20-2014.11.so
b67e9000 b6802000 r-xp /lib/libgcc_s-4.9.so.1
b6812000 b68f4000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6905000 b692f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6940000 b697c000 r-xp /usr/lib/libsystemd.so.0.4.0
b697e000 b6a00000 r-xp /usr/lib/libedje.so.1.13.0
b6a13000 b6a31000 r-xp /usr/lib/libecore.so.1.13.0
b6a51000 b6bd8000 r-xp /usr/lib/libevas.so.1.13.0
b6c0d000 b6c21000 r-xp /lib/libpthread-2.20-2014.11.so
b6c35000 b6e6a000 r-xp /usr/lib/libelementary.so.1.13.0
b6e98000 b6e9c000 r-xp /usr/lib/libsmack.so.1.0.0
b6eac000 b6eb3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec3000 b6ec5000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed5000 b6ed8000 r-xp /usr/lib/libbundle.so.0.1.22
b6ee8000 b6eea000 r-xp /lib/libdl-2.20-2014.11.so
b6efb000 b6f13000 r-xp /usr/lib/libaul.so.0.1.0
b6f27000 b6f2c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3d000 b6f4a000 r-xp /usr/lib/liblptcp.so
b6f5c000 b6f60000 r-xp /usr/lib/libsys-assert.so
b6f71000 b6f91000 r-xp /lib/ld-2.20-2014.11.so
b6fa2000 b6fa7000 r-xp /usr/bin/launchpad-loader
b7a23000 b7dd1000 rw-p [heap]
be89e000 be8bf000 rw-p [stack]
b7a23000 b7dd1000 rw-p [heap]
be89e000 be8bf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8242)
Call Stack Count: 1
 0: (0xb67256f0) [/lib/libc.so.6] + 0x756f0
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
 _start_app(2531) > no appinfo
09-10 16:03:30.689+0600 E/AUL_AMD (  648): amd_launch.c: __real_send(1012) > send fail to client: -122
09-10 16:03:30.689+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __WifiConnectionChangedCb(246) > [Sage][SageBizLogicInit] __WifiConnectionChangedCb()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __WifiConnectionChangedCb(248) > [Sage][SageBizLogic] InitState : -1
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __WifiConnectionChangedCb(266) > [Sage][SageBizLogicInit] type == CONNECTION_TYPE_WIFI
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 4
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __CheckSelfUpdate(522) > [Sage][SageBizLogicInit] __CheckSelfUpdate()
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(145) > [Sage][MintEventHandler] Sending event from:__CheckSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvt:1800
09-10 16:03:30.699+0600 E/CAPI_NETWORK_CONNECTION( 1572): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintNetTransactionHandler.c: __httpProxyChangedCb(290) > [Sage][MintNetTransaction] Proxy setting changed
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintNetTransactionHandler.c: __httpProxyChangedCb(293) > [Sage][MintNetTransaction] Proxy setting changed proxy(ipv4) Addr = 
09-10 16:03:30.699+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(452) > Connection opened IND[NONE]
09-10 16:03:30.699+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(460) > Successfully open connection
09-10 16:03:30.699+0600 I/CAPI_NETWORK_WIFI( 1572): libnetwork.c: __libnet_evt_cb(670) > Connection open error NONE
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(232) > [Sage][MintEventHandler] Event received, from:__CheckSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1800
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicMain.c: SageBizLogicMain_HandleEventL(38) > [Sage][SageBizLogicMain] Sub event arrived type = 0x708
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: SageBizLogicSelfUpdate_CheckUpdate(99) > [Sage][SageBizlogicSelfUpdate] SageBizLogicSelfUpdate_CheckUpdate()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __ResetSelfUpdateData(116) > [Sage][SageBizlogicSelfUpdate] __ResetSelfUpdateData()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __DoNext(73) > [Sage][SageBizlogicSelfUpdate] __DoNext()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __DoNext(76) > [Sage][SageBizlogicSelfUpdate] Current status = 0
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(274) > [Sage][SageBizlogicSelfUpdate] __SendCheckAppUp() [type = 0]
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __CheckPeriod(160) > [Sage][SageBizLogicSelfUpdateBg] __CheckPeriod()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __CheckPeriod(172) > [Sage][SageBizLogicSelfUpdateBg] periodeVal = 48
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __CheckPeriod(176) > [Sage][SageBizLogicSelfUpdateBg] periodeVal != -1
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __CheckPeriod(182) > [Sage][SageBizLogicSelfUpdateBg] ret == PREFERENCE_ERROR_NONE || latestTime > 0
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __CheckPeriod(196) > [Sage][SageBizLogicSelfUpdateBg] appUpdatePeriod: latestTime = 1473494331 / curTime = 1473501810 / term = 7479 / periodeVal = 172800
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __CheckPeriod(200) > [Sage][SageBizLogicSelfUpdateBg] term < periodeVal
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __SendCheckAppUp(283) > [Sage][SageBizlogicSelfUpdate] !__CheckPeriod()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicSelfUpdateBg.c: __EndStateSelfUpdate(147) > [Sage][SageBizlogicSelfUpdate] UpdateDate = 0 / 0 / 0 / 0 / -1 / -1 / -1 / -1 / -1 /  / 
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(145) > [Sage][MintEventHandler] Sending event from:__EndStateSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvt:1801
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event finished, from:__CheckSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1800
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(232) > [Sage][MintEventHandler] Event received, from:__EndStateSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1801
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicMain.c: SageBizLogicMain_HandleEventL(38) > [Sage][SageBizLogicMain] Sub event arrived type = 0x709
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: SageBizlogicInit_SelfUpdateComplete(533) > [Sage][SageBizLogicInit] SageBizlogicInit_SelfUpComplete()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 5
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 6
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 7
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __SendRequestUpdate(893) > [Sage][SageBizLogicInit] __SendRequestUpdate()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __SendRequestUpdate(896) > [Sage][SageBizLogicInit] MintConfig_GetUserId() [(null)]
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(145) > [Sage][MintEventHandler] Sending event from:__SendRequestUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvt:1796
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 8
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicReservedDL.c: SageBizLogicReservedDL_WifiOn(53) > [Sage][SageBizLogicReservedDL] SageBizLogicReservedDL_WifiOn()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicReservedDL.c: SageBizLogicReservedDL_WifiOn(63) > [Sage][SageBizLogicReservedDL] CONNECTION_TYPE_WIFI!
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicReservedDL.c: __CheckReservedDownloadList(107) > [Sage][SageBizLogicReservedDL] __CheckReservedDownloadList()
09-10 16:03:30.699+0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1572): preference.c: _preference_check_retry_err(474) > key(RESERVED_DOWNLOAD_LIST), check retry err: -21/(2/No such file or directory).
09-10 16:03:30.699+0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1572): preference.c: _preference_get_key(1050) > _preference_get_key(RESERVED_DOWNLOAD_LIST) step(-17825744) failed(2 / No such file or directory)
09-10 16:03:30.699+0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1572): preference.c: preference_get_string(1224) > preference_get_string(1572) : RESERVED_DOWNLOAD_LIST error
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicReservedDL.c: __CheckReservedDownloadList(113) > [Sage][SageBizLogicReservedDL] preference_get_string() fail
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicReservedDL.c: SageBizLogicReservedDL_WifiOn(74) > [Sage][SageBizLogicReservedDL] __CheckReservedDownloadList() success
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 9
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(145) > [Sage][MintEventHandler] Sending event from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION, subEvt:1030
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: MintEventHandler_SendEventWithFreeCb(145) > [Sage][MintEventHandler] Sending event from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION_THYME, subEvt:1106
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(145) > [Sage][SageBizLogicInit] __DecideInitState()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __DecideInitState(150) > [Sage][SageBizLogicInit] __initState = 10
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicInit.c: __ResetInitData(135) > [Sage][SageBizLogicInit] __ResetInitData()
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event finished, from:__EndStateSelfUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1801
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(232) > [Sage][MintEventHandler] Event received, from:__SendRequestUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1796
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicMain.c: SageBizLogicMain_HandleEventL(38) > [Sage][SageBizLogicMain] Sub event arrived type = 0x704
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: SageBizLogicUpdate_SetAction(133) > [Sage][SageBizLogicUpdate] SageBizLogicUpdate_SetAction()[1796]
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __Initialize(148) > [Sage][SageBizLogicUpdate] __Initialize()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ResetUpdateData(1637) > [Sage][SageBizLogicUpdate] __ResetUpdateData()
09-10 16:03:30.699+0600 E/CAPI_NETWORK_WIFI( 1572): net_wifi.c: wifi_initialize(59) > Already initialized
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __Initialize(188) > [Sage][SageBizLogicUpdate] wifi_initialize() fail[-38]
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __DecideState(201) > [Sage][SageBizLogicUpdate] Current State is 0
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __UpdateKillApp(232) > [Sage][SageBizLogicUpdate] __UpdateKillApp
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __UpdateKillApp(233) > [Sage][SageBizLogicUpdate] hasKillApp : 1
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ChackUpdatePeriod(1672) > [Sage][SageBizLogicUpdate] __ChackUpdatePeriod()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ChackUpdatePeriod(1712) > [Sage][SageBizLogicUpdate] type = 1 / periodeVal = 24
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ChackUpdatePeriod(1716) > [Sage][SageBizLogicUpdate] (periodeVal != -1) && (preferenceID != ESAGE_PREFERENCEID_NONE)
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ChackUpdatePeriod(1721) > [Sage][SageBizLogicUpdate] ret == PREFERENCE_ERROR_NONE || latestTime > 0
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ChackUpdatePeriod(1726) > [Sage][SageBizLogicUpdate] appUpdatePeriod: latestTime = 1473486108 / curTime = 1473501810 / term = 15702 / periodeVal = 86400
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ChackUpdatePeriod(1730) > [Sage][SageBizLogicUpdate] term < periodeVal
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __DecideState(201) > [Sage][SageBizLogicUpdate] Current State is 1
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __UpdateAppUpdateCount(339) > [Sage][SageBizLogicUpdate] __UpdateAppUpdateCount()
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __UpdateAppUpdateCount(340) > [Sage][SageBizLogicUpdate] UserID : (null)
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __DecideState(201) > [Sage][SageBizLogicUpdate] Current State is 2
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __UpdateEmergencyUpdate(1370) > [Sage][SageBizLogicUpdate] __UpdateEmergencyUpdate
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __UpdateEmergencyUpdate(1371) > [Sage][SageBizLogicUpdate] hasEmergencyUpdate : 0
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __UpdateEmergencyUpdate(1377) > [Sage][SageBizLogicUpdate] !__updateData.hasEmergencyUpdate || !__ChackUpdatePeriod(ESAGE_BIZLOGIC_UPDATE_LEATESTUPDATECHECKTIME_EMERGENCYAPP)
09-10 16:03:30.699+0600 I/Sage    ( 1572): SageBizLogicUpdate.c: __ResetUpdateData(1637) > [Sage][SageBizLogicUpdate] __ResetUpdateData()
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event finished, from:__SendRequestUpdate, mainEvent:ESAGE_EVENT_BIZLOGIC, subEvent:1796
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(232) > [Sage][MintEventHandler] Event received, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION, subEvent:1030
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event finished, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION, subEvent:1030
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(232) > [Sage][MintEventHandler] Event received, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION_THYME, subEvent:1106
09-10 16:03:30.699+0600 I/Sage    ( 1572): MintEventHandler.c: __eventHandler_Main_Callback(245) > [Sage][MintEventHandler] Event finished, from:__PushConnection, mainEvent:ESAGE_EVENT_NOTIFICATION_THYME, subEvent:1106
09-10 16:03:30.699+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/net-config, ret : 0
09-10 16:03:30.709+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/net-config, ret : 0
09-10 16:03:30.709+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:03:30.709+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 622
09-10 16:03:30.709+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:03:30.719+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:03:30.719+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:03:30.719+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:03:30.719+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for net.netpopup has already loaded
09-10 16:03:30.719+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:03:30.719+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:03:30.719+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:03:30.719+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:03:30.739+0600 I/CAPI_APPFW_APPLICATION( 9090): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:03:30.739+0600 I/CAPI_APPFW_APPLICATION( 9090): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:03:30.749+0600 I/APP_CORE( 9090): appcore-efl.c: __do_app(520) > [APP 9090] Event: RESET State: CREATED
09-10 16:03:30.749+0600 I/CAPI_APPFW_APPLICATION( 9090): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:03:30.769+0600 I/CAPI_APPFW_APPLICATION( 9090): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:03:30.819+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 9090, appid: net.netpopup
09-10 16:03:30.819+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:03:30.829+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:03:30.829+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:03:30.829+0600 W/AUL     (  622): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9090)
09-10 16:03:30.839+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 16:03:30.839+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:30.839+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:30.839+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:30.839+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:03:30.839+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:03:30.839+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:03:30.889+0600 W/INDICATOR(  685): toast_popup.c: _post_toast_message_callback(217) > [Connected to Wi-Fi network BaBu.][0]
09-10 16:03:30.889+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : net.netpopup
09-10 16:03:31.059+0600 I/MALI    (  685): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb81e26e0)
09-10 16:03:31.099+0600 I/MALI    (  685): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:03:31.099+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7794208), gem(21), surface(0xb78ae1a0)
09-10 16:03:31.099+0600 W/APP_CORE(  685): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00284
09-10 16:03:31.109+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(742) > state: CONFIGURATION
09-10 16:03:31.109+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78b96c0), gem(18), surface(0xb787e520)
09-10 16:03:31.129+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(670) > Connection open error NONE
09-10 16:03:31.139+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7877170), gem(10), surface(0xb78ae800)
09-10 16:03:31.219+0600 I/Tizen::Net::Wifi( 1366): (941) > The background scan result updated.
09-10 16:03:31.440+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb768eb50), gem(22), surface(0xb78bdd78)
09-10 16:03:31.820+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:03:31.820+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 16:03:31.850+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9090 pgid = 9090
09-10 16:03:31.850+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(9090)
09-10 16:03:31.860+0600 E/Tizen::App( 1366): (703) > Cannot acquire app for 9090.
09-10 16:03:31.860+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1970
09-10 16:03:31.900+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:03:31.900+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:03:31.900+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:03:31.900+0600 I/Tizen::App( 1366): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 9090.
09-10 16:03:31.900+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 9090
09-10 16:03:31.900+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9090
09-10 16:03:31.900+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9090
09-10 16:03:31.910+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1971
09-10 16:03:31.920+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 16:03:32.371+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [INIT] : waiting...
09-10 16:03:32.531+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 16:03:32.531+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 16:03:32.531+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 16:03:32.531+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(288616189) zone(/)
09-10 16:03:32.531+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 16:03:32.531+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 11:03:30 (UTC).
09-10 16:03:32.541+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 16:03:32.541+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[288616189] is removed.
09-10 16:03:32.541+0600 E/PUSHD   ( 1116): io.c: server_recv(270) > Fail to recv using curl
09-10 16:03:32.541+0600 E/PUSHD   ( 1116): proc.c: _receive_packet(2325) > ERROR : invalid return when receiving header [-1]
09-10 16:03:32.541+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 16:03:32.541+0600 W/PUSHD   ( 1116): State transition: [INIT]-> [PING]
09-10 16:03:32.541+0600 W/PUSHD   ( 1116): spp.c: _uds_list_changed_cb(2296) > UDS mode is off
09-10 16:03:32.551+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:03:32.551+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:03:32.551+0600 E/ALARM_MANAGER( 1116): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(1500), start(10-9-2016, 16:28:33), repeat(0), interval(0), type(-1073741822)
09-10 16:03:32.571+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 16:03:32.571+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 16:03:32.571+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 16:03:32.571+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:03:32.581+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:03:32.591+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:03:32.591+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:03:32.601+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:03:32.611+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:03:32.611+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 38
09-10 16:03:32.611+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
09-10 16:03:32.611+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
09-10 16:03:32.611+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1473503313, Sat Sep 10 16:28:33 2016
09-10 16:03:32.611+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1830799305, next duetime: 1473503313
09-10 16:03:32.611+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1830799305)
09-10 16:03:32.611+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1473505410), due_time(1473503313)
09-10 16:03:32.611+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 16:03:32.611+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 10:28:33 (UTC).
09-10 16:03:32.681+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 16:03:32.681+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 16:03:32.681+0600 W/PUSHD   ( 1116): State transition: [PING]-> [RUN]
09-10 16:03:32.681+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [RUN] : waiting...
09-10 16:03:32.841+0600 I/UXT     ( 9279): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 16:03:33.982+0600 W/INDICATOR(  685): toast_popup.c: _popup_timeout_cb(90) > 
09-10 16:03:34.102+0600 W/INDICATOR(  685): toast_popup.c: _popup_dismissed_cb(66) > 
09-10 16:03:35.594+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_wifi_state(739) > Wi-Fi state: 2
09-10 16:03:35.594+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:03:35.594+0600 E/CAPI_NETWORK_CONNECTION( 1359): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 16:03:35.594+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:03:35.834+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:03:37.906+0600 E/EFL     ( 8242): ecore_x<8242> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=12668756
09-10 16:03:37.996+0600 E/EFL     ( 8242): ecore_x<8242> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=12668840
09-10 16:03:39.237+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:03:44.042+0600 E/VCONF   (  609): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/usb_connection_mode
09-10 16:03:44.042+0600 E/VCONF   (  609): vconf.c: _vconf_check_retry_err(1368) > db/setting/usb_connection_mode : check retry err (-21/2).
09-10 16:03:44.042+0600 E/VCONF   (  609): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/usb_connection_mode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 16:03:44.042+0600 E/VCONF   (  609): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/usb_connection_mode) step(-21) failed(2 / No such file or directory)
09-10 16:03:44.042+0600 E/VCONF   (  609): vconf.c: vconf_get_int(2650) > vconf_get_int(609) : db/setting/usb_connection_mode error
09-10 16:03:44.042+0600 E/VCONF   (  609): vconf-kdb.c: _vconf_kdb_add_notify(329) > _vconf_kdb_add_notify : key(db/usb/sel_mode) has same callback(0xb6f34d78)
09-10 16:03:44.102+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:44.102+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:44.102+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:44.102+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:03:44.372+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:03:44.412+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 9345): media_content.c: media_content_connect(856) > [32m[9345]ref count : 0
09-10 16:03:44.432+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 9345): media_content.c: media_content_connect(888) > [32m[9345]ref count changed to: 1
09-10 16:03:44.592+0600 I/AUL     ( 9340): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 400 is changed to 1
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:400
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:400
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 100 is changed to 1
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:100
09-10 16:03:44.632+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:100
09-10 16:03:44.642+0600 E/RESOURCED(15587): heart-battery.c: heart_battery_calculate_prediction(1055) > No battery capacity history data
09-10 16:03:44.652+0600 I/AUL     ( 9340): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 16:03:44.673+0600 I/AUL     ( 9340): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 16:03:44.693+0600 I/AUL     ( 9340): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 16:03:44.693+0600 E/CAPI_APPFW_APP_MANAGER( 9340): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 16:03:44.703+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:03:44.723+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:03:44.743+0600 E/INDICATOR(  685): battery.c: show_digits(405) > show_digits[405]	 "Show digits: 100"
09-10 16:03:44.743+0600 I/INDICATOR(  685): battery.c: show_battery_icon(376) > "Percentage:(1) / Level:(10) / batt_Full:(0) / battery_charging(1)"
09-10 16:03:44.743+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 16:03:44.743+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:44.743+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:44.743+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:03:44.743+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:03:44.743+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:03:44.753+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:03:44.753+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 16:03:44.753+0600 E/CAPI_APPFW_APP_MANAGER(  769): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 16:03:44.833+0600 I/AUL     ( 9150): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:03:44.883+0600 I/AUL     ( 9150): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:03:44.883+0600 I/AUL     ( 9150): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:03:44.893+0600 E/QUICKPANEL(  991): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
09-10 16:03:44.893+0600 I/QUICKPANEL(  991): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 1[0;m
09-10 16:03:44.943+0600 I/AUL     ( 9150): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 16:03:44.943+0600 E/CAPI_APPFW_APP_MANAGER( 9150): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 16:03:44.943+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:03:44.943+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:03:44.963+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:03:44.963+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 16:03:44.963+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
09-10 16:03:44.963+0600 W/QUICKPANEL(  991): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
09-10 16:03:44.963+0600 E/EFL     (  991): eo<991> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
09-10 16:03:44.963+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
09-10 16:03:45.063+0600 E/INDICATOR(  685): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
09-10 16:03:47.746+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:04:00.798+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 16:04:00.798+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 4:04 p.m.
09-10 16:04:00.798+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 4:04 p.m."
09-10 16:04:00.798+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 4:04 p.m."
09-10 16:04:00.798+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 16:04:00.798+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146040187 Time: <font_size=31> </font_size> <font_size=31> 4:04 p.m.</font_size></font>"
09-10 16:04:07.655+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 16:04:14.161+0600 E/PKGMGR_SERVER( 9537): pkgmgr-server.c: main(2414) > package manager server start
09-10 16:04:14.231+0600 E/PKGMGR  ( 9535): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 16:04:14.271+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:04:14.271+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 8242
09-10 16:04:14.271+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:04:14.281+0600 W/AUL     ( 9541): launch.c: app_request_to_launchpad(396) > request cmd(5) to(8242)
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 16:04:14.281+0600 I/APP_CORE( 8242): appcore-efl.c: __do_app(520) > [APP 8242] Event: TERMINATE State: RUNNING
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(8242), cmd(4)
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:04:14.281+0600 W/AUL     ( 9541): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 16:04:14.281+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 8242): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 16:04:14.281+0600 E/APP_CORE( 8242): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 16:04:14.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:04:14.281+0600 E/APP_CORE( 8242): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 16:04:14.281+0600 I/CAPI_APPFW_APPLICATION( 8242): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:04:14.281+0600 I/CAPI_APPFW_APPLICATION( 8242): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:04:14.291+0600 E/CAPI_NETWORK_BLUETOOTH( 8242): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 16:04:14.291+0600 E/PKGMGR_SERVER( 9537): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9541]
09-10 16:04:14.351+0600 E/CAPI_NETWORK_BLUETOOTH( 8242): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 16:04:14.351+0600 E/CAPI_NETWORK_BLUETOOTH( 8242): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 16:04:14.351+0600 E/bluetooth( 8242): [bt_adapter_le_destroy_advertiser] Failed.
09-10 16:04:14.361+0600 I/CAPI_NETWORK_WIFI( 8242): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:04:14.361+0600 E/bluetooth( 8242): [wifi_deinitialize] Success.
09-10 16:04:14.361+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:04:14.391+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 16:04:14.391+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:04:14.391+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:04:14.391+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 16:04:14.391+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 16:04:14.402+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76ffd58), gem(10), surface(0xb787e520)
09-10 16:04:14.412+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:04:14.422+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768eb50), gem(13), surface(0xb78ae1a0)
09-10 16:04:14.452+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7794208), gem(18), surface(0xb78ae800)
09-10 16:04:14.452+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7794208), gem(18), surface(0xb7884608)
09-10 16:04:14.462+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:04:14.462+0600 E/EFL     ( 8242): elementary<8242> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 16:04:14.482+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 16:04:14.482+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:04:14.482+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 16:04:14.492+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:04:14.512+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 16:04:14.522+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76ffd58), gem(10), surface(0xb78ba300)
09-10 16:04:14.532+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 16:04:14.572+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 16:04:14.582+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 16:04:14.582+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:04:14.612+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:04:14.612+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 16:04:14.622+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83f4a70]
09-10 16:04:14.622+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:04:14.622+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83f4a70
09-10 16:04:14.632+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 16:04:14.642+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:04:14.642+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:04:14.662+0600 I/TIZEN_N_SOUND_MANAGER( 4903): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 16:04:14.662+0600 E/TIZEN_N_SOUND_MANAGER( 4903): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:04:14.662+0600 I/TIZEN_N_SOUND_MANAGER( 4903): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 16:04:14.662+0600 E/TIZEN_N_SOUND_MANAGER( 4903): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:04:14.662+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:04:14.672+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
09-10 16:04:14.672+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 16:04:14.672+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 16:04:14.672+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 16:04:14.692+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 16:04:14.692+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 16:04:14.692+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 16:04:14.692+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:13fcab0
09-10 16:04:14.692+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 16:04:14.692+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 16:04:14.692+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:04:14.692+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 16:04:14.712+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:04:14.712+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:04:14.712+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 16:04:14.712+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 16:04:14.712+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 16:04:14.712+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 16:04:14.722+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 16:04:14.802+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8242 pgid = 8242
09-10 16:04:14.802+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(8242)
09-10 16:04:14.872+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:04:14.872+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:04:14.872+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:04:14.872+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[8242] terminate event is forwarded
09-10 16:04:14.872+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:04:14.872+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 8242, ]
09-10 16:04:14.872+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:04:14.872+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 16:04:14.872+0600 I/Tizen::App( 1366): (512) > Not registered pid(8242)
09-10 16:04:14.872+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 16:04:14.872+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:04:14.872+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 8242
09-10 16:04:14.872+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8242
09-10 16:04:14.952+0600 W/CRASH_MANAGER( 9548): worker.c: worker_job(1199) > 1108242626162147350185
