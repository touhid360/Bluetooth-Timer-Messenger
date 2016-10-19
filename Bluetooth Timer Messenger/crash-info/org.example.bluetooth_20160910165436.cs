S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 24203
Date: 2016-09-10 16:54:36+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 24203, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb771fd78
r2   = 0xb42c3000, r3   = 0xb42c3000
r4   = 0xbec185bc, r5   = 0xb69c20f4
r6   = 0xb69c1310, r7   = 0xbec1841c
r8   = 0xb69c20f4, r9   = 0xb69c20f4
r10  = 0xb69d020c, fp   = 0x00000000
ip   = 0xb29b6a74, sp   = 0xbec17798
lr   = 0xb29ac1ff, pc   = 0xb66a56f0
cpsr = 0x800e0030

Memory Information
MemTotal:   730440 KB
MemFree:     46344 KB
Buffers:     43580 KB
Cached:     292328 KB
VmPeak:     105584 KB
VmSize:     103128 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24968 KB
VmRSS:       24968 KB
VmData:      34720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 24203 TID = 24203
24203 24235 24416 24418 

Maps Information
b1401000 b1c00000 rw-p [stack:24418]
b1d02000 b2501000 rw-p [stack:24416]
b2501000 b2512000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2522000 b2527000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25b3000 b25bb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25cc000 b25cd000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25dd000 b25f1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2605000 b2606000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2616000 b2619000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b262a000 b262b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b263b000 b263d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b264d000 b264f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b265f000 b266f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b267f000 b268b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b289c000 b28b3000 r-xp /usr/lib/libnetwork.so.0.0.0
b28c4000 b2902000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2913000 b291a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b292b000 b293a000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b294a000 b297f000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2992000 b2998000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29a8000 b29af000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ad0000 b2bb3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bea000 b2c12000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c24000 b3423000 rw-p [stack:24235]
b3423000 b3425000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3435000 b343f000 r-xp /lib/libnss_files-2.20-2014.11.so
b3450000 b3459000 r-xp /lib/libnss_nis-2.20-2014.11.so
b346a000 b347b000 r-xp /lib/libnsl-2.20-2014.11.so
b348e000 b3494000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34a5000 b34a6000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34ce000 b34d5000 r-xp /usr/lib/libminizip.so.1.0.0
b34e5000 b34ea000 r-xp /usr/lib/libstorage.so.0.1
b34fa000 b354f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3565000 b3579000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3589000 b35cd000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35dd000 b35e5000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35f5000 b3625000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3638000 b36f1000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3705000 b3759000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b376a000 b3785000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3795000 b3856000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3869000 b387b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b388b000 b388f000 r-xp /usr/lib/libogg.so.0.7.1
b389f000 b38c1000 r-xp /usr/lib/libvorbis.so.0.4.3
b38d1000 b39b5000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39d1000 b39de000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39ef000 b3a32000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a47000 b3a8e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a9f000 b3aa5000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ab6000 b3abd000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3acd000 b3b0d000 r-xp /usr/lib/libmdm.so.1.2.10
b3b1d000 b3b25000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b34000 b3b44000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b65000 b3bc5000 r-xp /usr/lib/libasound.so.2.0.0
b3bd7000 b3c0d000 r-xp /usr/lib/libpulse.so.0.16.2
b3c1e000 b3c21000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c31000 b3c34000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c44000 b3c49000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c59000 b3c5a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c6a000 b3c75000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c89000 b3c90000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3ca0000 b3ca6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cb6000 b3cbb000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3ccb000 b3ce6000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cf6000 b3cfd000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d0d000 b3d10000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d21000 b3d4f000 r-xp /usr/lib/libidn.so.11.5.44
b3d5f000 b3d75000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d86000 b3d90000 r-xp /usr/lib/libcares.so.2.1.0
b3da0000 b3daa000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dba000 b3dbc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dcc000 b3dcd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3ddd000 b3de1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3df2000 b3e1a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e2b000 b3e54000 r-xp /usr/lib/libturbojpeg.so
b3e74000 b3e7a000 r-xp /usr/lib/libgif.so.4.1.6
b3e8a000 b3ed0000 r-xp /usr/lib/libcurl.so.4.3.0
b3ee1000 b3f02000 r-xp /usr/lib/libexif.so.12.3.3
b3f1d000 b3f32000 r-xp /usr/lib/libtts.so
b3f43000 b3f4b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f5b000 b401b000 r-xp /usr/lib/libdali-core.so.0.0.0
b4026000 b4119000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4139000 b4213000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b422a000 b422c000 r-xp /usr/lib/libboost_system.so.1.51.0
b423c000 b4242000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4252000 b4275000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4286000 b4288000 r-xp /usr/lib/libappsvc.so.0.1.0
b4298000 b429a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42ab000 b42b0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42c7000 b42c9000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42d9000 b42e0000 r-xp /usr/lib/libsensord-share.so
b42f0000 b4308000 r-xp /usr/lib/libsensor.so.1.1.0
b4319000 b431c000 r-xp /usr/lib/libXv.so.1.0.0
b432c000 b4331000 r-xp /usr/lib/libutilX.so.1.1.0
b4341000 b4346000 r-xp /usr/lib/libappcore-common.so.1.1
b4356000 b435d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4370000 b4374000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4385000 b444f000 r-xp /usr/lib/libCOREGL.so.4.0
b4466000 b4469000 r-xp /usr/lib/libuuid.so.1.3.0
b447a000 b4491000 r-xp /usr/lib/libblkid.so.1.1.0
b44a2000 b44a4000 r-xp /usr/lib/libXau.so.6.0.0
b44b4000 b44b7000 r-xp /usr/lib/libEGL.so.1.4
b44bf000 b44c5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44d5000 b44d7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44e8000 b44f6000 r-xp /usr/lib/libGLESv2.so.2.0
b44ff000 b4561000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4576000 b458e000 r-xp /usr/lib/libmount.so.1.1.0
b459f000 b45b3000 r-xp /usr/lib/libxcb.so.1.1.0
b45c4000 b45cb000 r-xp /lib/libcrypt-2.20-2014.11.so
b4603000 b4614000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4625000 b4627000 r-xp /usr/lib/libiri.so
b4637000 b4642000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4653000 b4668000 r-xp /lib/libexpat.so.1.5.2
b467a000 b4738000 r-xp /usr/lib/libcairo.so.2.11200.14
b474b000 b4753000 r-xp /usr/lib/libdrm.so.2.4.0
b4763000 b4766000 r-xp /usr/lib/libdri2.so.0.0.0
b4777000 b47c5000 r-xp /usr/lib/libssl.so.1.0.0
b47da000 b47e6000 r-xp /usr/lib/libeeze.so.1.13.0
b47f6000 b47ff000 r-xp /usr/lib/libethumb.so.1.13.0
b480f000 b4812000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4822000 b49d9000 r-xp /usr/lib/libcrypto.so.1.0.0
b5630000 b5639000 r-xp /usr/lib/libXi.so.6.1.0
b5649000 b564b000 r-xp /usr/lib/libXgesture.so.7.0.0
b565b000 b565f000 r-xp /usr/lib/libXtst.so.6.1.0
b566f000 b5675000 r-xp /usr/lib/libXrender.so.1.3.0
b5685000 b568b000 r-xp /usr/lib/libXrandr.so.2.2.0
b569c000 b569e000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ae000 b56b1000 r-xp /usr/lib/libXfixes.so.3.1.0
b56c1000 b56cc000 r-xp /usr/lib/libXext.so.6.4.0
b56dc000 b56de000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ee000 b56f0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5701000 b57e3000 r-xp /usr/lib/libX11.so.6.3.0
b57f6000 b57fd000 r-xp /usr/lib/libXcursor.so.1.0.2
b580d000 b5825000 r-xp /usr/lib/libudev.so.1.6.0
b5827000 b582a000 r-xp /lib/libattr.so.1.1.0
b583a000 b585a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b585c000 b5861000 r-xp /usr/lib/libffi.so.6.0.2
b5871000 b5889000 r-xp /lib/libz.so.1.2.8
b5899000 b589b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ab000 b5980000 r-xp /usr/lib/libxml2.so.2.9.2
b5995000 b5a30000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a4c000 b5a4f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a5f000 b5a78000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a89000 b5a9a000 r-xp /lib/libresolv-2.20-2014.11.so
b5aae000 b5b28000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b3d000 b5b3f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b4f000 b5b56000 r-xp /usr/lib/libembryo.so.1.13.0
b5b66000 b5b7e000 r-xp /usr/lib/libpng12.so.0.50.0
b5b8f000 b5bb2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd3000 b5be7000 r-xp /usr/lib/libector.so.1.13.0
b5bf8000 b5c10000 r-xp /usr/lib/liblua-5.1.so
b5c21000 b5c78000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8c000 b5cb4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc5000 b5cd8000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ce9000 b5d20000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d31000 b5d3f000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d4f000 b5d57000 r-xp /usr/lib/libtbm.so.1.0.0
b5d67000 b5d74000 r-xp /usr/lib/libeio.so.1.13.0
b5d84000 b5d86000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d96000 b5d9b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dab000 b5dc2000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd4000 b5df4000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e04000 b5e24000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e26000 b5e2c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e3c000 b5e4d000 r-xp /usr/lib/libemotion.so.1.13.0
b5e5e000 b5e65000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e75000 b5e84000 r-xp /usr/lib/libeo.so.1.13.0
b5e95000 b5ea7000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eb8000 b5ebd000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ecd000 b5ee6000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ef6000 b5f13000 r-xp /usr/lib/libeet.so.1.13.0
b5f2c000 b5f74000 r-xp /usr/lib/libeina.so.1.13.0
b5f85000 b5f95000 r-xp /usr/lib/libefl.so.1.13.0
b5fa6000 b608b000 r-xp /usr/lib/libicuuc.so.51.1
b60a8000 b61e8000 r-xp /usr/lib/libicui18n.so.51.1
b61ff000 b6237000 r-xp /usr/lib/libecore_x.so.1.13.0
b6249000 b624c000 r-xp /lib/libcap.so.2.21
b625c000 b6285000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6296000 b629d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62af000 b62e6000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62f7000 b63e2000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63f5000 b646e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6480000 b6485000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6495000 b649f000 r-xp /usr/lib/libvconf.so.0.2.45
b64af000 b64b1000 r-xp /usr/lib/libvasum.so.0.3.1
b64c1000 b64c3000 r-xp /usr/lib/libttrace.so.1.1
b64d3000 b64d6000 r-xp /usr/lib/libiniparser.so.0
b64e6000 b650c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b651c000 b6521000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6532000 b6549000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b655a000 b65c5000 r-xp /lib/libm-2.20-2014.11.so
b65d6000 b65dc000 r-xp /lib/librt-2.20-2014.11.so
b65ed000 b65fa000 r-xp /usr/lib/libunwind.so.8.0.1
b6630000 b6754000 r-xp /lib/libc-2.20-2014.11.so
b6769000 b6782000 r-xp /lib/libgcc_s-4.9.so.1
b6792000 b6874000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6885000 b68af000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c0000 b68fc000 r-xp /usr/lib/libsystemd.so.0.4.0
b68fe000 b6980000 r-xp /usr/lib/libedje.so.1.13.0
b6993000 b69b1000 r-xp /usr/lib/libecore.so.1.13.0
b69d1000 b6b58000 r-xp /usr/lib/libevas.so.1.13.0
b6b8d000 b6ba1000 r-xp /lib/libpthread-2.20-2014.11.so
b6bb5000 b6dea000 r-xp /usr/lib/libelementary.so.1.13.0
b6e18000 b6e1c000 r-xp /usr/lib/libsmack.so.1.0.0
b6e2c000 b6e33000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e43000 b6e45000 r-xp /usr/lib/libdlog.so.0.0.0
b6e55000 b6e58000 r-xp /usr/lib/libbundle.so.0.1.22
b6e68000 b6e6a000 r-xp /lib/libdl-2.20-2014.11.so
b6e7b000 b6e93000 r-xp /usr/lib/libaul.so.0.1.0
b6ea7000 b6eac000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ebd000 b6eca000 r-xp /usr/lib/liblptcp.so
b6edc000 b6ee0000 r-xp /usr/lib/libsys-assert.so
b6ef1000 b6f11000 r-xp /lib/ld-2.20-2014.11.so
b6f22000 b6f27000 r-xp /usr/bin/launchpad-loader
b76b5000 b79e7000 rw-p [heap]
bebf8000 bec19000 rw-p [stack]
b76b5000 b79e7000 rw-p [heap]
bebf8000 bec19000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24203)
Call Stack Count: 1
 0: (0xb66a56f0) [/lib/libc.so.6] + 0x756f0
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
er-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-10 16:54:26.360+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-10 16:54:26.360+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-10 16:54:26.380+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: ok
09-10 16:54:26.380+0600 I/Tizen::App( 1366): (78) > Installation is Completed. [Package = org.example.bluetooth]
09-10 16:54:26.380+0600 I/Tizen::App( 1366): (671) > Enter. package(org.example.bluetooth), installationResult(0)
09-10 16:54:26.420+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.bluetooth]
09-10 16:54:26.420+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.bluetooth]
09-10 16:54:26.420+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-10 16:54:26.420+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-10 16:54:26.420+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.bluetooth]
09-10 16:54:26.440+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 16:54:26.440+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 16:54:26.440+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 16:54:26.440+0600 I/Tizen::App( 1366): (1360) > package(org.example.bluetooth), version(1.0.0), type(tpk), displayName(Timer Messenger), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.bluetooth), storeClient(), appRootPath(/opt/usr/apps/org.example.bluetooth)
09-10 16:54:26.440+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[Timer Messenger] enable[1] system[0]
09-10 16:54:26.440+0600 E/HOME_APPS(  873): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.bluetooth] mdm is not enabled
09-10 16:54:26.460+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[Timer Messenger] enable[1] system[0]
09-10 16:54:26.460+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: UpdateBoxData(1330) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], New icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png]!!!!!
09-10 16:54:26.470+0600 E/util-view(  873): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=22 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-10 16:54:26.470+0600 I/Tizen::App( 1366): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.bluetooth]
09-10 16:54:26.480+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-10 16:54:26.500+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], Loading state:[1]
09-10 16:54:26.530+0600 E/rpm-installer(24302): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 16:54:26.530+0600 E/rpm-installer(24302): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 16:54:26.530+0600 E/rpm-installer(24302): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 16:54:26.540+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 16:54:26.540+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 16:54:26.550+0600 E/PKGMGR_INFO( 1366): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-10 16:54:26.550+0600 I/Tizen::App( 1366): (683) > Application count(1) in this package
09-10 16:54:26.550+0600 I/Tizen::App( 1366): (840) > Enter.
09-10 16:54:26.560+0600 I/Tizen::App( 1366): (703) > Exit.
09-10 16:54:26.560+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [ok], install = [1]
09-10 16:54:26.560+0600 E/PKGMGR_SERVER(24298): pkgmgr-server.c: sighandler(417) > child NORMAL exit [24302]
09-10 16:54:26.570+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 16:54:26.570+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 16:54:26.570+0600 I/Tizen::App( 1366): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.bluetooth.info]
09-10 16:54:26.570+0600 I/Tizen::App( 1366): (131) > Enter
09-10 16:54:26.570+0600 I/Tizen::App( 1366): (137) > org.example.bluetooth does not have launch condition
09-10 16:54:26.570+0600 I/Tizen::App( 1366): (883) > Exit.
09-10 16:54:26.590+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:54:26.610+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb836fbc0]
09-10 16:54:26.610+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:54:26.610+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb836fbc0
09-10 16:54:26.610+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 16:54:26.620+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 16:54:26.620+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 16:54:26.640+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 16:54:26.640+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 16:54:26.660+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:54:26.680+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801c2140 is not stable during recalc loop
09-10 16:54:26.740+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801c2140 is not stable during recalc loop
09-10 16:54:26.750+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:54:26.760+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 16:54:27.161+0600 E/weather-agent(24303): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 16:54:27.161+0600 I/CAPI_APPFW_APPLICATION(24303): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 16:54:27.161+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:54:27.161+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:54:27.161+0600 E/weather-agent(24303): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 16:54:27.311+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 16:54:27.311+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 24303
09-10 16:54:27.311+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[24303] terminate event is forwarded
09-10 16:54:27.311+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:54:27.311+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 24303, ]
09-10 16:54:27.311+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:54:27.311+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 16:54:27.311+0600 I/Tizen::App( 1366): (512) > Not registered pid(24303)
09-10 16:54:27.311+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 16:54:27.311+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:54:27.311+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 24303
09-10 16:54:27.321+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:54:27.321+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 24303.
09-10 16:54:27.601+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:54:27.902+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:54:28.082+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:54:28.142+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:54:28.152+0600 E/PKGMGR_SERVER(24298): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 16:54:28.152+0600 E/PKGMGR_SERVER(24298): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 16:54:30.744+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:54:32.166+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:54:32.206+0600 W/AUL     (24408): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.bluetooth)
09-10 16:54:32.206+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:54:32.216+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-10 16:54:32.226+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-10 16:54:32.226+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:54:32.226+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 24408
09-10 16:54:32.226+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:54:32.246+0600 E/RESOURCED(15587): block.c: block_prelaunch_state(138) > insert data org.example.bluetooth, table num : 1
09-10 16:54:32.246+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:54:32.246+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:54:32.246+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:54:32.246+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.bluetooth has already loaded
09-10 16:54:32.246+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:54:32.246+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:54:32.246+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:54:32.246+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:54:32.266+0600 I/CAPI_APPFW_APPLICATION(24203): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:54:32.266+0600 I/CAPI_APPFW_APPLICATION(24203): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:54:32.296+0600 E/TBM     (24203): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 16:54:32.346+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 24203, appid: org.example.bluetooth
09-10 16:54:32.346+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:54:32.356+0600 W/AUL     (24408): launch.c: app_request_to_launchpad(425) > request cmd(0) result(24203)
09-10 16:54:32.376+0600 E/CAPI_NETWORK_WIFI(24203): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 16:54:32.406+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 16:54:32.616+0600 I/CAPI_NETWORK_WIFI(24203): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 16:54:32.616+0600 D/bluetooth(24203): [wifi_initialize] Success.
09-10 16:54:32.816+0600 I/APP_CORE(24203): appcore-efl.c: __do_app(520) > [APP 24203] Event: RESET State: CREATED
09-10 16:54:32.816+0600 I/CAPI_APPFW_APPLICATION(24203): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:54:32.816+0600 E/EFL     (24203): edje<24203> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:54:32.816+0600 E/EFL     (24203): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:54:32.826+0600 E/EFL     (24203): edje<24203> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:54:32.826+0600 E/EFL     (24203): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:54:32.836+0600 E/EFL     (24203): edje<24203> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:54:32.836+0600 E/EFL     (24203): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:54:32.926+0600 W/APP_CORE(24203): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
09-10 16:54:32.926+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 16:54:33.016+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77a55a8), gem(18), surface(0xb78925e8)
09-10 16:54:33.016+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768f8f0), gem(21), surface(0xb78b59d0)
09-10 16:54:33.027+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77a55a8), gem(18), surface(0xb78ba300)
09-10 16:54:33.027+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76a5628), gem(15), surface(0xb78b9638)
09-10 16:54:33.037+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 16:54:33.037+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 16:54:33.037+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 16:54:33.037+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(24203) status(4)
09-10 16:54:33.087+0600 I/APP_CORE(24203): appcore-efl.c: __do_app(520) > [APP 24203] Event: PAUSE State: CREATED
09-10 16:54:33.087+0600 I/TIZEN_N_EFL_UTIL_WINDOW(24203): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 16:54:33.087+0600 E/APP_CORE(24203): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:54:33.087+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:54:33.087+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb776ed70), gem(13), surface(0xb787e520)
09-10 16:54:33.237+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb775aad0), gem(22), surface(0xb78ae800)
09-10 16:54:33.347+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:54:33.347+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 16:54:33.387+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78756b0), gem(22), surface(0xb787e520)
09-10 16:54:33.397+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 16:54:33.397+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 24203.
09-10 16:54:33.407+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2349
09-10 16:54:33.417+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(24203) status(0)
09-10 16:54:33.417+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:33.807+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77a55a8), gem(13), surface(0xb78b9638)
09-10 16:54:33.907+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15724753
09-10 16:54:34.058+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15724899
09-10 16:54:34.058+0600 E/LOCKSCREEN(  869): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80001:VIEW_GESTURED
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80001 event_info:0
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:4:LKD_EVT_WILL_UNLOCK
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:4 event_info:0
09-10 16:54:34.058+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event_delay(1042) > [lockd_event_delay:1042:W] dealyed event:2:UNLOCK wait for:0.330000
09-10 16:54:34.058+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 16:54:34.088+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:54:34.148+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:54:34.368+0600 I/UXT     (24422): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 16:54:34.388+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:2 event_info:0
09-10 16:54:34.388+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:7
09-10 16:54:34.388+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
09-10 16:54:34.388+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 16:54:34.388+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 16:54:34.388+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:54:34.388+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 16:54:34.388+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 16:54:34.388+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_set(725) > [_lcd_timeout_timer_set:725:W] lcd off timer set:30.000000
09-10 16:54:34.398+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:54:34.398+0600 I/APP_CORE(24203): appcore-efl.c: __do_app(520) > [APP 24203] Event: RESUME State: CREATED
09-10 16:54:34.398+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:54:34.408+0600 I/APP_CORE(24203): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 16:54:34.408+0600 I/APP_CORE(24203): appcore-efl.c: __do_app(637) > [APP 24203] Initial Launching, call the resume_cb
09-10 16:54:34.408+0600 I/CAPI_APPFW_APPLICATION(24203): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:54:34.428+0600 I/Tizen::System( 1366): (259) > Active app [org.exampl], current [com.samsun] 
09-10 16:54:34.428+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:54:34.428+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(4)
09-10 16:54:34.428+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(869)
09-10 16:54:34.428+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: bg
09-10 16:54:34.438+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(24203) status(3)
09-10 16:54:34.438+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:54:34.438+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:54:34.438+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(24203)
09-10 16:54:34.438+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 24203, appid: org.example.bluetooth, status: fg
09-10 16:54:34.458+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:34.458+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [invisible]
09-10 16:54:34.458+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10002:WIN_BECOME_INVISIBLE
09-10 16:54:34.458+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10002 event_info:0
09-10 16:54:34.458+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:54:34.458+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:54:34.458+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:54:34.468+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
09-10 16:54:34.468+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 16:54:34.468+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:54:34.468+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:54:34.468+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 16:54:34.468+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 16:54:34.468+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 16:54:34.468+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 16:54:34.468+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 16:54:34.478+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 16:54:34.478+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:54:34.568+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-10 16:54:34.568+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 16:54:34.568+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:54:34.568+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 16:54:34.568+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 16:54:34.568+0600 E/LOCKSCREEN(  869): background-view.c: background_image_next_set(309) > [background_image_next_set:309:E] fopen wallpaper txt file failed.
09-10 16:54:35.359+0600 E/EFL     (24203): ecore_x<24203> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=15726203
09-10 16:54:35.359+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 16:54:35.359+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 16:54:35.369+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=15726203
09-10 16:54:35.369+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:35.659+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:54:35.669+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:54:35.669+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:54:35.669+0600 E/STARTER (  763): )
09-10 16:54:35.669+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:54:35.669+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:54:35.669+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:54:35.669+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 16:54:35.679+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:54:35.679+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 16:54:35.679+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:54:35.679+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 16:54:35.679+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:54:35.689+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:54:35.689+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:54:35.689+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:54:35.689+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 16:54:35.689+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:54:35.689+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:54:35.699+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:54:35.699+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:54:35.709+0600 E/CAPI_APPFW_APPLICATION(22834): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:54:35.709+0600 E/CAPI_APPFW_APPLICATION(22834): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:54:35.709+0600 E/CAPI_APPFW_APPLICATION(22834): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:54:35.709+0600 E/CAPI_APPFW_APPLICATION(22834): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:54:35.709+0600 E/CAPI_APPFW_APPLICATION(22834): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:54:35.709+0600 I/CAPI_APPFW_APPLICATION(22834): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:54:35.709+0600 I/CAPI_APPFW_APPLICATION(22834): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:54:35.739+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776c550), gem(13), surface(0xb78ae1a0)
09-10 16:54:35.739+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776c550), gem(13), surface(0xb787ceb0)
09-10 16:54:35.739+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:54:35.749+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 16:54:35.749+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 16:54:35.789+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7835780), gem(18), surface(0xb787e520)
09-10 16:54:35.799+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 22834, appid: com.samsung.task-mgr
09-10 16:54:35.799+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:54:35.799+0600 W/TASK_MGR_LITE(22834): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 16:54:35.809+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:35.809+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(22834)
09-10 16:54:35.809+0600 I/GXT_SIB (22834): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:54:35.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:54:35.859+0600 E/RUA     (22834): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 19, ncols : 5
09-10 16:54:35.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:54:35.859+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 24203
09-10 16:54:35.859+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:54:35.859+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:54:35.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 16:54:35.869+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 16:54:35.889+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:54:35.909+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 16:54:35.909+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:54:35.919+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 16:54:35.919+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:54:35.949+0600 I/APP_CORE(22834): appcore-efl.c: __do_app(520) > [APP 22834] Event: RESET State: CREATED
09-10 16:54:35.949+0600 I/CAPI_APPFW_APPLICATION(22834): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:54:35.969+0600 E/EFL     (22834): edje<22834> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:54:35.969+0600 E/EFL     (22834): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:54:35.969+0600 E/EFL     (22834): edje<22834> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:54:35.969+0600 E/EFL     (22834): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:54:35.979+0600 W/APP_CORE(22834): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200003
09-10 16:54:35.999+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=15726835
09-10 16:54:35.999+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 16:54:35.999+0600 E/EFL     (24203): ecore_x<24203> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=15726835
09-10 16:54:35.999+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:54:35.999+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:54:35.999+0600 E/STARTER (  763): )
09-10 16:54:35.999+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:54:36.009+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 16:54:36.009+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:54:36.009+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:54:36.009+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:54:36.079+0600 I/MALI    (22834): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb8ef7248)
09-10 16:54:36.089+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78104c0), gem(23), surface(0xb78a0b60)
09-10 16:54:36.100+0600 I/MALI    (22834): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:54:36.100+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(22834) status(0)
09-10 16:54:36.100+0600 I/APP_CORE(24203): appcore-efl.c: __do_app(520) > [APP 24203] Event: PAUSE State: RUNNING
09-10 16:54:36.100+0600 I/CAPI_APPFW_APPLICATION(24203): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:54:36.100+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:36.100+0600 I/TIZEN_N_EFL_UTIL_WINDOW(24203): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 16:54:36.100+0600 E/APP_CORE(24203): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:54:36.100+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:54:36.110+0600 I/APP_CORE(22834): appcore-efl.c: __do_app(520) > [APP 22834] Event: RESUME State: CREATED
09-10 16:54:36.110+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(22834) status(3)
09-10 16:54:36.110+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:54:36.110+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:54:36.110+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(22834)
09-10 16:54:36.110+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 22834, appid: com.samsung.task-mgr, status: fg
09-10 16:54:36.120+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7841268), gem(22), surface(0xb787ceb0)
09-10 16:54:36.120+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:36.140+0600 I/APP_CORE(22834): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 16:54:36.140+0600 I/APP_CORE(22834): appcore-efl.c: __do_app(637) > [APP 22834] Initial Launching, call the resume_cb
09-10 16:54:36.140+0600 I/CAPI_APPFW_APPLICATION(22834): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:54:36.600+0600 E/EFL     (22834): ecore_x<22834> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15727445
09-10 16:54:36.620+0600 E/EFL     (22834): ecore_x<22834> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15727462
09-10 16:54:36.620+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:54:36.620+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 24203
09-10 16:54:36.620+0600 W/AUL     (22834): launch.c: app_request_to_launchpad(396) > request cmd(4) to(24203)
09-10 16:54:36.620+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 16:54:36.630+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(24203), cmd(4)
09-10 16:54:36.630+0600 I/APP_CORE(24203): appcore-efl.c: __do_app(520) > [APP 24203] Event: TERMINATE State: PAUSED
09-10 16:54:36.630+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:54:36.630+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:54:36.630+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:54:36.630+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:54:36.630+0600 I/TIZEN_N_EFL_UTIL_WINDOW(24203): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 16:54:36.630+0600 E/APP_CORE(24203): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:54:36.630+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:54:36.630+0600 E/APP_CORE(24203): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 16:54:36.630+0600 I/CAPI_APPFW_APPLICATION(24203): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:54:36.640+0600 E/CAPI_NETWORK_BLUETOOTH(24203): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 16:54:36.650+0600 W/AUL     (22834): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 16:54:36.680+0600 I/MALI    (22834): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:54:36.700+0600 I/MALI    (22834): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:54:36.710+0600 I/MALI    (22834): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:54:36.770+0600 E/CAPI_NETWORK_BLUETOOTH(24203): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 16:54:36.770+0600 E/CAPI_NETWORK_BLUETOOTH(24203): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 16:54:36.770+0600 E/bluetooth(24203): [bt_adapter_le_destroy_advertiser] Failed.
09-10 16:54:36.780+0600 I/CAPI_NETWORK_WIFI(24203): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:54:36.780+0600 E/bluetooth(24203): [wifi_deinitialize] Success.
09-10 16:54:36.850+0600 E/EFL     (24203): elementary<24203> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 16:54:36.880+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 16:54:36.880+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 22834.
09-10 16:54:36.930+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:54:36.930+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:54:36.930+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(22834)
09-10 16:54:36.930+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 22834, appid: com.samsung.task-mgr, status: bg
09-10 16:54:36.930+0600 I/CAPI_APPFW_APPLICATION(22834): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:54:36.930+0600 W/TASK_MGR_LITE(22834): task-mgr-lite.c: _pause_app(406) > 
09-10 16:54:36.930+0600 I/CAPI_APPFW_APPLICATION(22834): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:54:36.940+0600 E/TASK_MGR_LITE(22834): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 16:54:36.980+0600 E/APP_CORE(22834): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 16:54:36.980+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:54:36.990+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 16:54:36.990+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:54:36.990+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:54:36.990+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 16:54:36.990+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 16:54:37.000+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77a55a8), gem(19), surface(0xb787e520)
09-10 16:54:37.000+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:37.010+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7725580), gem(21), surface(0xb78ae1a0)
09-10 16:54:37.040+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77a1588), gem(13), surface(0xb787ceb0)
09-10 16:54:37.040+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77a1588), gem(13), surface(0xb78b59d0)
09-10 16:54:37.060+0600 W/CRASH_MANAGER(24028): worker.c: worker_job(1199) > 1124203626162147350487
