S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 3515
Date: 2016-09-10 17:33:46+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3515, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb86eb2f8
r2   = 0xb4385000, r3   = 0xb4385000
r4   = 0xbeae75bc, r5   = 0xb6a840f4
r6   = 0xb6a83310, r7   = 0xbeae741c
r8   = 0xb6a840f4, r9   = 0xb6a840f4
r10  = 0xb6a9220c, fp   = 0x00000000
ip   = 0xb2a78b2c, sp   = 0xbeae6798
lr   = 0xb2a6e223, pc   = 0xb67676f0
cpsr = 0x80010030

Memory Information
MemTotal:   730440 KB
MemFree:     50120 KB
Buffers:     44192 KB
Cached:     287688 KB
VmPeak:     105588 KB
VmSize:     104632 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24884 KB
VmRSS:       24884 KB
VmData:      34724 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3515 TID = 3515
3515 3518 3952 

Maps Information
b1dc4000 b25c3000 rw-p [stack:3952]
b25c3000 b25d4000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25e4000 b25e9000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2675000 b267d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b268e000 b268f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b269f000 b26b3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26c7000 b26c8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26d8000 b26db000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26ec000 b26ed000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26fd000 b26ff000 r-xp /usr/lib/libxcb-present.so.0.0.0
b270f000 b2711000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2721000 b2731000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2741000 b274d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b295e000 b2975000 r-xp /usr/lib/libnetwork.so.0.0.0
b2986000 b29c4000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29d5000 b29dc000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29ed000 b29fc000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a0c000 b2a41000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a54000 b2a5a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a6a000 b2a71000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b92000 b2c75000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2cac000 b2cd4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ce6000 b34e5000 rw-p [stack:3518]
b34e5000 b34e7000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34f7000 b3501000 r-xp /lib/libnss_files-2.20-2014.11.so
b3512000 b351b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b352c000 b353d000 r-xp /lib/libnsl-2.20-2014.11.so
b3550000 b3556000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3567000 b3568000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3590000 b3597000 r-xp /usr/lib/libminizip.so.1.0.0
b35a7000 b35ac000 r-xp /usr/lib/libstorage.so.0.1
b35bc000 b3611000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3627000 b363b000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b364b000 b368f000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b369f000 b36a7000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36b7000 b36e7000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36fa000 b37b3000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37c7000 b381b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b382c000 b3847000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3857000 b3918000 r-xp /usr/lib/libprotobuf.so.9.0.1
b392b000 b393d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b394d000 b3951000 r-xp /usr/lib/libogg.so.0.7.1
b3961000 b3983000 r-xp /usr/lib/libvorbis.so.0.4.3
b3993000 b3a77000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a93000 b3aa0000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3ab1000 b3af4000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b09000 b3b50000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b61000 b3b67000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b78000 b3b7f000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b8f000 b3bcf000 r-xp /usr/lib/libmdm.so.1.2.10
b3bdf000 b3be7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bf6000 b3c06000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c27000 b3c87000 r-xp /usr/lib/libasound.so.2.0.0
b3c99000 b3ccf000 r-xp /usr/lib/libpulse.so.0.16.2
b3ce0000 b3ce3000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cf3000 b3cf6000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d06000 b3d0b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d1b000 b3d1c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d2c000 b3d37000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d4b000 b3d52000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d62000 b3d68000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d78000 b3d7d000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d8d000 b3da8000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3db8000 b3dbf000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dcf000 b3dd2000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3de3000 b3e11000 r-xp /usr/lib/libidn.so.11.5.44
b3e21000 b3e37000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e48000 b3e52000 r-xp /usr/lib/libcares.so.2.1.0
b3e62000 b3e6c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e7c000 b3e7e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e8e000 b3e8f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e9f000 b3ea3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eb4000 b3edc000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eed000 b3f16000 r-xp /usr/lib/libturbojpeg.so
b3f36000 b3f3c000 r-xp /usr/lib/libgif.so.4.1.6
b3f4c000 b3f92000 r-xp /usr/lib/libcurl.so.4.3.0
b3fa3000 b3fc4000 r-xp /usr/lib/libexif.so.12.3.3
b3fdf000 b3ff4000 r-xp /usr/lib/libtts.so
b4005000 b400d000 r-xp /usr/lib/libfeedback.so.0.1.4
b401d000 b40dd000 r-xp /usr/lib/libdali-core.so.0.0.0
b40e8000 b41db000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41fb000 b42d5000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42ec000 b42ee000 r-xp /usr/lib/libboost_system.so.1.51.0
b42fe000 b4304000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4314000 b4337000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4348000 b434a000 r-xp /usr/lib/libappsvc.so.0.1.0
b435a000 b435c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b436d000 b4372000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4389000 b438b000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b439b000 b43a2000 r-xp /usr/lib/libsensord-share.so
b43b2000 b43ca000 r-xp /usr/lib/libsensor.so.1.1.0
b43db000 b43de000 r-xp /usr/lib/libXv.so.1.0.0
b43ee000 b43f3000 r-xp /usr/lib/libutilX.so.1.1.0
b4403000 b4408000 r-xp /usr/lib/libappcore-common.so.1.1
b4418000 b441f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4432000 b4436000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4447000 b4511000 r-xp /usr/lib/libCOREGL.so.4.0
b4528000 b452b000 r-xp /usr/lib/libuuid.so.1.3.0
b453c000 b4553000 r-xp /usr/lib/libblkid.so.1.1.0
b4564000 b4566000 r-xp /usr/lib/libXau.so.6.0.0
b4576000 b4579000 r-xp /usr/lib/libEGL.so.1.4
b4581000 b4587000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4597000 b4599000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45aa000 b45b8000 r-xp /usr/lib/libGLESv2.so.2.0
b45c1000 b4623000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4638000 b4650000 r-xp /usr/lib/libmount.so.1.1.0
b4661000 b4675000 r-xp /usr/lib/libxcb.so.1.1.0
b4686000 b468d000 r-xp /lib/libcrypt-2.20-2014.11.so
b46c5000 b46d6000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46e7000 b46e9000 r-xp /usr/lib/libiri.so
b46f9000 b4704000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4715000 b472a000 r-xp /lib/libexpat.so.1.5.2
b473c000 b47fa000 r-xp /usr/lib/libcairo.so.2.11200.14
b480d000 b4815000 r-xp /usr/lib/libdrm.so.2.4.0
b4825000 b4828000 r-xp /usr/lib/libdri2.so.0.0.0
b4839000 b4887000 r-xp /usr/lib/libssl.so.1.0.0
b489c000 b48a8000 r-xp /usr/lib/libeeze.so.1.13.0
b48b8000 b48c1000 r-xp /usr/lib/libethumb.so.1.13.0
b48d1000 b48d4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48e4000 b4a9b000 r-xp /usr/lib/libcrypto.so.1.0.0
b56f2000 b56fb000 r-xp /usr/lib/libXi.so.6.1.0
b570b000 b570d000 r-xp /usr/lib/libXgesture.so.7.0.0
b571d000 b5721000 r-xp /usr/lib/libXtst.so.6.1.0
b5731000 b5737000 r-xp /usr/lib/libXrender.so.1.3.0
b5747000 b574d000 r-xp /usr/lib/libXrandr.so.2.2.0
b575e000 b5760000 r-xp /usr/lib/libXinerama.so.1.0.0
b5770000 b5773000 r-xp /usr/lib/libXfixes.so.3.1.0
b5783000 b578e000 r-xp /usr/lib/libXext.so.6.4.0
b579e000 b57a0000 r-xp /usr/lib/libXdamage.so.1.1.0
b57b0000 b57b2000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57c3000 b58a5000 r-xp /usr/lib/libX11.so.6.3.0
b58b8000 b58bf000 r-xp /usr/lib/libXcursor.so.1.0.2
b58cf000 b58e7000 r-xp /usr/lib/libudev.so.1.6.0
b58e9000 b58ec000 r-xp /lib/libattr.so.1.1.0
b58fc000 b591c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b591e000 b5923000 r-xp /usr/lib/libffi.so.6.0.2
b5933000 b594b000 r-xp /lib/libz.so.1.2.8
b595b000 b595d000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b596d000 b5a42000 r-xp /usr/lib/libxml2.so.2.9.2
b5a57000 b5af2000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b0e000 b5b11000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b21000 b5b3a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b4b000 b5b5c000 r-xp /lib/libresolv-2.20-2014.11.so
b5b70000 b5bea000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bff000 b5c01000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c11000 b5c18000 r-xp /usr/lib/libembryo.so.1.13.0
b5c28000 b5c40000 r-xp /usr/lib/libpng12.so.0.50.0
b5c51000 b5c74000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c95000 b5ca9000 r-xp /usr/lib/libector.so.1.13.0
b5cba000 b5cd2000 r-xp /usr/lib/liblua-5.1.so
b5ce3000 b5d3a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4e000 b5d76000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d87000 b5d9a000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dab000 b5de2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df3000 b5e01000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e11000 b5e19000 r-xp /usr/lib/libtbm.so.1.0.0
b5e29000 b5e36000 r-xp /usr/lib/libeio.so.1.13.0
b5e46000 b5e48000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e58000 b5e5d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6d000 b5e84000 r-xp /usr/lib/libefreet.so.1.13.0
b5e96000 b5eb6000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec6000 b5ee6000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee8000 b5eee000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5efe000 b5f0f000 r-xp /usr/lib/libemotion.so.1.13.0
b5f20000 b5f27000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f37000 b5f46000 r-xp /usr/lib/libeo.so.1.13.0
b5f57000 b5f69000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f7a000 b5f7f000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8f000 b5fa8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb8000 b5fd5000 r-xp /usr/lib/libeet.so.1.13.0
b5fee000 b6036000 r-xp /usr/lib/libeina.so.1.13.0
b6047000 b6057000 r-xp /usr/lib/libefl.so.1.13.0
b6068000 b614d000 r-xp /usr/lib/libicuuc.so.51.1
b616a000 b62aa000 r-xp /usr/lib/libicui18n.so.51.1
b62c1000 b62f9000 r-xp /usr/lib/libecore_x.so.1.13.0
b630b000 b630e000 r-xp /lib/libcap.so.2.21
b631e000 b6347000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6358000 b635f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6371000 b63a8000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b9000 b64a4000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b7000 b6530000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6542000 b6547000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6557000 b6561000 r-xp /usr/lib/libvconf.so.0.2.45
b6571000 b6573000 r-xp /usr/lib/libvasum.so.0.3.1
b6583000 b6585000 r-xp /usr/lib/libttrace.so.1.1
b6595000 b6598000 r-xp /usr/lib/libiniparser.so.0
b65a8000 b65ce000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65de000 b65e3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f4000 b660b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661c000 b6687000 r-xp /lib/libm-2.20-2014.11.so
b6698000 b669e000 r-xp /lib/librt-2.20-2014.11.so
b66af000 b66bc000 r-xp /usr/lib/libunwind.so.8.0.1
b66f2000 b6816000 r-xp /lib/libc-2.20-2014.11.so
b682b000 b6844000 r-xp /lib/libgcc_s-4.9.so.1
b6854000 b6936000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6947000 b6971000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6982000 b69be000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c0000 b6a42000 r-xp /usr/lib/libedje.so.1.13.0
b6a55000 b6a73000 r-xp /usr/lib/libecore.so.1.13.0
b6a93000 b6c1a000 r-xp /usr/lib/libevas.so.1.13.0
b6c4f000 b6c63000 r-xp /lib/libpthread-2.20-2014.11.so
b6c77000 b6eac000 r-xp /usr/lib/libelementary.so.1.13.0
b6eda000 b6ede000 r-xp /usr/lib/libsmack.so.1.0.0
b6eee000 b6ef5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f05000 b6f07000 r-xp /usr/lib/libdlog.so.0.0.0
b6f17000 b6f1a000 r-xp /usr/lib/libbundle.so.0.1.22
b6f2a000 b6f2c000 r-xp /lib/libdl-2.20-2014.11.so
b6f3d000 b6f55000 r-xp /usr/lib/libaul.so.0.1.0
b6f69000 b6f6e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7f000 b6f8c000 r-xp /usr/lib/liblptcp.so
b6f9e000 b6fa2000 r-xp /usr/lib/libsys-assert.so
b6fb3000 b6fd3000 r-xp /lib/ld-2.20-2014.11.so
b6fe4000 b6fe9000 r-xp /usr/bin/launchpad-loader
b8578000 b88ab000 rw-p [heap]
beac7000 beae8000 rw-p [stack]
b8578000 b88ab000 rw-p [heap]
beac7000 beae8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3515)
Call Stack Count: 1
 0: (0xb67676f0) [/lib/libc.so.6] + 0x756f0
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
caller(267) > Check app launching
09-10 17:32:08.373+0600 I/CAPI_APPFW_APPLICATION( 2673): app_main.c: ui_app_main(789) > app_efl_main
09-10 17:32:08.383+0600 I/CAPI_APPFW_APPLICATION( 2673): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 17:32:08.403+0600 E/TBM     ( 2673): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 17:32:08.463+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 2673, appid: org.example.bluetooth
09-10 17:32:08.463+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 17:32:08.473+0600 W/AUL     ( 3505): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2673)
09-10 17:32:08.483+0600 E/CAPI_NETWORK_WIFI( 2673): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 17:32:08.533+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 17:32:08.693+0600 I/CAPI_NETWORK_WIFI( 2673): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 17:32:08.693+0600 D/bluetooth( 2673): [wifi_initialize] Success.
09-10 17:32:08.883+0600 I/APP_CORE( 2673): appcore-efl.c: __do_app(520) > [APP 2673] Event: RESET State: CREATED
09-10 17:32:08.883+0600 I/CAPI_APPFW_APPLICATION( 2673): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 17:32:08.883+0600 E/EFL     ( 2673): edje<2673> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:32:08.883+0600 E/EFL     ( 2673): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:32:08.893+0600 E/EFL     ( 2673): edje<2673> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:32:08.893+0600 E/EFL     ( 2673): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:32:08.903+0600 E/EFL     ( 2673): edje<2673> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:32:08.903+0600 E/EFL     ( 2673): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:32:08.994+0600 W/APP_CORE( 2673): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5000002
09-10 17:32:08.994+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 17:32:09.084+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77bece0), gem(24), surface(0xb7877090)
09-10 17:32:09.084+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb779ad00), gem(13), surface(0xb78b1e60)
09-10 17:32:09.094+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77bece0), gem(24), surface(0xb78bfd48)
09-10 17:32:09.094+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(14), surface(0xb7871238)
09-10 17:32:09.104+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(2673) status(4)
09-10 17:32:09.134+0600 I/APP_CORE( 2673): appcore-efl.c: __do_app(520) > [APP 2673] Event: PAUSE State: CREATED
09-10 17:32:09.134+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 2673): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:32:09.134+0600 E/APP_CORE( 2673): appcore-efl.c: _capture_and_make_file(1631) > win[5000002] widget[480] height[800]
09-10 17:32:09.134+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:32:09.144+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7749dd0), gem(21), surface(0xb78ae1a0)
09-10 17:32:09.274+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7823e00), gem(30), surface(0xb787e520)
09-10 17:32:09.464+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:32:09.464+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 17:32:09.474+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76af128), gem(30), surface(0xb78ae1a0)
09-10 17:32:09.494+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2707
09-10 17:32:09.504+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 17:32:09.504+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 2673.
09-10 17:32:09.504+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(2673) status(0)
09-10 17:32:09.514+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:32:09.854+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77bece0), gem(21), surface(0xb787e520)
09-10 17:32:10.405+0600 I/UXT     ( 3515): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 17:32:13.468+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(2673)
09-10 17:32:13.468+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 2673, appid: org.example.bluetooth, status: bg
09-10 17:32:31.746+0600 E/PKGMGR_SERVER( 3646): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:32:31.816+0600 E/PKGMGR  ( 3643): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 17:32:31.866+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:32:31.866+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 2673
09-10 17:32:31.866+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:32:31.866+0600 W/AUL     ( 3649): launch.c: app_request_to_launchpad(396) > request cmd(5) to(2673)
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(2673), cmd(4)
09-10 17:32:31.876+0600 W/AUL     ( 3649): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 17:32:31.876+0600 I/APP_CORE( 2673): appcore-efl.c: __do_app(520) > [APP 2673] Event: TERMINATE State: CREATED
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 2673
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:32:31.876+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 2673): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:32:31.876+0600 E/APP_CORE( 2673): appcore-efl.c: _capture_and_make_file(1631) > win[5000002] widget[480] height[800]
09-10 17:32:31.876+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:32:31.876+0600 E/APP_CORE( 2673): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:32:31.876+0600 I/CAPI_APPFW_APPLICATION( 2673): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:32:31.876+0600 E/CAPI_NETWORK_BLUETOOTH( 2673): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:32:31.946+0600 E/CAPI_NETWORK_BLUETOOTH( 2673): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:32:31.946+0600 E/CAPI_NETWORK_BLUETOOTH( 2673): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:32:31.946+0600 E/bluetooth( 2673): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:32:31.946+0600 I/CAPI_NETWORK_WIFI( 2673): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:32:31.946+0600 E/bluetooth( 2673): [wifi_deinitialize] Success.
09-10 17:32:31.966+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7850178), gem(18), surface(0xb7877090)
09-10 17:32:31.976+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:32:31.976+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:32:31.976+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:32:31.976+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:32:31.976+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:32:31.976+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:32:31.976+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 17:32:31.986+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7850178), gem(18), surface(0xb78b9638)
09-10 17:32:31.986+0600 E/PKGMGR_SERVER( 3646): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3649]
09-10 17:32:31.986+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77bece0), gem(21), surface(0xb787ceb0)
09-10 17:32:31.986+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:32:31.996+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], Loading state:[1]
09-10 17:32:31.996+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(14), surface(0xb78ae510)
09-10 17:32:32.046+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77f2400), gem(13), surface(0xb78ae1a0)
09-10 17:32:32.296+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb789bac8), gem(13), surface(0xb787e520)
09-10 17:32:32.296+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2673 pgid = 2673
09-10 17:32:32.296+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(2673)
09-10 17:32:32.336+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:32:32.336+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:32:32.336+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:32:32.346+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[2673] terminate event is forwarded
09-10 17:32:32.346+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:32:32.346+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 2673, ]
09-10 17:32:32.346+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:32:32.346+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:32:32.346+0600 I/Tizen::App( 1366): (512) > Not registered pid(2673)
09-10 17:32:32.346+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:32:32.346+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:32:32.346+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 2673
09-10 17:32:32.346+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2673
09-10 17:32:32.346+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2712
09-10 17:32:32.356+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:32:32.356+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:32:32.356+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 2673.
09-10 17:32:34.448+0600 E/PKGMGR_SERVER( 3646): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 17:32:34.448+0600 E/PKGMGR_SERVER( 3646): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 17:32:36.881+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:32:36.881+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:32:38.292+0600 E/PKGMGR  ( 3767): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
09-10 17:32:38.402+0600 E/PKGMGR_SERVER( 3771): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:32:38.462+0600 E/PKGMGR_SERVER( 3771): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.bluetooth]
09-10 17:32:38.472+0600 E/PKGMGR_SERVER( 3771): pm-mdm.c: _get_package_info_from_file(115) > [0;31m[_get_package_info_from_file(): 115](ret < 0) access() failed. path: org.example.bluetooth errno: 2 (No such file or directory)[0;m
09-10 17:32:38.472+0600 E/PKGMGR  ( 3767): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[37670002]
09-10 17:32:38.542+0600 E/rpm-installer( 3774): rpm-appcore-intf.c: main(104) > ------------------------------------------------
09-10 17:32:38.552+0600 E/rpm-installer( 3774): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
09-10 17:32:38.552+0600 E/rpm-installer( 3774): rpm-appcore-intf.c: main(106) > ------------------------------------------------
09-10 17:32:38.662+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: start, val: update
09-10 17:32:38.662+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [start], Value = [update], install = [1]
09-10 17:32:38.672+0600 W/AUL_AMD (  648): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
09-10 17:32:38.672+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 30
09-10 17:32:38.672+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [30]
09-10 17:32:38.672+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [30], install = [1]
09-10 17:32:38.682+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.682+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.682+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.682+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.682+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.682+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.823+0600 E/rpm-installer( 3774): coretpk-parser.c: _coretpk_parser_get_manifest_info(1377) > (doc == NULL) xmlParseFile() failed.
09-10 17:32:38.823+0600 E/rpm-installer( 3774): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
09-10 17:32:38.893+0600 E/PKGMGR_PARSER( 3774): pkgmgr_parser.c: __check_theme(158) > theme for uninstallation.
09-10 17:32:38.913+0600 I/PRIVACY-MANAGER-CLIENT( 3774): SocketClient.cpp: SocketClient(37) > Client created
09-10 17:32:38.913+0600 I/PRIVACY-MANAGER-CLIENT( 3774): SocketClient.cpp: connect(62) > Client connected
09-10 17:32:38.913+0600 I/PRIVACY-MANAGER-SERVER(  933): SocketService.cpp: mainloop(257) > Got incoming connection
09-10 17:32:38.913+0600 I/PRIVACY-MANAGER-CLIENT( 3774): SocketClient.cpp: disconnect(72) > Client disconnected
09-10 17:32:38.923+0600 E/PKGMGR_CERT( 3774): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
09-10 17:32:38.923+0600 E/PKGMGR_CERT( 3774): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
09-10 17:32:38.943+0600 E/PKGMGR_CERT( 3774): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
09-10 17:32:38.983+0600 E/rpm-installer( 3774): coretpk-installer.c: _coretpk_installer_package_reinstall(6348) > _coretpk_installer_package_reinstall(org.example.bluetooth) failed.
09-10 17:32:38.993+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: fail
09-10 17:32:38.993+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [fail], install = [1]
09-10 17:32:38.993+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.993+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.993+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:38.993+0600 E/ESD     (  915): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
09-10 17:32:39.003+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.bluetooth",~) returned -1
09-10 17:32:39.003+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
09-10 17:32:39.003+0600 W/AUL_AMD (  648): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
09-10 17:32:39.493+0600 E/rpm-installer( 3774): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 17:32:39.493+0600 E/rpm-installer( 3774): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 17:32:39.493+0600 E/rpm-installer( 3774): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 17:32:39.523+0600 E/PKGMGR_SERVER( 3771): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3774]
09-10 17:32:40.444+0600 E/PKGMGR_SERVER( 3771): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 17:32:40.444+0600 E/PKGMGR_SERVER( 3771): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 17:32:43.557+0600 E/PKGMGR  ( 3849): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
09-10 17:32:43.657+0600 E/PKGMGR_SERVER( 3852): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:32:43.717+0600 E/PKGMGR_SERVER( 3852): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk]
09-10 17:32:43.727+0600 E/PKGMGR_INFO( 3852): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] not found in DB
09-10 17:32:43.737+0600 E/BACKEND_LIB( 3852): librpm.c: __installer_util_delete_dir(179) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-10 17:32:43.737+0600 E/PKGMGR_SERVER( 3852): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-10 17:32:43.747+0600 E/PKGMGR  ( 3849): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[38490002]
09-10 17:32:43.818+0600 E/rpm-installer( 3855): rpm-appcore-intf.c: main(104) > ------------------------------------------------
09-10 17:32:43.818+0600 E/rpm-installer( 3855): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
09-10 17:32:43.818+0600 E/rpm-installer( 3855): rpm-appcore-intf.c: main(106) > ------------------------------------------------
09-10 17:32:43.888+0600 E/PKGMGR_INSTALLER( 3855): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
09-10 17:32:43.888+0600 E/rpm-installer( 3855): rpm-appcore-intf.c: main(191) > [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] is tpk package.
09-10 17:32:43.908+0600 E/rpm-installer( 3855): coretpk-parser.c: _coretpk_parser_is_svc_app(1225) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
09-10 17:32:43.908+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [install-location] is empty.
09-10 17:32:43.908+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 17:32:43.908+0600 E/rpm-installer( 3855): coretpk-parser.c: _coretpk_parser_is_widget(1191) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
09-10 17:32:43.908+0600 E/rpm-installer( 3855): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 17:32:44.028+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: start, val: install
09-10 17:32:44.028+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [start], Value = [install], install = [1]
09-10 17:32:44.048+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 30
09-10 17:32:44.048+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [30]
09-10 17:32:44.048+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [30], install = [1]
09-10 17:32:44.048+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.048+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.048+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.048+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.048+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.048+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.148+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_check_vip_tag(474) > (ret == 1) metadata(watchface) is empty.
09-10 17:32:44.148+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [ui-gadget] is empty.
09-10 17:32:44.158+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_get_dpi_type(778) > key for dpi is found, get the dpi.
09-10 17:32:44.158+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_get_dpi_type(787) > device dpi is [233]
09-10 17:32:44.158+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_append_path(343) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-10 17:32:44.158+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 17:32:44.158+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_allow_onboot(582) > (ret == 1) metadata is empty.
09-10 17:32:44.158+0600 E/rpm-installer( 3855): coretpk-parser.c: __coretpk_parser_allow_autorestart(644) > (ret == 1) metadata is empty.
09-10 17:32:44.168+0600 E/PKGMGR_PARSER( 3855): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2682) > Manifest is Valid
09-10 17:32:44.168+0600 E/PKGMGR_PARSER( 3855): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-10 17:32:44.188+0600 E/PKGMGR_PARSER( 3855): pkgmgr_parser_db.c: __verify_label_cb(353) > package_label is PKGMGR_PARSER_EMPTY_STR
09-10 17:32:44.238+0600 I/PRIVACY-MANAGER-CLIENT( 3855): SocketClient.cpp: SocketClient(37) > Client created
09-10 17:32:44.498+0600 E/PKGMGR_PARSER( 3855): pkgmgr_parser.c: __check_theme(146) > theme for installation.
09-10 17:32:44.518+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-10 17:32:44.518+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 100
09-10 17:32:44.518+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 100
09-10 17:32:44.518+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 25 1
09-10 17:32:44.518+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 26 1
09-10 17:32:44.518+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 27 1
09-10 17:32:44.518+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 28 1
09-10 17:32:44.538+0600 E/PKGMGR_CERT( 3855): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
09-10 17:32:44.538+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 60
09-10 17:32:44.538+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [60]
09-10 17:32:44.538+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [60], install = [1]
09-10 17:32:44.548+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.548+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.548+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.548+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(154) > Enter
09-10 17:32:44.548+0600 I/SHAREDRULE_CLIENT(  592): SocketConnection.h: SocketConnection(47) > Created
09-10 17:32:44.548+0600 I/SHAREDRULE_SERVER(  589): SocketService.cpp: mainloop(234) > Got incoming connection
09-10 17:32:44.548+0600 I/SHAREDRULE_SERVER(  589): SocketConnection.h: SocketConnection(47) > Created
09-10 17:32:44.568+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(190) > return result : 0
09-10 17:32:44.568+0600 E/rpm-installer( 3855): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 17:32:44.598+0600 E/rpm-installer( 3855): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
09-10 17:32:44.608+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 100
09-10 17:32:44.608+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [100]
09-10 17:32:44.608+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [100], install = [1]
09-10 17:32:44.608+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.608+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:44.608+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:45.239+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-10 17:32:45.239+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-10 17:32:45.239+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-10 17:32:45.239+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: ok
09-10 17:32:45.239+0600 I/Tizen::App( 1366): (78) > Installation is Completed. [Package = org.example.bluetooth]
09-10 17:32:45.239+0600 I/Tizen::App( 1366): (671) > Enter. package(org.example.bluetooth), installationResult(0)
09-10 17:32:45.239+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:45.239+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:45.239+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:32:45.279+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-10 17:32:45.289+0600 I/Tizen::App( 1366): (1360) > package(org.example.bluetooth), version(1.0.0), type(tpk), displayName(Timer Messenger), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.bluetooth), storeClient(), appRootPath(/opt/usr/apps/org.example.bluetooth)
09-10 17:32:45.299+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.bluetooth]
09-10 17:32:45.299+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.bluetooth]
09-10 17:32:45.299+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-10 17:32:45.299+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-10 17:32:45.299+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.bluetooth]
09-10 17:32:45.309+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[Timer Messenger] enable[1] system[0]
09-10 17:32:45.309+0600 E/HOME_APPS(  873): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.bluetooth] mdm is not enabled
09-10 17:32:45.319+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[Timer Messenger] enable[1] system[0]
09-10 17:32:45.319+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: UpdateBoxData(1330) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], New icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png]!!!!!
09-10 17:32:45.319+0600 I/Tizen::App( 1366): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.bluetooth]
09-10 17:32:45.329+0600 E/util-view(  873): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=22 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-10 17:32:45.349+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 17:32:45.349+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 17:32:45.349+0600 E/PKGMGR_INFO( 1366): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-10 17:32:45.349+0600 I/Tizen::App( 1366): (683) > Application count(1) in this package
09-10 17:32:45.349+0600 I/Tizen::App( 1366): (703) > Exit.
09-10 17:32:45.349+0600 I/Tizen::App( 1366): (840) > Enter.
09-10 17:32:45.349+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [ok], install = [96]
09-10 17:32:45.359+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], Loading state:[1]
09-10 17:32:45.369+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 17:32:45.369+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 17:32:45.369+0600 I/Tizen::App( 1366): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.bluetooth.info]
09-10 17:32:45.369+0600 I/Tizen::App( 1366): (131) > Enter
09-10 17:32:45.379+0600 I/Tizen::App( 1366): (137) > org.example.bluetooth does not have launch condition
09-10 17:32:45.379+0600 I/Tizen::App( 1366): (883) > Exit.
09-10 17:32:45.409+0600 E/rpm-installer( 3855): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 17:32:45.409+0600 E/rpm-installer( 3855): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 17:32:45.409+0600 E/rpm-installer( 3855): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 17:32:45.419+0600 E/PKGMGR_SERVER( 3852): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3855]
09-10 17:32:46.450+0600 E/PKGMGR_SERVER( 3852): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 17:32:46.450+0600 E/PKGMGR_SERVER( 3852): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 17:32:51.165+0600 W/AUL     ( 3948): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.bluetooth)
09-10 17:32:51.165+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:32:51.175+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-10 17:32:51.185+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-10 17:32:51.185+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 17:32:51.185+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 3948
09-10 17:32:51.185+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 17:32:51.195+0600 E/RESOURCED(15587): block.c: block_prelaunch_state(138) > insert data org.example.bluetooth, table num : 1
09-10 17:32:51.195+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:32:51.195+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 17:32:51.195+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:32:51.195+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.bluetooth has already loaded
09-10 17:32:51.195+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:32:51.195+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 17:32:51.205+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 17:32:51.205+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 17:32:51.215+0600 I/CAPI_APPFW_APPLICATION( 3515): app_main.c: ui_app_main(789) > app_efl_main
09-10 17:32:51.225+0600 I/CAPI_APPFW_APPLICATION( 3515): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 17:32:51.245+0600 E/TBM     ( 3515): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 17:32:51.305+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 3515, appid: org.example.bluetooth
09-10 17:32:51.305+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 17:32:51.305+0600 W/AUL     ( 3948): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3515)
09-10 17:32:51.325+0600 E/CAPI_NETWORK_WIFI( 3515): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 17:32:51.365+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 17:32:51.515+0600 I/CAPI_NETWORK_WIFI( 3515): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 17:32:51.515+0600 D/bluetooth( 3515): [wifi_initialize] Success.
09-10 17:32:51.725+0600 I/APP_CORE( 3515): appcore-efl.c: __do_app(520) > [APP 3515] Event: RESET State: CREATED
09-10 17:32:51.725+0600 I/CAPI_APPFW_APPLICATION( 3515): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 17:32:51.725+0600 E/EFL     ( 3515): edje<3515> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:32:51.725+0600 E/EFL     ( 3515): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:32:51.725+0600 E/EFL     ( 3515): edje<3515> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:32:51.725+0600 E/EFL     ( 3515): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:32:51.735+0600 E/EFL     ( 3515): edje<3515> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:32:51.735+0600 E/EFL     ( 3515): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:32:51.825+0600 W/APP_CORE( 3515): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
09-10 17:32:51.825+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 17:32:51.915+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7737e90), gem(24), surface(0xb78ae1a0)
09-10 17:32:51.915+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb789bac8), gem(13), surface(0xb78b9638)
09-10 17:32:51.925+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7737e90), gem(24), surface(0xb78ae508)
09-10 17:32:51.925+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(14), surface(0xb78bb978)
09-10 17:32:51.935+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 17:32:51.935+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 17:32:51.935+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 17:32:51.935+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(3515) status(4)
09-10 17:32:51.975+0600 I/APP_CORE( 3515): appcore-efl.c: __do_app(520) > [APP 3515] Event: PAUSE State: CREATED
09-10 17:32:51.975+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 3515): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 17:32:51.975+0600 E/APP_CORE( 3515): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 17:32:51.975+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7784bf8), gem(21), surface(0xb787e520)
09-10 17:32:51.975+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:32:52.146+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78aa360), gem(30), surface(0xb7877090)
09-10 17:32:52.296+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(3515) status(0)
09-10 17:32:52.296+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:32:52.306+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:32:52.306+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 17:32:52.306+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7823e00), gem(30), surface(0xb787e520)
09-10 17:32:52.346+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 17:32:52.346+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 3515.
09-10 17:32:52.356+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2723
09-10 17:32:52.696+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7737e90), gem(21), surface(0xb78ae1a0)
09-10 17:32:53.247+0600 I/UXT     ( 3957): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 17:32:56.310+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(3515)
09-10 17:32:56.310+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 3515, appid: org.example.bluetooth, status: bg
09-10 17:33:46.509+0600 E/PKGMGR_SERVER( 4223): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:33:46.569+0600 E/PKGMGR  ( 4220): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 17:33:46.609+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:33:46.609+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 3515
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:33:46.619+0600 W/AUL     ( 4226): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3515)
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(3515), cmd(4)
09-10 17:33:46.619+0600 W/AUL     ( 4226): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 3515
09-10 17:33:46.619+0600 I/APP_CORE( 3515): appcore-efl.c: __do_app(520) > [APP 3515] Event: TERMINATE State: CREATED
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:33:46.619+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 3515): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:33:46.619+0600 E/APP_CORE( 3515): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 17:33:46.619+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:33:46.619+0600 E/APP_CORE( 3515): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:33:46.629+0600 I/CAPI_APPFW_APPLICATION( 3515): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:33:46.629+0600 E/CAPI_NETWORK_BLUETOOTH( 3515): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:33:46.689+0600 E/CAPI_NETWORK_BLUETOOTH( 3515): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:33:46.689+0600 E/CAPI_NETWORK_BLUETOOTH( 3515): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:33:46.689+0600 E/bluetooth( 3515): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:33:46.689+0600 I/CAPI_NETWORK_WIFI( 3515): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:33:46.689+0600 E/bluetooth( 3515): [wifi_deinitialize] Success.
09-10 17:33:46.709+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb789bac8), gem(18), surface(0xb7877090)
09-10 17:33:46.719+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb789bac8), gem(18), surface(0xb78bff80)
09-10 17:33:46.719+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:33:46.719+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 17:33:46.729+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7823e00), gem(30), surface(0xb78ae508)
09-10 17:33:46.729+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(14), surface(0xb7884560)
09-10 17:33:46.739+0600 E/PKGMGR_SERVER( 4223): pkgmgr-server.c: sighandler(417) > child NORMAL exit [4226]
09-10 17:33:46.749+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:33:46.749+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:33:46.749+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:33:46.749+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:33:46.749+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:33:46.749+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:33:46.799+0600 E/EFL     ( 3515): elementary<3515> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 17:33:46.949+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 3515 pgid = 3515
09-10 17:33:46.949+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(3515)
09-10 17:33:47.029+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:33:47.029+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:33:47.029+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:33:47.049+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[3515] terminate event is forwarded
09-10 17:33:47.049+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:33:47.049+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 3515, ]
09-10 17:33:47.049+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:33:47.049+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:33:47.049+0600 I/Tizen::App( 1366): (512) > Not registered pid(3515)
09-10 17:33:47.049+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:33:47.049+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:33:47.049+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 3515
09-10 17:33:47.049+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 3515
09-10 17:33:47.059+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2728
09-10 17:33:47.069+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:33:47.069+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:33:47.069+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 3515.
09-10 17:33:47.109+0600 W/CRASH_MANAGER( 4232): worker.c: worker_job(1199) > 1103515626162147350722
