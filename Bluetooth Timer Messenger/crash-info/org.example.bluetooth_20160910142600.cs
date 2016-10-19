S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 7025
Date: 2016-09-10 14:26:00+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7025, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb86a9908
r2   = 0xb4331000, r3   = 0xb4331000
r4   = 0xb8680c38, r5   = 0xbee565bc
r6   = 0xb6a2f310, r7   = 0xbee5641c
r8   = 0xb6a300f4, r9   = 0xb6a300f4
r10  = 0xb6a3e20c, fp   = 0x00000000
ip   = 0xb2a243e8, sp   = 0xbee54770
lr   = 0xb2a167d3, pc   = 0xb67136f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     91672 KB
Buffers:     38188 KB
Cached:     267548 KB
VmPeak:     111012 KB
VmSize:     107960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25396 KB
VmRSS:       25396 KB
VmData:      34888 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36240 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7025 TID = 7025
7025 7027 7863 

Maps Information
b1d6a000 b2569000 rw-p [stack:7863]
b2569000 b257a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b258a000 b258f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b261b000 b2623000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2634000 b2635000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2645000 b2659000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b266d000 b266e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b267e000 b2681000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2692000 b2693000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26a3000 b26a5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b26b5000 b26b7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26c7000 b26d7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26e7000 b26f3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2904000 b291b000 r-xp /usr/lib/libnetwork.so.0.0.0
b292c000 b296a000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b297b000 b2982000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2993000 b29a2000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b29b2000 b29e7000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29fa000 b2a00000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a10000 b2a1c000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b3e000 b2c21000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c58000 b2c80000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c92000 b3491000 rw-p [stack:7027]
b3491000 b3493000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34a3000 b34ad000 r-xp /lib/libnss_files-2.20-2014.11.so
b34be000 b34c7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34d8000 b34e9000 r-xp /lib/libnsl-2.20-2014.11.so
b34fc000 b3502000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3513000 b3514000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b353c000 b3543000 r-xp /usr/lib/libminizip.so.1.0.0
b3553000 b3558000 r-xp /usr/lib/libstorage.so.0.1
b3568000 b35bd000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35d3000 b35e7000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35f7000 b363b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b364b000 b3653000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3663000 b3693000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36a6000 b375f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3773000 b37c7000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37d8000 b37f3000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3803000 b38c4000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38d7000 b38e9000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38f9000 b38fd000 r-xp /usr/lib/libogg.so.0.7.1
b390d000 b392f000 r-xp /usr/lib/libvorbis.so.0.4.3
b393f000 b3a23000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a3f000 b3a4c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a5d000 b3aa0000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ab5000 b3afc000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b0d000 b3b13000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b24000 b3b2b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b3b000 b3b7b000 r-xp /usr/lib/libmdm.so.1.2.10
b3b8b000 b3b93000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3ba2000 b3bb2000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bd3000 b3c33000 r-xp /usr/lib/libasound.so.2.0.0
b3c45000 b3c7b000 r-xp /usr/lib/libpulse.so.0.16.2
b3c8c000 b3c8f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c9f000 b3ca2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cb2000 b3cb7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cc7000 b3cc8000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cd8000 b3ce3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cf7000 b3cfe000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d0e000 b3d14000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d24000 b3d29000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d39000 b3d54000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d64000 b3d6b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d7b000 b3d7e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d8f000 b3dbd000 r-xp /usr/lib/libidn.so.11.5.44
b3dcd000 b3de3000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3df4000 b3dfe000 r-xp /usr/lib/libcares.so.2.1.0
b3e0e000 b3e18000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e28000 b3e2a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e3a000 b3e3b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e4b000 b3e4f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e60000 b3e88000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e99000 b3ec2000 r-xp /usr/lib/libturbojpeg.so
b3ee2000 b3ee8000 r-xp /usr/lib/libgif.so.4.1.6
b3ef8000 b3f3e000 r-xp /usr/lib/libcurl.so.4.3.0
b3f4f000 b3f70000 r-xp /usr/lib/libexif.so.12.3.3
b3f8b000 b3fa0000 r-xp /usr/lib/libtts.so
b3fb1000 b3fb9000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fc9000 b4089000 r-xp /usr/lib/libdali-core.so.0.0.0
b4094000 b4187000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41a7000 b4281000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4298000 b429a000 r-xp /usr/lib/libboost_system.so.1.51.0
b42aa000 b42b0000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42c0000 b42e3000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42f4000 b42f6000 r-xp /usr/lib/libappsvc.so.0.1.0
b4306000 b4308000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4319000 b431e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4335000 b4337000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4347000 b434e000 r-xp /usr/lib/libsensord-share.so
b435e000 b4376000 r-xp /usr/lib/libsensor.so.1.1.0
b4387000 b438a000 r-xp /usr/lib/libXv.so.1.0.0
b439a000 b439f000 r-xp /usr/lib/libutilX.so.1.1.0
b43af000 b43b4000 r-xp /usr/lib/libappcore-common.so.1.1
b43c4000 b43cb000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43de000 b43e2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43f3000 b44bd000 r-xp /usr/lib/libCOREGL.so.4.0
b44d4000 b44d7000 r-xp /usr/lib/libuuid.so.1.3.0
b44e8000 b44ff000 r-xp /usr/lib/libblkid.so.1.1.0
b4510000 b4512000 r-xp /usr/lib/libXau.so.6.0.0
b4522000 b4525000 r-xp /usr/lib/libEGL.so.1.4
b452d000 b4533000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4543000 b4545000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4556000 b4564000 r-xp /usr/lib/libGLESv2.so.2.0
b456d000 b45cf000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45e4000 b45fc000 r-xp /usr/lib/libmount.so.1.1.0
b460d000 b4621000 r-xp /usr/lib/libxcb.so.1.1.0
b4632000 b4639000 r-xp /lib/libcrypt-2.20-2014.11.so
b4671000 b4682000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4693000 b4695000 r-xp /usr/lib/libiri.so
b46a5000 b46b0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46c1000 b46d6000 r-xp /lib/libexpat.so.1.5.2
b46e8000 b47a6000 r-xp /usr/lib/libcairo.so.2.11200.14
b47b9000 b47c1000 r-xp /usr/lib/libdrm.so.2.4.0
b47d1000 b47d4000 r-xp /usr/lib/libdri2.so.0.0.0
b47e5000 b4833000 r-xp /usr/lib/libssl.so.1.0.0
b4848000 b4854000 r-xp /usr/lib/libeeze.so.1.13.0
b4864000 b486d000 r-xp /usr/lib/libethumb.so.1.13.0
b487d000 b4880000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4890000 b4a47000 r-xp /usr/lib/libcrypto.so.1.0.0
b569e000 b56a7000 r-xp /usr/lib/libXi.so.6.1.0
b56b7000 b56b9000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c9000 b56cd000 r-xp /usr/lib/libXtst.so.6.1.0
b56dd000 b56e3000 r-xp /usr/lib/libXrender.so.1.3.0
b56f3000 b56f9000 r-xp /usr/lib/libXrandr.so.2.2.0
b570a000 b570c000 r-xp /usr/lib/libXinerama.so.1.0.0
b571c000 b571f000 r-xp /usr/lib/libXfixes.so.3.1.0
b572f000 b573a000 r-xp /usr/lib/libXext.so.6.4.0
b574a000 b574c000 r-xp /usr/lib/libXdamage.so.1.1.0
b575c000 b575e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b576f000 b5851000 r-xp /usr/lib/libX11.so.6.3.0
b5864000 b586b000 r-xp /usr/lib/libXcursor.so.1.0.2
b587b000 b5893000 r-xp /usr/lib/libudev.so.1.6.0
b5895000 b5898000 r-xp /lib/libattr.so.1.1.0
b58a8000 b58c8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ca000 b58cf000 r-xp /usr/lib/libffi.so.6.0.2
b58df000 b58f7000 r-xp /lib/libz.so.1.2.8
b5907000 b5909000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5919000 b59ee000 r-xp /usr/lib/libxml2.so.2.9.2
b5a03000 b5a9e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aba000 b5abd000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5acd000 b5ae6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af7000 b5b08000 r-xp /lib/libresolv-2.20-2014.11.so
b5b1c000 b5b96000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bab000 b5bad000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bbd000 b5bc4000 r-xp /usr/lib/libembryo.so.1.13.0
b5bd4000 b5bec000 r-xp /usr/lib/libpng12.so.0.50.0
b5bfd000 b5c20000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c41000 b5c55000 r-xp /usr/lib/libector.so.1.13.0
b5c66000 b5c7e000 r-xp /usr/lib/liblua-5.1.so
b5c8f000 b5ce6000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cfa000 b5d22000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d33000 b5d46000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d57000 b5d8e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9f000 b5dad000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dbd000 b5dc5000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd5000 b5de2000 r-xp /usr/lib/libeio.so.1.13.0
b5df2000 b5df4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e04000 b5e09000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e19000 b5e30000 r-xp /usr/lib/libefreet.so.1.13.0
b5e42000 b5e62000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e72000 b5e92000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e94000 b5e9a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eaa000 b5ebb000 r-xp /usr/lib/libemotion.so.1.13.0
b5ecc000 b5ed3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee3000 b5ef2000 r-xp /usr/lib/libeo.so.1.13.0
b5f03000 b5f15000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f26000 b5f2b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f3b000 b5f54000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f64000 b5f81000 r-xp /usr/lib/libeet.so.1.13.0
b5f9a000 b5fe2000 r-xp /usr/lib/libeina.so.1.13.0
b5ff3000 b6003000 r-xp /usr/lib/libefl.so.1.13.0
b6014000 b60f9000 r-xp /usr/lib/libicuuc.so.51.1
b6116000 b6256000 r-xp /usr/lib/libicui18n.so.51.1
b626d000 b62a5000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b7000 b62ba000 r-xp /lib/libcap.so.2.21
b62ca000 b62f3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6304000 b630b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631d000 b6354000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6365000 b6450000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6463000 b64dc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ee000 b64f3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6503000 b650d000 r-xp /usr/lib/libvconf.so.0.2.45
b651d000 b651f000 r-xp /usr/lib/libvasum.so.0.3.1
b652f000 b6531000 r-xp /usr/lib/libttrace.so.1.1
b6541000 b6544000 r-xp /usr/lib/libiniparser.so.0
b6554000 b657a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b658a000 b658f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a0000 b65b7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c8000 b6633000 r-xp /lib/libm-2.20-2014.11.so
b6644000 b664a000 r-xp /lib/librt-2.20-2014.11.so
b665b000 b6668000 r-xp /usr/lib/libunwind.so.8.0.1
b669e000 b67c2000 r-xp /lib/libc-2.20-2014.11.so
b67d7000 b67f0000 r-xp /lib/libgcc_s-4.9.so.1
b6800000 b68e2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f3000 b691d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692e000 b696a000 r-xp /usr/lib/libsystemd.so.0.4.0
b696c000 b69ee000 r-xp /usr/lib/libedje.so.1.13.0
b6a01000 b6a1f000 r-xp /usr/lib/libecore.so.1.13.0
b6a3f000 b6bc6000 r-xp /usr/lib/libevas.so.1.13.0
b6bfb000 b6c0f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c23000 b6e58000 r-xp /usr/lib/libelementary.so.1.13.0
b6e86000 b6e8a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e9a000 b6ea1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb1000 b6eb3000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec3000 b6ec6000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed6000 b6ed8000 r-xp /lib/libdl-2.20-2014.11.so
b6ee9000 b6f01000 r-xp /usr/lib/libaul.so.0.1.0
b6f15000 b6f1a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2b000 b6f38000 r-xp /usr/lib/liblptcp.so
b6f4a000 b6f4e000 r-xp /usr/lib/libsys-assert.so
b6f5f000 b6f7f000 r-xp /lib/ld-2.20-2014.11.so
b6f90000 b6f95000 r-xp /usr/bin/launchpad-loader
b863f000 b8994000 rw-p [heap]
bee36000 bee57000 rw-p [stack]
b863f000 b8994000 rw-p [heap]
bee36000 bee57000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7025)
Call Stack Count: 1
 0: (0xb67136f0) [/lib/libc.so.6] + 0x756f0
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
app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 14:25:28.394+0600 I/AUL     ( 8775): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 14:25:28.414+0600 I/AUL     ( 8775): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 14:25:28.424+0600 I/AUL     ( 8775): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 14:25:28.424+0600 E/CAPI_APPFW_APP_MANAGER( 8775): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 14:25:28.444+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 14:25:28.464+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 14:25:28.484+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 14:25:28.504+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 14:25:28.504+0600 E/CAPI_APPFW_APP_MANAGER(  769): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 14:25:28.564+0600 E/INDICATOR(  685): battery.c: show_digits(405) > show_digits[405]	 "Show digits: 79"
09-10 14:25:28.564+0600 I/INDICATOR(  685): battery.c: show_battery_icon(376) > "Percentage:(1) / Level:(7) / batt_Full:(0) / battery_charging(1)"
09-10 14:25:28.594+0600 I/AUL     (17245): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 14:25:28.624+0600 I/AUL     (17245): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 14:25:28.654+0600 I/AUL     (17245): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 14:25:28.664+0600 E/QUICKPANEL(  991): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
09-10 14:25:28.664+0600 I/QUICKPANEL(  991): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 1[0;m
09-10 14:25:28.684+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 14:25:28.684+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 14:25:28.684+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 14:25:28.684+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 14:25:28.684+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
09-10 14:25:28.684+0600 W/QUICKPANEL(  991): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
09-10 14:25:28.694+0600 I/AUL     (17245): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 14:25:28.694+0600 E/CAPI_APPFW_APP_MANAGER(17245): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 14:25:28.694+0600 E/EFL     (  991): eo<991> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
09-10 14:25:28.694+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
09-10 14:25:28.694+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 14:25:28.694+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:28.694+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:28.694+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:28.694+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:25:28.694+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:25:28.805+0600 E/INDICATOR(  685): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
09-10 14:25:28.995+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 14:25:29.005+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 14:25:29.005+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:29.005+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:29.005+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:29.005+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:25:29.005+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:25:29.996+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 14:25:30.006+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 14:25:30.006+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:30.006+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:30.006+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:25:30.006+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:25:30.006+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:25:30.937+0600 E/VCONF   ( 8780): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:25:51.327+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 14:25:57.302+0600 I/Tizen::System( 1366): (280) > The screen has been turned on.
09-10 14:25:57.302+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:25:57.312+0600 E/EFL     ( 7025): ecore_x<7025> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=7404320
09-10 14:25:57.312+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=7404320
09-10 14:25:57.312+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 14:25:57.312+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 14:25:57.332+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:25:57.332+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:25:57.332+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 14:25:57.402+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 14:25:57.402+0600 E/EFL     ( 7025): ecore_x<7025> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=7404423
09-10 14:25:57.402+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=7404423
09-10 14:25:57.402+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:25:57.402+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:25:57.402+0600 E/STARTER (  763): )
09-10 14:25:57.402+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 14:25:57.402+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 14:25:57.402+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:25:57.402+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:25:57.603+0600 W/STARTER (  763): hw_key.c: _homekey_timer_cb(487) > [_homekey_timer_cb:487] _homekey_timer_cb, homekey count[1], lock state[0]
09-10 14:25:57.603+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:25:57.603+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:25:57.603+0600 E/STARTER (  763): )
09-10 14:25:57.603+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:25:57.603+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 873
09-10 14:25:57.613+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
09-10 14:25:57.613+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 14:25:57.623+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 14:25:57.623+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 14:25:57.623+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 14:25:57.623+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 14:25:57.633+0600 W/AUL     (  648): app_signal.c: aul_send_app_resume_request_signal(470) > send_app_resume_signal, pid: 873, appid: com.samsung.homescreen
09-10 14:25:57.633+0600 W/AUL_AMD (  648): amd_launch.c: __nofork_processing(1431) > __nofork_processing, cmd: 0, pid: 873
09-10 14:25:57.633+0600 W/AUL_AMD (  648): amd_request.c: __send_home_launch_signal(579) > send a home launch signal
09-10 14:25:57.633+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESET State: PAUSED
09-10 14:25:57.633+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 14:25:57.633+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(873), cmd(0)
09-10 14:25:57.633+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(873)
09-10 14:25:57.633+0600 E/STARTER (  763): dbus-util.c: starter_dbus_home_raise_signal_send(227) > [starter_dbus_home_raise_signal_send:227] Sending HOME RAISE signal, result:0
09-10 14:25:57.633+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
09-10 14:25:57.633+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
09-10 14:25:57.633+0600 W/cluster-home(  873): cluster-data-provider.cpp: OnMainScrollStarted(4740) >  Main Scroll Started
09-10 14:25:57.643+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:25:57.643+0600 W/cluster-home(  873): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed
09-10 14:25:57.643+0600 W/cluster-home(  873): cluster-data-provider.cpp: OnMainScrollCompleted(4753) >  Main Scroll Completed Done
09-10 14:25:57.653+0600 W/CAPI_APPFW_APP_CONTROL(  873): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-10 14:25:57.663+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(572) > Legacy lifecycle: 0
09-10 14:25:57.663+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(574) > [APP 873] App already running, raise the window
09-10 14:25:57.673+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 14:25:57.673+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:25:57.673+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:25:57.673+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 14:25:57.673+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 14:25:57.673+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:25:57.683+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7737e90), gem(23), surface(0xb78bb9e0)
09-10 14:25:57.693+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7737e90), gem(23), surface(0xb78925e8)
09-10 14:25:57.723+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(10), surface(0xb78bf238)
09-10 14:25:57.723+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(10), surface(0xb78ae510)
09-10 14:25:57.743+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:25:57.743+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:25:57.753+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 14:25:57.753+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:25:57.753+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 14:25:57.753+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(7025) status(4)
09-10 14:25:57.753+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(7025)
09-10 14:25:57.753+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 7025, appid: org.example.bluetooth, status: bg
09-10 14:25:57.763+0600 I/APP_CORE( 7025): appcore-efl.c: __do_app(520) > [APP 7025] Event: PAUSE State: RUNNING
09-10 14:25:57.763+0600 I/CAPI_APPFW_APPLICATION( 7025): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:25:57.783+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7727330), gem(19), surface(0xb78bf240)
09-10 14:25:57.783+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 14:25:57.813+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 14:25:57.813+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:25:57.843+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:25:57.853+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 14:25:57.863+0600 I/TIZEN_N_SOUND_MANAGER( 6833): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 14:25:57.863+0600 E/TIZEN_N_SOUND_MANAGER( 6833): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:25:57.863+0600 I/TIZEN_N_SOUND_MANAGER( 6833): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 14:25:57.863+0600 E/TIZEN_N_SOUND_MANAGER( 6833): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:25:57.873+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:25:57.883+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 7025): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 125
09-10 14:25:57.883+0600 E/APP_CORE( 7025): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 14:25:57.883+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:25:57.903+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 14:25:57.943+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb833d288]
09-10 14:25:57.943+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 14:25:57.943+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb833d288
09-10 14:25:57.953+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 14:25:57.953+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
09-10 14:25:57.953+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 14:25:57.953+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 14:25:57.953+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 14:25:58.063+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77983f8), gem(19), surface(0xb78925e8)
09-10 14:25:58.153+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:25:58.163+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:25:58.173+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:25:59.034+0600 E/EFL     (  873): ecore_x<873> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=7406052
09-10 14:25:59.034+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=7406052
09-10 14:25:59.034+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
09-10 14:25:59.034+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 14:25:59.034+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 14:25:59.034+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:25:59.334+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 14:25:59.334+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:25:59.334+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:25:59.334+0600 E/STARTER (  763): )
09-10 14:25:59.334+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 14:25:59.334+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:25:59.334+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:25:59.344+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 14:25:59.344+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 14:25:59.354+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 14:25:59.354+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 14:25:59.354+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 14:25:59.354+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 14:25:59.364+0600 E/RESOURCED(  688): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 14:25:59.364+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 14:25:59.364+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 14:25:59.364+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 14:25:59.364+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 14:25:59.364+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 14:25:59.364+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 14:25:59.364+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 14:25:59.384+0600 E/CAPI_APPFW_APPLICATION( 4552): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:25:59.384+0600 E/CAPI_APPFW_APPLICATION( 4552): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:25:59.384+0600 E/CAPI_APPFW_APPLICATION( 4552): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:25:59.384+0600 E/CAPI_APPFW_APPLICATION( 4552): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:25:59.384+0600 E/CAPI_APPFW_APPLICATION( 4552): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:25:59.384+0600 I/CAPI_APPFW_APPLICATION( 4552): app_main.c: ui_app_main(789) > app_efl_main
09-10 14:25:59.384+0600 I/CAPI_APPFW_APPLICATION( 4552): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 14:25:59.404+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778ae60), gem(19), surface(0xb78bb9e0)
09-10 14:25:59.404+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778ae60), gem(19), surface(0xb78ae510)
09-10 14:25:59.404+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 14:25:59.414+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 14:25:59.414+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 14:25:59.454+0600 W/TASK_MGR_LITE( 4552): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 14:25:59.464+0600 I/GXT_SIB ( 4552): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 14:25:59.464+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 4552, appid: com.samsung.task-mgr
09-10 14:25:59.464+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 14:25:59.484+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(4552)
09-10 14:25:59.484+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:25:59.515+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:25:59.515+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:25:59.525+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:25:59.525+0600 E/RUA     ( 4552): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
09-10 14:25:59.525+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 14:25:59.525+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 14:25:59.525+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 14:25:59.535+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:25:59.535+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 7025
09-10 14:25:59.535+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 14:25:59.535+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 14:25:59.545+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 14:25:59.545+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 14:25:59.595+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:25:59.595+0600 I/APP_CORE( 4552): appcore-efl.c: __do_app(520) > [APP 4552] Event: RESET State: CREATED
09-10 14:25:59.595+0600 I/CAPI_APPFW_APPLICATION( 4552): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 14:25:59.605+0600 E/RESOURCED(  688): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 14:25:59.625+0600 E/EFL     ( 4552): edje<4552> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:25:59.625+0600 E/EFL     ( 4552): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:25:59.625+0600 E/EFL     ( 4552): edje<4552> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:25:59.625+0600 E/EFL     ( 4552): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:25:59.635+0600 W/APP_CORE( 4552): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200003
09-10 14:25:59.635+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 14:25:59.725+0600 I/MALI    ( 4552): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb89a1b28)
09-10 14:25:59.735+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb786b030), gem(23), surface(0xb78925e8)
09-10 14:25:59.745+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(4552) status(0)
09-10 14:25:59.745+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: RUNNING
09-10 14:25:59.745+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:25:59.745+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 14:25:59.745+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:25:59.745+0600 I/MALI    ( 4552): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:25:59.765+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 14:25:59.765+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 14:25:59.765+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 14:25:59.765+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(4552) status(3)
09-10 14:25:59.765+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:25:59.765+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:25:59.765+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(4552)
09-10 14:25:59.765+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 4552, appid: com.samsung.task-mgr, status: fg
09-10 14:25:59.765+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 14:25:59.765+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 14:25:59.765+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 14:25:59.775+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78b9910), gem(22), surface(0xb78bb9e0)
09-10 14:25:59.775+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:25:59.775+0600 I/APP_CORE( 4552): appcore-efl.c: __do_app(520) > [APP 4552] Event: RESUME State: CREATED
09-10 14:25:59.785+0600 I/APP_CORE( 4552): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 14:25:59.785+0600 I/APP_CORE( 4552): appcore-efl.c: __do_app(637) > [APP 4552] Initial Launching, call the resume_cb
09-10 14:25:59.785+0600 I/CAPI_APPFW_APPLICATION( 4552): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:25:59.855+0600 E/EFL     (  873): ecore_x<873> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=7406882
09-10 14:25:59.855+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 14:25:59.855+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
09-10 14:25:59.855+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=7406882
09-10 14:25:59.855+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:25:59.855+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:25:59.855+0600 E/STARTER (  763): )
09-10 14:25:59.855+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 14:25:59.865+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 14:25:59.865+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:25:59.865+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:25:59.975+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 6833): media_content.c: media_content_disconnect(940) > [32m[6833]ref count changed to: 0
09-10 14:25:59.975+0600 I/CAPI_NETWORK_WIFI( 6833): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 14:25:59.995+0600 E/ALARM_MANAGER( 6833): alarm-lib-stub.c: _send_alarm_delete_all(434) > alarm_manager_call_alarm_delete_all_sync() failed. return_code[0]
09-10 14:25:59.995+0600 E/ALARM_MANAGER( 6833): alarm-lib-stub.c: _send_alarm_delete_all(436) > dbus error message: The connection is closed
09-10 14:26:00.495+0600 E/EFL     ( 4552): ecore_x<4552> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7407517
09-10 14:26:00.516+0600 E/EFL     ( 4552): ecore_x<4552> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7407545
09-10 14:26:00.526+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 14:26:00.526+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 4552.
09-10 14:26:00.526+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:26:00.526+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 7025
09-10 14:26:00.526+0600 W/AUL     ( 4552): launch.c: app_request_to_launchpad(396) > request cmd(4) to(7025)
09-10 14:26:00.536+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 14:26:00.546+0600 E/RESOURCED(  688): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.930
09-10 14:26:00.546+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(7025), cmd(4)
09-10 14:26:00.546+0600 W/AUL     ( 4552): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 14:26:00.556+0600 I/APP_CORE( 7025): appcore-efl.c: __do_app(520) > [APP 7025] Event: TERMINATE State: PAUSED
09-10 14:26:00.556+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:26:00.556+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:26:00.556+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:26:00.556+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:26:00.556+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 7025): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 14:26:00.556+0600 E/APP_CORE( 7025): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 14:26:00.556+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:26:00.556+0600 E/APP_CORE( 7025): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 14:26:00.556+0600 I/CAPI_APPFW_APPLICATION( 7025): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:26:00.566+0600 E/CAPI_NETWORK_BLUETOOTH( 7025): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 14:26:00.586+0600 I/MALI    ( 4552): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:26:00.606+0600 I/MALI    ( 4552): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:26:00.616+0600 I/MALI    ( 4552): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:26:00.656+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 14:26:00.676+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 2:26 p.m.
09-10 14:26:00.676+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 2:26 p.m."
09-10 14:26:00.676+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 2:26 p.m."
09-10 14:26:00.676+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 14:26:00.676+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146979286 Time: <font_size=31> </font_size> <font_size=31> 2:26 p.m.</font_size></font>"
09-10 14:26:00.726+0600 E/CAPI_NETWORK_BLUETOOTH( 7025): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 14:26:00.726+0600 E/CAPI_NETWORK_BLUETOOTH( 7025): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 14:26:00.726+0600 E/bluetooth( 7025): [bt_adapter_le_destroy_advertiser] Failed.
09-10 14:26:00.736+0600 I/CAPI_NETWORK_WIFI( 7025): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 14:26:00.736+0600 E/bluetooth( 7025): [wifi_deinitialize] Success.
09-10 14:26:00.806+0600 E/EFL     ( 7025): elementary<7025> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 14:26:00.836+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:26:00.836+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:26:00.836+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(4552)
09-10 14:26:00.836+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 4552, appid: com.samsung.task-mgr, status: bg
09-10 14:26:00.836+0600 I/CAPI_APPFW_APPLICATION( 4552): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:26:00.836+0600 W/TASK_MGR_LITE( 4552): task-mgr-lite.c: _pause_app(406) > 
09-10 14:26:00.836+0600 I/CAPI_APPFW_APPLICATION( 4552): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:26:00.856+0600 E/TASK_MGR_LITE( 4552): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 14:26:00.866+0600 E/APP_CORE( 4552): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 14:26:00.866+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:26:00.886+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 14:26:00.886+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:26:00.886+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:26:00.886+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 14:26:00.886+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 14:26:00.886+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:26:00.906+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7808d50), gem(22), surface(0xb78925e8)
09-10 14:26:00.926+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:26:00.926+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7808d50), gem(22), surface(0xb78bb9e0)
09-10 14:26:00.926+0600 I/MALI    ( 4552): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 14:26:00.926+0600 I/MALI    ( 4552): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=4552   close drm_fd=29 
09-10 14:26:00.926+0600 I/MALI    ( 4552): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 14:26:00.956+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b28e8), gem(26), surface(0xb786cac8)
09-10 14:26:00.956+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b28e8), gem(26), surface(0xb787c298)
09-10 14:26:00.976+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:26:00.976+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 14:26:00.976+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:26:00.976+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 14:26:01.016+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 14:26:01.016+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 14:26:01.046+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 14:26:01.096+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77ff378), gem(19), surface(0xb786cac8)
09-10 14:26:01.106+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 14:26:01.136+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7025 pgid = 7025
09-10 14:26:01.136+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(7025)
09-10 14:26:01.146+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 14:26:01.236+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb781e8d8), gem(19), surface(0xb78bb9e0)
09-10 14:26:01.286+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 14:26:01.286+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 14:26:01.286+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 14:26:01.286+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb82fde68]
09-10 14:26:01.286+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 14:26:01.286+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb82fde68
09-10 14:26:01.286+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 14:26:01.286+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
09-10 14:26:01.286+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 14:26:01.286+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 14:26:01.286+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 14:26:01.296+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[7025] terminate event is forwarded
09-10 14:26:01.296+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:26:01.296+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 7025, ]
09-10 14:26:01.296+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:26:01.296+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 14:26:01.296+0600 I/Tizen::App( 1366): (512) > Not registered pid(7025)
09-10 14:26:01.296+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 14:26:01.296+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:26:01.296+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 7025
09-10 14:26:01.296+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7025
09-10 14:26:01.306+0600 E/RESOURCED(  688): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.931
09-10 14:26:01.346+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:26:01.346+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 7025.
09-10 14:26:01.366+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:26:01.386+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:26:01.396+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:26:01.446+0600 W/CRASH_MANAGER( 8986): worker.c: worker_job(1199) > 1107025626162147349596
