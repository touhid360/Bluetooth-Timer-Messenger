S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 14857
Date: 2016-09-08 14:17:54+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14857, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb75f1208
r2   = 0xb42a6000, r3   = 0xb42a6000
r4   = 0xb75c7c38, r5   = 0xbea895bc
r6   = 0xb69a4310, r7   = 0xbea8941c
r8   = 0xb69a50f4, r9   = 0xb69a50f4
r10  = 0xb69b320c, fp   = 0x00000000
ip   = 0xb2999b74, sp   = 0xbea87770
lr   = 0xb298b673, pc   = 0xb66886f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     30072 KB
Buffers:     29628 KB
Cached:     269944 KB
VmPeak:     110584 KB
VmSize:     108160 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25176 KB
VmRSS:       25176 KB
VmData:      35088 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36244 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14857 TID = 14857
14857 14864 16834 

Maps Information
b1cdf000 b24de000 rw-p [stack:16834]
b24de000 b24ef000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b24ff000 b2504000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2590000 b2598000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25a9000 b25aa000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25ba000 b25ce000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25e2000 b25e3000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b25f3000 b25f6000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2607000 b2608000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2618000 b261a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b262a000 b262c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b263c000 b264c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b265c000 b2668000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2879000 b2890000 r-xp /usr/lib/libnetwork.so.0.0.0
b28a1000 b28df000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b28f0000 b28f7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2908000 b2917000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2927000 b295c000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b296f000 b2975000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2985000 b2992000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ab3000 b2b96000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bcd000 b2bf5000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c07000 b3406000 rw-p [stack:14864]
b3406000 b3408000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3418000 b3422000 r-xp /lib/libnss_files-2.20-2014.11.so
b3433000 b343c000 r-xp /lib/libnss_nis-2.20-2014.11.so
b344d000 b345e000 r-xp /lib/libnsl-2.20-2014.11.so
b3471000 b3477000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3488000 b3489000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34b1000 b34b8000 r-xp /usr/lib/libminizip.so.1.0.0
b34c8000 b34cd000 r-xp /usr/lib/libstorage.so.0.1
b34dd000 b3532000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3548000 b355c000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b356c000 b35b0000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35c0000 b35c8000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35d8000 b3608000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b361b000 b36d4000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36e8000 b373c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b374d000 b3768000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3778000 b3839000 r-xp /usr/lib/libprotobuf.so.9.0.1
b384c000 b385e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b386e000 b3872000 r-xp /usr/lib/libogg.so.0.7.1
b3882000 b38a4000 r-xp /usr/lib/libvorbis.so.0.4.3
b38b4000 b3998000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39b4000 b39c1000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39d2000 b3a15000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a2a000 b3a71000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a82000 b3a88000 r-xp /usr/lib/libjson-c.so.2.0.1
b3a99000 b3aa0000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ab0000 b3af0000 r-xp /usr/lib/libmdm.so.1.2.10
b3b00000 b3b08000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b17000 b3b27000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b48000 b3ba8000 r-xp /usr/lib/libasound.so.2.0.0
b3bba000 b3bf0000 r-xp /usr/lib/libpulse.so.0.16.2
b3c01000 b3c04000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c14000 b3c17000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c27000 b3c2c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c3c000 b3c3d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c4d000 b3c58000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c6c000 b3c73000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c83000 b3c89000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3c99000 b3c9e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cae000 b3cc9000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cd9000 b3ce0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3cf0000 b3cf3000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d04000 b3d32000 r-xp /usr/lib/libidn.so.11.5.44
b3d42000 b3d58000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d69000 b3d73000 r-xp /usr/lib/libcares.so.2.1.0
b3d83000 b3d8d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3d9d000 b3d9f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3daf000 b3db0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dc0000 b3dc4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3dd5000 b3dfd000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e0e000 b3e37000 r-xp /usr/lib/libturbojpeg.so
b3e57000 b3e5d000 r-xp /usr/lib/libgif.so.4.1.6
b3e6d000 b3eb3000 r-xp /usr/lib/libcurl.so.4.3.0
b3ec4000 b3ee5000 r-xp /usr/lib/libexif.so.12.3.3
b3f00000 b3f15000 r-xp /usr/lib/libtts.so
b3f26000 b3f2e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f3e000 b3ffe000 r-xp /usr/lib/libdali-core.so.0.0.0
b4009000 b40fc000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b411c000 b41f6000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b420d000 b420f000 r-xp /usr/lib/libboost_system.so.1.51.0
b421f000 b4225000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4235000 b4258000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4269000 b426b000 r-xp /usr/lib/libappsvc.so.0.1.0
b427b000 b427d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b428e000 b4293000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42aa000 b42ac000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42bc000 b42c3000 r-xp /usr/lib/libsensord-share.so
b42d3000 b42eb000 r-xp /usr/lib/libsensor.so.1.1.0
b42fc000 b42ff000 r-xp /usr/lib/libXv.so.1.0.0
b430f000 b4314000 r-xp /usr/lib/libutilX.so.1.1.0
b4324000 b4329000 r-xp /usr/lib/libappcore-common.so.1.1
b4339000 b4340000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4353000 b4357000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4368000 b4432000 r-xp /usr/lib/libCOREGL.so.4.0
b4449000 b444c000 r-xp /usr/lib/libuuid.so.1.3.0
b445d000 b4474000 r-xp /usr/lib/libblkid.so.1.1.0
b4485000 b4487000 r-xp /usr/lib/libXau.so.6.0.0
b4497000 b449a000 r-xp /usr/lib/libEGL.so.1.4
b44a2000 b44a8000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44b8000 b44ba000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44cb000 b44d9000 r-xp /usr/lib/libGLESv2.so.2.0
b44e2000 b4544000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4559000 b4571000 r-xp /usr/lib/libmount.so.1.1.0
b4582000 b4596000 r-xp /usr/lib/libxcb.so.1.1.0
b45a7000 b45ae000 r-xp /lib/libcrypt-2.20-2014.11.so
b45e6000 b45f7000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4608000 b460a000 r-xp /usr/lib/libiri.so
b461a000 b4625000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4636000 b464b000 r-xp /lib/libexpat.so.1.5.2
b465d000 b471b000 r-xp /usr/lib/libcairo.so.2.11200.14
b472e000 b4736000 r-xp /usr/lib/libdrm.so.2.4.0
b4746000 b4749000 r-xp /usr/lib/libdri2.so.0.0.0
b475a000 b47a8000 r-xp /usr/lib/libssl.so.1.0.0
b47bd000 b47c9000 r-xp /usr/lib/libeeze.so.1.13.0
b47d9000 b47e2000 r-xp /usr/lib/libethumb.so.1.13.0
b47f2000 b47f5000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4805000 b49bc000 r-xp /usr/lib/libcrypto.so.1.0.0
b5613000 b561c000 r-xp /usr/lib/libXi.so.6.1.0
b562c000 b562e000 r-xp /usr/lib/libXgesture.so.7.0.0
b563e000 b5642000 r-xp /usr/lib/libXtst.so.6.1.0
b5652000 b5658000 r-xp /usr/lib/libXrender.so.1.3.0
b5668000 b566e000 r-xp /usr/lib/libXrandr.so.2.2.0
b567f000 b5681000 r-xp /usr/lib/libXinerama.so.1.0.0
b5691000 b5694000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a4000 b56af000 r-xp /usr/lib/libXext.so.6.4.0
b56bf000 b56c1000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d1000 b56d3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e4000 b57c6000 r-xp /usr/lib/libX11.so.6.3.0
b57d9000 b57e0000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f0000 b5808000 r-xp /usr/lib/libudev.so.1.6.0
b580a000 b580d000 r-xp /lib/libattr.so.1.1.0
b581d000 b583d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b583f000 b5844000 r-xp /usr/lib/libffi.so.6.0.2
b5854000 b586c000 r-xp /lib/libz.so.1.2.8
b587c000 b587e000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b588e000 b5963000 r-xp /usr/lib/libxml2.so.2.9.2
b5978000 b5a13000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a2f000 b5a32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a42000 b5a5b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6c000 b5a7d000 r-xp /lib/libresolv-2.20-2014.11.so
b5a91000 b5b0b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b20000 b5b22000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b32000 b5b39000 r-xp /usr/lib/libembryo.so.1.13.0
b5b49000 b5b61000 r-xp /usr/lib/libpng12.so.0.50.0
b5b72000 b5b95000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb6000 b5bca000 r-xp /usr/lib/libector.so.1.13.0
b5bdb000 b5bf3000 r-xp /usr/lib/liblua-5.1.so
b5c04000 b5c5b000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c6f000 b5c97000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca8000 b5cbb000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ccc000 b5d03000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d14000 b5d22000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d32000 b5d3a000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4a000 b5d57000 r-xp /usr/lib/libeio.so.1.13.0
b5d67000 b5d69000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d79000 b5d7e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d8e000 b5da5000 r-xp /usr/lib/libefreet.so.1.13.0
b5db7000 b5dd7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de7000 b5e07000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e09000 b5e0f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e1f000 b5e30000 r-xp /usr/lib/libemotion.so.1.13.0
b5e41000 b5e48000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e58000 b5e67000 r-xp /usr/lib/libeo.so.1.13.0
b5e78000 b5e8a000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e9b000 b5ea0000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb0000 b5ec9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed9000 b5ef6000 r-xp /usr/lib/libeet.so.1.13.0
b5f0f000 b5f57000 r-xp /usr/lib/libeina.so.1.13.0
b5f68000 b5f78000 r-xp /usr/lib/libefl.so.1.13.0
b5f89000 b606e000 r-xp /usr/lib/libicuuc.so.51.1
b608b000 b61cb000 r-xp /usr/lib/libicui18n.so.51.1
b61e2000 b621a000 r-xp /usr/lib/libecore_x.so.1.13.0
b622c000 b622f000 r-xp /lib/libcap.so.2.21
b623f000 b6268000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6279000 b6280000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6292000 b62c9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62da000 b63c5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d8000 b6451000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6463000 b6468000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6478000 b6482000 r-xp /usr/lib/libvconf.so.0.2.45
b6492000 b6494000 r-xp /usr/lib/libvasum.so.0.3.1
b64a4000 b64a6000 r-xp /usr/lib/libttrace.so.1.1
b64b6000 b64b9000 r-xp /usr/lib/libiniparser.so.0
b64c9000 b64ef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64ff000 b6504000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6515000 b652c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b653d000 b65a8000 r-xp /lib/libm-2.20-2014.11.so
b65b9000 b65bf000 r-xp /lib/librt-2.20-2014.11.so
b65d0000 b65dd000 r-xp /usr/lib/libunwind.so.8.0.1
b6613000 b6737000 r-xp /lib/libc-2.20-2014.11.so
b674c000 b6765000 r-xp /lib/libgcc_s-4.9.so.1
b6775000 b6857000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6868000 b6892000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a3000 b68df000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e1000 b6963000 r-xp /usr/lib/libedje.so.1.13.0
b6976000 b6994000 r-xp /usr/lib/libecore.so.1.13.0
b69b4000 b6b3b000 r-xp /usr/lib/libevas.so.1.13.0
b6b70000 b6b84000 r-xp /lib/libpthread-2.20-2014.11.so
b6b98000 b6dcd000 r-xp /usr/lib/libelementary.so.1.13.0
b6dfb000 b6dff000 r-xp /usr/lib/libsmack.so.1.0.0
b6e0f000 b6e16000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e26000 b6e28000 r-xp /usr/lib/libdlog.so.0.0.0
b6e38000 b6e3b000 r-xp /usr/lib/libbundle.so.0.1.22
b6e4b000 b6e4d000 r-xp /lib/libdl-2.20-2014.11.so
b6e5e000 b6e76000 r-xp /usr/lib/libaul.so.0.1.0
b6e8a000 b6e8f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea0000 b6ead000 r-xp /usr/lib/liblptcp.so
b6ebf000 b6ec3000 r-xp /usr/lib/libsys-assert.so
b6ed4000 b6ef4000 r-xp /lib/ld-2.20-2014.11.so
b6f05000 b6f0a000 r-xp /usr/bin/launchpad-loader
b7586000 b7914000 rw-p [heap]
bea69000 bea8a000 rw-p [stack]
b7586000 b7914000 rw-p [heap]
bea69000 bea8a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14857)
Call Stack Count: 1
 0: (0xb66886f0) [/lib/libc.so.6] + 0x756f0
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
 877
