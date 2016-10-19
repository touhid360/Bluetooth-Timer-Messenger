S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 22708
Date: 2016-09-10 16:54:12+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 22708, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000058b4
r2   = 0x00000006, r3   = 0xb44964c0
r4   = 0x00000002, r5   = 0xb4496000
r6   = 0xb679b09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb69e3300
ip   = 0x00000000, sp   = 0xbef92f0c
lr   = 0xb6691f18, pc   = 0xb6690b84
cpsr = 0x200d0010

Memory Information
MemTotal:   730440 KB
MemFree:     51348 KB
Buffers:     43492 KB
Cached:     292012 KB
VmPeak:     111380 KB
VmSize:     105008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25552 KB
VmRSS:       25484 KB
VmData:      35100 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 22708 TID = 22708
22708 22711 22813 

Maps Information
b1d36000 b2535000 rw-p [stack:22813]
b2535000 b2546000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2556000 b255b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25e7000 b25ef000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2600000 b2601000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2611000 b2625000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2639000 b263a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b264a000 b264d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b265e000 b265f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b266f000 b2671000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2681000 b2683000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2693000 b26a3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26b3000 b26bf000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28d0000 b28e7000 r-xp /usr/lib/libnetwork.so.0.0.0
b28f8000 b2936000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2947000 b294e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b295f000 b296e000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b297e000 b29b3000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29c6000 b29cc000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29dc000 b29e3000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b05000 b2be8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c1f000 b2c47000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c59000 b3458000 rw-p [stack:22711]
b3458000 b345a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b346a000 b3474000 r-xp /lib/libnss_files-2.20-2014.11.so
b3485000 b348e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b349f000 b34b0000 r-xp /lib/libnsl-2.20-2014.11.so
b34c3000 b34c9000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34da000 b34db000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3503000 b350a000 r-xp /usr/lib/libminizip.so.1.0.0
b351a000 b351f000 r-xp /usr/lib/libstorage.so.0.1
b352f000 b3584000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b359a000 b35ae000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35be000 b3602000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3612000 b361a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b362a000 b365a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b366d000 b3726000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b373a000 b378e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b379f000 b37ba000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37ca000 b388b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b389e000 b38b0000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38c0000 b38c4000 r-xp /usr/lib/libogg.so.0.7.1
b38d4000 b38f6000 r-xp /usr/lib/libvorbis.so.0.4.3
b3906000 b39ea000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a06000 b3a13000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a24000 b3a67000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a7c000 b3ac3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ad4000 b3ada000 r-xp /usr/lib/libjson-c.so.2.0.1
b3aeb000 b3af2000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b02000 b3b42000 r-xp /usr/lib/libmdm.so.1.2.10
b3b52000 b3b5a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b69000 b3b79000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b9a000 b3bfa000 r-xp /usr/lib/libasound.so.2.0.0
b3c0c000 b3c42000 r-xp /usr/lib/libpulse.so.0.16.2
b3c53000 b3c56000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c66000 b3c69000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c79000 b3c7e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c8e000 b3c8f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c9f000 b3caa000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cbe000 b3cc5000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cd5000 b3cdb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3ceb000 b3cf0000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d00000 b3d1b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d2b000 b3d32000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d42000 b3d45000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d56000 b3d84000 r-xp /usr/lib/libidn.so.11.5.44
b3d94000 b3daa000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dbb000 b3dc5000 r-xp /usr/lib/libcares.so.2.1.0
b3dd5000 b3ddf000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3def000 b3df1000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e01000 b3e02000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e12000 b3e16000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e27000 b3e4f000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e60000 b3e89000 r-xp /usr/lib/libturbojpeg.so
b3ea9000 b3eaf000 r-xp /usr/lib/libgif.so.4.1.6
b3ebf000 b3f05000 r-xp /usr/lib/libcurl.so.4.3.0
b3f16000 b3f37000 r-xp /usr/lib/libexif.so.12.3.3
b3f52000 b3f67000 r-xp /usr/lib/libtts.so
b3f78000 b3f80000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f90000 b4050000 r-xp /usr/lib/libdali-core.so.0.0.0
b405b000 b414e000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b416e000 b4248000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b425f000 b4261000 r-xp /usr/lib/libboost_system.so.1.51.0
b4271000 b4277000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4287000 b42aa000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42bb000 b42bd000 r-xp /usr/lib/libappsvc.so.0.1.0
b42cd000 b42cf000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e0000 b42e5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42fc000 b42fe000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b430e000 b4315000 r-xp /usr/lib/libsensord-share.so
b4325000 b433d000 r-xp /usr/lib/libsensor.so.1.1.0
b434e000 b4351000 r-xp /usr/lib/libXv.so.1.0.0
b4361000 b4366000 r-xp /usr/lib/libutilX.so.1.1.0
b4376000 b437b000 r-xp /usr/lib/libappcore-common.so.1.1
b438b000 b4392000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43a5000 b43a9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43ba000 b4484000 r-xp /usr/lib/libCOREGL.so.4.0
b449b000 b449e000 r-xp /usr/lib/libuuid.so.1.3.0
b44af000 b44c6000 r-xp /usr/lib/libblkid.so.1.1.0
b44d7000 b44d9000 r-xp /usr/lib/libXau.so.6.0.0
b44e9000 b44ec000 r-xp /usr/lib/libEGL.so.1.4
b44f4000 b44fa000 r-xp /usr/lib/libxcb-render.so.0.0.0
b450a000 b450c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b451d000 b452b000 r-xp /usr/lib/libGLESv2.so.2.0
b4534000 b4596000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45ab000 b45c3000 r-xp /usr/lib/libmount.so.1.1.0
b45d4000 b45e8000 r-xp /usr/lib/libxcb.so.1.1.0
b45f9000 b4600000 r-xp /lib/libcrypt-2.20-2014.11.so
b4638000 b4649000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b465a000 b465c000 r-xp /usr/lib/libiri.so
b466c000 b4677000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4688000 b469d000 r-xp /lib/libexpat.so.1.5.2
b46af000 b476d000 r-xp /usr/lib/libcairo.so.2.11200.14
b4780000 b4788000 r-xp /usr/lib/libdrm.so.2.4.0
b4798000 b479b000 r-xp /usr/lib/libdri2.so.0.0.0
b47ac000 b47fa000 r-xp /usr/lib/libssl.so.1.0.0
b480f000 b481b000 r-xp /usr/lib/libeeze.so.1.13.0
b482b000 b4834000 r-xp /usr/lib/libethumb.so.1.13.0
b4844000 b4847000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4857000 b4a0e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5665000 b566e000 r-xp /usr/lib/libXi.so.6.1.0
b567e000 b5680000 r-xp /usr/lib/libXgesture.so.7.0.0
b5690000 b5694000 r-xp /usr/lib/libXtst.so.6.1.0
b56a4000 b56aa000 r-xp /usr/lib/libXrender.so.1.3.0
b56ba000 b56c0000 r-xp /usr/lib/libXrandr.so.2.2.0
b56d1000 b56d3000 r-xp /usr/lib/libXinerama.so.1.0.0
b56e3000 b56e6000 r-xp /usr/lib/libXfixes.so.3.1.0
b56f6000 b5701000 r-xp /usr/lib/libXext.so.6.4.0
b5711000 b5713000 r-xp /usr/lib/libXdamage.so.1.1.0
b5723000 b5725000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5736000 b5818000 r-xp /usr/lib/libX11.so.6.3.0
b582b000 b5832000 r-xp /usr/lib/libXcursor.so.1.0.2
b5842000 b585a000 r-xp /usr/lib/libudev.so.1.6.0
b585c000 b585f000 r-xp /lib/libattr.so.1.1.0
b586f000 b588f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5891000 b5896000 r-xp /usr/lib/libffi.so.6.0.2
b58a6000 b58be000 r-xp /lib/libz.so.1.2.8
b58ce000 b58d0000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58e0000 b59b5000 r-xp /usr/lib/libxml2.so.2.9.2
b59ca000 b5a65000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a81000 b5a84000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a94000 b5aad000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5abe000 b5acf000 r-xp /lib/libresolv-2.20-2014.11.so
b5ae3000 b5b5d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b72000 b5b74000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b84000 b5b8b000 r-xp /usr/lib/libembryo.so.1.13.0
b5b9b000 b5bb3000 r-xp /usr/lib/libpng12.so.0.50.0
b5bc4000 b5be7000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c08000 b5c1c000 r-xp /usr/lib/libector.so.1.13.0
b5c2d000 b5c45000 r-xp /usr/lib/liblua-5.1.so
b5c56000 b5cad000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cc1000 b5ce9000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cfa000 b5d0d000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d1e000 b5d55000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d66000 b5d74000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d84000 b5d8c000 r-xp /usr/lib/libtbm.so.1.0.0
b5d9c000 b5da9000 r-xp /usr/lib/libeio.so.1.13.0
b5db9000 b5dbb000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dcb000 b5dd0000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5de0000 b5df7000 r-xp /usr/lib/libefreet.so.1.13.0
b5e09000 b5e29000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e39000 b5e59000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e5b000 b5e61000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e71000 b5e82000 r-xp /usr/lib/libemotion.so.1.13.0
b5e93000 b5e9a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eaa000 b5eb9000 r-xp /usr/lib/libeo.so.1.13.0
b5eca000 b5edc000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eed000 b5ef2000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f02000 b5f1b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f2b000 b5f48000 r-xp /usr/lib/libeet.so.1.13.0
b5f61000 b5fa9000 r-xp /usr/lib/libeina.so.1.13.0
b5fba000 b5fca000 r-xp /usr/lib/libefl.so.1.13.0
b5fdb000 b60c0000 r-xp /usr/lib/libicuuc.so.51.1
b60dd000 b621d000 r-xp /usr/lib/libicui18n.so.51.1
b6234000 b626c000 r-xp /usr/lib/libecore_x.so.1.13.0
b627e000 b6281000 r-xp /lib/libcap.so.2.21
b6291000 b62ba000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62cb000 b62d2000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62e4000 b631b000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b632c000 b6417000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b642a000 b64a3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64b5000 b64ba000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64ca000 b64d4000 r-xp /usr/lib/libvconf.so.0.2.45
b64e4000 b64e6000 r-xp /usr/lib/libvasum.so.0.3.1
b64f6000 b64f8000 r-xp /usr/lib/libttrace.so.1.1
b6508000 b650b000 r-xp /usr/lib/libiniparser.so.0
b651b000 b6541000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6551000 b6556000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6567000 b657e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b658f000 b65fa000 r-xp /lib/libm-2.20-2014.11.so
b660b000 b6611000 r-xp /lib/librt-2.20-2014.11.so
b6622000 b662f000 r-xp /usr/lib/libunwind.so.8.0.1
b6665000 b6789000 r-xp /lib/libc-2.20-2014.11.so
b679e000 b67b7000 r-xp /lib/libgcc_s-4.9.so.1
b67c7000 b68a9000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ba000 b68e4000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68f5000 b6931000 r-xp /usr/lib/libsystemd.so.0.4.0
b6933000 b69b5000 r-xp /usr/lib/libedje.so.1.13.0
b69c8000 b69e6000 r-xp /usr/lib/libecore.so.1.13.0
b6a06000 b6b8d000 r-xp /usr/lib/libevas.so.1.13.0
b6bc2000 b6bd6000 r-xp /lib/libpthread-2.20-2014.11.so
b6bea000 b6e1f000 r-xp /usr/lib/libelementary.so.1.13.0
b6e4d000 b6e51000 r-xp /usr/lib/libsmack.so.1.0.0
b6e61000 b6e68000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e78000 b6e7a000 r-xp /usr/lib/libdlog.so.0.0.0
b6e8a000 b6e8d000 r-xp /usr/lib/libbundle.so.0.1.22
b6e9d000 b6e9f000 r-xp /lib/libdl-2.20-2014.11.so
b6eb0000 b6ec8000 r-xp /usr/lib/libaul.so.0.1.0
b6edc000 b6ee1000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ef2000 b6eff000 r-xp /usr/lib/liblptcp.so
b6f11000 b6f15000 r-xp /usr/lib/libsys-assert.so
b6f26000 b6f46000 r-xp /lib/ld-2.20-2014.11.so
b6f57000 b6f5c000 r-xp /usr/bin/launchpad-loader
b703f000 b73d0000 rw-p [heap]
bef73000 bef94000 rw-p [stack]
b703f000 b73d0000 rw-p [heap]
bef73000 bef94000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22708)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6690b84) [/lib/libc.so.6] + 0x2bb84
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
:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:40.560+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:40.560+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:40.570+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:40.570+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 16:50:40.610+0600 I/ISE_MULTI(  821): isemain.cpp: slot_set_caps_mode(792) > [0;36m[hidden state:false] mode=0[0m
09-10 16:50:40.610+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=1[0m
09-10 16:50:41.010+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15491854
09-10 16:50:41.010+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15491854
09-10 16:50:41.070+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15491917
09-10 16:50:41.080+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:41.080+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:41.080+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:41.080+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:41.080+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=2[0m
09-10 16:50:41.931+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15492781
09-10 16:50:41.931+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15492781
09-10 16:50:42.001+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15492843
09-10 16:50:42.001+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:42.001+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:42.001+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:42.001+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 16:50:42.001+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:42.001+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:42.001+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=3[0m
09-10 16:50:42.001+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:42.001+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:43.202+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15494054
09-10 16:50:43.202+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15494054
09-10 16:50:43.272+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15494115
09-10 16:50:43.272+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:43.272+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:43.272+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:43.272+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=4[0m
09-10 16:50:43.272+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:43.493+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15494342
09-10 16:50:43.493+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15494342
09-10 16:50:43.573+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15494427
09-10 16:50:43.583+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:43.583+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:43.583+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:43.583+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=5[0m
09-10 16:50:43.583+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:44.383+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15495225
09-10 16:50:44.383+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15495225
09-10 16:50:44.464+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15495309
09-10 16:50:44.464+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:44.464+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:44.464+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 16:50:44.464+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:44.464+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:44.464+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:44.464+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:44.464+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:44.464+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=6[0m
09-10 16:50:44.674+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15495526
09-10 16:50:44.674+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15495526
09-10 16:50:44.784+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15495631
09-10 16:50:44.784+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:44.784+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:44.784+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:44.784+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 16:50:44.794+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:45.124+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15495978
09-10 16:50:45.124+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15495978
09-10 16:50:45.194+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15496041
09-10 16:50:45.194+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 16:50:45.194+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 16:50:45.194+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 16:50:45.194+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 16:50:45.194+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 16:50:50.680+0600 E/EFL     (22708): eo<22708> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb7080c38 is not pointing to a valid object. Maybe it has already been freed.
09-10 16:50:50.680+0600 E/EFL     (22708): eo<22708> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7080c38) is an invalid ref.
09-10 16:50:50.740+0600 D/bluetooth(22708): [bt_socket_connect_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
09-10 16:50:52.281+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=15503000
09-10 16:50:52.291+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=15503138
09-10 16:50:52.291+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 16:50:52.291+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 16:50:52.311+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5c00002 FAILED!
09-10 16:50:52.401+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7870d98), gem(24), surface(0xb787e520)
09-10 16:50:52.411+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb781d240), gem(29), surface(0xb78ae1a0)
09-10 16:50:52.421+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 16:50:57.847+0600 D/bluetooth(22708): Callback: Socket of connection - 49.
09-10 16:50:57.847+0600 D/bluetooth(22708): Callback: Role of connection - 2.
09-10 16:50:57.847+0600 D/bluetooth(22708): Callback: Address of connection - 90:00:DB:03:35:2E.
09-10 16:50:57.877+0600 D/bluetooth(22708): Socket fd: 49
09-10 16:50:57.877+0600 D/bluetooth(22708): Data: 
09-10 16:50:57.877+0600 D/bluetooth(22708): Size: 30
09-10 16:51:00.079+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 16:51:00.089+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 4:51 p.m.
09-10 16:51:00.089+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 4:51 p.m."
09-10 16:51:00.089+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 4:51 p.m."
09-10 16:51:00.089+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 16:51:00.089+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145793103 Time: <font_size=31> </font_size> <font_size=31> 4:51 p.m.</font_size></font>"
09-10 16:51:05.214+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15516059
09-10 16:51:05.894+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15516746
09-10 16:51:09.027+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15519873
09-10 16:51:09.308+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15520149
09-10 16:51:17.235+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15528079
09-10 16:51:17.336+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15528182
09-10 16:51:17.336+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 16:51:17.336+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 16:51:17.336+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 16:51:17.336+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 16:51:17.696+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15528539
09-10 16:51:17.816+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15528657
09-10 16:51:18.347+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15529195
09-10 16:51:18.447+0600 E/EFL     (22708): ecore_x<22708> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15529290
09-10 16:51:18.667+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 16:51:41.369+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 16:51:48.366+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:51:48.366+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:51:48.386+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 16:51:48.386+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 16:51:48.386+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 16:51:48.386+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:142fc90
09-10 16:51:48.386+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 16:51:48.386+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 16:51:48.386+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:51:48.396+0600 W/APP_CORE(22708): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 16:51:48.396+0600 I/APP_CORE(22708): appcore-efl.c: __do_app(520) > [APP 22708] Event: PAUSE State: RUNNING
09-10 16:51:48.396+0600 I/CAPI_APPFW_APPLICATION(22708): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:51:48.396+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 16:51:48.396+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:51:48.396+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:51:48.406+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 16:51:48.446+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 16:51:48.936+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b2ca8), gem(14), surface(0xb78ae1a0)
09-10 16:51:48.936+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:51:48.936+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:51:48.946+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 16:51:48.976+0600 I/APP_CORE(22708): appcore-efl.c: __do_app(520) > [APP 22708] Event: PAUSE State: PAUSED
09-10 16:51:48.976+0600 I/TIZEN_N_EFL_UTIL_WINDOW(22708): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 16:51:48.976+0600 E/APP_CORE(22708): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 16:51:48.976+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78a30f0), gem(13), surface(0xb787e520)
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 16:51:48.976+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 16:51:48.976+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 16:51:48.976+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:51:48.976+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:51:48.986+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 16:51:48.986+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 16:51:48.986+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:51:48.986+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(22708) status(4)
09-10 16:51:48.986+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(22708)
09-10 16:51:48.986+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 22708, appid: org.example.bluetooth, status: bg
09-10 16:51:48.986+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:51:48.986+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:51:48.986+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:51:48.986+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:51:48.986+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 16:51:48.996+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 16:51:48.996+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:51:48.996+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:51:48.996+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:51:48.996+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:51:48.996+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:51:49.037+0600 I/TIZEN_N_SOUND_MANAGER(22594): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 16:51:49.037+0600 E/TIZEN_N_SOUND_MANAGER(22594): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:51:49.047+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 16:51:49.047+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:51:49.047+0600 I/TIZEN_N_SOUND_MANAGER(22594): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 16:51:49.047+0600 E/TIZEN_N_SOUND_MANAGER(22594): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:51:49.047+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 16:51:49.047+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 16:51:49.047+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 16:51:49.047+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:51:49.057+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76a5628), gem(15), surface(0xb787ceb0)
09-10 16:51:49.057+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 16:51:49.057+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:51:49.057+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 16:51:49.057+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:51:49.057+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 23363
09-10 16:51:49.067+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:51:49.067+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 16:51:49.067+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:51:49.067+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 16:51:49.107+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 23363
09-10 16:51:49.107+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 23363, appid: com.samsung.weather-m-agent
09-10 16:51:49.107+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(23363)
09-10 16:51:49.107+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 16:51:49.107+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 16:51:49.107+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 16:51:49.107+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 16:51:49.107+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 16:51:49.107+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 16:51:49.117+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:51:49.127+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 16:51:49.127+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 23363.
09-10 16:51:49.127+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 16:51:49.127+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 16:51:49.127+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:51:49.127+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 16:51:49.127+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 16:51:49.177+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 16:51:49.287+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77a1588), gem(18), surface(0xb78ba300)
09-10 16:51:49.387+0600 E/weather-agent(23363): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 16:51:49.397+0600 E/weather-common(23363): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 16:51:49.397+0600 E/weather-agent(23363): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 16:51:49.407+0600 I/MESSAGE_PORT(23363): message-port.c: __initialize(872) > initialize
09-10 16:51:49.417+0600 I/MESSAGE_PORT(23363): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 16:51:49.457+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 16:51:49.457+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 16:51:49.457+0600 I/MESSAGE_PORT(23363): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:51:49.457+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 16:51:49.457+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 16:51:49.457+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 16:51:49.457+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 16:51:49.457+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 16:51:49.457+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 16:51:49.467+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:51:49.467+0600 E/MESSAGE_PORT(23363): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 16:51:49.467+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 16:51:49.467+0600 I/MESSAGE_PORT(23363): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 16:51:49.467+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 16:51:49.477+0600 E/MESSAGE_PORT(23363): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 16:51:49.477+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 16:51:49.477+0600 E/weather-common(23363): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 16:51:49.477+0600 E/weather-agent(23363): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 16:51:49.477+0600 E/weather-agent(23363): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 16:51:49.477+0600 I/MESSAGE_PORT(23363): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 16:51:49.477+0600 I/MESSAGE_PORT(23363): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 16:51:49.497+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:51:49.537+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 16:51:49.537+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 16:51:49.727+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83662c0]
09-10 16:51:49.727+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:51:49.727+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83662c0
09-10 16:51:49.727+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 16:51:49.737+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 16:51:49.737+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 16:51:49.757+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 16:51:49.757+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 16:51:49.767+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:51:49.797+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801a4717 is not stable during recalc loop
09-10 16:51:49.857+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801a4717 is not stable during recalc loop
09-10 16:51:49.857+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:51:49.867+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 16:51:50.478+0600 E/weather-agent(23363): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 16:51:50.478+0600 I/CAPI_APPFW_APPLICATION(23363): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 16:51:50.478+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:51:50.478+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:51:50.478+0600 E/weather-agent(23363): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 16:51:50.638+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 16:51:50.638+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 23363
09-10 16:51:50.638+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[23363] terminate event is forwarded
09-10 16:51:50.638+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:51:50.638+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 23363, ]
09-10 16:51:50.638+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:51:50.638+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 16:51:50.638+0600 I/Tizen::App( 1366): (512) > Not registered pid(23363)
09-10 16:51:50.638+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 16:51:50.638+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:51:50.638+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 23363
09-10 16:51:50.648+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:51:50.648+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 23363.
09-10 16:51:53.401+0600 I/APP_CORE(22708): appcore-efl.c: __do_app(520) > [APP 22708] Event: MEM_FLUSH State: PAUSED
09-10 16:51:55.483+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:52:57.193+0600 I/CAPI_CONTENT_MEDIA_CONTENT(22594): media_content.c: media_content_disconnect(940) > [32m[22594]ref count changed to: 0
09-10 16:52:57.193+0600 I/CAPI_NETWORK_WIFI(22594): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:52:57.223+0600 E/ALARM_MANAGER(22594): alarm-lib-stub.c: _send_alarm_delete_all(434) > alarm_manager_call_alarm_delete_all_sync() failed. return_code[0]
09-10 16:52:57.223+0600 E/ALARM_MANAGER(22594): alarm-lib-stub.c: _send_alarm_delete_all(436) > dbus error message: The connection is closed
09-10 16:54:11.926+0600 E/PKGMGR_SERVER(24021): pkgmgr-server.c: main(2414) > package manager server start
09-10 16:54:11.986+0600 E/PKGMGR  (24019): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 22708
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:54:12.036+0600 W/AUL     (24024): launch.c: app_request_to_launchpad(396) > request cmd(5) to(22708)
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 16:54:12.036+0600 I/APP_CORE(22708): appcore-efl.c: __do_app(520) > [APP 22708] Event: TERMINATE State: PAUSED
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(22708), cmd(4)
09-10 16:54:12.036+0600 W/AUL     (24024): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:54:12.036+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:54:12.046+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:54:12.046+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 16:54:12.046+0600 I/TIZEN_N_EFL_UTIL_WINDOW(22708): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 16:54:12.046+0600 E/APP_CORE(22708): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:54:12.046+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:54:12.046+0600 E/APP_CORE(22708): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 16:54:12.046+0600 I/CAPI_APPFW_APPLICATION(22708): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:54:12.046+0600 E/CAPI_NETWORK_BLUETOOTH(22708): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 16:54:12.056+0600 E/PKGMGR_SERVER(24021): pkgmgr-server.c: sighandler(417) > child NORMAL exit [24024]
09-10 16:54:12.136+0600 E/CAPI_NETWORK_BLUETOOTH(22708): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 16:54:12.136+0600 E/CAPI_NETWORK_BLUETOOTH(22708): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 16:54:12.136+0600 E/bluetooth(22708): [bt_adapter_le_destroy_advertiser] Failed.
09-10 16:54:12.136+0600 I/CAPI_NETWORK_WIFI(22708): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:54:12.136+0600 E/bluetooth(22708): [wifi_deinitialize] Success.
09-10 16:54:12.146+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 16:54:12.146+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:54:12.146+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:54:12.146+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 16:54:12.146+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 16:54:12.156+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:54:12.186+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768f8f0), gem(21), surface(0xb78ae800)
09-10 16:54:12.196+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768f8f0), gem(21), surface(0xb78b59d0)
09-10 16:54:12.206+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78a30f0), gem(13), surface(0xb7890628)
09-10 16:54:12.206+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b2ca8), gem(14), surface(0xb784e4b0)
09-10 16:54:12.206+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:54:12.236+0600 E/EFL     (22708): ecore<22708> lib/ecore/ecore_main.c:1552 _ecore_main_fd_handlers_bads_rem() Removing bad fds
09-10 16:54:12.236+0600 E/EFL     (22708): ecore<22708> lib/ecore/ecore_main.c:1561 _ecore_main_fd_handlers_bads_rem() Found bad fd at index 23
09-10 16:54:12.236+0600 E/EFL     (22708): ecore<22708> lib/ecore/ecore_main.c:1564 _ecore_main_fd_handlers_bads_rem() Fd set for error! calling user
09-10 16:54:12.236+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77a55a8), gem(19), surface(0xb787e520)
09-10 16:54:12.396+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 22708 pgid = 22708
09-10 16:54:12.396+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(22708)
09-10 16:54:12.476+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:54:12.476+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:54:12.476+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:54:12.476+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 22708
09-10 16:54:12.476+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 22708
09-10 16:54:12.476+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[22708] terminate event is forwarded
09-10 16:54:12.476+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:54:12.476+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 22708, ]
09-10 16:54:12.476+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:54:12.476+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 16:54:12.476+0600 I/Tizen::App( 1366): (512) > Not registered pid(22708)
09-10 16:54:12.476+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 16:54:12.476+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:54:12.486+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:54:12.486+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 22708.
09-10 16:54:12.527+0600 W/CRASH_MANAGER(24028): worker.c: worker_job(1199) > 0622708626162147350485
