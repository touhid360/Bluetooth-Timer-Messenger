S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 18572
Date: 2016-09-10 14:52:37+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18572, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb79410b8
r2   = 0xb42a9000, r3   = 0xb42a9000
r4   = 0xb790ec38, r5   = 0xbef905bc
r6   = 0xb69a7310, r7   = 0xbef9041c
r8   = 0xb69a80f4, r9   = 0xb69a80f4
r10  = 0xb69b620c, fp   = 0x00000000
ip   = 0xb299c3b0, sp   = 0xbef8e770
lr   = 0xb298ffa7, pc   = 0xb668b6f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     65760 KB
Buffers:     40136 KB
Cached:     281776 KB
VmPeak:     106092 KB
VmSize:     103540 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25468 KB
VmRSS:       25468 KB
VmData:      35116 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36232 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18572 TID = 18572
18572 18575 18714 18804 

Maps Information
b0e93000 b1692000 rw-p [stack:18804]
b1ce4000 b24e3000 rw-p [stack:18714]
b24e3000 b24f4000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2504000 b2509000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2595000 b259d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25ae000 b25af000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25bf000 b25d3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25e7000 b25e8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25f8000 b25fb000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b260c000 b260d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b261d000 b261f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b262f000 b2631000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2641000 b2651000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2661000 b266d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b287e000 b2895000 r-xp /usr/lib/libnetwork.so.0.0.0
b28a6000 b28e4000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b28f5000 b28fc000 r-xp /usr/lib/libefl-extension.so.0.1.0
b290d000 b291c000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b292c000 b2961000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2974000 b297a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b298a000 b2994000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ab6000 b2b99000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bd0000 b2bf8000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c0a000 b3409000 rw-p [stack:18575]
b3409000 b340b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b341b000 b3425000 r-xp /lib/libnss_files-2.20-2014.11.so
b3436000 b343f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3450000 b3461000 r-xp /lib/libnsl-2.20-2014.11.so
b3474000 b347a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b348b000 b348c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34b4000 b34bb000 r-xp /usr/lib/libminizip.so.1.0.0
b34cb000 b34d0000 r-xp /usr/lib/libstorage.so.0.1
b34e0000 b3535000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b354b000 b355f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b356f000 b35b3000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35c3000 b35cb000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35db000 b360b000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b361e000 b36d7000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36eb000 b373f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3750000 b376b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b377b000 b383c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b384f000 b3861000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3871000 b3875000 r-xp /usr/lib/libogg.so.0.7.1
b3885000 b38a7000 r-xp /usr/lib/libvorbis.so.0.4.3
b38b7000 b399b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39b7000 b39c4000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39d5000 b3a18000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a2d000 b3a74000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a85000 b3a8b000 r-xp /usr/lib/libjson-c.so.2.0.1
b3a9c000 b3aa3000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ab3000 b3af3000 r-xp /usr/lib/libmdm.so.1.2.10
b3b03000 b3b0b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b1a000 b3b2a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b4b000 b3bab000 r-xp /usr/lib/libasound.so.2.0.0
b3bbd000 b3bf3000 r-xp /usr/lib/libpulse.so.0.16.2
b3c04000 b3c07000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c17000 b3c1a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c2a000 b3c2f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c3f000 b3c40000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c50000 b3c5b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c6f000 b3c76000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c86000 b3c8c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3c9c000 b3ca1000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cb1000 b3ccc000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cdc000 b3ce3000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3cf3000 b3cf6000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d07000 b3d35000 r-xp /usr/lib/libidn.so.11.5.44
b3d45000 b3d5b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d6c000 b3d76000 r-xp /usr/lib/libcares.so.2.1.0
b3d86000 b3d90000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3da0000 b3da2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3db2000 b3db3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dc3000 b3dc7000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3dd8000 b3e00000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e11000 b3e3a000 r-xp /usr/lib/libturbojpeg.so
b3e5a000 b3e60000 r-xp /usr/lib/libgif.so.4.1.6
b3e70000 b3eb6000 r-xp /usr/lib/libcurl.so.4.3.0
b3ec7000 b3ee8000 r-xp /usr/lib/libexif.so.12.3.3
b3f03000 b3f18000 r-xp /usr/lib/libtts.so
b3f29000 b3f31000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f41000 b4001000 r-xp /usr/lib/libdali-core.so.0.0.0
b400c000 b40ff000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b411f000 b41f9000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4210000 b4212000 r-xp /usr/lib/libboost_system.so.1.51.0
b4222000 b4228000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4238000 b425b000 r-xp /usr/lib/libboost_thread.so.1.51.0
b426c000 b426e000 r-xp /usr/lib/libappsvc.so.0.1.0
b427e000 b4280000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4291000 b4296000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ad000 b42af000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42bf000 b42c6000 r-xp /usr/lib/libsensord-share.so
b42d6000 b42ee000 r-xp /usr/lib/libsensor.so.1.1.0
b42ff000 b4302000 r-xp /usr/lib/libXv.so.1.0.0
b4312000 b4317000 r-xp /usr/lib/libutilX.so.1.1.0
b4327000 b432c000 r-xp /usr/lib/libappcore-common.so.1.1
b433c000 b4343000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4356000 b435a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b436b000 b4435000 r-xp /usr/lib/libCOREGL.so.4.0
b444c000 b444f000 r-xp /usr/lib/libuuid.so.1.3.0
b4460000 b4477000 r-xp /usr/lib/libblkid.so.1.1.0
b4488000 b448a000 r-xp /usr/lib/libXau.so.6.0.0
b449a000 b449d000 r-xp /usr/lib/libEGL.so.1.4
b44a5000 b44ab000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44bb000 b44bd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44ce000 b44dc000 r-xp /usr/lib/libGLESv2.so.2.0
b44e5000 b4547000 r-xp /usr/lib/libpixman-1.so.0.28.2
b455c000 b4574000 r-xp /usr/lib/libmount.so.1.1.0
b4585000 b4599000 r-xp /usr/lib/libxcb.so.1.1.0
b45aa000 b45b1000 r-xp /lib/libcrypt-2.20-2014.11.so
b45e9000 b45fa000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b460b000 b460d000 r-xp /usr/lib/libiri.so
b461d000 b4628000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4639000 b464e000 r-xp /lib/libexpat.so.1.5.2
b4660000 b471e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4731000 b4739000 r-xp /usr/lib/libdrm.so.2.4.0
b4749000 b474c000 r-xp /usr/lib/libdri2.so.0.0.0
b475d000 b47ab000 r-xp /usr/lib/libssl.so.1.0.0
b47c0000 b47cc000 r-xp /usr/lib/libeeze.so.1.13.0
b47dc000 b47e5000 r-xp /usr/lib/libethumb.so.1.13.0
b47f5000 b47f8000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4808000 b49bf000 r-xp /usr/lib/libcrypto.so.1.0.0
b5616000 b561f000 r-xp /usr/lib/libXi.so.6.1.0
b562f000 b5631000 r-xp /usr/lib/libXgesture.so.7.0.0
b5641000 b5645000 r-xp /usr/lib/libXtst.so.6.1.0
b5655000 b565b000 r-xp /usr/lib/libXrender.so.1.3.0
b566b000 b5671000 r-xp /usr/lib/libXrandr.so.2.2.0
b5682000 b5684000 r-xp /usr/lib/libXinerama.so.1.0.0
b5694000 b5697000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a7000 b56b2000 r-xp /usr/lib/libXext.so.6.4.0
b56c2000 b56c4000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d4000 b56d6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e7000 b57c9000 r-xp /usr/lib/libX11.so.6.3.0
b57dc000 b57e3000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f3000 b580b000 r-xp /usr/lib/libudev.so.1.6.0
b580d000 b5810000 r-xp /lib/libattr.so.1.1.0
b5820000 b5840000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5842000 b5847000 r-xp /usr/lib/libffi.so.6.0.2
b5857000 b586f000 r-xp /lib/libz.so.1.2.8
b587f000 b5881000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5891000 b5966000 r-xp /usr/lib/libxml2.so.2.9.2
b597b000 b5a16000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a32000 b5a35000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a45000 b5a5e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6f000 b5a80000 r-xp /lib/libresolv-2.20-2014.11.so
b5a94000 b5b0e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b23000 b5b25000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b35000 b5b3c000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4c000 b5b64000 r-xp /usr/lib/libpng12.so.0.50.0
b5b75000 b5b98000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb9000 b5bcd000 r-xp /usr/lib/libector.so.1.13.0
b5bde000 b5bf6000 r-xp /usr/lib/liblua-5.1.so
b5c07000 b5c5e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c72000 b5c9a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cab000 b5cbe000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ccf000 b5d06000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d17000 b5d25000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d35000 b5d3d000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4d000 b5d5a000 r-xp /usr/lib/libeio.so.1.13.0
b5d6a000 b5d6c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d7c000 b5d81000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d91000 b5da8000 r-xp /usr/lib/libefreet.so.1.13.0
b5dba000 b5dda000 r-xp /usr/lib/libeldbus.so.1.13.0
b5dea000 b5e0a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e0c000 b5e12000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e22000 b5e33000 r-xp /usr/lib/libemotion.so.1.13.0
b5e44000 b5e4b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e5b000 b5e6a000 r-xp /usr/lib/libeo.so.1.13.0
b5e7b000 b5e8d000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e9e000 b5ea3000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb3000 b5ecc000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5edc000 b5ef9000 r-xp /usr/lib/libeet.so.1.13.0
b5f12000 b5f5a000 r-xp /usr/lib/libeina.so.1.13.0
b5f6b000 b5f7b000 r-xp /usr/lib/libefl.so.1.13.0
b5f8c000 b6071000 r-xp /usr/lib/libicuuc.so.51.1
b608e000 b61ce000 r-xp /usr/lib/libicui18n.so.51.1
b61e5000 b621d000 r-xp /usr/lib/libecore_x.so.1.13.0
b622f000 b6232000 r-xp /lib/libcap.so.2.21
b6242000 b626b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b627c000 b6283000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6295000 b62cc000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62dd000 b63c8000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63db000 b6454000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6466000 b646b000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b647b000 b6485000 r-xp /usr/lib/libvconf.so.0.2.45
b6495000 b6497000 r-xp /usr/lib/libvasum.so.0.3.1
b64a7000 b64a9000 r-xp /usr/lib/libttrace.so.1.1
b64b9000 b64bc000 r-xp /usr/lib/libiniparser.so.0
b64cc000 b64f2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6502000 b6507000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6518000 b652f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6540000 b65ab000 r-xp /lib/libm-2.20-2014.11.so
b65bc000 b65c2000 r-xp /lib/librt-2.20-2014.11.so
b65d3000 b65e0000 r-xp /usr/lib/libunwind.so.8.0.1
b6616000 b673a000 r-xp /lib/libc-2.20-2014.11.so
b674f000 b6768000 r-xp /lib/libgcc_s-4.9.so.1
b6778000 b685a000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b686b000 b6895000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a6000 b68e2000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e4000 b6966000 r-xp /usr/lib/libedje.so.1.13.0
b6979000 b6997000 r-xp /usr/lib/libecore.so.1.13.0
b69b7000 b6b3e000 r-xp /usr/lib/libevas.so.1.13.0
b6b73000 b6b87000 r-xp /lib/libpthread-2.20-2014.11.so
b6b9b000 b6dd0000 r-xp /usr/lib/libelementary.so.1.13.0
b6dfe000 b6e02000 r-xp /usr/lib/libsmack.so.1.0.0
b6e12000 b6e19000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e29000 b6e2b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e3b000 b6e3e000 r-xp /usr/lib/libbundle.so.0.1.22
b6e4e000 b6e50000 r-xp /lib/libdl-2.20-2014.11.so
b6e61000 b6e79000 r-xp /usr/lib/libaul.so.0.1.0
b6e8d000 b6e92000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea3000 b6eb0000 r-xp /usr/lib/liblptcp.so
b6ec2000 b6ec6000 r-xp /usr/lib/libsys-assert.so
b6ed7000 b6ef7000 r-xp /lib/ld-2.20-2014.11.so
b6f08000 b6f0d000 r-xp /usr/bin/launchpad-loader
b78cd000 b7c62000 rw-p [heap]
bef70000 bef91000 rw-p [stack]
b78cd000 b7c62000 rw-p [heap]
bef70000 bef91000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18572)
Call Stack Count: 1
 0: (0xb668b6f0) [/lib/libc.so.6] + 0x756f0
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
18721): manager.c: ugman_ug_create(666) > [34mafter ug(ug-bluetooth-efl) create cb[0m
09-10 14:52:30.767+0600 E/EFL     (18721): elementary<18721> elm_layout.c:638 _elm_layout_part_aliasing_eval() no default content part set for object 0x8000e875 -- part must not be NULL
09-10 14:52:30.827+0600 W/UI_GADGET(18721): manager.c: ugman_tree_dump(185) > [34m============== TREE_DUMP =============[0m
09-10 14:52:30.827+0600 W/UI_GADGET(18721): manager.c: ugman_tree_dump(186) > [34mROOT: Manager(0xb8738308)[0m
09-10 14:52:30.827+0600 W/UI_GADGET(18721): manager.c: ugman_tree_dump(203) > [34m[1] ug-bluetooth-efl [F] (mem : b24e9000-b2517000) (ug : 0xb850bac0) (PARENT:  Manager)[0m
09-10 14:52:30.837+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:30.837+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:30.867+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76e5738), gem(22), surface(0xb78a0c40)
09-10 14:52:30.877+0600 E/EFL     (18721): edje<18721> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:30.877+0600 E/EFL     (18721): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:30.897+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:52:30.907+0600 I/Tizen::System( 1366): (259) > Active app [ug-bluetoo], current [org.exampl] 
09-10 14:52:30.907+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:52:30.907+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:52:30.907+0600 E/EFL     (18721): edje<18721> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:30.907+0600 E/EFL     (18721): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:30.917+0600 E/EFL     (18721): edje<18721> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:30.917+0600 E/EFL     (18721): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:30.917+0600 E/EFL     (18721): edje<18721> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:30.917+0600 E/EFL     (18721): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:30.917+0600 E/EFL     (18721): edje<18721> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:30.917+0600 E/EFL     (18721): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:30.927+0600 W/APP_CORE(18721): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000003
09-10 14:52:30.927+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 14:52:31.017+0600 I/MALI    (18721): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb8503890)
09-10 14:52:31.037+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785af58), gem(23), surface(0xb7808968)
09-10 14:52:31.037+0600 I/MALI    (18721): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:31.037+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76e5738), gem(22), surface(0xb7757640)
09-10 14:52:31.047+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78603c0), gem(10), surface(0xb78ae1a0)
09-10 14:52:31.057+0600 I/APP_CORE(18572): appcore-efl.c: __do_app(520) > [APP 18572] Event: PAUSE State: RUNNING
09-10 14:52:31.057+0600 I/CAPI_APPFW_APPLICATION(18572): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:52:31.057+0600 I/TIZEN_N_EFL_UTIL_WINDOW(18572): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 4
09-10 14:52:31.057+0600 E/APP_CORE(18572): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 14:52:31.057+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:52:31.077+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18572) status(4)
09-10 14:52:31.077+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(18572)
09-10 14:52:31.077+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18572, appid: org.example.bluetooth, status: bg
09-10 14:52:31.077+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18721) status(3)
09-10 14:52:31.077+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:52:31.077+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:52:31.077+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG ug-bluetooth-efl(18721)
09-10 14:52:31.077+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18721, appid: ug-bluetooth-efl, status: fg
09-10 14:52:31.097+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:52:31.187+0600 I/CAPI_NETWORK_CONNECTION(18721): connection.c: connection_create(442) > New handle created[0xb8819480]
09-10 14:52:31.187+0600 E/CAPI_NETWORK_BLUETOOTH(18721): bluetooth-hid.c: bt_hid_host_initialize(74) > [bt_hid_host_initialize] NOT_SUPPORTED(0xc0000002)
09-10 14:52:31.187+0600 W/CAPI_APPFW_APP_CONTROL(18721): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-10 14:52:31.257+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77cfb70), gem(10), surface(0xb78a0c40)
09-10 14:52:31.368+0600 I/UXT     (18720): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 14:52:31.918+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 14:52:31.918+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 14:52:32.198+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 14:52:32.749+0600 I/APP_CORE(18721): appcore-efl.c: __do_app(520) > [APP 18721] Event: RESUME State: CREATED
09-10 14:52:32.799+0600 I/APP_CORE(18721): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 14:52:32.799+0600 I/APP_CORE(18721): appcore-efl.c: __do_app(637) > [APP 18721] Initial Launching, call the resume_cb
09-10 14:52:32.839+0600 W/UI_GADGET(18721): manager.c: ugman_ug_resume(385) > [34mug(0xb850bac0)->state : 2[0m
09-10 14:52:33.059+0600 I/MALI    (18721): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:33.079+0600 I/MALI    (18721): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:33.089+0600 I/MALI    (18721): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:33.370+0600 I/Tizen::System( 1366): (340) > Setting event[http://tizen.org/setting/network.bluetooth] is occured.
09-10 14:52:33.370+0600 I/Tizen::System( 1366): (362) > Event is delivered to b7f61910.
09-10 14:52:33.400+0600 I/Tizen::System( 1366): (1389) > Bluetooth callback is invoked. result:0, adapter_state:1, user_data:b804c5b8
09-10 14:52:33.400+0600 E/Tizen::System( 1366): (1393) > Bluetooth processing is under way.
09-10 14:52:33.400+0600 I/QUICKPANEL(  991): BluetoothQuickBtnControl.cpp: __onBluetoothStatusChanged(147) > [0;32mbluetooth state : 1[0;m
09-10 14:52:33.420+0600 D/bluetooth(18572): [adapter_state_changed_cb] Bluetooth is enabled!
09-10 14:52:33.430+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 14:52:33.430+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:52:33.430+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:52:33.430+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:52:33.450+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:52:33.450+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:52:33.460+0600 E/EFL     (  991): edje<991> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/setting_icon_wvga has a non-fixed part 'bg.image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:52:33.610+0600 D/bluetooth(18572): [adapter_state_changed_cb] Adapter address: 90:00:DB:03:33:F2.
09-10 14:52:33.620+0600 E/EFL     (18721): eo<18721> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x8002f57b's acvie is  NULL, entry: 0xb6ee6bf0, 0xb87c4108, 0
09-10 14:52:33.620+0600 E/EFL     (18721): eo<18721> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x8002f57b is not pointing to a valid object. Maybe it has already been freed.
09-10 14:52:33.620+0600 E/EFL     (18721): eo<18721> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8002f57b) is an invalid ref.
09-10 14:52:33.620+0600 E/EFL     (18721): <18721> lib/ecore/ecore_idler.c:91 _ecore_idler_del() safety check failed: idler == NULL
09-10 14:52:33.630+0600 W/CAPI_APPFW_APP_CONTROL(18721): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-10 14:52:33.630+0600 W/UI_GADGET_CLIENT(18721): ug-client.c: _ug_client_result_cb(585) > get reply result error(-126) . result will be APP_CONTROL_RESULT_SUCCEEDED
09-10 14:52:33.630+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:52:33.630+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:52:33.630+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG ug-bluetooth-efl(18721)
09-10 14:52:33.630+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18721, appid: ug-bluetooth-efl, status: bg
09-10 14:52:33.640+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18572) status(3)
09-10 14:52:33.640+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:52:33.640+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:52:33.640+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(18572)
09-10 14:52:33.640+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18572, appid: org.example.bluetooth, status: fg
09-10 14:52:33.640+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:52:33.640+0600 E/EFL     (18721): eo<18721> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x8006733b's acvie is  NULL, entry: 0xb6ee79e8, 0xb850c428, 0
09-10 14:52:33.640+0600 E/EFL     (18721): eo<18721> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x8006733b is not pointing to a valid object. Maybe it has already been freed.
09-10 14:52:33.640+0600 E/EFL     (18721): eo<18721> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8006733b) is an invalid ref.
09-10 14:52:33.640+0600 E/EFL     (18721): <18721> lib/ecore/ecore_idler.c:91 _ecore_idler_del() safety check failed: idler == NULL
09-10 14:52:33.640+0600 E/CAPI_NETWORK_BLUETOOTH(18721): bluetooth-hid.c: bt_hid_host_deinitialize(95) > [bt_hid_host_deinitialize] NOT_SUPPORTED(0xc0000002)
09-10 14:52:33.680+0600 D/bluetooth(18572): [adapter_state_changed_cb] Adapter name: Samsung Z1.
09-10 14:52:33.710+0600 D/bluetooth(18572): [adapter_state_changed_cb] Visibility: GENERAL_DISCOVERABLE
09-10 14:52:33.740+0600 I/CAPI_NETWORK_CONNECTION(18721): connection.c: connection_destroy(460) > Destroy handle: 0xb8819480
09-10 14:52:33.800+0600 W/UI_GADGET(18721): manager.c: ugman_tree_dump(185) > [34m============== TREE_DUMP =============[0m
09-10 14:52:33.800+0600 W/UI_GADGET(18721): manager.c: ugman_tree_dump(186) > [34mROOT: Manager(0xb8738308)[0m
09-10 14:52:33.800+0600 W/UI_GADGET(18721): manager.c: ugman_ug_destroy(600) > [34mug parent is null[0m
09-10 14:52:33.800+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:33.830+0600 I/MALI    (18721): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 14:52:33.830+0600 I/MALI    (18721): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=18721   close drm_fd=33 
09-10 14:52:33.830+0600 I/MALI    (18721): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 14:52:33.900+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76e5738), gem(10), surface(0xb78ae1a0)
09-10 14:52:33.900+0600 E/EFL     (18572): edje<18572> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:33.900+0600 E/EFL     (18572): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:33.900+0600 E/EFL     (18572): edje<18572> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:33.900+0600 E/EFL     (18572): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:33.920+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76e5738), gem(10), surface(0xb7808968)
09-10 14:52:33.950+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78302e0), gem(23), surface(0xb78a0c40)
09-10 14:52:33.950+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78302e0), gem(23), surface(0xb789ef70)
09-10 14:52:33.970+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:34.000+0600 I/APP_CORE(18572): appcore-efl.c: __do_app(520) > [APP 18572] Event: RESUME State: PAUSED
09-10 14:52:34.000+0600 I/CAPI_APPFW_APPLICATION(18572): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:52:34.000+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7737e90), gem(22), surface(0xb78a0c40)
09-10 14:52:34.020+0600 I/Tizen::System( 1366): (259) > Active app [org.exampl], current [ug-bluetoo] 
09-10 14:52:34.020+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:52:34.030+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:52:34.030+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:52:34.130+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78448e8), gem(22), surface(0xb7808968)
09-10 14:52:34.150+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 14:52:34.150+0600 I/Tizen::App( 1366): (243) > App[ug-bluetooth-efl] pid[18721] terminate event is forwarded
09-10 14:52:34.160+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:52:34.160+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [ug-bluetooth-efl, 18721, ]
09-10 14:52:34.160+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:52:34.160+0600 I/Tizen::App( 1366): (506) > TerminatedApp(ug-bluetooth-efl)
09-10 14:52:34.160+0600 I/Tizen::App( 1366): (512) > Not registered pid(18721)
09-10 14:52:34.160+0600 I/Tizen::System( 1366): (246) > Terminated app [ug-bluetooth-efl]
09-10 14:52:34.160+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:52:34.160+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 18721
09-10 14:52:34.160+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18721
09-10 14:52:34.160+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 18721
09-10 14:52:34.160+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 14:52:34.160+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:52:34.160+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for ug-bluetooth-efl, 18721.
09-10 14:52:34.981+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: MEM_FLUSH State: PAUSED
09-10 14:52:35.652+0600 E/EFL     (18572): ecore_x<18572> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9002669
09-10 14:52:35.762+0600 E/EFL     (18572): ecore_x<18572> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9002774
09-10 14:52:35.772+0600 E/VCONF   (18572): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
09-10 14:52:35.772+0600 E/VCONF   (18572): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
09-10 14:52:35.772+0600 E/VCONF   (18572): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
09-10 14:52:35.772+0600 E/VCONF   (18572): vconf.c: vconf_get_bool(2729) > vconf_get_bool(18572) : db/ise/keysound error
09-10 14:52:35.772+0600 E/VCONF   (18572): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
09-10 14:52:35.772+0600 E/VCONF   (18572): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
09-10 14:52:36.172+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=9003189
09-10 14:52:36.172+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 14:52:36.172+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 14:52:36.172+0600 E/EFL     (18572): ecore_x<18572> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=9003189
09-10 14:52:36.172+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:52:36.473+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 14:52:36.473+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:52:36.473+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:52:36.473+0600 E/STARTER (  763): )
09-10 14:52:36.473+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 14:52:36.473+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:52:36.473+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:52:36.483+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 14:52:36.483+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 14:52:36.493+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 14:52:36.493+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 14:52:36.493+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 14:52:36.493+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 14:52:36.503+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 14:52:36.503+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 14:52:36.503+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 14:52:36.503+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 14:52:36.503+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 14:52:36.503+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 14:52:36.503+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 14:52:36.503+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 14:52:36.523+0600 E/CAPI_APPFW_APPLICATION(18704): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:52:36.523+0600 E/CAPI_APPFW_APPLICATION(18704): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:52:36.523+0600 E/CAPI_APPFW_APPLICATION(18704): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:52:36.523+0600 E/CAPI_APPFW_APPLICATION(18704): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:52:36.523+0600 E/CAPI_APPFW_APPLICATION(18704): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:52:36.523+0600 I/CAPI_APPFW_APPLICATION(18704): app_main.c: ui_app_main(789) > app_efl_main
09-10 14:52:36.523+0600 I/CAPI_APPFW_APPLICATION(18704): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 14:52:36.533+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785af58), gem(10), surface(0xb78ae1a0)
09-10 14:52:36.543+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785af58), gem(10), surface(0xb7890698)
09-10 14:52:36.543+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 14:52:36.543+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 14:52:36.543+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 14:52:36.593+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77b28e8), gem(22), surface(0xb7808968)
09-10 14:52:36.603+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 18704, appid: com.samsung.task-mgr
09-10 14:52:36.603+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 14:52:36.603+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(18704)
09-10 14:52:36.613+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:52:36.683+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 14:52:36.683+0600 W/TASK_MGR_LITE(18704): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 14:52:36.693+0600 I/GXT_SIB (18704): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 14:52:36.733+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:52:36.733+0600 E/RUA     (18704): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 18, ncols : 5
09-10 14:52:36.733+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 14:52:36.743+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:52:36.743+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 18572
09-10 14:52:36.743+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 14:52:36.743+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 14:52:36.753+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:36.753+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:36.773+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 14:52:36.793+0600 E/AUL_AMD (  648): amd_launch.c: _amd_proc_find_proc_info(1933) > proc info not found
09-10 14:52:36.793+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:52:36.803+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:52:36.813+0600 I/TIZEN_N_SOUND_MANAGER(18385): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 14:52:36.813+0600 E/TIZEN_N_SOUND_MANAGER(18385): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:52:36.813+0600 I/TIZEN_N_SOUND_MANAGER(18385): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 14:52:36.813+0600 E/TIZEN_N_SOUND_MANAGER(18385): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:52:36.813+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:52:36.823+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 14:52:36.823+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=9003836
09-10 14:52:36.823+0600 E/EFL     (18572): ecore_x<18572> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=9003836
09-10 14:52:36.823+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:52:36.823+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:52:36.823+0600 E/STARTER (  763): )
09-10 14:52:36.823+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 14:52:36.833+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 14:52:36.833+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:52:36.833+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:52:36.843+0600 I/APP_CORE(18704): appcore-efl.c: __do_app(520) > [APP 18704] Event: RESET State: CREATED
09-10 14:52:36.843+0600 I/CAPI_APPFW_APPLICATION(18704): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 14:52:36.843+0600 E/EFL     (18704): edje<18704> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:36.843+0600 E/EFL     (18704): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:36.843+0600 E/EFL     (18704): edje<18704> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:52:36.843+0600 E/EFL     (18704): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:52:36.853+0600 W/APP_CORE(18704): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5400003
09-10 14:52:36.853+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 14:52:36.913+0600 I/MALI    (18704): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb806fd58)
09-10 14:52:36.923+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7816748), gem(26), surface(0xb78c63f8)
09-10 14:52:36.933+0600 I/MALI    (18704): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:36.933+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18704) status(0)
09-10 14:52:36.943+0600 I/APP_CORE(18572): appcore-efl.c: __do_app(520) > [APP 18572] Event: PAUSE State: RUNNING
09-10 14:52:36.943+0600 I/CAPI_APPFW_APPLICATION(18572): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:52:36.943+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:52:36.943+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18572) status(4)
09-10 14:52:36.943+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(18572)
09-10 14:52:36.943+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18572, appid: org.example.bluetooth, status: bg
09-10 14:52:36.953+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18704) status(3)
09-10 14:52:36.953+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:52:36.953+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:52:36.953+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(18704)
09-10 14:52:36.953+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18704, appid: com.samsung.task-mgr, status: fg
09-10 14:52:36.963+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:52:36.963+0600 I/TIZEN_N_EFL_UTIL_WINDOW(18572): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 21
09-10 14:52:36.963+0600 E/APP_CORE(18572): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 14:52:36.963+0600 I/APP_CORE(18704): appcore-efl.c: __do_app(520) > [APP 18704] Event: RESUME State: CREATED
09-10 14:52:36.963+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:52:36.963+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb768eb50), gem(23), surface(0xb786c978)
09-10 14:52:36.973+0600 I/APP_CORE(18704): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 14:52:36.973+0600 I/APP_CORE(18704): appcore-efl.c: __do_app(637) > [APP 18704] Initial Launching, call the resume_cb
09-10 14:52:36.973+0600 I/CAPI_APPFW_APPLICATION(18704): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:52:37.443+0600 E/EFL     (18704): ecore_x<18704> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9004463
09-10 14:52:37.484+0600 E/EFL     (18704): ecore_x<18704> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9004504
09-10 14:52:37.484+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:52:37.484+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 18572
09-10 14:52:37.484+0600 W/AUL     (18704): launch.c: app_request_to_launchpad(396) > request cmd(4) to(18572)
09-10 14:52:37.494+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 14:52:37.494+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(18572), cmd(4)
09-10 14:52:37.494+0600 W/AUL     (18704): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 14:52:37.494+0600 I/APP_CORE(18572): appcore-efl.c: __do_app(520) > [APP 18572] Event: TERMINATE State: PAUSED
09-10 14:52:37.494+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:52:37.494+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:52:37.504+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:52:37.504+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:52:37.504+0600 I/TIZEN_N_EFL_UTIL_WINDOW(18572): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 14:52:37.504+0600 E/APP_CORE(18572): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 14:52:37.504+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:52:37.504+0600 E/APP_CORE(18572): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 14:52:37.504+0600 I/CAPI_APPFW_APPLICATION(18572): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:52:37.504+0600 E/CAPI_NETWORK_BLUETOOTH(18572): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 14:52:37.534+0600 I/MALI    (18704): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:37.554+0600 I/MALI    (18704): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:37.564+0600 I/MALI    (18704): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:37.734+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 14:52:37.734+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 18704.
09-10 14:52:37.744+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1256
09-10 14:52:37.764+0600 E/CAPI_NETWORK_BLUETOOTH(18572): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 14:52:37.764+0600 E/CAPI_NETWORK_BLUETOOTH(18572): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 14:52:37.764+0600 E/bluetooth(18572): [bt_adapter_le_destroy_advertiser] Failed.
09-10 14:52:37.764+0600 I/CAPI_NETWORK_WIFI(18572): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 14:52:37.774+0600 E/bluetooth(18572): [wifi_deinitialize] Success.
09-10 14:52:37.784+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:52:37.784+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:52:37.784+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(18704)
09-10 14:52:37.784+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18704, appid: com.samsung.task-mgr, status: bg
09-10 14:52:37.784+0600 I/CAPI_APPFW_APPLICATION(18704): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:52:37.784+0600 W/TASK_MGR_LITE(18704): task-mgr-lite.c: _pause_app(406) > 
09-10 14:52:37.784+0600 I/CAPI_APPFW_APPLICATION(18704): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:52:37.804+0600 E/TASK_MGR_LITE(18704): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 14:52:37.824+0600 E/APP_CORE(18704): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 14:52:37.834+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:37.844+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 14:52:37.844+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:52:37.844+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:52:37.844+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 14:52:37.844+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 14:52:37.844+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:52:37.874+0600 E/EFL     (18572): elementary<18572> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 14:52:37.884+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778ae60), gem(10), surface(0xb7890698)
09-10 14:52:37.894+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:37.904+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778ae60), gem(10), surface(0xb7808968)
09-10 14:52:37.944+0600 I/MALI    (18704): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 14:52:37.944+0600 I/MALI    (18704): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=18704   close drm_fd=29 
09-10 14:52:37.944+0600 I/MALI    (18704): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 14:52:37.944+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76af128), gem(26), surface(0xb78ae1a0)
09-10 14:52:37.944+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76af128), gem(26), surface(0xb786c978)
09-10 14:52:37.964+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:52:37.964+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:52:37.964+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 14:52:37.964+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:52:37.964+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 14:52:37.984+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 14:52:38.014+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 14:52:38.014+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 14:52:38.014+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb773cdf0), gem(19), surface(0xb78ae1a0)
09-10 14:52:38.014+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 14:52:38.054+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 14:52:38.084+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8314638]
09-10 14:52:38.084+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 14:52:38.084+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 14:52:38.084+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 14:52:38.084+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8314638
09-10 14:52:38.114+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 14:52:38.114+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-10 14:52:38.114+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-10 14:52:38.114+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 14:52:38.114+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 14:52:38.114+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 14:52:38.214+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78306d8), gem(19), surface(0xb7808968)
09-10 14:52:38.334+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 18572 pgid = 18572
09-10 14:52:38.334+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(18572)
09-10 14:52:38.394+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:38.404+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:38.414+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:52:38.414+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 14:52:38.414+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 14:52:38.414+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 14:52:38.424+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[18572] terminate event is forwarded
09-10 14:52:38.424+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:52:38.424+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 18572, ]
09-10 14:52:38.424+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:52:38.424+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 14:52:38.424+0600 I/Tizen::App( 1366): (512) > Not registered pid(18572)
09-10 14:52:38.424+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 14:52:38.424+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:52:38.424+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 18572
09-10 14:52:38.424+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18572
09-10 14:52:38.424+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1257
09-10 14:52:38.444+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 14:52:38.454+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:52:38.454+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 18572.
09-10 14:52:38.495+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 18704 pgid = 18704
09-10 14:52:38.495+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(18704)
09-10 14:52:38.535+0600 W/CRASH_MANAGER(18825): worker.c: worker_job(1199) > 1118572626162147349755