09-08 14:14:32.058+0600 W/AUL     (  652): app_signal.c: aul_send_app_resume_request_signal(470) > send_app_resume_signal, pid: 14857, appid: org.example.bluetooth
09-08 14:14:32.058+0600 W/AUL_AMD (  652): amd_launch.c: __nofork_processing(1431) > __nofork_processing, cmd: 1, pid: 14857
09-08 14:14:32.058+0600 W/AUL_AMD (  652): amd_launch.c: _resume_app(943) > resume done
09-08 14:14:32.068+0600 W/AUL_AMD (  652): amd_launch.c: __reply_handler(1102) > listen fd(26) , send fd(25), pid(14857), cmd(3)
09-08 14:14:32.068+0600 W/AUL     (  877): launch.c: app_request_to_launchpad(425) > request cmd(1) result(14857)
09-08 14:14:32.068+0600 E/AUL     (  652): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-08 14:14:32.078+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3367) > pid(14857) status(3)
09-08 14:14:32.078+0600 W/AUL     (  652): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(14857)
09-08 14:14:32.078+0600 W/AUL     (  652): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 14857, appid: org.example.bluetooth, status: fg
09-08 14:14:32.098+0600 E/AUL     (  652): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-08 14:14:32.128+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb85cabf0), gem(11), surface(0xb8646468)
09-08 14:14:32.138+0600 E/EFL     (14857): edje<14857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 14:14:32.138+0600 E/EFL     (14857): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 14:14:32.138+0600 E/EFL     (14857): edje<14857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 14:14:32.138+0600 E/EFL     (14857): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 14:14:32.178+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb85c2ef0), gem(12), surface(0xb8688a50)
09-08 14:14:32.188+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb85c2ef0), gem(12), surface(0xb8668770)
09-08 14:14:32.188+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb85ed120), gem(22), surface(0xb868d238)
09-08 14:14:32.188+0600 E/EFL     (  274): eo<274> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 14:14:32.188+0600 E/EFL     (  274): eo<274> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 14:14:32.198+0600 I/Tizen::System( 1296): (259) > Active app [org.exampl], current [com.samsun] 
09-08 14:14:32.198+0600 I/Tizen::Io( 1296): (729) > Entry not found
09-08 14:14:32.208+0600 I/APP_CORE(  877): appcore-efl.c: __do_app(520) > [APP 877] Event: PAUSE State: RUNNING
09-08 14:14:32.208+0600 I/CAPI_APPFW_APPLICATION(  877): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 14:14:32.208+0600 E/cluster-home(  877): homescreen.cpp: OnPause(260) >  app pause
09-08 14:14:32.218+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3367) > pid(877) status(4)
09-08 14:14:32.218+0600 W/AUL     (  652): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(877)
09-08 14:14:32.218+0600 W/AUL     (  652): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 877, appid: com.samsung.homescreen, status: bg
09-08 14:14:32.228+0600 I/Tizen::System( 1296): (157) > change brightness system value.
09-08 14:14:32.238+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 15
09-08 14:14:32.258+0600 I/APP_CORE(14857): appcore-efl.c: __do_app(520) > [APP 14857] Event: RESUME State: PAUSED
09-08 14:14:32.258+0600 I/CAPI_APPFW_APPLICATION(14857): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 14:14:32.258+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb85cabf0), gem(11), surface(0xb8668828)
09-08 14:14:32.529+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3367) > pid(14857) status(0)
09-08 14:14:32.529+0600 E/AUL     (  652): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-08 14:14:33.590+0600 E/EFL     (14857): ecore_x<14857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3178781
09-08 14:14:33.640+0600 E/EFL     (14857): ecore_x<14857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3178808
09-08 14:14:33.680+0600 E/CAPI_NETWORK_WIFI(14857): libnetwork.c: _wifi_libnet_get_wifi_device_state(1177) > Failed to get technology properties
09-08 14:14:33.680+0600 E/bluetooth(14857): [wifi_is_activated] failed
09-08 14:14:33.680+0600 D/bluetooth(14857): Failed to get Wi-Fi device state.
09-08 14:14:33.680+0600 E/CAPI_NETWORK_WIFI(14857): net_wifi.c: wifi_activate(110) > Not initialized
09-08 14:14:33.680+0600 E/bluetooth(14857): [wifi_activate] failed -38
09-08 14:14:35.241+0600 E/EFL     (14857): ecore_x<14857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3180436
09-08 14:14:35.271+0600 E/EFL     (14857): ecore_x<14857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3180466
09-08 14:14:35.842+0600 E/EFL     (14857): ecore_x<14857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=3180963
09-08 14:14:35.842+0600 E/EFL     (14857): ecore_x<14857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=3181034
09-08 14:14:35.852+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3367) > pid(877) status(3)
09-08 14:14:35.852+0600 W/AUL_AMD (  652): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 14:14:35.852+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-08 14:14:35.852+0600 W/AUL     (  652): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(877)
09-08 14:14:35.852+0600 W/AUL     (  652): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 877, appid: com.samsung.homescreen, status: fg
09-08 14:14:35.872+0600 E/AUL     (  652): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-08 14:14:35.882+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8673d60), gem(11), surface(0xb865d0e8)
09-08 14:14:35.902+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8673d60), gem(11), surface(0xb8692b68)
09-08 14:14:35.942+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8641dd0), gem(22), surface(0xb8665148)
09-08 14:14:35.942+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8641dd0), gem(22), surface(0xb86914e8)
09-08 14:14:35.952+0600 E/EFL     (  274): eo<274> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 14:14:35.952+0600 E/EFL     (  274): eo<274> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 14:14:35.962+0600 I/APP_CORE(  877): appcore-efl.c: __do_app(520) > [APP 877] Event: RESUME State: PAUSED
09-08 14:14:35.962+0600 I/CAPI_APPFW_APPLICATION(  877): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-08 14:14:35.962+0600 E/cluster-home(  877): homescreen.cpp: OnResume(233) >  app resume
09-08 14:14:35.972+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3367) > pid(14857) status(4)
09-08 14:14:35.972+0600 W/AUL     (  652): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(14857)
09-08 14:14:35.972+0600 W/AUL     (  652): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 14857, appid: org.example.bluetooth, status: bg
09-08 14:14:36.002+0600 I/Tizen::System( 1296): (259) > Active app [com.samsun], current [org.exampl] 
09-08 14:14:36.002+0600 I/Tizen::Io( 1296): (729) > Entry not found
09-08 14:14:36.012+0600 I/MALI    (  877): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-08 14:14:36.012+0600 I/Tizen::System( 1296): (157) > change brightness system value.
09-08 14:14:36.012+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8652110), gem(12), surface(0xb8665148)
09-08 14:14:36.042+0600 E/weather-widget( 1416): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-08 14:14:36.052+0600 I/TIZEN_N_SOUND_MANAGER(15173): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-08 14:14:36.052+0600 E/TIZEN_N_SOUND_MANAGER(15173): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 14:14:36.052+0600 I/TIZEN_N_SOUND_MANAGER(15173): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-08 14:14:36.052+0600 E/TIZEN_N_SOUND_MANAGER(15173): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-08 14:14:36.062+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 15
09-08 14:14:36.102+0600 E/weather-widget( 1416): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-08 14:14:36.122+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 36
09-08 14:14:36.132+0600 I/APP_CORE(14857): appcore-efl.c: __do_app(520) > [APP 14857] Event: PAUSE State: RUNNING
09-08 14:14:36.132+0600 I/CAPI_APPFW_APPLICATION(14857): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 14:14:36.132+0600 I/TIZEN_N_EFL_UTIL_WINDOW(14857): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-08 14:14:36.132+0600 E/APP_CORE(14857): appcore-efl.c: _capture_and_make_file(1631) > win[7200002] widget[480] height[800]
09-08 14:14:36.142+0600 E/weather-common( 1416): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-08 14:14:36.142+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 33
09-08 14:14:36.182+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_create(442) > New handle created[0xb7471b18]
09-08 14:14:36.182+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_get_type(496) > Connected Network = 0
09-08 14:14:36.182+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-08 14:14:36.182+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-08 14:14:36.182+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_destroy(460) > Destroy handle: 0xb7471b18
09-08 14:14:36.192+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-08 14:14:36.192+0600 E/weather-widget( 1416): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-08 14:14:36.192+0600 E/weather-widget( 1416): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-08 14:14:36.192+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-08 14:14:36.192+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-08 14:14:36.192+0600 W/AUL     ( 1416): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1416, appid: com.samsung.weather-m-widget, status: fg
09-08 14:14:36.222+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb859fa70), gem(12), surface(0xb86914e8)
09-08 14:14:36.332+0600 I/MALI    (  877): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-08 14:14:36.342+0600 I/MALI    (  877): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-08 14:14:36.352+0600 I/MALI    (  877): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-08 14:14:36.543+0600 E/EFL     (  877): ecore_x<877> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=3181704
09-08 14:14:36.543+0600 E/cluster-view(  877): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
09-08 14:14:36.543+0600 E/EFL     (  877): ecore_x<877> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=3181735
09-08 14:14:36.543+0600 E/cluster-view(  877): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
09-08 14:14:36.543+0600 W/cluster-home(  877): cluster-data-provider.cpp: OnMainScrollStarted(4740) >  Main Scroll Started
09-08 14:14:36.543+0600 W/cluster-home(  877): cluster-data-provider.cpp: OnMainScrollStarted(4742) >  Main Scroll Started Done
09-08 14:14:36.563+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-08 14:14:36.563+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-08 14:14:36.563+0600 W/AUL     ( 1416): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1416, appid: com.samsung.weather-m-widget, status: bg
09-08 14:14:36.723+0600 W/cluster-home(  877): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed
09-08 14:14:36.723+0600 W/cluster-home(  877): cluster-data-provider.cpp: OnMainScrollCompleted(4753) >  Main Scroll Completed Done
09-08 14:14:36.733+0600 E/weather-widget( 1416): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-08 14:14:36.753+0600 E/weather-widget( 1416): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-08 14:14:36.763+0600 E/weather-common( 1416): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-08 14:14:36.773+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_create(442) > New handle created[0xb7396ed0]
09-08 14:14:36.773+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_get_type(496) > Connected Network = 0
09-08 14:14:36.773+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-08 14:14:36.773+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-08 14:14:36.773+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_destroy(460) > Destroy handle: 0xb7396ed0
09-08 14:14:36.783+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-08 14:14:36.783+0600 E/weather-widget( 1416): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-08 14:14:36.783+0600 E/weather-widget( 1416): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-08 14:14:36.783+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-08 14:14:36.783+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-08 14:14:36.783+0600 W/AUL     ( 1416): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1416, appid: com.samsung.weather-m-widget, status: fg
09-08 14:14:41.127+0600 I/APP_CORE(14857): appcore-efl.c: __do_app(520) > [APP 14857] Event: MEM_FLUSH State: PAUSED
09-08 14:14:59.525+0600 I/Tizen::System( 1296): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-08 14:15:00.776+0600 I/INDICATOR(  689): clock.c: indicator_clock_changed_cb(195) > ""
09-08 14:15:00.776+0600 E/UXT     (  689): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 2:15 p.m.
09-08 14:15:00.776+0600 I/INDICATOR(  689): clock.c: getTimeFormatted(176) > "time format : 2:15 p.m."
09-08 14:15:00.776+0600 I/INDICATOR(  689): clock.c: indicator_clock_changed_cb(244) > "time format : 2:15 p.m."
09-08 14:15:00.776+0600 W/INDICATOR(  689): clock.c: indicator_clock_changed_cb(272) > 
09-08 14:15:00.786+0600 I/INDICATOR(  689): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146658908 Time: <font_size=31> </font_size> <font_size=31> 2:15 p.m.</font_size></font>"
09-08 14:15:06.532+0600 W/LOCKSCREEN(  874): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-08 14:15:06.532+0600 W/LOCKSCREEN(  874): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-08 14:15:06.532+0600 W/LOCKSCREEN(  874): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-08 14:15:06.532+0600 W/LOCKSCREEN(  874): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:1528de0
09-08 14:15:06.532+0600 W/LOCKSCREEN(  874): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-08 14:15:06.532+0600 W/LOCKSCREEN(  874): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-08 14:15:06.532+0600 E/LOCKSCREEN(  874): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 14:15:06.532+0600 E/LOCKSCREEN(  874): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-08 14:15:06.542+0600 E/VCONF   (16113): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-08 14:15:06.542+0600 E/VCONF   (16113): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-08 14:15:06.542+0600 E/LOCKSCREEN(  874): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-08 14:15:06.552+0600 E/VOLUME  (  993): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-08 14:15:06.552+0600 E/VOLUME  (  993): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-08 14:15:06.562+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb864fd88), gem(15), surface(0xb860d6a8)
09-08 14:15:06.592+0600 I/APP_CORE(  877): appcore-efl.c: __do_app(520) > [APP 877] Event: PAUSE State: RUNNING
09-08 14:15:06.592+0600 I/CAPI_APPFW_APPLICATION(  877): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-08 14:15:06.592+0600 E/cluster-home(  877): homescreen.cpp: OnPause(260) >  app pause
09-08 14:15:06.592+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-08 14:15:06.592+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-08 14:15:06.592+0600 W/AUL     ( 1416): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1416, appid: com.samsung.weather-m-widget, status: bg
09-08 14:15:06.602+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3367) > pid(874) status(3)
09-08 14:15:06.632+0600 W/INDICATOR(  689): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-08 14:15:07.102+0600 W/AUL_AMD (  652): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-08 14:15:07.102+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-08 14:15:07.102+0600 W/AUL     (  652): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(874)
09-08 14:15:07.102+0600 W/AUL     (  652): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 874, appid: com.samsung.lockscreen, status: fg
09-08 14:15:07.112+0600 E/cluster-home(  877): homescreen.cpp: OnPause(260) >  app pause
09-08 14:15:07.122+0600 E/AUL     (  652): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-08 14:15:07.122+0600 W/AUL_AMD (  652): amd_launch.c: __e17_status_handler(3367) > pid(877) status(4)
09-08 14:15:07.122+0600 W/AUL     (  652): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(877)
09-08 14:15:07.122+0600 W/AUL     (  652): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 877, appid: com.samsung.homescreen, status: bg
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-08 14:15:07.142+0600 E/LOCKSCREEN(  874): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-08 14:15:07.142+0600 W/LOCKSCREEN(  874): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-08 14:15:07.142+0600 E/VCONF   (16113): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-08 14:15:07.142+0600 E/VCONF   (16113): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-08 14:15:07.142+0600 E/LOCKSCREEN(  874): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-08 14:15:07.142+0600 W/APP_CORE(  874): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-08 14:15:07.152+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb84bcd00), gem(11), surface(0xb86929d0)
09-08 14:15:07.152+0600 E/EFL     (  274): eo<274> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 14:15:07.152+0600 E/EFL     (  274): eo<274> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-08 14:15:07.152+0600 E/EFL     (  874): edje<874> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 14:15:07.152+0600 E/EFL     (  874): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 14:15:07.152+0600 E/EFL     (  874): edje<874> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-08 14:15:07.152+0600 E/EFL     (  874): By the power of Grayskull, your previous Embryo stack is now broken!
09-08 14:15:07.162+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8668468), gem(14), surface(0xb8692df8)
09-08 14:15:07.172+0600 W/LOCKSCREEN(  874): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-08 14:15:07.172+0600 W/LOCKSCREEN(  874): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-08 14:15:07.172+0600 W/LOCKSCREEN(  874): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-08 14:15:07.172+0600 W/LOCKSCREEN(  874): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-08 14:15:07.172+0600 W/LOCKSCREEN(  874): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-08 14:15:07.172+0600 W/LOCKSCREEN(  874): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-08 14:15:07.172+0600 E/VOLUME  (  993): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-08 14:15:07.172+0600 E/VOLUME  (  993): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-08 14:15:07.182+0600 W/AUL     (  874): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-08 14:15:07.192+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 0
09-08 14:15:07.192+0600 W/AUL_AMD (  652): amd_launch.c: _start_app(2527) > caller pid : 874
09-08 14:15:07.192+0600 I/AUL_AMD (  652): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-08 14:15:07.192+0600 W/AUL_AMD (  652): amd_launch.c: _start_app(3262) > loading shared rule
09-08 14:15:07.192+0600 I/SHAREDRULE_CLIENT(  652): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-08 14:15:07.192+0600 I/SHAREDRULE_CLIENT(  652): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-08 14:15:07.192+0600 I/SHAREDRULE_CLIENT(  652): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-08 14:15:07.202+0600 W/AUL_AMD (  652): amd_launch.c: start_process(648) > child process: 17319
09-08 14:15:07.202+0600 I/Tizen::System( 1296): (259) > Active app [com.samsun], current [com.samsun] 
09-08 14:15:07.202+0600 I/Tizen::System( 1296): (273) > Current App[com.samsun] is already actived.
09-08 14:15:07.202+0600 E/RESOURCED(  698): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-08 14:15:07.222+0600 I/APP_CORE(  689): appcore-efl.c: __do_app(520) > [APP 689] Event: MEM_FLUSH State: CREATED
09-08 14:15:07.222+0600 W/INDICATOR(  689): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-08 14:15:07.252+0600 W/AUL_AMD (  652): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 17319
09-08 14:15:07.252+0600 W/AUL     (  652): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 17319, appid: com.samsung.weather-m-agent
09-08 14:15:07.263+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 15
09-08 14:15:07.273+0600 W/AUL     (  874): launch.c: app_request_to_launchpad(425) > request cmd(0) result(17319)
09-08 14:15:07.273+0600 W/APP_CORE(  874): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-08 14:15:07.273+0600 I/APP_CORE(  874): appcore-efl.c: __do_app(520) > [APP 874] Event: PAUSE State: PAUSED
09-08 14:15:07.273+0600 E/LOCKSCREEN(  874): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-08 14:15:07.273+0600 E/LOCKSCREEN(  874): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-08 14:15:07.273+0600 E/LOCKSCREEN(  874): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-08 14:15:07.273+0600 W/LOCKSCREEN(  874): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-08 14:15:07.273+0600 W/LOCKSCREEN(  874): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-08 14:15:07.293+0600 I/Tizen::App( 1296): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-08 14:15:07.293+0600 I/Tizen::App( 1296): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 17319.
09-08 14:15:07.313+0600 I/MALI    (  274): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb865f458), gem(12), surface(0xb8683ee8)
09-08 14:15:07.463+0600 E/weather-agent(17319): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-08 14:15:07.463+0600 E/weather-common(17319): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-08 14:15:07.473+0600 E/weather-agent(17319): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-08 14:15:07.483+0600 I/MESSAGE_PORT(17319): message-port.c: __initialize(872) > initialize
09-08 14:15:07.503+0600 I/MESSAGE_PORT(17319): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-08 14:15:07.543+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 14:15:07.543+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 14:15:07.543+0600 I/MESSAGE_PORT(17319): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 14:15:07.543+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-08 14:15:07.543+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-08 14:15:07.543+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-08 14:15:07.543+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-08 14:15:07.553+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-08 14:15:07.553+0600 I/MESSAGE_PORT(  874): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-08 14:15:07.553+0600 E/MESSAGE_PORT(17319): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-08 14:15:07.553+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-08 14:15:07.553+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-08 14:15:07.563+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 15
09-08 14:15:07.563+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-08 14:15:07.563+0600 I/MESSAGE_PORT( 1416): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-08 14:15:07.563+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 14:15:07.563+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 14:15:07.563+0600 I/MESSAGE_PORT(17319): message-port.c: __message_port_send_message(972) > port exist check !!
09-08 14:15:07.563+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-08 14:15:07.563+0600 I/MESSAGE_PORT(17319): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-08 14:15:07.563+0600 I/MESSAGE_PORT(17319): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-08 14:15:07.573+0600 E/MESSAGE_PORT(17319): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 28.900000[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 4[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473321498[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-08 14:15:07.573+0600 E/weather-common(17319): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-08 14:15:07.573+0600 E/weather-agent(17319): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-08 14:15:07.573+0600 E/weather-agent(17319): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-08 14:15:07.573+0600 I/MESSAGE_PORT(17319): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-08 14:15:07.573+0600 I/MESSAGE_PORT(17319): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-08 14:15:07.573+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 15
09-08 14:15:07.593+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 15
09-08 14:15:07.643+0600 E/weather-widget( 1416): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-08 14:15:07.643+0600 E/weather-widget( 1416): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-08 14:15:07.833+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_create(442) > New handle created[0xb73ff7d0]
09-08 14:15:07.833+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_get_type(496) > Connected Network = 0
09-08 14:15:07.833+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-08 14:15:07.833+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-08 14:15:07.833+0600 I/CAPI_NETWORK_CONNECTION( 1416): connection.c: connection_destroy(460) > Destroy handle: 0xb73ff7d0
09-08 14:15:07.833+0600 E/weather-common( 1416): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-08 14:15:07.843+0600 W/LOCATION( 1416): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-08 14:15:07.843+0600 E/weather-common( 1416): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-08 14:15:07.843+0600 E/weather-widget( 1416): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-08 14:15:07.843+0600 E/weather-widget( 1416): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-08 14:15:07.843+0600 I/CAPI_WIDGET_APPLICATION( 1416): widget_app.c: __provider_update_cb(287) > received updating signal
09-08 14:15:07.863+0600 E/EFL     ( 1416): edje<1416> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-08 14:15:07.893+0600 E/EFL     ( 1416): evas_main<1416> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80036d73 is not stable during recalc loop
09-08 14:15:07.963+0600 E/EFL     ( 1416): evas_main<1416> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80036d73 is not stable during recalc loop
09-08 14:15:07.963+0600 E/EFL     ( 1416): edje<1416> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-08 14:15:07.973+0600 E/cluster-home(  877): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-08 14:15:08.574+0600 E/weather-agent(17319): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-08 14:15:08.574+0600 I/CAPI_APPFW_APPLICATION(17319): service_app_main.c: service_app_exit(446) > service_app_exit
09-08 14:15:08.574+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 22
09-08 14:15:08.574+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(1207) > app status : 5
09-08 14:15:08.574+0600 E/weather-agent(17319): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-08 14:15:08.714+0600 W/AUL_AMD (  652): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-08 14:15:08.714+0600 W/AUL_AMD (  652): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17319
09-08 14:15:08.724+0600 I/Tizen::App( 1296): (243) > App[com.samsung.weather-m-agent] pid[17319] terminate event is forwarded
09-08 14:15:08.724+0600 I/Tizen::System( 1296): (256) > osp.accessorymanager.service provider is found.
09-08 14:15:08.724+0600 I/Tizen::System( 1296): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 17319, ]
09-08 14:15:08.724+0600 I/Tizen::System( 1296): (256) > osp.system.service provider is found.
09-08 14:15:08.724+0600 I/Tizen::App( 1296): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-08 14:15:08.724+0600 I/Tizen::App( 1296): (512) > Not registered pid(17319)
09-08 14:15:08.724+0600 I/Tizen::System( 1296): (246) > Terminated app [com.samsung.weather-m-agent]
09-08 14:15:08.724+0600 I/Tizen::Io( 1296): (729) > Entry not found
09-08 14:15:08.724+0600 I/ESD     (  945): esd_main.c: __esd_app_dead_handler(1773) > pid: 17319
09-08 14:15:08.724+0600 E/RESOURCED(  698): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-08 14:15:08.734+0600 I/Tizen::System( 1296): (157) > change brightness system value.
09-08 14:15:08.734+0600 I/Tizen::App( 1296): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 17319.
09-08 14:15:08.734+0600 I/Tizen::System( 1296): (458) > org.tizen.system.deviced.display - CurrentBrightness (51)
09-08 14:15:11.587+0600 I/APP_CORE(  877): appcore-efl.c: __do_app(520) > [APP 877] Event: MEM_FLUSH State: PAUSED
09-08 14:15:13.569+0600 W/AUL_AMD (  652): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-08 14:17:54.686+0600 E/PKGMGR_SERVER(18208): pkgmgr-server.c: main(2414) > package manager server start
09-08 14:17:54.786+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 14
09-08 14:17:54.786+0600 W/AUL_AMD (  652): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14857
09-08 14:17:54.786+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 12
09-08 14:17:54.786+0600 W/AUL     (18211): launch.c: app_request_to_launchpad(396) > request cmd(5) to(14857)
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 5
09-08 14:17:54.796+0600 I/APP_CORE(14857): appcore-efl.c: __do_app(520) > [APP 14857] Event: TERMINATE State: PAUSED
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_launch.c: __reply_handler(1102) > listen fd(26) , send fd(25), pid(14857), cmd(4)
09-08 14:17:54.796+0600 W/AUL     (18211): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 22
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(1207) > app status : 5
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 14
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 22
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(1207) > app status : 5
09-08 14:17:54.796+0600 I/TIZEN_N_EFL_UTIL_WINDOW(14857): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-08 14:17:54.796+0600 E/APP_CORE(14857): appcore-efl.c: _capture_and_make_file(1631) > win[7200002] widget[480] height[800]
09-08 14:17:54.796+0600 W/AUL_AMD (  652): amd_request.c: __request_handler(912) > __request_handler: 33
09-08 14:17:54.796+0600 E/APP_CORE(14857): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-08 14:17:54.796+0600 I/CAPI_APPFW_APPLICATION(14857): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-08 14:17:54.806+0600 E/CAPI_NETWORK_BLUETOOTH(14857): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-08 14:17:54.816+0600 E/PKGMGR_SERVER(18208): pkgmgr-server.c: sighandler(417) > child NORMAL exit [18211]
09-08 14:17:54.836+0600 E/CAPI_NETWORK_BLUETOOTH(14857): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-08 14:17:54.836+0600 E/CAPI_NETWORK_BLUETOOTH(14857): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-08 14:17:54.836+0600 E/bluetooth(14857): [bt_adapter_le_destroy_advertiser] Failed.
09-08 14:17:54.856+0600 E/PKGMGR  (18206): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-08 14:17:54.896+0600 E/EFL     (14857): elementary<14857> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041c10, part 'elm.text'
09-08 14:17:55.046+0600 I/AUL_PAD ( 1411): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14857 pgid = 14857
09-08 14:17:55.046+0600 I/AUL_PAD ( 1411): sigchild.h: __sigchild_action(143) > dead_pid(14857)
09-08 14:17:55.096+0600 I/AUL_PAD ( 1411): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-08 14:17:55.096+0600 I/AUL_PAD ( 1411): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-08 14:17:55.096+0600 E/AUL_PAD ( 1411): launchpad.c: main(698) > error reading sigchld info
09-08 14:17:55.106+0600 I/Tizen::App( 1296): (243) > App[org.example.bluetooth] pid[14857] terminate event is forwarded
09-08 14:17:55.106+0600 I/Tizen::System( 1296): (256) > osp.accessorymanager.service provider is found.
09-08 14:17:55.106+0600 I/Tizen::System( 1296): (196) > Accessory Owner is removed [org.example.bluetooth, 14857, ]
09-08 14:17:55.106+0600 I/Tizen::System( 1296): (256) > osp.system.service provider is found.
09-08 14:17:55.106+0600 I/Tizen::App( 1296): (506) > TerminatedApp(org.example.bluetooth)
09-08 14:17:55.106+0600 I/Tizen::App( 1296): (512) > Not registered pid(14857)
09-08 14:17:55.106+0600 I/Tizen::System( 1296): (246) > Terminated app [org.example.bluetooth]
09-08 14:17:55.106+0600 I/Tizen::Io( 1296): (729) > Entry not found
09-08 14:17:55.106+0600 I/ESD     (  945): esd_main.c: __esd_app_dead_handler(1773) > pid: 14857
09-08 14:17:55.106+0600 W/AUL_AMD (  652): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14857
09-08 14:17:55.116+0600 E/RESOURCED(  698): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.452
09-08 14:17:55.126+0600 I/Tizen::System( 1296): (157) > change brightness system value.
09-08 14:17:55.126+0600 I/Tizen::App( 1296): (782) > Finished invoking application event listener for org.example.bluetooth, 14857.
09-08 14:17:55.166+0600 W/CRASH_MANAGER(18219): worker.c: worker_job(1199) > 1114857626162147332267
