S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 30216
Date: 2016-09-10 13:52:25+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 30216, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb87d2790
r2   = 0xb434d000, r3   = 0xb434d000
r4   = 0xb86b6c38, r5   = 0xbebde5bc
r6   = 0xb6a4b310, r7   = 0xbebde41c
r8   = 0xb6a4c0f4, r9   = 0xb6a4c0f4
r10  = 0xb6a5a20c, fp   = 0x00000000
ip   = 0xb2a40d14, sp   = 0xbebdc770
lr   = 0xb2a32803, pc   = 0xb672f6f0
cpsr = 0x80030030

Memory Information
MemTotal:   730440 KB
MemFree:    103972 KB
Buffers:     35656 KB
Cached:     262156 KB
VmPeak:     105708 KB
VmSize:     103172 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25036 KB
VmRSS:       25036 KB
VmData:      34708 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36244 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 30216 TID = 30216
30216 30219 30685 

Maps Information
b1d86000 b2585000 rw-p [stack:30685]
b2585000 b2596000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25a6000 b25ab000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2637000 b263f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2650000 b2651000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2661000 b2675000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2689000 b268a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b269a000 b269d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26ae000 b26af000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26bf000 b26c1000 r-xp /usr/lib/libxcb-present.so.0.0.0
b26d1000 b26d3000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26e3000 b26f3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2703000 b270f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2920000 b2937000 r-xp /usr/lib/libnetwork.so.0.0.0
b2948000 b2986000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2997000 b299e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29af000 b29be000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b29ce000 b2a03000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a16000 b2a1c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a2c000 b2a39000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b5a000 b2c3d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c74000 b2c9c000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cae000 b34ad000 rw-p [stack:30219]
b34ad000 b34af000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34bf000 b34c9000 r-xp /lib/libnss_files-2.20-2014.11.so
b34da000 b34e3000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34f4000 b3505000 r-xp /lib/libnsl-2.20-2014.11.so
b3518000 b351e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b352f000 b3530000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3558000 b355f000 r-xp /usr/lib/libminizip.so.1.0.0
b356f000 b3574000 r-xp /usr/lib/libstorage.so.0.1
b3584000 b35d9000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35ef000 b3603000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3613000 b3657000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3667000 b366f000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b367f000 b36af000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36c2000 b377b000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b378f000 b37e3000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37f4000 b380f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b381f000 b38e0000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38f3000 b3905000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3915000 b3919000 r-xp /usr/lib/libogg.so.0.7.1
b3929000 b394b000 r-xp /usr/lib/libvorbis.so.0.4.3
b395b000 b3a3f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a5b000 b3a68000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a79000 b3abc000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ad1000 b3b18000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b29000 b3b2f000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b40000 b3b47000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b57000 b3b97000 r-xp /usr/lib/libmdm.so.1.2.10
b3ba7000 b3baf000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bbe000 b3bce000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bef000 b3c4f000 r-xp /usr/lib/libasound.so.2.0.0
b3c61000 b3c97000 r-xp /usr/lib/libpulse.so.0.16.2
b3ca8000 b3cab000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cbb000 b3cbe000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cce000 b3cd3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3ce3000 b3ce4000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cf4000 b3cff000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d13000 b3d1a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d2a000 b3d30000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d40000 b3d45000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d55000 b3d70000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d80000 b3d87000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d97000 b3d9a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3dab000 b3dd9000 r-xp /usr/lib/libidn.so.11.5.44
b3de9000 b3dff000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e10000 b3e1a000 r-xp /usr/lib/libcares.so.2.1.0
b3e2a000 b3e34000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e44000 b3e46000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e56000 b3e57000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e67000 b3e6b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e7c000 b3ea4000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eb5000 b3ede000 r-xp /usr/lib/libturbojpeg.so
b3efe000 b3f04000 r-xp /usr/lib/libgif.so.4.1.6
b3f14000 b3f5a000 r-xp /usr/lib/libcurl.so.4.3.0
b3f6b000 b3f8c000 r-xp /usr/lib/libexif.so.12.3.3
b3fa7000 b3fbc000 r-xp /usr/lib/libtts.so
b3fcd000 b3fd5000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fe5000 b40a5000 r-xp /usr/lib/libdali-core.so.0.0.0
b40b0000 b41a3000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41c3000 b429d000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42b4000 b42b6000 r-xp /usr/lib/libboost_system.so.1.51.0
b42c6000 b42cc000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42dc000 b42ff000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4310000 b4312000 r-xp /usr/lib/libappsvc.so.0.1.0
b4322000 b4324000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4335000 b433a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4351000 b4353000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4363000 b436a000 r-xp /usr/lib/libsensord-share.so
b437a000 b4392000 r-xp /usr/lib/libsensor.so.1.1.0
b43a3000 b43a6000 r-xp /usr/lib/libXv.so.1.0.0
b43b6000 b43bb000 r-xp /usr/lib/libutilX.so.1.1.0
b43cb000 b43d0000 r-xp /usr/lib/libappcore-common.so.1.1
b43e0000 b43e7000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43fa000 b43fe000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b440f000 b44d9000 r-xp /usr/lib/libCOREGL.so.4.0
b44f0000 b44f3000 r-xp /usr/lib/libuuid.so.1.3.0
b4504000 b451b000 r-xp /usr/lib/libblkid.so.1.1.0
b452c000 b452e000 r-xp /usr/lib/libXau.so.6.0.0
b453e000 b4541000 r-xp /usr/lib/libEGL.so.1.4
b4549000 b454f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b455f000 b4561000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4572000 b4580000 r-xp /usr/lib/libGLESv2.so.2.0
b4589000 b45eb000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4600000 b4618000 r-xp /usr/lib/libmount.so.1.1.0
b4629000 b463d000 r-xp /usr/lib/libxcb.so.1.1.0
b464e000 b4655000 r-xp /lib/libcrypt-2.20-2014.11.so
b468d000 b469e000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46af000 b46b1000 r-xp /usr/lib/libiri.so
b46c1000 b46cc000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46dd000 b46f2000 r-xp /lib/libexpat.so.1.5.2
b4704000 b47c2000 r-xp /usr/lib/libcairo.so.2.11200.14
b47d5000 b47dd000 r-xp /usr/lib/libdrm.so.2.4.0
b47ed000 b47f0000 r-xp /usr/lib/libdri2.so.0.0.0
b4801000 b484f000 r-xp /usr/lib/libssl.so.1.0.0
b4864000 b4870000 r-xp /usr/lib/libeeze.so.1.13.0
b4880000 b4889000 r-xp /usr/lib/libethumb.so.1.13.0
b4899000 b489c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48ac000 b4a63000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ba000 b56c3000 r-xp /usr/lib/libXi.so.6.1.0
b56d3000 b56d5000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e5000 b56e9000 r-xp /usr/lib/libXtst.so.6.1.0
b56f9000 b56ff000 r-xp /usr/lib/libXrender.so.1.3.0
b570f000 b5715000 r-xp /usr/lib/libXrandr.so.2.2.0
b5726000 b5728000 r-xp /usr/lib/libXinerama.so.1.0.0
b5738000 b573b000 r-xp /usr/lib/libXfixes.so.3.1.0
b574b000 b5756000 r-xp /usr/lib/libXext.so.6.4.0
b5766000 b5768000 r-xp /usr/lib/libXdamage.so.1.1.0
b5778000 b577a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b578b000 b586d000 r-xp /usr/lib/libX11.so.6.3.0
b5880000 b5887000 r-xp /usr/lib/libXcursor.so.1.0.2
b5897000 b58af000 r-xp /usr/lib/libudev.so.1.6.0
b58b1000 b58b4000 r-xp /lib/libattr.so.1.1.0
b58c4000 b58e4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58e6000 b58eb000 r-xp /usr/lib/libffi.so.6.0.2
b58fb000 b5913000 r-xp /lib/libz.so.1.2.8
b5923000 b5925000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5935000 b5a0a000 r-xp /usr/lib/libxml2.so.2.9.2
b5a1f000 b5aba000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ad6000 b5ad9000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae9000 b5b02000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b13000 b5b24000 r-xp /lib/libresolv-2.20-2014.11.so
b5b38000 b5bb2000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bc7000 b5bc9000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bd9000 b5be0000 r-xp /usr/lib/libembryo.so.1.13.0
b5bf0000 b5c08000 r-xp /usr/lib/libpng12.so.0.50.0
b5c19000 b5c3c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c5d000 b5c71000 r-xp /usr/lib/libector.so.1.13.0
b5c82000 b5c9a000 r-xp /usr/lib/liblua-5.1.so
b5cab000 b5d02000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d16000 b5d3e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d4f000 b5d62000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d73000 b5daa000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dbb000 b5dc9000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd9000 b5de1000 r-xp /usr/lib/libtbm.so.1.0.0
b5df1000 b5dfe000 r-xp /usr/lib/libeio.so.1.13.0
b5e0e000 b5e10000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e20000 b5e25000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e35000 b5e4c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e5e000 b5e7e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e8e000 b5eae000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eb0000 b5eb6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec6000 b5ed7000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee8000 b5eef000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eff000 b5f0e000 r-xp /usr/lib/libeo.so.1.13.0
b5f1f000 b5f31000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f42000 b5f47000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f57000 b5f70000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f80000 b5f9d000 r-xp /usr/lib/libeet.so.1.13.0
b5fb6000 b5ffe000 r-xp /usr/lib/libeina.so.1.13.0
b600f000 b601f000 r-xp /usr/lib/libefl.so.1.13.0
b6030000 b6115000 r-xp /usr/lib/libicuuc.so.51.1
b6132000 b6272000 r-xp /usr/lib/libicui18n.so.51.1
b6289000 b62c1000 r-xp /usr/lib/libecore_x.so.1.13.0
b62d3000 b62d6000 r-xp /lib/libcap.so.2.21
b62e6000 b630f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6320000 b6327000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6339000 b6370000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6381000 b646c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b647f000 b64f8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b650a000 b650f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b651f000 b6529000 r-xp /usr/lib/libvconf.so.0.2.45
b6539000 b653b000 r-xp /usr/lib/libvasum.so.0.3.1
b654b000 b654d000 r-xp /usr/lib/libttrace.so.1.1
b655d000 b6560000 r-xp /usr/lib/libiniparser.so.0
b6570000 b6596000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a6000 b65ab000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65bc000 b65d3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65e4000 b664f000 r-xp /lib/libm-2.20-2014.11.so
b6660000 b6666000 r-xp /lib/librt-2.20-2014.11.so
b6677000 b6684000 r-xp /usr/lib/libunwind.so.8.0.1
b66ba000 b67de000 r-xp /lib/libc-2.20-2014.11.so
b67f3000 b680c000 r-xp /lib/libgcc_s-4.9.so.1
b681c000 b68fe000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b690f000 b6939000 r-xp /usr/lib/libdbus-1.so.3.8.12
b694a000 b6986000 r-xp /usr/lib/libsystemd.so.0.4.0
b6988000 b6a0a000 r-xp /usr/lib/libedje.so.1.13.0
b6a1d000 b6a3b000 r-xp /usr/lib/libecore.so.1.13.0
b6a5b000 b6be2000 r-xp /usr/lib/libevas.so.1.13.0
b6c17000 b6c2b000 r-xp /lib/libpthread-2.20-2014.11.so
b6c3f000 b6e74000 r-xp /usr/lib/libelementary.so.1.13.0
b6ea2000 b6ea6000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb6000 b6ebd000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ecd000 b6ecf000 r-xp /usr/lib/libdlog.so.0.0.0
b6edf000 b6ee2000 r-xp /usr/lib/libbundle.so.0.1.22
b6ef2000 b6ef4000 r-xp /lib/libdl-2.20-2014.11.so
b6f05000 b6f1d000 r-xp /usr/lib/libaul.so.0.1.0
b6f31000 b6f36000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f47000 b6f54000 r-xp /usr/lib/liblptcp.so
b6f66000 b6f6a000 r-xp /usr/lib/libsys-assert.so
b6f7b000 b6f9b000 r-xp /lib/ld-2.20-2014.11.so
b6fac000 b6fb1000 r-xp /usr/bin/launchpad-loader
b8675000 b89a4000 rw-p [heap]
bebbe000 bebdf000 rw-p [stack]
b8675000 b89a4000 rw-p [heap]
bebbe000 bebdf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30216)
Call Stack Count: 1
 0: (0xb672f6f0) [/lib/libc.so.6] + 0x756f0
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
GER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 08:16:40 (UTC).
09-10 13:51:39.672+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 13:51:39.672+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 13:51:39.702+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 13:51:39.702+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 30691 pgid = 30691
09-10 13:51:39.702+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(30691)
09-10 13:51:39.702+0600 E/Tizen::App( 1366): (703) > Cannot acquire app for 30691.
09-10 13:51:39.712+0600 E/RESOURCED(  688): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.698
09-10 13:51:39.732+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 13:51:39.732+0600 W/PUSHD   ( 1116): State transition: [PING]-> [RUN]
09-10 13:51:39.732+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [RUN] : waiting...
09-10 13:51:39.732+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7859a48), gem(28), surface(0xb789c3a0)
09-10 13:51:39.762+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 13:51:39.762+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 13:51:39.762+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 13:51:39.772+0600 I/Tizen::App( 1366): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 30691.
09-10 13:51:39.772+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 30691
09-10 13:51:39.772+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 30691
09-10 13:51:39.772+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 30691
09-10 13:51:39.782+0600 E/RESOURCED(  688): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.699
09-10 13:51:39.782+0600 E/RESOURCED(  688): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 13:51:40.203+0600 E/EFL     (30216): ecore_x<30216> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=5444495
09-10 13:51:40.333+0600 E/EFL     (30216): ecore_x<30216> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=5444611
09-10 13:51:40.433+0600 I/APP_CORE(  991): appcore-efl.c: __do_app(520) > [APP 991] Event: MEM_FLUSH State: PAUSED
09-10 13:51:40.713+0600 I/UXT     (30817): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 13:51:41.314+0600 I/CAPI_NETWORK_WIFI(30216): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:51:41.314+0600 I/CAPI_NETWORK_WIFI(27311): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:51:41.314+0600 I/CAPI_NETWORK_CONNECTION(17193): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 13:51:41.314+0600 I/CAPI_NETWORK_CONNECTION(17193): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 13:51:41.314+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 13:51:41.314+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 13:51:41.314+0600 I/CAPI_NETWORK_WIFI( 1366): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:51:41.324+0600 I/CAPI_NETWORK_WIFI(  991): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:51:41.374+0600 I/Tizen::Net::Wifi( 1366): (742) > _WifiService is not registered.
09-10 13:51:41.374+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 13:51:41.374+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 13:51:41.374+0600 I/CAPI_NETWORK_WIFI( 1572): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:51:41.394+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:51:41.634+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 13:51:41.664+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=5445951
09-10 13:51:41.664+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 13:51:41.664+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 13:51:41.664+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 13:51:41.674+0600 E/EFL     (30216): ecore_x<30216> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=5445951
09-10 13:51:41.794+0600 W/INDICATOR(  685): toast_popup.c: _popup_timeout_cb(90) > 
09-10 13:51:41.814+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=5446107
09-10 13:51:41.814+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 13:51:41.814+0600 E/EFL     (30216): ecore_x<30216> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=5446107
09-10 13:51:41.824+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 13:51:41.824+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 13:51:41.824+0600 E/STARTER (  763): )
09-10 13:51:41.824+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 13:51:41.824+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 13:51:41.824+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 13:51:41.824+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 13:51:41.875+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 13:51:41.915+0600 W/INDICATOR(  685): toast_popup.c: _popup_dismissed_cb(66) > 
09-10 13:51:42.025+0600 W/STARTER (  763): hw_key.c: _homekey_timer_cb(487) > [_homekey_timer_cb:487] _homekey_timer_cb, homekey count[1], lock state[0]
09-10 13:51:42.025+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 13:51:42.025+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 13:51:42.025+0600 E/STARTER (  763): )
09-10 13:51:42.025+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 13:51:42.025+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 873
09-10 13:51:42.035+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
09-10 13:51:42.035+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 13:51:42.045+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 13:51:42.045+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 13:51:42.045+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 13:51:42.045+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 13:51:42.045+0600 W/AUL     (  648): app_signal.c: aul_send_app_resume_request_signal(470) > send_app_resume_signal, pid: 873, appid: com.samsung.homescreen
09-10 13:51:42.045+0600 W/AUL_AMD (  648): amd_launch.c: __nofork_processing(1431) > __nofork_processing, cmd: 0, pid: 873
09-10 13:51:42.055+0600 W/AUL_AMD (  648): amd_request.c: __send_home_launch_signal(579) > send a home launch signal
09-10 13:51:42.055+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESET State: PAUSED
09-10 13:51:42.055+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 13:51:42.055+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(873), cmd(0)
09-10 13:51:42.055+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(873)
09-10 13:51:42.055+0600 E/STARTER (  763): dbus-util.c: starter_dbus_home_raise_signal_send(227) > [starter_dbus_home_raise_signal_send:227] Sending HOME RAISE signal, result:0
09-10 13:51:42.055+0600 W/CAPI_APPFW_APP_CONTROL(  873): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-10 13:51:42.065+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(572) > Legacy lifecycle: 0
09-10 13:51:42.065+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(574) > [APP 873] App already running, raise the window
09-10 13:51:42.065+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 13:51:42.075+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 13:51:42.075+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 13:51:42.075+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 13:51:42.075+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 13:51:42.075+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 13:51:42.075+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 13:51:42.095+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7724728), gem(18), surface(0xb78ae1a0)
09-10 13:51:42.125+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7756838), gem(13), surface(0xb789c3a0)
09-10 13:51:42.155+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77fd4d0), gem(21), surface(0xb78a7c00)
09-10 13:51:42.155+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77fd4d0), gem(21), surface(0xb78b9cc8)
09-10 13:51:42.165+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 13:51:42.165+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 13:51:42.175+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 13:51:42.175+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 13:51:42.175+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 13:51:42.185+0600 I/APP_CORE(30216): appcore-efl.c: __do_app(520) > [APP 30216] Event: PAUSE State: RUNNING
09-10 13:51:42.185+0600 I/CAPI_APPFW_APPLICATION(30216): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 13:51:42.185+0600 I/TIZEN_N_EFL_UTIL_WINDOW(30216): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 5
09-10 13:51:42.185+0600 E/APP_CORE(30216): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 13:51:42.195+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 13:51:42.195+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7724728), gem(18), surface(0xb78a7c00)
09-10 13:51:42.215+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 13:51:42.215+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 13:51:42.225+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 13:51:42.245+0600 I/TIZEN_N_SOUND_MANAGER(27311): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 13:51:42.245+0600 E/TIZEN_N_SOUND_MANAGER(27311): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 13:51:42.245+0600 I/TIZEN_N_SOUND_MANAGER(27311): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 13:51:42.245+0600 E/TIZEN_N_SOUND_MANAGER(27311): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 13:51:42.245+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:51:42.445+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb786b030), gem(13), surface(0xb78add70)
09-10 13:51:42.565+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 13:51:42.575+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 13:51:42.595+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 13:51:43.686+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 13:51:44.737+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:51:44.737+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:51:44.797+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_wifi_state(739) > Wi-Fi state: 2
09-10 13:51:44.807+0600 E/CAPI_NETWORK_CONNECTION( 1359): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 13:51:44.807+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:51:44.837+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_wifi_state(739) > Wi-Fi state: 2
09-10 13:51:44.837+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:51:44.837+0600 E/CAPI_NETWORK_CONNECTION( 1359): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 13:51:44.837+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:51:47.190+0600 I/APP_CORE(30216): appcore-efl.c: __do_app(520) > [APP 30216] Event: MEM_FLUSH State: PAUSED
09-10 13:52:00.793+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 13:52:00.803+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 1:52 p.m.
09-10 13:52:00.803+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 1:52 p.m."
09-10 13:52:00.803+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 1:52 p.m."
09-10 13:52:00.803+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 13:52:00.803+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147097453 Time: <font_size=31> </font_size> <font_size=31> 1:52 p.m.</font_size></font>"
09-10 13:52:04.687+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 13:52:11.674+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 13:52:11.674+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 13:52:11.694+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 13:52:11.694+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 13:52:11.694+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 13:52:11.704+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 13:52:11.704+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 13:52:11.704+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 13:52:11.704+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:13d6d70
09-10 13:52:11.704+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 13:52:11.704+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 13:52:11.714+0600 W/APP_CORE(  873): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 13:52:11.714+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: RUNNING
09-10 13:52:11.714+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 13:52:11.714+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 13:52:11.714+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 13:52:11.734+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 13:52:11.734+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:52:11.734+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:52:11.734+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 13:52:11.734+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 13:52:12.244+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 13:52:12.254+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 13:52:12.254+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 13:52:12.264+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77aef10), gem(15), surface(0xb78ae1a0)
09-10 13:52:12.284+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: PAUSED
09-10 13:52:12.314+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb786cfc8), gem(13), surface(0xb78925e8)
09-10 13:52:12.324+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 13:52:12.324+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 13:52:12.324+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 13:52:12.334+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 13:52:12.334+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 13:52:12.334+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 13:52:12.334+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 13:52:12.334+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 13:52:12.334+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 13:52:12.334+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 13:52:12.364+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 13:52:12.374+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 13:52:12.374+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 13:52:12.394+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:52:12.404+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 13:52:12.444+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78adc90), gem(18), surface(0xb78ae768)
09-10 13:52:12.444+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 13:52:12.484+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 13:52:12.484+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 13:52:12.494+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 13:52:12.494+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 13:52:12.494+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:52:12.494+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 13:52:12.494+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:52:12.494+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7886b50), gem(14), surface(0xb78ba220)
09-10 13:52:12.494+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 13:52:12.494+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 13:52:12.494+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 13:52:12.494+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 13:52:12.494+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 13:52:12.494+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 13:52:12.504+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 13:52:12.504+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 13:52:12.504+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 13:52:12.504+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 13:52:12.504+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 13:52:12.504+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 13:52:12.504+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 13:52:12.504+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 30916
09-10 13:52:12.514+0600 E/RESOURCED(  688): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 13:52:12.564+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 30916
09-10 13:52:12.564+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 30916, appid: com.samsung.weather-m-agent
09-10 13:52:12.574+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(30916)
09-10 13:52:12.594+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 13:52:12.594+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 30916.
09-10 13:52:12.604+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 13:52:12.604+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 13:52:12.604+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 13:52:12.604+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 13:52:12.604+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 13:52:12.604+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 13:52:12.615+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 13:52:12.615+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 13:52:12.615+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 13:52:12.615+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 13:52:12.615+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 13:52:12.745+0600 E/weather-agent(30916): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 13:52:12.745+0600 E/weather-common(30916): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 13:52:12.745+0600 E/weather-agent(30916): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 13:52:12.755+0600 I/MESSAGE_PORT(30916): message-port.c: __initialize(872) > initialize
09-10 13:52:12.765+0600 I/MESSAGE_PORT(30916): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 13:52:12.795+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 13:52:12.795+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 13:52:12.795+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:52:12.795+0600 E/MESSAGE_PORT(30916): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 13:52:12.795+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 13:52:12.795+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 13:52:12.805+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 13:52:12.805+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:52:12.805+0600 E/MESSAGE_PORT(30916): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 13:52:12.805+0600 E/weather-common(30916): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 13:52:12.805+0600 E/weather-agent(30916): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 13:52:12.805+0600 E/weather-agent(30916): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 13:52:12.805+0600 I/MESSAGE_PORT(30916): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 13:52:12.825+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:52:12.875+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 13:52:12.875+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 13:52:13.085+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8305cf0]
09-10 13:52:13.085+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:52:13.085+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8305cf0
09-10 13:52:13.085+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 13:52:13.085+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 13:52:13.085+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 13:52:13.115+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 13:52:13.115+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 13:52:13.125+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 13:52:13.155+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801609cf is not stable during recalc loop
09-10 13:52:13.215+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801609cf is not stable during recalc loop
09-10 13:52:13.215+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 13:52:13.225+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 13:52:13.816+0600 E/weather-agent(30916): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 13:52:13.816+0600 I/CAPI_APPFW_APPLICATION(30916): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 13:52:13.816+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 13:52:13.816+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 13:52:13.816+0600 E/weather-agent(30916): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 13:52:13.956+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 13:52:13.956+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 30916
09-10 13:52:13.966+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[30916] terminate event is forwarded
09-10 13:52:13.966+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 13:52:13.966+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 30916, ]
09-10 13:52:13.966+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 13:52:13.966+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 13:52:13.966+0600 I/Tizen::App( 1366): (512) > Not registered pid(30916)
09-10 13:52:13.966+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 13:52:13.966+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 13:52:13.966+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 30916
09-10 13:52:13.976+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 13:52:13.976+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 30916.
09-10 13:52:13.976+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 13:52:16.208+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 68
09-10 13:52:16.208+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 13:52:16.208+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
09-10 13:52:16.208+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
09-10 13:52:16.228+0600 E/INDICATOR(  685): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
09-10 13:52:16.719+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: MEM_FLUSH State: PAUSED
09-10 13:52:18.821+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 13:52:25.457+0600 E/PKGMGR_SERVER(31011): pkgmgr-server.c: main(2414) > package manager server start
09-10 13:52:25.517+0600 E/PKGMGR  (31009): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 13:52:25.567+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 13:52:25.567+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 30216
09-10 13:52:25.567+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 13:52:25.567+0600 W/AUL     (31015): launch.c: app_request_to_launchpad(396) > request cmd(5) to(30216)
09-10 13:52:25.567+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 13:52:25.567+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(30216), cmd(4)
09-10 13:52:25.567+0600 I/APP_CORE(30216): appcore-efl.c: __do_app(520) > [APP 30216] Event: TERMINATE State: PAUSED
09-10 13:52:25.577+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 13:52:25.577+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 13:52:25.577+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 13:52:25.577+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 13:52:25.577+0600 W/AUL     (31015): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 13:52:25.577+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 13:52:25.577+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 13:52:25.577+0600 I/TIZEN_N_EFL_UTIL_WINDOW(30216): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 13:52:25.577+0600 E/APP_CORE(30216): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 13:52:25.577+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 13:52:25.577+0600 E/APP_CORE(30216): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 13:52:25.577+0600 I/CAPI_APPFW_APPLICATION(30216): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 13:52:25.577+0600 E/CAPI_NETWORK_BLUETOOTH(30216): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 13:52:25.597+0600 E/PKGMGR_SERVER(31011): pkgmgr-server.c: sighandler(417) > child NORMAL exit [31015]
09-10 13:52:25.637+0600 E/CAPI_NETWORK_BLUETOOTH(30216): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 13:52:25.637+0600 E/CAPI_NETWORK_BLUETOOTH(30216): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 13:52:25.637+0600 E/bluetooth(30216): [bt_adapter_le_destroy_advertiser] Failed.
09-10 13:52:25.647+0600 I/CAPI_NETWORK_WIFI(30216): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 13:52:25.647+0600 E/bluetooth(30216): [wifi_deinitialize] Success.
09-10 13:52:25.697+0600 E/EFL     (30216): elementary<30216> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 13:52:25.847+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 30216 pgid = 30216
09-10 13:52:25.847+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(30216)
09-10 13:52:25.897+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 13:52:25.897+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 13:52:25.897+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 13:52:25.897+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[30216] terminate event is forwarded
09-10 13:52:25.897+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 13:52:25.897+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 30216, ]
09-10 13:52:25.897+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 13:52:25.897+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 13:52:25.897+0600 I/Tizen::App( 1366): (512) > Not registered pid(30216)
09-10 13:52:25.897+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 13:52:25.897+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 13:52:25.897+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 30216
09-10 13:52:25.897+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 30216
09-10 13:52:25.917+0600 E/RESOURCED(  688): datausage-common.c: remove_each_counter(300) > Can't remove counter, due it's not in tree
09-10 13:52:25.917+0600 E/RESOURCED(  688): datausage-common.c: remove_each_counter(300) > Can't remove counter, due it's not in tree
09-10 13:52:25.917+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 13:52:25.917+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 30216.
09-10 13:52:25.948+0600 W/CRASH_MANAGER(31020): worker.c: worker_job(1199) > 1130216626162147349394
