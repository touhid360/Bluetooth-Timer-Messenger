S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 16372
Date: 2016-09-10 14:46:26+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16372, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb8077408
r2   = 0xb4397000, r3   = 0xb4397000
r4   = 0xb8043528, r5   = 0xbeda65bc
r6   = 0xb6a95310, r7   = 0xbeda641c
r8   = 0xb6a960f4, r9   = 0xb6a960f4
r10  = 0xb6aa420c, fp   = 0x00000000
ip   = 0xb2a8a3b4, sp   = 0xbeda4770
lr   = 0xb2a7e063, pc   = 0xb67796f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     71656 KB
Buffers:     39792 KB
Cached:     280880 KB
VmPeak:     114912 KB
VmSize:     112412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25176 KB
VmRSS:       25176 KB
VmData:      43952 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36232 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16372 TID = 16372
16372 16409 16530 16532 

Maps Information
b0a01000 b1200000 rw-p [stack:16532]
b1dd2000 b25d1000 rw-p [stack:16530]
b25d1000 b25e2000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25f2000 b25f7000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2683000 b268b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b269c000 b269d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b26ad000 b26c1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26d5000 b26d6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26e6000 b26e9000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26fa000 b26fb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b270b000 b270d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b271d000 b271f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b272f000 b273f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b274f000 b275b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b296c000 b2983000 r-xp /usr/lib/libnetwork.so.0.0.0
b2994000 b29d2000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29e3000 b29ea000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29fb000 b2a0a000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a1a000 b2a4f000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a62000 b2a68000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a78000 b2a82000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ba4000 b2c87000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2cbe000 b2ce6000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cf8000 b34f7000 rw-p [stack:16409]
b34f7000 b34f9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3509000 b3513000 r-xp /lib/libnss_files-2.20-2014.11.so
b3524000 b352d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b353e000 b354f000 r-xp /lib/libnsl-2.20-2014.11.so
b3562000 b3568000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3579000 b357a000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b35a2000 b35a9000 r-xp /usr/lib/libminizip.so.1.0.0
b35b9000 b35be000 r-xp /usr/lib/libstorage.so.0.1
b35ce000 b3623000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3639000 b364d000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b365d000 b36a1000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b36b1000 b36b9000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36c9000 b36f9000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b370c000 b37c5000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37d9000 b382d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b383e000 b3859000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3869000 b392a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b393d000 b394f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b395f000 b3963000 r-xp /usr/lib/libogg.so.0.7.1
b3973000 b3995000 r-xp /usr/lib/libvorbis.so.0.4.3
b39a5000 b3a89000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3aa5000 b3ab2000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3ac3000 b3b06000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b1b000 b3b62000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b73000 b3b79000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b8a000 b3b91000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ba1000 b3be1000 r-xp /usr/lib/libmdm.so.1.2.10
b3bf1000 b3bf9000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3c08000 b3c18000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c39000 b3c99000 r-xp /usr/lib/libasound.so.2.0.0
b3cab000 b3ce1000 r-xp /usr/lib/libpulse.so.0.16.2
b3cf2000 b3cf5000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3d05000 b3d08000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d18000 b3d1d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d2d000 b3d2e000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d3e000 b3d49000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d5d000 b3d64000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d74000 b3d7a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d8a000 b3d8f000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d9f000 b3dba000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3dca000 b3dd1000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3de1000 b3de4000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3df5000 b3e23000 r-xp /usr/lib/libidn.so.11.5.44
b3e33000 b3e49000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e5a000 b3e64000 r-xp /usr/lib/libcares.so.2.1.0
b3e74000 b3e7e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e8e000 b3e90000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3ea0000 b3ea1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3eb1000 b3eb5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3ec6000 b3eee000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eff000 b3f28000 r-xp /usr/lib/libturbojpeg.so
b3f48000 b3f4e000 r-xp /usr/lib/libgif.so.4.1.6
b3f5e000 b3fa4000 r-xp /usr/lib/libcurl.so.4.3.0
b3fb5000 b3fd6000 r-xp /usr/lib/libexif.so.12.3.3
b3ff1000 b4006000 r-xp /usr/lib/libtts.so
b4017000 b401f000 r-xp /usr/lib/libfeedback.so.0.1.4
b402f000 b40ef000 r-xp /usr/lib/libdali-core.so.0.0.0
b40fa000 b41ed000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b420d000 b42e7000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42fe000 b4300000 r-xp /usr/lib/libboost_system.so.1.51.0
b4310000 b4316000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4326000 b4349000 r-xp /usr/lib/libboost_thread.so.1.51.0
b435a000 b435c000 r-xp /usr/lib/libappsvc.so.0.1.0
b436c000 b436e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b437f000 b4384000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b439b000 b439d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b43ad000 b43b4000 r-xp /usr/lib/libsensord-share.so
b43c4000 b43dc000 r-xp /usr/lib/libsensor.so.1.1.0
b43ed000 b43f0000 r-xp /usr/lib/libXv.so.1.0.0
b4400000 b4405000 r-xp /usr/lib/libutilX.so.1.1.0
b4415000 b441a000 r-xp /usr/lib/libappcore-common.so.1.1
b442a000 b4431000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4444000 b4448000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4459000 b4523000 r-xp /usr/lib/libCOREGL.so.4.0
b453a000 b453d000 r-xp /usr/lib/libuuid.so.1.3.0
b454e000 b4565000 r-xp /usr/lib/libblkid.so.1.1.0
b4576000 b4578000 r-xp /usr/lib/libXau.so.6.0.0
b4588000 b458b000 r-xp /usr/lib/libEGL.so.1.4
b4593000 b4599000 r-xp /usr/lib/libxcb-render.so.0.0.0
b45a9000 b45ab000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45bc000 b45ca000 r-xp /usr/lib/libGLESv2.so.2.0
b45d3000 b4635000 r-xp /usr/lib/libpixman-1.so.0.28.2
b464a000 b4662000 r-xp /usr/lib/libmount.so.1.1.0
b4673000 b4687000 r-xp /usr/lib/libxcb.so.1.1.0
b4698000 b469f000 r-xp /lib/libcrypt-2.20-2014.11.so
b46d7000 b46e8000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46f9000 b46fb000 r-xp /usr/lib/libiri.so
b470b000 b4716000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4727000 b473c000 r-xp /lib/libexpat.so.1.5.2
b474e000 b480c000 r-xp /usr/lib/libcairo.so.2.11200.14
b481f000 b4827000 r-xp /usr/lib/libdrm.so.2.4.0
b4837000 b483a000 r-xp /usr/lib/libdri2.so.0.0.0
b484b000 b4899000 r-xp /usr/lib/libssl.so.1.0.0
b48ae000 b48ba000 r-xp /usr/lib/libeeze.so.1.13.0
b48ca000 b48d3000 r-xp /usr/lib/libethumb.so.1.13.0
b48e3000 b48e6000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48f6000 b4aad000 r-xp /usr/lib/libcrypto.so.1.0.0
b5704000 b570d000 r-xp /usr/lib/libXi.so.6.1.0
b571d000 b571f000 r-xp /usr/lib/libXgesture.so.7.0.0
b572f000 b5733000 r-xp /usr/lib/libXtst.so.6.1.0
b5743000 b5749000 r-xp /usr/lib/libXrender.so.1.3.0
b5759000 b575f000 r-xp /usr/lib/libXrandr.so.2.2.0
b5770000 b5772000 r-xp /usr/lib/libXinerama.so.1.0.0
b5782000 b5785000 r-xp /usr/lib/libXfixes.so.3.1.0
b5795000 b57a0000 r-xp /usr/lib/libXext.so.6.4.0
b57b0000 b57b2000 r-xp /usr/lib/libXdamage.so.1.1.0
b57c2000 b57c4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57d5000 b58b7000 r-xp /usr/lib/libX11.so.6.3.0
b58ca000 b58d1000 r-xp /usr/lib/libXcursor.so.1.0.2
b58e1000 b58f9000 r-xp /usr/lib/libudev.so.1.6.0
b58fb000 b58fe000 r-xp /lib/libattr.so.1.1.0
b590e000 b592e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5930000 b5935000 r-xp /usr/lib/libffi.so.6.0.2
b5945000 b595d000 r-xp /lib/libz.so.1.2.8
b596d000 b596f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b597f000 b5a54000 r-xp /usr/lib/libxml2.so.2.9.2
b5a69000 b5b04000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b20000 b5b23000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b33000 b5b4c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b5d000 b5b6e000 r-xp /lib/libresolv-2.20-2014.11.so
b5b82000 b5bfc000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5c11000 b5c13000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c23000 b5c2a000 r-xp /usr/lib/libembryo.so.1.13.0
b5c3a000 b5c52000 r-xp /usr/lib/libpng12.so.0.50.0
b5c63000 b5c86000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ca7000 b5cbb000 r-xp /usr/lib/libector.so.1.13.0
b5ccc000 b5ce4000 r-xp /usr/lib/liblua-5.1.so
b5cf5000 b5d4c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d60000 b5d88000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d99000 b5dac000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dbd000 b5df4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e05000 b5e13000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e23000 b5e2b000 r-xp /usr/lib/libtbm.so.1.0.0
b5e3b000 b5e48000 r-xp /usr/lib/libeio.so.1.13.0
b5e58000 b5e5a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e6a000 b5e6f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e7f000 b5e96000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea8000 b5ec8000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed8000 b5ef8000 r-xp /usr/lib/libecore_con.so.1.13.0
b5efa000 b5f00000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f10000 b5f21000 r-xp /usr/lib/libemotion.so.1.13.0
b5f32000 b5f39000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f49000 b5f58000 r-xp /usr/lib/libeo.so.1.13.0
b5f69000 b5f7b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f8c000 b5f91000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fa1000 b5fba000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fca000 b5fe7000 r-xp /usr/lib/libeet.so.1.13.0
b6000000 b6048000 r-xp /usr/lib/libeina.so.1.13.0
b6059000 b6069000 r-xp /usr/lib/libefl.so.1.13.0
b607a000 b615f000 r-xp /usr/lib/libicuuc.so.51.1
b617c000 b62bc000 r-xp /usr/lib/libicui18n.so.51.1
b62d3000 b630b000 r-xp /usr/lib/libecore_x.so.1.13.0
b631d000 b6320000 r-xp /lib/libcap.so.2.21
b6330000 b6359000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b636a000 b6371000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6383000 b63ba000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63cb000 b64b6000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c9000 b6542000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6554000 b6559000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6569000 b6573000 r-xp /usr/lib/libvconf.so.0.2.45
b6583000 b6585000 r-xp /usr/lib/libvasum.so.0.3.1
b6595000 b6597000 r-xp /usr/lib/libttrace.so.1.1
b65a7000 b65aa000 r-xp /usr/lib/libiniparser.so.0
b65ba000 b65e0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65f0000 b65f5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6606000 b661d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b662e000 b6699000 r-xp /lib/libm-2.20-2014.11.so
b66aa000 b66b0000 r-xp /lib/librt-2.20-2014.11.so
b66c1000 b66ce000 r-xp /usr/lib/libunwind.so.8.0.1
b6704000 b6828000 r-xp /lib/libc-2.20-2014.11.so
b683d000 b6856000 r-xp /lib/libgcc_s-4.9.so.1
b6866000 b6948000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6959000 b6983000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6994000 b69d0000 r-xp /usr/lib/libsystemd.so.0.4.0
b69d2000 b6a54000 r-xp /usr/lib/libedje.so.1.13.0
b6a67000 b6a85000 r-xp /usr/lib/libecore.so.1.13.0
b6aa5000 b6c2c000 r-xp /usr/lib/libevas.so.1.13.0
b6c61000 b6c75000 r-xp /lib/libpthread-2.20-2014.11.so
b6c89000 b6ebe000 r-xp /usr/lib/libelementary.so.1.13.0
b6eec000 b6ef0000 r-xp /usr/lib/libsmack.so.1.0.0
b6f00000 b6f07000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f17000 b6f19000 r-xp /usr/lib/libdlog.so.0.0.0
b6f29000 b6f2c000 r-xp /usr/lib/libbundle.so.0.1.22
b6f3c000 b6f3e000 r-xp /lib/libdl-2.20-2014.11.so
b6f4f000 b6f67000 r-xp /usr/lib/libaul.so.0.1.0
b6f7b000 b6f80000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f91000 b6f9e000 r-xp /usr/lib/liblptcp.so
b6fb0000 b6fb4000 r-xp /usr/lib/libsys-assert.so
b6fc5000 b6fe5000 r-xp /lib/ld-2.20-2014.11.so
b6ff6000 b6ffb000 r-xp /usr/bin/launchpad-loader
b8001000 b8333000 rw-p [heap]
bed86000 beda7000 rw-p [stack]
b8001000 b8333000 rw-p [heap]
bed86000 beda7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16372)
Call Stack Count: 1
 0: (0xb67796f0) [/lib/libc.so.6] + 0x756f0
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
14:46:19.895+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=8626917
09-10 14:46:19.965+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=8626991
09-10 14:46:20.466+0600 D/bluetooth(16372): Callback: Disconnected.
09-10 14:46:20.466+0600 D/bluetooth(16372): Callback: Socket of disconnection - 46.
09-10 14:46:20.466+0600 D/bluetooth(16372): Callback: Address of connection - 90:00:DB:03:35:2E.
09-10 14:46:21.076+0600 I/Tizen::System( 1366): (340) > Setting event[http://tizen.org/setting/network.bluetooth] is occured.
09-10 14:46:21.076+0600 I/Tizen::System( 1366): (362) > Event is delivered to b7f61910.
09-10 14:46:21.096+0600 E/EFL     (  991): edje<991> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/setting_icon_wvga has a non-fixed part 'bg.image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:46:21.357+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:21.357+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:21.357+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:21.357+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:21.367+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:46:21.367+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:46:21.447+0600 D/bluetooth(16372): [adapter_state_changed_cb] Bluetooth is disabled!
09-10 14:46:21.457+0600 I/Tizen::System( 1366): (1389) > Bluetooth callback is invoked. result:0, adapter_state:0, user_data:b804c5b8
09-10 14:46:21.457+0600 E/Tizen::System( 1366): (1393) > Bluetooth processing is under way.
09-10 14:46:21.457+0600 I/QUICKPANEL(  991): BluetoothQuickBtnControl.cpp: __onBluetoothStatusChanged(147) > [0;32mbluetooth state : 0[0;m
09-10 14:46:21.477+0600 E/EFL     (  991): edje<991> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/setting_icon_wvga has a non-fixed part 'bg.image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:46:22.748+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=8629767
09-10 14:46:22.748+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=8629767
09-10 14:46:22.768+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=8629795
09-10 14:46:22.868+0600 E/CAPI_NETWORK_WIFI(  991): net_wifi.c: wifi_deactivate(156) > wifi_deactivate is called : return[0]
09-10 14:46:22.898+0600 E/EFL     (  991): edje<991> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/setting_icon_wvga has a non-fixed part 'bg.image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:46:22.928+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 14:46:22.928+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/587/status successfully
09-10 14:46:22.928+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
09-10 14:46:22.928+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(674849178) zone(/)
09-10 14:46:22.928+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 14:46:22.928+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 09:07:15 (UTC).
09-10 14:46:22.928+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 14:46:22.928+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[674849178] is removed.
09-10 14:46:22.978+0600 I/CAPI_NETWORK_WIFI(16372): libnetwork.c: __libnet_evt_cb(742) > state: ASSOCIATION
09-10 14:46:22.988+0600 I/CAPI_NETWORK_WIFI(12946): libnetwork.c: __libnet_evt_cb(742) > state: ASSOCIATION
09-10 14:46:22.988+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 14:46:22.988+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(510) > state: ASSOCIATION
09-10 14:46:22.988+0600 I/CAPI_NETWORK_WIFI( 1366): libnetwork.c: __libnet_evt_cb(742) > state: ASSOCIATION
09-10 14:46:23.048+0600 I/CAPI_NETWORK_WIFI(  991): libnetwork.c: __libnet_evt_cb(742) > state: ASSOCIATION
09-10 14:46:23.048+0600 E/CAPI_NETWORK_WIFI(12946): libnetwork.c: __libnet_evt_cb(711) > Connection close error NONE
09-10 14:46:23.048+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(482) > Connection closed IND[NONE]
09-10 14:46:23.048+0600 E/CAPI_NETWORK_WIFI(16372): libnetwork.c: __libnet_evt_cb(711) > Connection close error NONE
09-10 14:46:23.048+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(489) > Successfully closed connection
09-10 14:46:23.048+0600 E/CAPI_NETWORK_WIFI( 1366): libnetwork.c: __libnet_evt_cb(711) > Connection close error NONE
09-10 14:46:23.058+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 14:46:23.058+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(510) > state: ASSOCIATION
09-10 14:46:23.058+0600 I/CAPI_NETWORK_WIFI( 1572): libnetwork.c: __libnet_evt_cb(742) > state: ASSOCIATION
09-10 14:46:23.058+0600 I/CAPI_NETWORK_WIFI(12946): libnetwork.c: __libnet_evt_cb(742) > state: DISCONNECTED
09-10 14:46:23.058+0600 I/CAPI_NETWORK_WIFI(16372): libnetwork.c: __libnet_evt_cb(742) > state: DISCONNECTED
09-10 14:46:23.058+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 14:46:23.058+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(510) > state: DISCONNECTED
09-10 14:46:23.058+0600 I/CAPI_NETWORK_WIFI( 1366): libnetwork.c: __libnet_evt_cb(742) > state: DISCONNECTED
09-10 14:46:23.068+0600 E/CAPI_NETWORK_WIFI(  991): libnetwork.c: __libnet_evt_cb(711) > Connection close error NONE
09-10 14:46:23.068+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(742) > state: ASSOCIATION
09-10 14:46:23.068+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(482) > Connection closed IND[NONE]
09-10 14:46:23.068+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(489) > Successfully closed connection
09-10 14:46:23.068+0600 E/CAPI_NETWORK_WIFI( 1572): libnetwork.c: __libnet_evt_cb(711) > Connection close error NONE
09-10 14:46:23.068+0600 I/CAPI_NETWORK_WIFI(  991): libnetwork.c: __libnet_evt_cb(742) > state: DISCONNECTED
09-10 14:46:23.078+0600 E/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(711) > Connection close error NONE
09-10 14:46:23.078+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 14:46:23.078+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(510) > state: DISCONNECTED
09-10 14:46:23.078+0600 I/CAPI_NETWORK_WIFI( 1572): libnetwork.c: __libnet_evt_cb(742) > state: DISCONNECTED
09-10 14:46:23.078+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(742) > state: DISCONNECTED
09-10 14:46:23.108+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 14:46:23.118+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 14:46:23.118+0600 E/ALARM_MANAGER( 1116): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(1), start(10-9-2016, 14:46:24), repeat(0), interval(0), type(-1073741822)
09-10 14:46:23.118+0600 I/SYNCSERVICE( 1063): SyncManager_NetworkChangeListener.cpp: OnConnectionChanged(35) > Network connection changed 0
09-10 14:46:23.118+0600 I/SYNCSERVICE( 1063): SyncManager_SyncManager.cpp: OnWifiStatusChanged(330) > Wifi network change detected 0
09-10 14:46:23.118+0600 I/SYNCSERVICE( 1063): SyncManager_SyncManager.cpp: OnDNetStatusChanged(316) > Data network change detected 0
09-10 14:46:23.118+0600 I/SYNCSERVICE( 1063): SyncManager_SyncManager.cpp: OnBluetoothStatusChanged(344) > Bluetooth status 0
09-10 14:46:23.118+0600 I/Sage    ( 1572): SageBizLogicInit.c: __WifiConnectionChangedCb(246) > [Sage][SageBizLogicInit] __WifiConnectionChangedCb()
09-10 14:46:23.118+0600 I/Sage    ( 1572): SageBizLogicInit.c: __WifiConnectionChangedCb(248) > [Sage][SageBizLogic] InitState : -1
09-10 14:46:23.118+0600 I/Sage    ( 1572): SageBizLogicInit.c: __WifiConnectionChangedCb(274) > [Sage][SageBizLogicInit] type != CONNECTION_TYPE_WIFI
09-10 14:46:23.118+0600 I/Sage    ( 1572): SageBizLogicReservedDL.c: SageBizLogicReservedDL_WifiOff(83) > [Sage][SageBizLogicReservedDL] SageBizLogicReservedDL_WifiOFF()
09-10 14:46:23.118+0600 I/Sage    ( 1572): SageBizLogicReservedDL.c: SageBizLogicReservedDL_WifiOff(87) > [Sage][SageBizLogicReservedDL] !gIsRunning
09-10 14:46:23.118+0600 E/CAPI_NETWORK_CONNECTION( 1068): connection.c: __connection_cb_ip_changed_cb_idle(239) > Unknown IP address type: IP() 
09-10 14:46:23.118+0600 E/CAPI_NETWORK_CONNECTION( 1068): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 14:46:23.128+0600 E/CAPI_NETWORK_CONNECTION( 1572): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 14:46:23.128+0600 I/Sage    ( 1572): MintNetTransactionHandler.c: __httpProxyChangedCb(290) > [Sage][MintNetTransaction] Proxy setting changed
09-10 14:46:23.128+0600 I/Sage    ( 1572): MintNetTransactionHandler.c: __httpProxyChangedCb(293) > [Sage][MintNetTransaction] Proxy setting changed proxy(ipv4) Addr = 
09-10 14:46:23.128+0600 I/Tizen::System( 1366): (340) > Setting event[http://tizen.org/setting/network.wifi] is occured.
09-10 14:46:23.128+0600 I/Tizen::System( 1366): (362) > Event is delivered to b7f61910.
09-10 14:46:23.128+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 14:46:23.128+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 14:46:23.128+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 14:46:23.128+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:46:23.138+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 14:46:23.148+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 14:46:23.148+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:46:23.158+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 14:46:23.168+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 14:46:23.168+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 38
09-10 14:46:23.168+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
09-10 14:46:23.168+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
09-10 14:46:23.168+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1473497184, Sat Sep 10 14:46:24 2016
09-10 14:46:23.168+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 885388302, next duetime: 1473497184
09-10 14:46:23.168+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(885388302)
09-10 14:46:23.168+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1473498435), due_time(1473497184)
09-10 14:46:23.168+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 14:46:23.168+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 08:46:24 (UTC).
09-10 14:46:23.168+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 14:46:23.178+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 14:46:23.178+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 14:46:23.178+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 14:46:23.178+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(885388302) zone(/)
09-10 14:46:23.178+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 14:46:23.178+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 09:07:15 (UTC).
09-10 14:46:23.298+0600 E/WIFI_LOADER(16740): wifi-loader.c: wifi_stop(415) > wifi_stop called
09-10 14:46:23.308+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 14:46:23.308+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[885388302] is removed.
09-10 14:46:23.318+0600 E/PUSHD   ( 1116): spp.c: _when_st_run_ends(3021) > Push server disconnected
09-10 14:46:23.338+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 14:46:23.338+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 14:46:23.338+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 14:46:23.338+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1446072653) zone(/)
09-10 14:46:23.338+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 14:46:23.338+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 18:00:00 (UTC).
09-10 14:46:23.349+0600 I/CAPI_NETWORK_WIFI(12946): libnetwork.c: __libnet_power_on_off_cb(453) > Wi-Fi power off
09-10 14:46:23.349+0600 I/CAPI_NETWORK_WIFI( 1366): libnetwork.c: __libnet_power_on_off_cb(453) > Wi-Fi power off
09-10 14:46:23.349+0600 I/CAPI_NETWORK_WIFI(  991): libnetwork.c: __libnet_power_on_off_cb(453) > Wi-Fi power off
09-10 14:46:23.369+0600 E/EFL     (  991): edje<991> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/setting_icon_wvga has a non-fixed part 'bg.image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:46:23.379+0600 I/Tizen::System( 1366): (340) > Setting event[http://tizen.org/setting/network.wifi] is occured.
09-10 14:46:23.379+0600 I/Tizen::System( 1366): (362) > Event is delivered to b7f61910.
09-10 14:46:23.389+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_power_on_off_cb(453) > Wi-Fi power off
09-10 14:46:23.399+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:23.399+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:23.399+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:23.399+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 14:46:23.399+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:46:23.399+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 14:46:23.469+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 14:46:23.469+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[1446072653] is removed.
09-10 14:46:23.469+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 14:46:23.469+0600 W/PUSHD   ( 1116): State transition: [RUN]-> [NETWORK_OPEN]
09-10 14:46:23.469+0600 I/CAPI_NETWORK_CONNECTION( 1116): connection.c: connection_get_type(496) > Connected Network = 0
09-10 14:46:23.469+0600 E/PUSHD   ( 1116): spp.c: _when_st_nopen_begins(2754) > Net state : disconnected
09-10 14:46:23.469+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [NETWORK_OPEN] : waiting...
09-10 14:46:23.529+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 14:46:24.009+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=8631029
09-10 14:46:24.019+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=8631029
09-10 14:46:24.109+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=8631133
09-10 14:46:24.109+0600 E/EFL     (  283): <283> e_mod_processmgr.c:486 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
09-10 14:46:24.119+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(991) status(4)
09-10 14:46:24.119+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.quickpanel(991)
09-10 14:46:24.119+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 991, appid: com.samsung.quickpanel, status: bg
09-10 14:46:24.129+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=8631133
09-10 14:46:24.129+0600 I/APP_CORE(  991): appcore-efl.c: __do_app(520) > [APP 991] Event: PAUSE State: RUNNING
09-10 14:46:24.129+0600 I/CAPI_APPFW_APPLICATION(  991): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:46:24.380+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __onEcoreEventMsgReceived(973) > [0;31m* Critical * Quickpanel is opened.[0;m
09-10 14:46:24.380+0600 W/LOCKSCREEN(  869): event.c: _ecore_event_client_message_cb(119) > [_ecore_event_client_message_cb:119:W] quickpanel is closed
09-10 14:46:24.380+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:100001:QUICKPANEL_OFF
09-10 14:46:24.380+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:100001 event_info:0
09-10 14:46:24.380+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __onEcoreEventMsgReceived(934) > [0;31m* Critical * Quickpanel is closed.[0;m
09-10 14:46:24.380+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __ungrabKeyEvent(534) > [0;31m* Critical * failed to ungrab KEY_SELECT[0;m
09-10 14:46:24.590+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=8631614
09-10 14:46:24.590+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 14:46:24.590+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 14:46:24.600+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:46:24.600+0600 E/EFL     (16372): ecore_x<16372> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=8631614
09-10 14:46:24.900+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 14:46:24.900+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:46:24.900+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:46:24.900+0600 E/STARTER (  763): )
09-10 14:46:24.900+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 14:46:24.900+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:46:24.900+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:46:24.900+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 14:46:24.910+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 14:46:24.910+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 14:46:24.910+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 14:46:24.910+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 14:46:24.910+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 14:46:24.920+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 14:46:24.920+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 14:46:24.920+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 14:46:24.920+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 14:46:24.920+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 14:46:24.920+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 14:46:24.930+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 14:46:24.930+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 14:46:24.940+0600 E/CAPI_APPFW_APPLICATION(16506): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:46:24.940+0600 E/CAPI_APPFW_APPLICATION(16506): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:46:24.940+0600 E/CAPI_APPFW_APPLICATION(16506): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:46:24.940+0600 E/CAPI_APPFW_APPLICATION(16506): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:46:24.940+0600 E/CAPI_APPFW_APPLICATION(16506): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 14:46:24.940+0600 I/CAPI_APPFW_APPLICATION(16506): app_main.c: ui_app_main(789) > app_efl_main
09-10 14:46:24.940+0600 I/CAPI_APPFW_APPLICATION(16506): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 14:46:24.960+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7737e90), gem(10), surface(0xb7808968)
09-10 14:46:24.960+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7737e90), gem(10), surface(0xb7876938)
09-10 14:46:24.960+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 14:46:24.970+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 14:46:24.970+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 14:46:25.020+0600 W/TASK_MGR_LITE(16506): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 14:46:25.020+0600 I/GXT_SIB (16506): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 14:46:25.030+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 16506, appid: com.samsung.task-mgr
09-10 14:46:25.030+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 14:46:25.040+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16506)
09-10 14:46:25.040+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:46:25.090+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 14:46:25.100+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:46:25.100+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:46:25.100+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:46:25.100+0600 E/RUA     (16506): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 18, ncols : 5
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 14:46:25.100+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:46:25.100+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 16372
09-10 14:46:25.100+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 14:46:25.100+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 14:46:25.140+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 14:46:25.140+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:46:25.160+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:46:25.160+0600 I/TIZEN_N_SOUND_MANAGER(12946): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 14:46:25.160+0600 E/TIZEN_N_SOUND_MANAGER(12946): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:46:25.160+0600 I/TIZEN_N_SOUND_MANAGER(12946): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 14:46:25.160+0600 E/TIZEN_N_SOUND_MANAGER(12946): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:46:25.160+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:46:25.190+0600 I/APP_CORE(16506): appcore-efl.c: __do_app(520) > [APP 16506] Event: RESET State: CREATED
09-10 14:46:25.190+0600 I/CAPI_APPFW_APPLICATION(16506): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 14:46:25.200+0600 E/EFL     (16506): edje<16506> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:46:25.200+0600 E/EFL     (16506): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:46:25.200+0600 E/EFL     (16506): edje<16506> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:46:25.200+0600 E/EFL     (16506): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:46:25.210+0600 W/APP_CORE(16506): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5000003
09-10 14:46:25.210+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 14:46:25.270+0600 I/MALI    (16506): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb8338f38)
09-10 14:46:25.290+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb781c980), gem(23), surface(0xb7801628)
09-10 14:46:25.300+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(16372) status(4)
09-10 14:46:25.300+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(16372)
09-10 14:46:25.300+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 16372, appid: org.example.bluetooth, status: bg
09-10 14:46:25.300+0600 I/APP_CORE(16372): appcore-efl.c: __do_app(520) > [APP 16372] Event: PAUSE State: RUNNING
09-10 14:46:25.300+0600 I/CAPI_APPFW_APPLICATION(16372): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:46:25.310+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(16506) status(3)
09-10 14:46:25.310+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:46:25.310+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:46:25.310+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(16506)
09-10 14:46:25.310+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 16506, appid: com.samsung.task-mgr, status: fg
09-10 14:46:25.310+0600 I/MALI    (16506): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:46:25.310+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:46:25.320+0600 I/APP_CORE(16506): appcore-efl.c: __do_app(520) > [APP 16506] Event: RESUME State: CREATED
09-10 14:46:25.330+0600 I/TIZEN_N_EFL_UTIL_WINDOW(16372): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 28
09-10 14:46:25.330+0600 E/APP_CORE(16372): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 14:46:25.330+0600 I/APP_CORE(16506): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 14:46:25.330+0600 I/APP_CORE(16506): appcore-efl.c: __do_app(637) > [APP 16506] Initial Launching, call the resume_cb
09-10 14:46:25.330+0600 I/CAPI_APPFW_APPLICATION(16506): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:46:25.340+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76e5738), gem(19), surface(0xb78ae1a0)
09-10 14:46:25.340+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:46:25.340+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(16506) status(0)
09-10 14:46:25.340+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:46:25.551+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 14:46:25.551+0600 E/EFL     (16372): ecore_x<16372> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=8632569
09-10 14:46:25.551+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=8632569
09-10 14:46:25.551+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 14:46:25.551+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 14:46:25.551+0600 E/STARTER (  763): )
09-10 14:46:25.551+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 14:46:25.551+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 14:46:25.551+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:46:25.551+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:46:25.631+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 14:46:25.691+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 14:46:26.071+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1194
09-10 14:46:26.081+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 14:46:26.081+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 16506.
09-10 14:46:26.161+0600 E/EFL     (16506): ecore_x<16506> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=8633180
09-10 14:46:26.221+0600 E/EFL     (16506): ecore_x<16506> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=8633240
09-10 14:46:26.221+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:46:26.221+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 16372
09-10 14:46:26.221+0600 W/AUL     (16506): launch.c: app_request_to_launchpad(396) > request cmd(4) to(16372)
09-10 14:46:26.221+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 14:46:26.231+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(16372), cmd(4)
09-10 14:46:26.231+0600 W/AUL     (16506): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 14:46:26.231+0600 I/APP_CORE(16372): appcore-efl.c: __do_app(520) > [APP 16372] Event: TERMINATE State: PAUSED
09-10 14:46:26.231+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:46:26.231+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:46:26.231+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:46:26.231+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:46:26.241+0600 I/TIZEN_N_EFL_UTIL_WINDOW(16372): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 14:46:26.241+0600 E/APP_CORE(16372): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 14:46:26.241+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:46:26.241+0600 E/APP_CORE(16372): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 14:46:26.241+0600 I/CAPI_APPFW_APPLICATION(16372): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:46:26.241+0600 E/CAPI_NETWORK_BLUETOOTH(16372): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 14:46:26.261+0600 I/MALI    (16506): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:46:26.261+0600 I/MALI    (16506): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:46:26.281+0600 I/MALI    (16506): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:46:26.321+0600 E/CAPI_NETWORK_BLUETOOTH(16372): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 14:46:26.321+0600 E/CAPI_NETWORK_BLUETOOTH(16372): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 14:46:26.321+0600 E/bluetooth(16372): [bt_adapter_le_destroy_advertiser] Failed.
09-10 14:46:26.331+0600 I/CAPI_NETWORK_WIFI(16372): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 14:46:26.331+0600 E/bluetooth(16372): [wifi_deinitialize] Success.
09-10 14:46:26.442+0600 E/EFL     (16372): elementary<16372> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 14:46:26.502+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:46:26.502+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:46:26.502+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(16506)
09-10 14:46:26.502+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 16506, appid: com.samsung.task-mgr, status: bg
09-10 14:46:26.502+0600 I/CAPI_APPFW_APPLICATION(16506): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:46:26.502+0600 W/TASK_MGR_LITE(16506): task-mgr-lite.c: _pause_app(406) > 
09-10 14:46:26.502+0600 I/CAPI_APPFW_APPLICATION(16506): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:46:26.512+0600 E/TASK_MGR_LITE(16506): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 14:46:26.522+0600 E/APP_CORE(16506): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 14:46:26.522+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:46:26.532+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 14:46:26.532+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:46:26.532+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:46:26.532+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 14:46:26.532+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 14:46:26.542+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:46:26.572+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7878218), gem(19), surface(0xb7876938)
09-10 14:46:26.582+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:46:26.592+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7805ab0), gem(22), surface(0xb7808968)
09-10 14:46:26.622+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb773cdf0), gem(26), surface(0xb7801628)
09-10 14:46:26.622+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb773cdf0), gem(26), surface(0xb78ae1a0)
09-10 14:46:26.652+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 14:46:26.652+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:46:26.652+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 14:46:26.662+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:46:26.672+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16372 pgid = 16372
09-10 14:46:26.672+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(16372)
09-10 14:46:26.672+0600 I/MALI    (16506): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 14:46:26.672+0600 I/MALI    (16506): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=16506   close drm_fd=29 
09-10 14:46:26.672+0600 I/MALI    (16506): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 14:46:26.692+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7878218), gem(19), surface(0xb7891500)
09-10 14:46:26.702+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 14:46:26.702+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 14:46:26.702+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 14:46:26.702+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 16372
09-10 14:46:26.712+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1195
09-10 14:46:26.772+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 14:46:26.812+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 14:46:26.872+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 14:46:26.902+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb82cd6b0]
09-10 14:46:26.902+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 14:46:26.902+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 14:46:26.902+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 14:46:26.902+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb82cd6b0
09-10 14:46:26.912+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 14:46:26.912+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-10 14:46:26.912+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-10 14:46:26.912+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 14:46:26.912+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 14:46:26.912+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 14:46:26.932+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76accf0), gem(22), surface(0xb7808968)
09-10 14:46:26.982+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:46:26.992+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16372
09-10 14:46:27.012+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 14:46:27.012+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 14:46:27.012+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[16372] terminate event is forwarded
09-10 14:46:27.012+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:46:27.012+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 16372, ]
09-10 14:46:27.012+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:46:27.012+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 14:46:27.012+0600 I/Tizen::App( 1366): (512) > Not registered pid(16372)
09-10 14:46:27.012+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 14:46:27.012+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:46:27.032+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:46:27.032+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 16372.
09-10 14:46:27.082+0600 W/CRASH_MANAGER(16756): worker.c: worker_job(1199) > 1116372626162147349718
