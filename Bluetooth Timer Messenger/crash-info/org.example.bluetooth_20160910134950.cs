S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 28635
Date: 2016-09-10 13:49:50+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 28635, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb82c80c8
r2   = 0xb42b7000, r3   = 0xb42b7000
r4   = 0xb81afc38, r5   = 0xbe8cb5bc
r6   = 0xb69b5310, r7   = 0xbe8cb41c
r8   = 0xb69b60f4, r9   = 0xb69b60f4
r10  = 0xb69c420c, fp   = 0x00000000
ip   = 0xb29aad14, sp   = 0xbe8c9770
lr   = 0xb299c803, pc   = 0xb66996f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:    107080 KB
Buffers:     34916 KB
Cached:     260444 KB
VmPeak:     108708 KB
VmSize:     104636 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25016 KB
VmRSS:       25016 KB
VmData:      34708 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36244 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 28635 TID = 28635
28635 28637 29361 

Maps Information
b1cf0000 b24ef000 rw-p [stack:29361]
b24ef000 b2500000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2510000 b2515000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25a1000 b25a9000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25ba000 b25bb000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25cb000 b25df000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25f3000 b25f4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2604000 b2607000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2618000 b2619000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2629000 b262b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b263b000 b263d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b264d000 b265d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b266d000 b2679000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b288a000 b28a1000 r-xp /usr/lib/libnetwork.so.0.0.0
b28b2000 b28f0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2901000 b2908000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2919000 b2928000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2938000 b296d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2980000 b2986000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2996000 b29a3000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ac4000 b2ba7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bde000 b2c06000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c18000 b3417000 rw-p [stack:28637]
b3417000 b3419000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3429000 b3433000 r-xp /lib/libnss_files-2.20-2014.11.so
b3444000 b344d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b345e000 b346f000 r-xp /lib/libnsl-2.20-2014.11.so
b3482000 b3488000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3499000 b349a000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34c2000 b34c9000 r-xp /usr/lib/libminizip.so.1.0.0
b34d9000 b34de000 r-xp /usr/lib/libstorage.so.0.1
b34ee000 b3543000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3559000 b356d000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b357d000 b35c1000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35d1000 b35d9000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35e9000 b3619000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b362c000 b36e5000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36f9000 b374d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b375e000 b3779000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3789000 b384a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b385d000 b386f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b387f000 b3883000 r-xp /usr/lib/libogg.so.0.7.1
b3893000 b38b5000 r-xp /usr/lib/libvorbis.so.0.4.3
b38c5000 b39a9000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39c5000 b39d2000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39e3000 b3a26000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a3b000 b3a82000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a93000 b3a99000 r-xp /usr/lib/libjson-c.so.2.0.1
b3aaa000 b3ab1000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ac1000 b3b01000 r-xp /usr/lib/libmdm.so.1.2.10
b3b11000 b3b19000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b28000 b3b38000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b59000 b3bb9000 r-xp /usr/lib/libasound.so.2.0.0
b3bcb000 b3c01000 r-xp /usr/lib/libpulse.so.0.16.2
b3c12000 b3c15000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c25000 b3c28000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c38000 b3c3d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c4d000 b3c4e000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c5e000 b3c69000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c7d000 b3c84000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c94000 b3c9a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3caa000 b3caf000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cbf000 b3cda000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cea000 b3cf1000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d01000 b3d04000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d15000 b3d43000 r-xp /usr/lib/libidn.so.11.5.44
b3d53000 b3d69000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d7a000 b3d84000 r-xp /usr/lib/libcares.so.2.1.0
b3d94000 b3d9e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dae000 b3db0000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dc0000 b3dc1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dd1000 b3dd5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3de6000 b3e0e000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e1f000 b3e48000 r-xp /usr/lib/libturbojpeg.so
b3e68000 b3e6e000 r-xp /usr/lib/libgif.so.4.1.6
b3e7e000 b3ec4000 r-xp /usr/lib/libcurl.so.4.3.0
b3ed5000 b3ef6000 r-xp /usr/lib/libexif.so.12.3.3
b3f11000 b3f26000 r-xp /usr/lib/libtts.so
b3f37000 b3f3f000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f4f000 b400f000 r-xp /usr/lib/libdali-core.so.0.0.0
b401a000 b410d000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b412d000 b4207000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b421e000 b4220000 r-xp /usr/lib/libboost_system.so.1.51.0
b4230000 b4236000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4246000 b4269000 r-xp /usr/lib/libboost_thread.so.1.51.0
b427a000 b427c000 r-xp /usr/lib/libappsvc.so.0.1.0
b428c000 b428e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b429f000 b42a4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42bb000 b42bd000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42cd000 b42d4000 r-xp /usr/lib/libsensord-share.so
b42e4000 b42fc000 r-xp /usr/lib/libsensor.so.1.1.0
b430d000 b4310000 r-xp /usr/lib/libXv.so.1.0.0
b4320000 b4325000 r-xp /usr/lib/libutilX.so.1.1.0
b4335000 b433a000 r-xp /usr/lib/libappcore-common.so.1.1
b434a000 b4351000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4364000 b4368000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4379000 b4443000 r-xp /usr/lib/libCOREGL.so.4.0
b445a000 b445d000 r-xp /usr/lib/libuuid.so.1.3.0
b446e000 b4485000 r-xp /usr/lib/libblkid.so.1.1.0
b4496000 b4498000 r-xp /usr/lib/libXau.so.6.0.0
b44a8000 b44ab000 r-xp /usr/lib/libEGL.so.1.4
b44b3000 b44b9000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44c9000 b44cb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44dc000 b44ea000 r-xp /usr/lib/libGLESv2.so.2.0
b44f3000 b4555000 r-xp /usr/lib/libpixman-1.so.0.28.2
b456a000 b4582000 r-xp /usr/lib/libmount.so.1.1.0
b4593000 b45a7000 r-xp /usr/lib/libxcb.so.1.1.0
b45b8000 b45bf000 r-xp /lib/libcrypt-2.20-2014.11.so
b45f7000 b4608000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4619000 b461b000 r-xp /usr/lib/libiri.so
b462b000 b4636000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4647000 b465c000 r-xp /lib/libexpat.so.1.5.2
b466e000 b472c000 r-xp /usr/lib/libcairo.so.2.11200.14
b473f000 b4747000 r-xp /usr/lib/libdrm.so.2.4.0
b4757000 b475a000 r-xp /usr/lib/libdri2.so.0.0.0
b476b000 b47b9000 r-xp /usr/lib/libssl.so.1.0.0
b47ce000 b47da000 r-xp /usr/lib/libeeze.so.1.13.0
b47ea000 b47f3000 r-xp /usr/lib/libethumb.so.1.13.0
b4803000 b4806000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4816000 b49cd000 r-xp /usr/lib/libcrypto.so.1.0.0
b5624000 b562d000 r-xp /usr/lib/libXi.so.6.1.0
b563d000 b563f000 r-xp /usr/lib/libXgesture.so.7.0.0
b564f000 b5653000 r-xp /usr/lib/libXtst.so.6.1.0
b5663000 b5669000 r-xp /usr/lib/libXrender.so.1.3.0
b5679000 b567f000 r-xp /usr/lib/libXrandr.so.2.2.0
b5690000 b5692000 r-xp /usr/lib/libXinerama.so.1.0.0
b56a2000 b56a5000 r-xp /usr/lib/libXfixes.so.3.1.0
b56b5000 b56c0000 r-xp /usr/lib/libXext.so.6.4.0
b56d0000 b56d2000 r-xp /usr/lib/libXdamage.so.1.1.0
b56e2000 b56e4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56f5000 b57d7000 r-xp /usr/lib/libX11.so.6.3.0
b57ea000 b57f1000 r-xp /usr/lib/libXcursor.so.1.0.2
b5801000 b5819000 r-xp /usr/lib/libudev.so.1.6.0
b581b000 b581e000 r-xp /lib/libattr.so.1.1.0
b582e000 b584e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5850000 b5855000 r-xp /usr/lib/libffi.so.6.0.2
b5865000 b587d000 r-xp /lib/libz.so.1.2.8
b588d000 b588f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b589f000 b5974000 r-xp /usr/lib/libxml2.so.2.9.2
b5989000 b5a24000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a40000 b5a43000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a53000 b5a6c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a7d000 b5a8e000 r-xp /lib/libresolv-2.20-2014.11.so
b5aa2000 b5b1c000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b31000 b5b33000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b43000 b5b4a000 r-xp /usr/lib/libembryo.so.1.13.0
b5b5a000 b5b72000 r-xp /usr/lib/libpng12.so.0.50.0
b5b83000 b5ba6000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc7000 b5bdb000 r-xp /usr/lib/libector.so.1.13.0
b5bec000 b5c04000 r-xp /usr/lib/liblua-5.1.so
b5c15000 b5c6c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c80000 b5ca8000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb9000 b5ccc000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cdd000 b5d14000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d25000 b5d33000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d43000 b5d4b000 r-xp /usr/lib/libtbm.so.1.0.0
b5d5b000 b5d68000 r-xp /usr/lib/libeio.so.1.13.0
b5d78000 b5d7a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d8a000 b5d8f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d9f000 b5db6000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc8000 b5de8000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df8000 b5e18000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e1a000 b5e20000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e30000 b5e41000 r-xp /usr/lib/libemotion.so.1.13.0
b5e52000 b5e59000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e69000 b5e78000 r-xp /usr/lib/libeo.so.1.13.0
b5e89000 b5e9b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eac000 b5eb1000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ec1000 b5eda000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5eea000 b5f07000 r-xp /usr/lib/libeet.so.1.13.0
b5f20000 b5f68000 r-xp /usr/lib/libeina.so.1.13.0
b5f79000 b5f89000 r-xp /usr/lib/libefl.so.1.13.0
b5f9a000 b607f000 r-xp /usr/lib/libicuuc.so.51.1
b609c000 b61dc000 r-xp /usr/lib/libicui18n.so.51.1
b61f3000 b622b000 r-xp /usr/lib/libecore_x.so.1.13.0
b623d000 b6240000 r-xp /lib/libcap.so.2.21
b6250000 b6279000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b628a000 b6291000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62a3000 b62da000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62eb000 b63d6000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e9000 b6462000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6474000 b6479000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6489000 b6493000 r-xp /usr/lib/libvconf.so.0.2.45
b64a3000 b64a5000 r-xp /usr/lib/libvasum.so.0.3.1
b64b5000 b64b7000 r-xp /usr/lib/libttrace.so.1.1
b64c7000 b64ca000 r-xp /usr/lib/libiniparser.so.0
b64da000 b6500000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6510000 b6515000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6526000 b653d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b654e000 b65b9000 r-xp /lib/libm-2.20-2014.11.so
b65ca000 b65d0000 r-xp /lib/librt-2.20-2014.11.so
b65e1000 b65ee000 r-xp /usr/lib/libunwind.so.8.0.1
b6624000 b6748000 r-xp /lib/libc-2.20-2014.11.so
b675d000 b6776000 r-xp /lib/libgcc_s-4.9.so.1
b6786000 b6868000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6879000 b68a3000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b4000 b68f0000 r-xp /usr/lib/libsystemd.so.0.4.0
b68f2000 b6974000 r-xp /usr/lib/libedje.so.1.13.0
b6987000 b69a5000 r-xp /usr/lib/libecore.so.1.13.0
b69c5000 b6b4c000 r-xp /usr/lib/libevas.so.1.13.0
b6b81000 b6b95000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba9000 b6dde000 r-xp /usr/lib/libelementary.so.1.13.0
b6e0c000 b6e10000 r-xp /usr/lib/libsmack.so.1.0.0
b6e20000 b6e27000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e37000 b6e39000 r-xp /usr/lib/libdlog.so.0.0.0
b6e49000 b6e4c000 r-xp /usr/lib/libbundle.so.0.1.22
b6e5c000 b6e5e000 r-xp /lib/libdl-2.20-2014.11.so
b6e6f000 b6e87000 r-xp /usr/lib/libaul.so.0.1.0
b6e9b000 b6ea0000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eb1000 b6ebe000 r-xp /usr/lib/liblptcp.so
b6ed0000 b6ed4000 r-xp /usr/lib/libsys-assert.so
b6ee5000 b6f05000 r-xp /lib/ld-2.20-2014.11.so
b6f16000 b6f1b000 r-xp /usr/bin/launchpad-loader
b816e000 b849d000 rw-p [heap]
be8ab000 be8cc000 rw-p [stack]
b816e000 b849d000 rw-p [heap]
be8ab000 be8cc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28635)
Call Stack Count: 1
 0: (0xb66996f0) [/lib/libc.so.6] + 0x756f0
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
600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(670) > Connection open error NONE
09-10 13:48:27.235+0600 I/CAPI_NETWORK_WIFI(28635): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:48:27.235+0600 I/CAPI_NETWORK_WIFI(27311): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:48:27.245+0600 I/CAPI_NETWORK_CONNECTION(17193): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 13:48:27.245+0600 I/CAPI_NETWORK_CONNECTION(17193): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 13:48:27.245+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 13:48:27.245+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 13:48:27.245+0600 I/CAPI_NETWORK_WIFI( 1366): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:48:27.245+0600 I/CAPI_NETWORK_WIFI(  991): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:48:27.265+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [INIT] : waiting...
09-10 13:48:27.275+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 13:48:27.275+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 13:48:27.275+0600 I/CAPI_NETWORK_WIFI( 1572): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:48:27.275+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 13:48:27.315+0600 I/Tizen::Net::Wifi( 1366): (742) > _WifiService is not registered.
09-10 13:48:27.445+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 13:48:27.445+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 13:48:27.445+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 13:48:27.445+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(697383823) zone(/)
09-10 13:48:27.445+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 13:48:27.445+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 08:48:26 (UTC).
09-10 13:48:27.445+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 13:48:27.445+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[697383823] is removed.
09-10 13:48:27.445+0600 E/PUSHD   ( 1116): io.c: server_recv(270) > Fail to recv using curl
09-10 13:48:27.445+0600 E/PUSHD   ( 1116): proc.c: _receive_packet(2325) > ERROR : invalid return when receiving header [-1]
09-10 13:48:27.445+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 13:48:27.445+0600 W/PUSHD   ( 1116): State transition: [INIT]-> [PING]
09-10 13:48:27.445+0600 W/PUSHD   ( 1116): spp.c: _uds_list_changed_cb(2296) > UDS mode is off
09-10 13:48:27.455+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 13:48:27.465+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 13:48:27.465+0600 E/ALARM_MANAGER( 1116): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(1500), start(10-9-2016, 14:13:27), repeat(0), interval(0), type(-1073741822)
09-10 13:48:27.465+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 13:48:27.465+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 13:48:27.465+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 13:48:27.465+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:48:27.475+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 13:48:27.485+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 13:48:27.485+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:48:27.495+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 13:48:27.505+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 13:48:27.505+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 38
09-10 13:48:27.505+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
09-10 13:48:27.505+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
09-10 13:48:27.505+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1473495207, Sat Sep 10 14:13:27 2016
09-10 13:48:27.505+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1474272699, next duetime: 1473495207
09-10 13:48:27.505+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1474272699)
09-10 13:48:27.505+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1473497306), due_time(1473495207)
09-10 13:48:27.505+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 13:48:27.505+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 08:13:27 (UTC).
09-10 13:48:27.585+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 13:48:27.585+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 13:48:27.585+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 13:48:27.615+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 29365 pgid = 29365
09-10 13:48:27.615+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(29365)
09-10 13:48:27.625+0600 E/Tizen::App( 1366): (703) > Cannot acquire app for 29365.
09-10 13:48:27.635+0600 E/RESOURCED(  688): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.645
09-10 13:48:27.635+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 13:48:27.635+0600 W/PUSHD   ( 1116): State transition: [PING]-> [RUN]
09-10 13:48:27.645+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [RUN] : waiting...
09-10 13:48:27.675+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 13:48:27.675+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 13:48:27.675+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 13:48:27.675+0600 I/Tizen::App( 1366): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 29365.
09-10 13:48:27.675+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 29365
09-10 13:48:27.675+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 29365
09-10 13:48:27.675+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 29365
09-10 13:48:27.685+0600 E/RESOURCED(  688): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.646
09-10 13:48:27.695+0600 E/RESOURCED(  688): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 13:48:28.416+0600 E/EFL     (28635): ecore_x<28635> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=5252707
09-10 13:48:28.426+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 13:48:28.486+0600 E/EFL     (28635): ecore_x<28635> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=5252769
09-10 13:48:28.596+0600 I/UXT     (29455): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 13:48:28.916+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 13:48:28.956+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 13:48:29.016+0600 E/EFL     (28635): ecore_x<28635> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=5253307
09-10 13:48:29.056+0600 E/EFL     (28635): ecore_x<28635> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=5253348
09-10 13:48:29.076+0600 D/bluetooth(28635): Succeeded to get Wi-Fi device state.
09-10 13:48:29.337+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 13:48:29.457+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 13:48:29.517+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 13:48:29.677+0600 E/EFL     (28635): ecore_x<28635> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=5253963
09-10 13:48:29.747+0600 W/INDICATOR(  685): toast_popup.c: _popup_timeout_cb(90) > 
09-10 13:48:29.757+0600 E/EFL     (28635): ecore_x<28635> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=5254038
09-10 13:48:29.857+0600 W/INDICATOR(  685): toast_popup.c: _popup_dismissed_cb(66) > 
09-10 13:48:31.409+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_wifi_state(739) > Wi-Fi state: 2
09-10 13:48:31.409+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:48:31.409+0600 E/CAPI_NETWORK_CONNECTION( 1359): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 13:48:31.409+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:48:31.599+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 13:48:51.739+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 13:48:51.749+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 13:48:51.749+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:51.749+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:51.749+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:51.749+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:51.749+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:52.039+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 13:48:52.740+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 13:48:52.750+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 13:48:52.750+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:52.750+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:52.750+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:52.750+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:52.750+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:55.742+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 13:48:55.752+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 13:48:55.752+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:55.752+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:55.752+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:55.752+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:55.752+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:57.734+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 13:48:57.744+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 13:48:57.744+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:57.744+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:57.744+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:57.744+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:57.744+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:58.725+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 13:48:58.735+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 13:48:58.735+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:58.735+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:58.735+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 13:48:58.735+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:58.735+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 13:48:59.036+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 13:48:59.036+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 13:48:59.056+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 13:48:59.066+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 13:48:59.066+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 13:48:59.066+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 13:48:59.066+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:1279ff0
09-10 13:48:59.066+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 13:48:59.066+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 13:48:59.076+0600 W/APP_CORE(28635): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 13:48:59.076+0600 I/APP_CORE(28635): appcore-efl.c: __do_app(520) > [APP 28635] Event: PAUSE State: RUNNING
09-10 13:48:59.076+0600 I/CAPI_APPFW_APPLICATION(28635): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 13:48:59.076+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 13:48:59.076+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 13:48:59.076+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 13:48:59.076+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 13:48:59.096+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 13:48:59.106+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:48:59.106+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:48:59.106+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 13:48:59.106+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 13:48:59.606+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 13:48:59.606+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 13:48:59.616+0600 I/APP_CORE(28635): appcore-efl.c: __do_app(520) > [APP 28635] Event: PAUSE State: PAUSED
09-10 13:48:59.616+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 13:48:59.616+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76ffeb8), gem(15), surface(0xb786aed8)
09-10 13:48:59.646+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 13:48:59.656+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776f350), gem(21), surface(0xb787cf18)
09-10 13:48:59.666+0600 I/TIZEN_N_EFL_UTIL_WINDOW(28635): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 49
09-10 13:48:59.666+0600 E/APP_CORE(28635): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 13:48:59.666+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 13:48:59.666+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 13:48:59.666+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 13:48:59.666+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 13:48:59.666+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 13:48:59.666+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 13:48:59.676+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 13:48:59.676+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 13:48:59.726+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 13:48:59.726+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 13:48:59.736+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 13:48:59.736+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 13:48:59.756+0600 I/TIZEN_N_SOUND_MANAGER(27311): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 13:48:59.756+0600 E/TIZEN_N_SOUND_MANAGER(27311): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 13:48:59.756+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 13:48:59.756+0600 I/TIZEN_N_SOUND_MANAGER(27311): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 13:48:59.756+0600 E/TIZEN_N_SOUND_MANAGER(27311): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 13:48:59.756+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:48:59.806+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 13:48:59.806+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 13:48:59.816+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7850270), gem(14), surface(0xb789bcc0)
09-10 13:48:59.816+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 13:48:59.816+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 13:48:59.816+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 13:48:59.816+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 13:48:59.816+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 13:48:59.816+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 13:48:59.816+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 13:48:59.826+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:48:59.826+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 13:48:59.826+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 13:48:59.826+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 13:48:59.826+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 13:48:59.826+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 13:48:59.826+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 13:48:59.826+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 13:48:59.826+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 13:48:59.836+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 13:48:59.836+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 13:48:59.836+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 13:48:59.836+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 13:48:59.836+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 13:48:59.836+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 13:48:59.836+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 13:48:59.836+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 13:48:59.846+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 29567
09-10 13:48:59.846+0600 E/RESOURCED(  688): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 13:48:59.846+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7727800), gem(26), surface(0xb789bd78)
09-10 13:48:59.896+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 29567
09-10 13:48:59.896+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 29567, appid: com.samsung.weather-m-agent
09-10 13:48:59.917+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(29567)
09-10 13:48:59.927+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 13:48:59.927+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 13:48:59.927+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 13:48:59.927+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 13:48:59.927+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 13:48:59.927+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 13:48:59.927+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 13:48:59.927+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 29567.
09-10 13:48:59.937+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 13:48:59.937+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 13:48:59.937+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 13:48:59.937+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 13:48:59.937+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 13:49:00.097+0600 E/weather-agent(29567): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 13:49:00.107+0600 E/weather-common(29567): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 13:49:00.107+0600 E/weather-agent(29567): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 13:49:00.117+0600 I/MESSAGE_PORT(29567): message-port.c: __initialize(872) > initialize
09-10 13:49:00.127+0600 I/MESSAGE_PORT(29567): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 13:49:00.167+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 13:49:00.167+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 13:49:00.177+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 13:49:00.177+0600 E/MESSAGE_PORT(29567): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 13:49:00.177+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 13:49:00.177+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 13:49:00.177+0600 I/MESSAGE_PORT(29567): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 13:49:00.177+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 13:49:00.187+0600 E/MESSAGE_PORT(29567): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 13:49:00.187+0600 E/weather-common(29567): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 13:49:00.187+0600 E/weather-agent(29567): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 13:49:00.187+0600 E/weather-agent(29567): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 13:49:00.187+0600 I/MESSAGE_PORT(29567): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 13:49:00.187+0600 I/MESSAGE_PORT(29567): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 13:49:00.187+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:49:00.217+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 13:49:00.257+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 13:49:00.257+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 13:49:00.467+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb839cf90]
09-10 13:49:00.467+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 13:49:00.467+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb839cf90
09-10 13:49:00.467+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 13:49:00.467+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 13:49:00.467+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 13:49:00.497+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 13:49:00.497+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 13:49:00.517+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 13:49:00.537+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80044d7d is not stable during recalc loop
09-10 13:49:00.617+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80044d7d is not stable during recalc loop
09-10 13:49:00.617+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 13:49:00.627+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 13:49:01.198+0600 E/weather-agent(29567): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 13:49:01.198+0600 I/CAPI_APPFW_APPLICATION(29567): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 13:49:01.198+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 13:49:01.198+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 13:49:01.198+0600 E/weather-agent(29567): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 13:49:01.338+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 13:49:01.338+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 29567
09-10 13:49:01.338+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[29567] terminate event is forwarded
09-10 13:49:01.338+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 13:49:01.338+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 29567, ]
09-10 13:49:01.338+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 13:49:01.338+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 13:49:01.338+0600 I/Tizen::App( 1366): (512) > Not registered pid(29567)
09-10 13:49:01.338+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 13:49:01.338+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 13:49:01.338+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 29567
09-10 13:49:01.348+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 13:49:01.348+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 29567.
09-10 13:49:04.081+0600 I/APP_CORE(28635): appcore-efl.c: __do_app(520) > [APP 28635] Event: MEM_FLUSH State: PAUSED
09-10 13:49:06.203+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 13:49:36.042+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 67
09-10 13:49:36.042+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 13:49:36.042+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
09-10 13:49:36.042+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
09-10 13:49:36.052+0600 E/INDICATOR(  685): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
09-10 13:49:50.586+0600 E/PKGMGR_SERVER(29777): pkgmgr-server.c: main(2414) > package manager server start
09-10 13:49:50.646+0600 E/PKGMGR  (29774): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 13:49:50.686+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 13:49:50.686+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 28635
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 13:49:50.696+0600 W/AUL     (29781): launch.c: app_request_to_launchpad(396) > request cmd(5) to(28635)
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 13:49:50.696+0600 I/APP_CORE(28635): appcore-efl.c: __do_app(520) > [APP 28635] Event: TERMINATE State: PAUSED
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(28635), cmd(4)
09-10 13:49:50.696+0600 W/AUL     (29781): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 13:49:50.696+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 13:49:50.696+0600 I/TIZEN_N_EFL_UTIL_WINDOW(28635): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 13:49:50.696+0600 E/APP_CORE(28635): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 13:49:50.706+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 13:49:50.706+0600 E/APP_CORE(28635): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 13:49:50.706+0600 I/CAPI_APPFW_APPLICATION(28635): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 13:49:50.706+0600 E/CAPI_NETWORK_BLUETOOTH(28635): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 13:49:50.716+0600 E/PKGMGR_SERVER(29777): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29781]
09-10 13:49:50.766+0600 E/CAPI_NETWORK_BLUETOOTH(28635): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 13:49:50.766+0600 E/CAPI_NETWORK_BLUETOOTH(28635): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 13:49:50.766+0600 E/bluetooth(28635): [bt_adapter_le_destroy_advertiser] Failed.
09-10 13:49:50.766+0600 I/CAPI_NETWORK_WIFI(28635): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 13:49:50.776+0600 E/bluetooth(28635): [wifi_deinitialize] Success.
09-10 13:49:50.786+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7844b38), gem(18), surface(0xb7877570)
09-10 13:49:50.786+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 13:49:50.786+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 13:49:50.786+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 13:49:50.786+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 13:49:50.786+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 13:49:50.796+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 13:49:50.806+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7844b38), gem(18), surface(0xb788e248)
09-10 13:49:50.816+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776f350), gem(21), surface(0xb78a4140)
09-10 13:49:50.816+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76ffeb8), gem(15), surface(0xb78a7f60)
09-10 13:49:50.856+0600 E/EFL     (28635): elementary<28635> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 13:49:50.876+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7701768), gem(13), surface(0xb789a4c0)
09-10 13:49:51.026+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 28635 pgid = 28635
09-10 13:49:51.026+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(28635)
09-10 13:49:51.126+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb775d568), gem(13), surface(0xb789a4c0)
09-10 13:49:51.167+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 13:49:51.167+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 13:49:51.167+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 13:49:51.167+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[28635] terminate event is forwarded
09-10 13:49:51.167+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 13:49:51.167+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 28635, ]
09-10 13:49:51.167+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 13:49:51.167+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 13:49:51.167+0600 I/Tizen::App( 1366): (512) > Not registered pid(28635)
09-10 13:49:51.167+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 13:49:51.167+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 13:49:51.177+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 28635
09-10 13:49:51.187+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 28635
09-10 13:49:51.217+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 13:49:51.217+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 28635.
09-10 13:49:51.267+0600 W/CRASH_MANAGER(29786): worker.c: worker_job(1199) > 1128635626162147349379
