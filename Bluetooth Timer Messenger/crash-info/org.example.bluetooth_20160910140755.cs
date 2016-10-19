S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 509
Date: 2016-09-10 14:07:55+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 509, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb8846f70
r2   = 0xb42d4000, r3   = 0xb42d4000
r4   = 0xb880cc38, r5   = 0xbee075bc
r6   = 0xb69d2310, r7   = 0xbee0741c
r8   = 0xb69d30f4, r9   = 0xb69d30f4
r10  = 0xb69e120c, fp   = 0x00000000
ip   = 0xb29c7b50, sp   = 0xbee05770
lr   = 0xb29b97d3, pc   = 0xb66b66f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     98268 KB
Buffers:     36824 KB
Cached:     264956 KB
VmPeak:     111336 KB
VmSize:     105584 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26224 KB
VmRSS:       26112 KB
VmData:      35572 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36264 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 509 TID = 509
509 512 1985 

Maps Information
b138f000 b1394000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1d0d000 b250c000 rw-p [stack:1985]
b250c000 b251d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b252d000 b2532000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25be000 b25c6000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25d7000 b25d8000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25e8000 b25fc000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2610000 b2611000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2621000 b2624000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2635000 b2636000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2646000 b2648000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2658000 b265a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b266a000 b267a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b268a000 b2696000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28a7000 b28be000 r-xp /usr/lib/libnetwork.so.0.0.0
b28cf000 b290d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b291e000 b2925000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2936000 b2945000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2955000 b298a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b299d000 b29a3000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29b3000 b29c0000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ae1000 b2bc4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bfb000 b2c23000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c35000 b3434000 rw-p [stack:512]
b3434000 b3436000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3446000 b3450000 r-xp /lib/libnss_files-2.20-2014.11.so
b3461000 b346a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b347b000 b348c000 r-xp /lib/libnsl-2.20-2014.11.so
b349f000 b34a5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34b6000 b34b7000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34df000 b34e6000 r-xp /usr/lib/libminizip.so.1.0.0
b34f6000 b34fb000 r-xp /usr/lib/libstorage.so.0.1
b350b000 b3560000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3576000 b358a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b359a000 b35de000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35ee000 b35f6000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3606000 b3636000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3649000 b3702000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3716000 b376a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b377b000 b3796000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37a6000 b3867000 r-xp /usr/lib/libprotobuf.so.9.0.1
b387a000 b388c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b389c000 b38a0000 r-xp /usr/lib/libogg.so.0.7.1
b38b0000 b38d2000 r-xp /usr/lib/libvorbis.so.0.4.3
b38e2000 b39c6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39e2000 b39ef000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a00000 b3a43000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a58000 b3a9f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ab0000 b3ab6000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ac7000 b3ace000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ade000 b3b1e000 r-xp /usr/lib/libmdm.so.1.2.10
b3b2e000 b3b36000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b45000 b3b55000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b76000 b3bd6000 r-xp /usr/lib/libasound.so.2.0.0
b3be8000 b3c1e000 r-xp /usr/lib/libpulse.so.0.16.2
b3c2f000 b3c32000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c42000 b3c45000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c55000 b3c5a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c6a000 b3c6b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c7b000 b3c86000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c9a000 b3ca1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cb1000 b3cb7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cc7000 b3ccc000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cdc000 b3cf7000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d07000 b3d0e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d1e000 b3d21000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d32000 b3d60000 r-xp /usr/lib/libidn.so.11.5.44
b3d70000 b3d86000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d97000 b3da1000 r-xp /usr/lib/libcares.so.2.1.0
b3db1000 b3dbb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dcb000 b3dcd000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3ddd000 b3dde000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dee000 b3df2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e03000 b3e2b000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e3c000 b3e65000 r-xp /usr/lib/libturbojpeg.so
b3e85000 b3e8b000 r-xp /usr/lib/libgif.so.4.1.6
b3e9b000 b3ee1000 r-xp /usr/lib/libcurl.so.4.3.0
b3ef2000 b3f13000 r-xp /usr/lib/libexif.so.12.3.3
b3f2e000 b3f43000 r-xp /usr/lib/libtts.so
b3f54000 b3f5c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f6c000 b402c000 r-xp /usr/lib/libdali-core.so.0.0.0
b4037000 b412a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b414a000 b4224000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b423b000 b423d000 r-xp /usr/lib/libboost_system.so.1.51.0
b424d000 b4253000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4263000 b4286000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4297000 b4299000 r-xp /usr/lib/libappsvc.so.0.1.0
b42a9000 b42ab000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42bc000 b42c1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42d8000 b42da000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42ea000 b42f1000 r-xp /usr/lib/libsensord-share.so
b4301000 b4319000 r-xp /usr/lib/libsensor.so.1.1.0
b432a000 b432d000 r-xp /usr/lib/libXv.so.1.0.0
b433d000 b4342000 r-xp /usr/lib/libutilX.so.1.1.0
b4352000 b4357000 r-xp /usr/lib/libappcore-common.so.1.1
b4367000 b436e000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4381000 b4385000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4396000 b4460000 r-xp /usr/lib/libCOREGL.so.4.0
b4477000 b447a000 r-xp /usr/lib/libuuid.so.1.3.0
b448b000 b44a2000 r-xp /usr/lib/libblkid.so.1.1.0
b44b3000 b44b5000 r-xp /usr/lib/libXau.so.6.0.0
b44c5000 b44c8000 r-xp /usr/lib/libEGL.so.1.4
b44d0000 b44d6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44e6000 b44e8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44f9000 b4507000 r-xp /usr/lib/libGLESv2.so.2.0
b4510000 b4572000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4587000 b459f000 r-xp /usr/lib/libmount.so.1.1.0
b45b0000 b45c4000 r-xp /usr/lib/libxcb.so.1.1.0
b45d5000 b45dc000 r-xp /lib/libcrypt-2.20-2014.11.so
b4614000 b4625000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4636000 b4638000 r-xp /usr/lib/libiri.so
b4648000 b4653000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4664000 b4679000 r-xp /lib/libexpat.so.1.5.2
b468b000 b4749000 r-xp /usr/lib/libcairo.so.2.11200.14
b475c000 b4764000 r-xp /usr/lib/libdrm.so.2.4.0
b4774000 b4777000 r-xp /usr/lib/libdri2.so.0.0.0
b4788000 b47d6000 r-xp /usr/lib/libssl.so.1.0.0
b47eb000 b47f7000 r-xp /usr/lib/libeeze.so.1.13.0
b4807000 b4810000 r-xp /usr/lib/libethumb.so.1.13.0
b4820000 b4823000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4833000 b49ea000 r-xp /usr/lib/libcrypto.so.1.0.0
b5641000 b564a000 r-xp /usr/lib/libXi.so.6.1.0
b565a000 b565c000 r-xp /usr/lib/libXgesture.so.7.0.0
b566c000 b5670000 r-xp /usr/lib/libXtst.so.6.1.0
b5680000 b5686000 r-xp /usr/lib/libXrender.so.1.3.0
b5696000 b569c000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ad000 b56af000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bf000 b56c2000 r-xp /usr/lib/libXfixes.so.3.1.0
b56d2000 b56dd000 r-xp /usr/lib/libXext.so.6.4.0
b56ed000 b56ef000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ff000 b5701000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5712000 b57f4000 r-xp /usr/lib/libX11.so.6.3.0
b5807000 b580e000 r-xp /usr/lib/libXcursor.so.1.0.2
b581e000 b5836000 r-xp /usr/lib/libudev.so.1.6.0
b5838000 b583b000 r-xp /lib/libattr.so.1.1.0
b584b000 b586b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b586d000 b5872000 r-xp /usr/lib/libffi.so.6.0.2
b5882000 b589a000 r-xp /lib/libz.so.1.2.8
b58aa000 b58ac000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58bc000 b5991000 r-xp /usr/lib/libxml2.so.2.9.2
b59a6000 b5a41000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a5d000 b5a60000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a70000 b5a89000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a9a000 b5aab000 r-xp /lib/libresolv-2.20-2014.11.so
b5abf000 b5b39000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4e000 b5b50000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b60000 b5b67000 r-xp /usr/lib/libembryo.so.1.13.0
b5b77000 b5b8f000 r-xp /usr/lib/libpng12.so.0.50.0
b5ba0000 b5bc3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5be4000 b5bf8000 r-xp /usr/lib/libector.so.1.13.0
b5c09000 b5c21000 r-xp /usr/lib/liblua-5.1.so
b5c32000 b5c89000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c9d000 b5cc5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cd6000 b5ce9000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cfa000 b5d31000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d42000 b5d50000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d60000 b5d68000 r-xp /usr/lib/libtbm.so.1.0.0
b5d78000 b5d85000 r-xp /usr/lib/libeio.so.1.13.0
b5d95000 b5d97000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da7000 b5dac000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dbc000 b5dd3000 r-xp /usr/lib/libefreet.so.1.13.0
b5de5000 b5e05000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e15000 b5e35000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e37000 b5e3d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e4d000 b5e5e000 r-xp /usr/lib/libemotion.so.1.13.0
b5e6f000 b5e76000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e86000 b5e95000 r-xp /usr/lib/libeo.so.1.13.0
b5ea6000 b5eb8000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ec9000 b5ece000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ede000 b5ef7000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f07000 b5f24000 r-xp /usr/lib/libeet.so.1.13.0
b5f3d000 b5f85000 r-xp /usr/lib/libeina.so.1.13.0
b5f96000 b5fa6000 r-xp /usr/lib/libefl.so.1.13.0
b5fb7000 b609c000 r-xp /usr/lib/libicuuc.so.51.1
b60b9000 b61f9000 r-xp /usr/lib/libicui18n.so.51.1
b6210000 b6248000 r-xp /usr/lib/libecore_x.so.1.13.0
b625a000 b625d000 r-xp /lib/libcap.so.2.21
b626d000 b6296000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a7000 b62ae000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62c0000 b62f7000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6308000 b63f3000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6406000 b647f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6491000 b6496000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a6000 b64b0000 r-xp /usr/lib/libvconf.so.0.2.45
b64c0000 b64c2000 r-xp /usr/lib/libvasum.so.0.3.1
b64d2000 b64d4000 r-xp /usr/lib/libttrace.so.1.1
b64e4000 b64e7000 r-xp /usr/lib/libiniparser.so.0
b64f7000 b651d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b652d000 b6532000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6543000 b655a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b656b000 b65d6000 r-xp /lib/libm-2.20-2014.11.so
b65e7000 b65ed000 r-xp /lib/librt-2.20-2014.11.so
b65fe000 b660b000 r-xp /usr/lib/libunwind.so.8.0.1
b6641000 b6765000 r-xp /lib/libc-2.20-2014.11.so
b677a000 b6793000 r-xp /lib/libgcc_s-4.9.so.1
b67a3000 b6885000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6896000 b68c0000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68d1000 b690d000 r-xp /usr/lib/libsystemd.so.0.4.0
b690f000 b6991000 r-xp /usr/lib/libedje.so.1.13.0
b69a4000 b69c2000 r-xp /usr/lib/libecore.so.1.13.0
b69e2000 b6b69000 r-xp /usr/lib/libevas.so.1.13.0
b6b9e000 b6bb2000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc6000 b6dfb000 r-xp /usr/lib/libelementary.so.1.13.0
b6e29000 b6e2d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e3d000 b6e44000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e54000 b6e56000 r-xp /usr/lib/libdlog.so.0.0.0
b6e66000 b6e69000 r-xp /usr/lib/libbundle.so.0.1.22
b6e79000 b6e7b000 r-xp /lib/libdl-2.20-2014.11.so
b6e8c000 b6ea4000 r-xp /usr/lib/libaul.so.0.1.0
b6eb8000 b6ebd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ece000 b6edb000 r-xp /usr/lib/liblptcp.so
b6eed000 b6ef1000 r-xp /usr/lib/libsys-assert.so
b6f02000 b6f22000 r-xp /lib/ld-2.20-2014.11.so
b6f33000 b6f38000 r-xp /usr/bin/launchpad-loader
b87cb000 b8bc1000 rw-p [heap]
bede7000 bee08000 rw-p [stack]
b87cb000 b8bc1000 rw-p [heap]
bede7000 bee08000 rw-p [stack]
End of Maps Information

Callstack Information (PID:509)
Call Stack Count: 1
 0: (0xb66b66f0) [/lib/libc.so.6] + 0x756f0
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
127+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 14:06:26.127+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 14:06:26.127+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 14:06:26.127+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 14:06:26.127+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 14:06:26.127+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 14:06:26.137+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 14:06:26.147+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_helper_event(2262) > [0;33mXT9_CMD_INPUTMODE value = 14[0m
09-10 14:06:26.147+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 14:06:26.147+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 14:06:26.187+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 14:06:26.197+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 14:06:27.839+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6332124
09-10 14:06:27.839+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6332124
09-10 14:06:27.879+0600 I/MALI    (  821): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:06:27.879+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7805ab0), gem(24), surface(0xb786c668)
09-10 14:06:27.899+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6332163
09-10 14:06:27.899+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 14:06:27.899+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 14:06:27.899+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 14:06:27.899+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 14:06:27.909+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=5[0m
09-10 14:06:28.740+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6333026
09-10 14:06:28.740+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6333026
09-10 14:06:28.860+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6333142
09-10 14:06:28.860+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 14:06:28.860+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 14:06:28.860+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 14:06:28.860+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 14:06:28.860+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 14:06:28.860+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 14:06:28.870+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=6[0m
09-10 14:06:28.870+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 14:06:28.870+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 14:06:30.491+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6334772
09-10 14:06:30.491+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6334772
09-10 14:06:30.582+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6334864
09-10 14:06:30.582+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 14:06:30.592+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 14:06:30.592+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 14:06:30.592+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 14:06:30.592+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 14:06:30.692+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6334976
09-10 14:06:30.692+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6334976
09-10 14:06:30.782+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6335060
09-10 14:06:30.782+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 14:06:30.782+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 14:06:30.782+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 14:06:30.792+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 14:06:30.792+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 14:06:31.282+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=6335467
09-10 14:06:31.282+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=6335564
09-10 14:06:31.282+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 14:06:31.282+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 14:06:31.302+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5200002 FAILED!
09-10 14:06:31.312+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 14:06:31.362+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7851cf0), gem(26), surface(0xb78b3a78)
09-10 14:06:31.362+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7727330), gem(23), surface(0xb785ddb8)
09-10 14:06:33.765+0600 E/EFL     (  509): eo<509> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb880b8c8 is not pointing to a valid object. Maybe it has already been freed.
09-10 14:06:33.765+0600 E/EFL     (  509): eo<509> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb880b8c8) is an invalid ref.
09-10 14:06:47.078+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 14:06:54.195+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 14:06:56.857+0600 I/Tizen::System( 1366): (280) > The screen has been turned on.
09-10 14:06:56.857+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:06:56.877+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6361139
09-10 14:06:56.887+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:06:56.887+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 14:06:57.408+0600 E/EFL     (  509): ecore_x<509> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6361684
09-10 14:06:57.408+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 14:06:57.408+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 14:06:57.408+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 14:06:57.408+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 14:07:00.000+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 14:07:00.000+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 2:07 p.m.
09-10 14:07:00.000+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 2:07 p.m."
09-10 14:07:00.000+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 2:07 p.m."
09-10 14:07:00.000+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 14:07:00.000+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145984599 Time: <font_size=31> </font_size> <font_size=31> 2:07 p.m.</font_size></font>"
09-10 14:07:20.070+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 14:07:27.067+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:07:27.067+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:07:27.087+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 14:07:27.097+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 14:07:27.097+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 14:07:27.097+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 14:07:27.097+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:13684b8
09-10 14:07:27.097+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 14:07:27.097+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 14:07:27.107+0600 W/APP_CORE(  509): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 14:07:27.107+0600 I/APP_CORE(  509): appcore-efl.c: __do_app(520) > [APP 509] Event: PAUSE State: RUNNING
09-10 14:07:27.107+0600 I/CAPI_APPFW_APPLICATION(  509): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:07:27.107+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 14:07:27.107+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 14:07:27.107+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 14:07:27.107+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 14:07:27.107+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 14:07:27.137+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:07:27.137+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:07:27.137+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 14:07:27.137+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 14:07:27.647+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:07:27.647+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:07:27.647+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 14:07:27.667+0600 I/APP_CORE(  509): appcore-efl.c: __do_app(520) > [APP 509] Event: PAUSE State: PAUSED
09-10 14:07:27.667+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb779c828), gem(14), surface(0xb78b2c00)
09-10 14:07:27.687+0600 I/TIZEN_N_EFL_UTIL_WINDOW(  509): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 17
09-10 14:07:27.687+0600 E/APP_CORE(  509): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 14:07:27.687+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:07:27.717+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785bbd8), gem(19), surface(0xb78ae1a0)
09-10 14:07:27.727+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:07:27.727+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:07:27.757+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 14:07:27.757+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:07:27.757+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:07:27.757+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 14:07:27.757+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 14:07:27.767+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(509) status(4)
09-10 14:07:27.767+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(509)
09-10 14:07:27.767+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 509, appid: org.example.bluetooth, status: bg
09-10 14:07:27.787+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:07:27.797+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 14:07:27.797+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:07:27.817+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:07:27.817+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 14:07:27.847+0600 I/TIZEN_N_SOUND_MANAGER(32680): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 14:07:27.847+0600 E/TIZEN_N_SOUND_MANAGER(32680): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:07:27.857+0600 I/TIZEN_N_SOUND_MANAGER(32680): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 14:07:27.857+0600 E/TIZEN_N_SOUND_MANAGER(32680): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:07:27.857+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:07:27.877+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 14:07:27.927+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb775af48), gem(21), surface(0xb78b3a78)
09-10 14:07:27.927+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77cf508), gem(15), surface(0xb7876938)
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 14:07:27.937+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 14:07:27.937+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 14:07:27.948+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 14:07:27.948+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:07:27.958+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:07:27.958+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 14:07:27.958+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 14:07:27.958+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:07:27.958+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:07:27.958+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:07:27.958+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:07:27.958+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 14:07:27.958+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 14:07:27.958+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 14:07:27.958+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 14:07:27.968+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 14:07:27.968+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 14:07:27.968+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 14:07:27.968+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 14:07:27.968+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 3075
09-10 14:07:27.968+0600 E/RESOURCED(  688): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 14:07:27.968+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 14:07:28.018+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 3075
09-10 14:07:28.018+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 3075, appid: com.samsung.weather-m-agent
09-10 14:07:28.038+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3075)
09-10 14:07:28.048+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 14:07:28.048+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 14:07:28.048+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 14:07:28.048+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 14:07:28.048+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 14:07:28.048+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 14:07:28.048+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 14:07:28.048+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 3075.
09-10 14:07:28.058+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 14:07:28.058+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 14:07:28.058+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 14:07:28.058+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 14:07:28.058+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 14:07:28.228+0600 E/weather-agent( 3075): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 14:07:28.228+0600 E/weather-common( 3075): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 14:07:28.228+0600 E/weather-agent( 3075): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 14:07:28.248+0600 I/MESSAGE_PORT( 3075): message-port.c: __initialize(872) > initialize
09-10 14:07:28.258+0600 I/MESSAGE_PORT( 3075): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 14:07:28.298+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 14:07:28.298+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 14:07:28.298+0600 I/MESSAGE_PORT( 3075): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:07:28.298+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 14:07:28.298+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 14:07:28.298+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 14:07:28.298+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 14:07:28.298+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 14:07:28.298+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 14:07:28.308+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 14:07:28.308+0600 E/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 14:07:28.308+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 3075): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 14:07:28.308+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 14:07:28.318+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:07:28.318+0600 E/MESSAGE_PORT( 3075): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 14:07:28.318+0600 E/weather-common( 3075): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 14:07:28.318+0600 E/weather-agent( 3075): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 14:07:28.318+0600 E/weather-agent( 3075): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 14:07:28.318+0600 I/MESSAGE_PORT( 3075): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 14:07:28.318+0600 I/MESSAGE_PORT( 3075): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 14:07:28.338+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:07:28.388+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 14:07:28.388+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 14:07:28.588+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83b64f8]
09-10 14:07:28.588+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 14:07:28.588+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83b64f8
09-10 14:07:28.588+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 14:07:28.598+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 14:07:28.598+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 14:07:28.618+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 14:07:28.618+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 14:07:28.628+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:07:28.658+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801fc788 is not stable during recalc loop
09-10 14:07:28.718+0600 I/CAPI_CONTENT_MEDIA_CONTENT(32680): media_content.c: media_content_disconnect(940) > [32m[32680]ref count changed to: 0
09-10 14:07:28.718+0600 I/CAPI_NETWORK_WIFI(32680): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 14:07:28.718+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801fc788 is not stable during recalc loop
09-10 14:07:28.728+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:07:28.738+0600 E/ALARM_MANAGER(32680): alarm-lib-stub.c: _send_alarm_delete_all(434) > alarm_manager_call_alarm_delete_all_sync() failed. return_code[0]
09-10 14:07:28.738+0600 E/ALARM_MANAGER(32680): alarm-lib-stub.c: _send_alarm_delete_all(436) > dbus error message: The connection is closed
09-10 14:07:28.748+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 14:07:29.319+0600 E/weather-agent( 3075): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 14:07:29.319+0600 I/CAPI_APPFW_APPLICATION( 3075): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 14:07:29.319+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:07:29.319+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:07:29.319+0600 E/weather-agent( 3075): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 14:07:29.469+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 14:07:29.469+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 3075
09-10 14:07:29.469+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[3075] terminate event is forwarded
09-10 14:07:29.469+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:07:29.469+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 3075, ]
09-10 14:07:29.469+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:07:29.469+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 14:07:29.469+0600 I/Tizen::App( 1366): (512) > Not registered pid(3075)
09-10 14:07:29.469+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 14:07:29.469+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:07:29.469+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 3075
09-10 14:07:29.479+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:07:29.479+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 3075.
09-10 14:07:32.122+0600 I/APP_CORE(  509): appcore-efl.c: __do_app(520) > [APP 509] Event: MEM_FLUSH State: PAUSED
09-10 14:07:34.334+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 14:07:55.514+0600 E/PKGMGR_SERVER( 3232): pkgmgr-server.c: main(2414) > package manager server start
09-10 14:07:55.574+0600 E/PKGMGR  ( 3230): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 14:07:55.615+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:07:55.615+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 509
09-10 14:07:55.615+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:07:55.615+0600 W/AUL     ( 3237): launch.c: app_request_to_launchpad(396) > request cmd(5) to(509)
09-10 14:07:55.615+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 14:07:55.625+0600 I/APP_CORE(  509): appcore-efl.c: __do_app(520) > [APP 509] Event: TERMINATE State: PAUSED
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(509), cmd(4)
09-10 14:07:55.625+0600 W/AUL     ( 3237): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:07:55.625+0600 I/TIZEN_N_EFL_UTIL_WINDOW(  509): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 14:07:55.625+0600 E/APP_CORE(  509): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 14:07:55.625+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:07:55.625+0600 E/APP_CORE(  509): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 14:07:55.625+0600 I/CAPI_APPFW_APPLICATION(  509): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:07:55.625+0600 E/CAPI_NETWORK_BLUETOOTH(  509): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 14:07:55.635+0600 E/PKGMGR_SERVER( 3232): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3237]
09-10 14:07:55.695+0600 E/CAPI_NETWORK_BLUETOOTH(  509): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 14:07:55.695+0600 E/CAPI_NETWORK_BLUETOOTH(  509): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 14:07:55.695+0600 E/bluetooth(  509): [bt_adapter_le_destroy_advertiser] Failed.
09-10 14:07:55.705+0600 I/CAPI_NETWORK_WIFI(  509): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 14:07:55.705+0600 E/bluetooth(  509): [wifi_deinitialize] Success.
09-10 14:07:55.725+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 14:07:55.725+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:07:55.725+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:07:55.725+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 14:07:55.725+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 14:07:55.725+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:07:55.735+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77ccea8), gem(13), surface(0xb78a96e8)
09-10 14:07:55.745+0600 E/EFL     (  509): eo<509> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x8001444e's acvie is  NULL, entry: 0xb34d7530, 0xb89c2298, 0
09-10 14:07:55.745+0600 E/EFL     (  509): eo<509> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x8001444e is not pointing to a valid object. Maybe it has already been freed.
09-10 14:07:55.745+0600 E/EFL     (  509): eo<509> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8001444e) is an invalid ref.
09-10 14:07:55.755+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77ccea8), gem(13), surface(0xb78780c8)
09-10 14:07:55.755+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785bbd8), gem(19), surface(0xb78ba1e8)
09-10 14:07:55.765+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb779c828), gem(14), surface(0xb78a14c8)
09-10 14:07:55.805+0600 E/EFL     (  509): elementary<509> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 14:07:55.825+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77abd18), gem(18), surface(0xb78ae1a0)
09-10 14:07:56.035+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 509 pgid = 509
09-10 14:07:56.035+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(509)
09-10 14:07:56.065+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78302e0), gem(18), surface(0xb78780c8)
09-10 14:07:56.125+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 14:07:56.125+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 14:07:56.125+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 14:07:56.165+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[509] terminate event is forwarded
09-10 14:07:56.165+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:07:56.165+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 509, ]
09-10 14:07:56.165+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:07:56.165+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 14:07:56.165+0600 I/Tizen::App( 1366): (512) > Not registered pid(509)
09-10 14:07:56.165+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 14:07:56.165+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:07:56.175+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 509
09-10 14:07:56.175+0600 W/CRASH_MANAGER( 3244): worker.c: worker_job(1199) > 1100509626162147349487
