S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 31014
Date: 2016-09-10 17:20:27+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 31014, uid 5000)

Register Information
r0   = 0x00000045, r1   = 0x00000000
r2   = 0xb697f38c, r3   = 0x00000000
r4   = 0x00000045, r5   = 0xb7096fd0
r6   = 0xb70c2410, r7   = 0xb6a8184c
r8   = 0xb6a9020c, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb6a6e300
ip   = 0xb69604dd, sp   = 0xbed86058
lr   = 0xb5e9e299, pc   = 0xb69604ea
cpsr = 0x60060030

Memory Information
MemTotal:   730440 KB
MemFree:     41244 KB
Buffers:     43984 KB
Cached:     292204 KB
VmPeak:     120848 KB
VmSize:     117556 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25972 KB
VmRSS:       25968 KB
VmData:      44420 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36240 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 31014 TID = 31014
31014 31059 31234 31237 

Maps Information
b0a01000 b1200000 rw-p [stack:31237]
b1d50000 b1d55000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1dc2000 b25c1000 rw-p [stack:31234]
b25c1000 b25d2000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25e2000 b25e7000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2673000 b267b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b268c000 b268d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b269d000 b26b1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26c5000 b26c6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26d6000 b26d9000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26ea000 b26eb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26fb000 b26fd000 r-xp /usr/lib/libxcb-present.so.0.0.0
b270d000 b270f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b271f000 b272f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b273f000 b274b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b295c000 b2973000 r-xp /usr/lib/libnetwork.so.0.0.0
b2984000 b29c2000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29d3000 b29da000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29eb000 b29fa000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a0a000 b2a3f000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a52000 b2a58000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a68000 b2a6f000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b90000 b2c73000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2caa000 b2cd2000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ce4000 b34e3000 rw-p [stack:31059]
b34e3000 b34e5000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34f5000 b34ff000 r-xp /lib/libnss_files-2.20-2014.11.so
b3510000 b3519000 r-xp /lib/libnss_nis-2.20-2014.11.so
b352a000 b353b000 r-xp /lib/libnsl-2.20-2014.11.so
b354e000 b3554000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3565000 b3566000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b358e000 b3595000 r-xp /usr/lib/libminizip.so.1.0.0
b35a5000 b35aa000 r-xp /usr/lib/libstorage.so.0.1
b35ba000 b360f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3625000 b3639000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3649000 b368d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b369d000 b36a5000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36b5000 b36e5000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36f8000 b37b1000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37c5000 b3819000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b382a000 b3845000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3855000 b3916000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3929000 b393b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b394b000 b394f000 r-xp /usr/lib/libogg.so.0.7.1
b395f000 b3981000 r-xp /usr/lib/libvorbis.so.0.4.3
b3991000 b3a75000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a91000 b3a9e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3aaf000 b3af2000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b07000 b3b4e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b5f000 b3b65000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b76000 b3b7d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b8d000 b3bcd000 r-xp /usr/lib/libmdm.so.1.2.10
b3bdd000 b3be5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bf4000 b3c04000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c25000 b3c85000 r-xp /usr/lib/libasound.so.2.0.0
b3c97000 b3ccd000 r-xp /usr/lib/libpulse.so.0.16.2
b3cde000 b3ce1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cf1000 b3cf4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d04000 b3d09000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d19000 b3d1a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d2a000 b3d35000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d49000 b3d50000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d60000 b3d66000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d76000 b3d7b000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d8b000 b3da6000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3db6000 b3dbd000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dcd000 b3dd0000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3de1000 b3e0f000 r-xp /usr/lib/libidn.so.11.5.44
b3e1f000 b3e35000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e46000 b3e50000 r-xp /usr/lib/libcares.so.2.1.0
b3e60000 b3e6a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e7a000 b3e7c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e8c000 b3e8d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e9d000 b3ea1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eb2000 b3eda000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eeb000 b3f14000 r-xp /usr/lib/libturbojpeg.so
b3f34000 b3f3a000 r-xp /usr/lib/libgif.so.4.1.6
b3f4a000 b3f90000 r-xp /usr/lib/libcurl.so.4.3.0
b3fa1000 b3fc2000 r-xp /usr/lib/libexif.so.12.3.3
b3fdd000 b3ff2000 r-xp /usr/lib/libtts.so
b4003000 b400b000 r-xp /usr/lib/libfeedback.so.0.1.4
b401b000 b40db000 r-xp /usr/lib/libdali-core.so.0.0.0
b40e6000 b41d9000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41f9000 b42d3000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42ea000 b42ec000 r-xp /usr/lib/libboost_system.so.1.51.0
b42fc000 b4302000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4312000 b4335000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4346000 b4348000 r-xp /usr/lib/libappsvc.so.0.1.0
b4358000 b435a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b436b000 b4370000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4387000 b4389000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4399000 b43a0000 r-xp /usr/lib/libsensord-share.so
b43b0000 b43c8000 r-xp /usr/lib/libsensor.so.1.1.0
b43d9000 b43dc000 r-xp /usr/lib/libXv.so.1.0.0
b43ec000 b43f1000 r-xp /usr/lib/libutilX.so.1.1.0
b4401000 b4406000 r-xp /usr/lib/libappcore-common.so.1.1
b4416000 b441d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4430000 b4434000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4445000 b450f000 r-xp /usr/lib/libCOREGL.so.4.0
b4526000 b4529000 r-xp /usr/lib/libuuid.so.1.3.0
b453a000 b4551000 r-xp /usr/lib/libblkid.so.1.1.0
b4562000 b4564000 r-xp /usr/lib/libXau.so.6.0.0
b4574000 b4577000 r-xp /usr/lib/libEGL.so.1.4
b457f000 b4585000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4595000 b4597000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45a8000 b45b6000 r-xp /usr/lib/libGLESv2.so.2.0
b45bf000 b4621000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4636000 b464e000 r-xp /usr/lib/libmount.so.1.1.0
b465f000 b4673000 r-xp /usr/lib/libxcb.so.1.1.0
b4684000 b468b000 r-xp /lib/libcrypt-2.20-2014.11.so
b46c3000 b46d4000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46e5000 b46e7000 r-xp /usr/lib/libiri.so
b46f7000 b4702000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4713000 b4728000 r-xp /lib/libexpat.so.1.5.2
b473a000 b47f8000 r-xp /usr/lib/libcairo.so.2.11200.14
b480b000 b4813000 r-xp /usr/lib/libdrm.so.2.4.0
b4823000 b4826000 r-xp /usr/lib/libdri2.so.0.0.0
b4837000 b4885000 r-xp /usr/lib/libssl.so.1.0.0
b489a000 b48a6000 r-xp /usr/lib/libeeze.so.1.13.0
b48b6000 b48bf000 r-xp /usr/lib/libethumb.so.1.13.0
b48cf000 b48d2000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48e2000 b4a99000 r-xp /usr/lib/libcrypto.so.1.0.0
b56f0000 b56f9000 r-xp /usr/lib/libXi.so.6.1.0
b5709000 b570b000 r-xp /usr/lib/libXgesture.so.7.0.0
b571b000 b571f000 r-xp /usr/lib/libXtst.so.6.1.0
b572f000 b5735000 r-xp /usr/lib/libXrender.so.1.3.0
b5745000 b574b000 r-xp /usr/lib/libXrandr.so.2.2.0
b575c000 b575e000 r-xp /usr/lib/libXinerama.so.1.0.0
b576e000 b5771000 r-xp /usr/lib/libXfixes.so.3.1.0
b5781000 b578c000 r-xp /usr/lib/libXext.so.6.4.0
b579c000 b579e000 r-xp /usr/lib/libXdamage.so.1.1.0
b57ae000 b57b0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57c1000 b58a3000 r-xp /usr/lib/libX11.so.6.3.0
b58b6000 b58bd000 r-xp /usr/lib/libXcursor.so.1.0.2
b58cd000 b58e5000 r-xp /usr/lib/libudev.so.1.6.0
b58e7000 b58ea000 r-xp /lib/libattr.so.1.1.0
b58fa000 b591a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b591c000 b5921000 r-xp /usr/lib/libffi.so.6.0.2
b5931000 b5949000 r-xp /lib/libz.so.1.2.8
b5959000 b595b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b596b000 b5a40000 r-xp /usr/lib/libxml2.so.2.9.2
b5a55000 b5af0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b0c000 b5b0f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b1f000 b5b38000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b49000 b5b5a000 r-xp /lib/libresolv-2.20-2014.11.so
b5b6e000 b5be8000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bfd000 b5bff000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c0f000 b5c16000 r-xp /usr/lib/libembryo.so.1.13.0
b5c26000 b5c3e000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4f000 b5c72000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c93000 b5ca7000 r-xp /usr/lib/libector.so.1.13.0
b5cb8000 b5cd0000 r-xp /usr/lib/liblua-5.1.so
b5ce1000 b5d38000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4c000 b5d74000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d85000 b5d98000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da9000 b5de0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df1000 b5dff000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e0f000 b5e17000 r-xp /usr/lib/libtbm.so.1.0.0
b5e27000 b5e34000 r-xp /usr/lib/libeio.so.1.13.0
b5e44000 b5e46000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e56000 b5e5b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6b000 b5e82000 r-xp /usr/lib/libefreet.so.1.13.0
b5e94000 b5eb4000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec4000 b5ee4000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee6000 b5eec000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5efc000 b5f0d000 r-xp /usr/lib/libemotion.so.1.13.0
b5f1e000 b5f25000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f35000 b5f44000 r-xp /usr/lib/libeo.so.1.13.0
b5f55000 b5f67000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f78000 b5f7d000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8d000 b5fa6000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb6000 b5fd3000 r-xp /usr/lib/libeet.so.1.13.0
b5fec000 b6034000 r-xp /usr/lib/libeina.so.1.13.0
b6045000 b6055000 r-xp /usr/lib/libefl.so.1.13.0
b6066000 b614b000 r-xp /usr/lib/libicuuc.so.51.1
b6168000 b62a8000 r-xp /usr/lib/libicui18n.so.51.1
b62bf000 b62f7000 r-xp /usr/lib/libecore_x.so.1.13.0
b6309000 b630c000 r-xp /lib/libcap.so.2.21
b631c000 b6345000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6356000 b635d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b636f000 b63a6000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b7000 b64a2000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b5000 b652e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6540000 b6545000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6555000 b655f000 r-xp /usr/lib/libvconf.so.0.2.45
b656f000 b6571000 r-xp /usr/lib/libvasum.so.0.3.1
b6581000 b6583000 r-xp /usr/lib/libttrace.so.1.1
b6593000 b6596000 r-xp /usr/lib/libiniparser.so.0
b65a6000 b65cc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65dc000 b65e1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f2000 b6609000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661a000 b6685000 r-xp /lib/libm-2.20-2014.11.so
b6696000 b669c000 r-xp /lib/librt-2.20-2014.11.so
b66ad000 b66ba000 r-xp /usr/lib/libunwind.so.8.0.1
b66f0000 b6814000 r-xp /lib/libc-2.20-2014.11.so
b6829000 b6842000 r-xp /lib/libgcc_s-4.9.so.1
b6852000 b6934000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6945000 b696f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6980000 b69bc000 r-xp /usr/lib/libsystemd.so.0.4.0
b69be000 b6a40000 r-xp /usr/lib/libedje.so.1.13.0
b6a53000 b6a71000 r-xp /usr/lib/libecore.so.1.13.0
b6a91000 b6c18000 r-xp /usr/lib/libevas.so.1.13.0
b6c4d000 b6c61000 r-xp /lib/libpthread-2.20-2014.11.so
b6c75000 b6eaa000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed8000 b6edc000 r-xp /usr/lib/libsmack.so.1.0.0
b6eec000 b6ef3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f03000 b6f05000 r-xp /usr/lib/libdlog.so.0.0.0
b6f15000 b6f18000 r-xp /usr/lib/libbundle.so.0.1.22
b6f28000 b6f2a000 r-xp /lib/libdl-2.20-2014.11.so
b6f3b000 b6f53000 r-xp /usr/lib/libaul.so.0.1.0
b6f67000 b6f6c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7d000 b6f8a000 r-xp /usr/lib/liblptcp.so
b6f9c000 b6fa0000 r-xp /usr/lib/libsys-assert.so
b6fb1000 b6fd1000 r-xp /lib/ld-2.20-2014.11.so
b6fe2000 b6fe7000 r-xp /usr/bin/launchpad-loader
b705e000 b73f6000 rw-p [heap]
bed66000 bed87000 rw-p [stack]
bed66000 bed87000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31014)
Call Stack Count: 12
 0: dbus_watch_handle + 0xd (0xb69604ea) [/usr/lib/libdbus-1.so.3] + 0x1b4ea
 1: (0xb5e9e299) [/usr/lib/libeldbus.so.1] + 0xa299
 2: (0xb6a6463b) [/usr/lib/libecore.so.1] + 0x1163b
 3: (0xb6a64987) [/usr/lib/libecore.so.1] + 0x11987
 4: ecore_main_loop_iterate + 0x22 (0xb6a64bcb) [/usr/lib/libecore.so.1] + 0x11bcb
 5: elm_shutdown + 0x40 (0xb6db62e1) [/usr/lib/libelementary.so.1] + 0x1412e1
 6: appcore_efl_main + 0x2aa (0xb6f6a35b) [/usr/lib/libappcore-efl.so.1] + 0x335b
 7: ui_app_main + 0xc0 (0xb4432909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: main + 0x52 (0xb2a6ac33) [/opt/usr/apps/org.example.bluetooth/bin/babu] + 0x2c33
 9: (0xb6fe3baf) [/opt/usr/apps/org.example.bluetooth/bin/babu] + 0x1baf
10: __libc_start_main + 0x114 (0xb67064bc) [/lib/libc.so.6] + 0x164bc
11: (0xb6fe3e94) [/opt/usr/apps/org.example.bluetooth/bin/babu] + 0x1e94
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
g/homescreen/easymode
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.733+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.743+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_helper_event(2262) > [0;33mXT9_CMD_INPUTMODE value = 14[0m
09-10 17:20:00.743+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:20:00.743+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:20:00.793+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:20:00.923+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 17:20:00.933+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 5:20 p.m.
09-10 17:20:00.933+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 5:20 p.m."
09-10 17:20:00.933+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 5:20 p.m."
09-10 17:20:00.933+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 17:20:00.933+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145620288 Time: <font_size=31> </font_size> <font_size=31> 5:20 p.m.</font_size></font>"
09-10 17:20:01.274+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17164832
09-10 17:20:01.274+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17164832
09-10 17:20:01.304+0600 I/MALI    (  821): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:20:01.324+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7796d38), gem(27), surface(0xb78bff90)
09-10 17:20:01.344+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17164906
09-10 17:20:01.354+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:01.354+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:01.354+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:20:01.354+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=4[0m
09-10 17:20:01.354+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:01.994+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17165551
09-10 17:20:01.994+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17165551
09-10 17:20:02.094+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17165648
09-10 17:20:02.094+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:02.094+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:02.094+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:20:02.094+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=5[0m
09-10 17:20:02.094+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:04.226+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17167786
09-10 17:20:04.226+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17167786
09-10 17:20:04.286+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17167846
09-10 17:20:04.297+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:04.297+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:04.297+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:04.297+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 17:20:04.297+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:04.297+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:20:04.297+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=6[0m
09-10 17:20:04.297+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:04.297+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:04.837+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17168396
09-10 17:20:04.837+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17168396
09-10 17:20:04.967+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17168526
09-10 17:20:04.977+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:04.977+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:04.977+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:20:04.977+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 17:20:04.977+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:05.768+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17169322
09-10 17:20:05.768+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17169322
09-10 17:20:05.778+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:05.778+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:05.778+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 17:20:05.778+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:05.778+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=6[0m
09-10 17:20:05.878+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17169428
09-10 17:20:06.128+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17169677
09-10 17:20:06.128+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17169677
09-10 17:20:06.218+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17169772
09-10 17:20:06.218+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:06.218+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:06.218+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:06.218+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:20:06.228+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 17:20:06.369+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17169916
09-10 17:20:06.369+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17169916
09-10 17:20:06.429+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17169989
09-10 17:20:06.439+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:20:06.439+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:20:06.439+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:20:06.439+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:20:06.439+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 17:20:07.029+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17170450
09-10 17:20:07.029+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17170579
09-10 17:20:07.029+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:20:07.029+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 17:20:07.039+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5200002 FAILED!
09-10 17:20:07.059+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:20:07.109+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb781d268), gem(13), surface(0xb787e520)
09-10 17:20:07.109+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7837bc8), gem(24), surface(0xb78bff90)
09-10 17:20:09.822+0600 E/EFL     (31014): eo<31014> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb709fc38 is not pointing to a valid object. Maybe it has already been freed.
09-10 17:20:09.822+0600 E/EFL     (31014): eo<31014> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb709fc38) is an invalid ref.
09-10 17:20:21.433+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17184985
09-10 17:20:21.513+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17185058
09-10 17:20:21.513+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:20:21.513+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 17:20:21.513+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:20:21.513+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:20:22.474+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17186029
09-10 17:20:22.554+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17186104
09-10 17:20:22.805+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17186354
09-10 17:20:22.835+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17186395
09-10 17:20:23.515+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17187071
09-10 17:20:23.515+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17187071
09-10 17:20:23.515+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 17:20:23.515+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 17:20:23.515+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:20:23.826+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 17:20:23.826+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 17:20:23.826+0600 E/STARTER (  763): )
09-10 17:20:23.826+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 17:20:23.826+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 17:20:23.826+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:20:23.826+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:20:23.836+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 17:20:23.836+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:20:23.846+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 17:20:23.846+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 17:20:23.846+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 17:20:23.846+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 17:20:23.856+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:20:23.856+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 17:20:23.856+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:20:23.856+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 17:20:23.856+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:20:23.856+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 17:20:23.856+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 17:20:23.856+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 17:20:23.876+0600 E/CAPI_APPFW_APPLICATION(29116): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:20:23.876+0600 E/CAPI_APPFW_APPLICATION(29116): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:20:23.876+0600 E/CAPI_APPFW_APPLICATION(29116): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:20:23.876+0600 E/CAPI_APPFW_APPLICATION(29116): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:20:23.876+0600 E/CAPI_APPFW_APPLICATION(29116): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:20:23.876+0600 I/CAPI_APPFW_APPLICATION(29116): app_main.c: ui_app_main(789) > app_efl_main
09-10 17:20:23.876+0600 I/CAPI_APPFW_APPLICATION(29116): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 17:20:23.886+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776ed70), gem(10), surface(0xb787e520)
09-10 17:20:23.896+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776ed70), gem(10), surface(0xb7833af8)
09-10 17:20:23.896+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 17:20:23.906+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 17:20:23.906+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 17:20:23.946+0600 W/TASK_MGR_LITE(29116): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 17:20:23.956+0600 I/GXT_SIB (29116): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 17:20:23.956+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 29116, appid: com.samsung.task-mgr
09-10 17:20:23.956+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 17:20:23.956+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(29116)
09-10 17:20:23.966+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:20:24.006+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:20:24.016+0600 E/RUA     (29116): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 19, ncols : 5
09-10 17:20:24.016+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:20:24.016+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 31014
09-10 17:20:24.016+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 17:20:24.016+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 17:20:24.026+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 17:20:24.036+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:20:24.036+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:20:24.086+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 17:20:24.086+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:20:24.096+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:20:24.136+0600 I/TIZEN_N_SOUND_MANAGER(31123): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 17:20:24.136+0600 E/TIZEN_N_SOUND_MANAGER(31123): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:20:24.136+0600 I/TIZEN_N_SOUND_MANAGER(31123): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 17:20:24.136+0600 E/TIZEN_N_SOUND_MANAGER(31123): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:20:24.136+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:20:24.156+0600 I/APP_CORE(29116): appcore-efl.c: __do_app(520) > [APP 29116] Event: RESET State: CREATED
09-10 17:20:24.156+0600 I/CAPI_APPFW_APPLICATION(29116): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 17:20:24.166+0600 E/EFL     (29116): edje<29116> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:20:24.166+0600 E/EFL     (29116): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:20:24.166+0600 E/EFL     (29116): edje<29116> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:20:24.166+0600 E/EFL     (29116): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:20:24.176+0600 W/APP_CORE(29116): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5400003
09-10 17:20:24.176+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 17:20:24.236+0600 I/MALI    (29116): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb7a464e0)
09-10 17:20:24.246+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17187799
09-10 17:20:24.246+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 17:20:24.246+0600 E/EFL     (31014): ecore_x<31014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17187799
09-10 17:20:24.246+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 17:20:24.246+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 17:20:24.246+0600 E/STARTER (  763): )
09-10 17:20:24.246+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 17:20:24.246+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 17:20:24.246+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:20:24.246+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:20:24.256+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7854060), gem(21), surface(0xb78ae1a0)
09-10 17:20:24.256+0600 I/MALI    (29116): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:20:24.266+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(29116) status(0)
09-10 17:20:24.276+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:20:24.276+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(31014) status(4)
09-10 17:20:24.276+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(31014)
09-10 17:20:24.276+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 31014, appid: org.example.bluetooth, status: bg
09-10 17:20:24.276+0600 I/APP_CORE(29116): appcore-efl.c: __do_app(520) > [APP 29116] Event: RESUME State: CREATED
09-10 17:20:24.286+0600 I/APP_CORE(31014): appcore-efl.c: __do_app(520) > [APP 31014] Event: PAUSE State: RUNNING
09-10 17:20:24.286+0600 I/CAPI_APPFW_APPLICATION(31014): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:20:24.286+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78aa360), gem(13), surface(0xb7833af8)
09-10 17:20:24.286+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(29116) status(3)
09-10 17:20:24.286+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:20:24.286+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:20:24.286+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(29116)
09-10 17:20:24.286+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 29116, appid: com.samsung.task-mgr, status: fg
09-10 17:20:24.296+0600 I/TIZEN_N_EFL_UTIL_WINDOW(31014): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
09-10 17:20:24.296+0600 E/APP_CORE(31014): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 17:20:24.296+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:20:24.296+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:20:24.306+0600 I/APP_CORE(29116): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 17:20:24.306+0600 I/APP_CORE(29116): appcore-efl.c: __do_app(637) > [APP 29116] Initial Launching, call the resume_cb
09-10 17:20:24.306+0600 I/CAPI_APPFW_APPLICATION(29116): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:20:24.997+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 17:20:24.997+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 29116.
09-10 17:20:25.007+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2577
09-10 17:20:25.938+0600 I/UXT     (31629): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 17:20:25.998+0600 E/TBM     (31629): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 17:20:26.138+0600 E/EFL     (31629): edje<31629> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:20:26.138+0600 E/EFL     (31629): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:20:26.148+0600 E/EFL     (31629): edje<31629> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:20:26.148+0600 E/EFL     (31629): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:20:26.148+0600 E/EFL     (31629): edje<31629> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:20:26.148+0600 E/EFL     (31629): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:20:27.459+0600 E/EFL     (29116): ecore_x<29116> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17191012
09-10 17:20:27.529+0600 E/EFL     (29116): ecore_x<29116> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17191083
09-10 17:20:27.529+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:20:27.529+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 31014
09-10 17:20:27.529+0600 W/AUL     (29116): launch.c: app_request_to_launchpad(396) > request cmd(4) to(31014)
09-10 17:20:27.539+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 17:20:27.539+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(31014), cmd(4)
09-10 17:20:27.539+0600 W/AUL     (29116): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 17:20:27.539+0600 I/APP_CORE(31014): appcore-efl.c: __do_app(520) > [APP 31014] Event: TERMINATE State: PAUSED
09-10 17:20:27.539+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:20:27.539+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:20:27.539+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:20:27.539+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:20:27.549+0600 I/TIZEN_N_EFL_UTIL_WINDOW(31014): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 17:20:27.549+0600 E/APP_CORE(31014): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 17:20:27.549+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:20:27.549+0600 E/APP_CORE(31014): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:20:27.549+0600 I/CAPI_APPFW_APPLICATION(31014): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:20:27.549+0600 E/CAPI_NETWORK_BLUETOOTH(31014): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:20:27.579+0600 I/MALI    (29116): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:20:27.599+0600 I/MALI    (29116): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:20:27.609+0600 I/MALI    (29116): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:20:27.709+0600 E/CAPI_NETWORK_BLUETOOTH(31014): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:20:27.709+0600 E/CAPI_NETWORK_BLUETOOTH(31014): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:20:27.709+0600 E/bluetooth(31014): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:20:27.719+0600 I/CAPI_NETWORK_WIFI(31014): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:20:27.719+0600 E/bluetooth(31014): [wifi_deinitialize] Success.
09-10 17:20:27.769+0600 E/EFL     (31014): eo<31014> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x80164729's acvie is  NULL, entry: 0xb358b938, 0xb7259500, 0
09-10 17:20:27.769+0600 E/EFL     (31014): eo<31014> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x80164729 is not pointing to a valid object. Maybe it has already been freed.
09-10 17:20:27.769+0600 E/EFL     (31014): eo<31014> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x80164729) is an invalid ref.
09-10 17:20:27.809+0600 E/EFL     (31014): ecore<31014> lib/ecore/ecore_main.c:1552 _ecore_main_fd_handlers_bads_rem() Removing bad fds
09-10 17:20:27.809+0600 E/EFL     (31014): ecore<31014> lib/ecore/ecore_main.c:1561 _ecore_main_fd_handlers_bads_rem() Found bad fd at index 23
09-10 17:20:27.809+0600 E/EFL     (31014): ecore<31014> lib/ecore/ecore_main.c:1564 _ecore_main_fd_handlers_bads_rem() Fd set for error! calling user
09-10 17:20:27.829+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:20:27.829+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:20:27.829+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(29116)
09-10 17:20:27.829+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 29116, appid: com.samsung.task-mgr, status: bg
09-10 17:20:27.829+0600 I/CAPI_APPFW_APPLICATION(29116): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:20:27.829+0600 W/TASK_MGR_LITE(29116): task-mgr-lite.c: _pause_app(406) > 
09-10 17:20:27.829+0600 I/CAPI_APPFW_APPLICATION(29116): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:20:27.839+0600 E/TASK_MGR_LITE(29116): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 17:20:27.859+0600 E/APP_CORE(29116): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 17:20:27.859+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:20:27.859+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:20:27.870+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:20:27.870+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:20:27.870+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:20:27.870+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:20:27.880+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:20:27.900+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776c550), gem(13), surface(0xb787e520)
09-10 17:20:27.920+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776c550), gem(13), surface(0xb78ae1a0)
09-10 17:20:27.970+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(30), surface(0xb7833af8)
09-10 17:20:27.970+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(30), surface(0xb78be948)
09-10 17:20:27.990+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:20:27.990+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 17:20:27.990+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:20:27.990+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 17:20:28.010+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 17:20:28.020+0600 I/MALI    (29116): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 17:20:28.020+0600 I/MALI    (29116): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=29116   close drm_fd=28 
09-10 17:20:28.020+0600 I/MALI    (29116): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 17:20:28.040+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:20:28.040+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76af128), gem(19), surface(0xb7833af8)
09-10 17:20:28.060+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 17:20:28.090+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 17:20:28.090+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 17:20:28.130+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 17:20:28.150+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:20:28.160+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 31014 pgid = 31014
09-10 17:20:28.160+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(31014)
09-10 17:20:28.190+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83d9f78]
09-10 17:20:28.190+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 17:20:28.190+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83d9f78
09-10 17:20:28.190+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 17:20:28.190+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
09-10 17:20:28.190+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 17:20:28.190+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 17:20:28.190+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 17:20:28.270+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:20:28.270+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:20:28.270+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:20:28.270+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[31014] terminate event is forwarded
09-10 17:20:28.270+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:20:28.270+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 31014, ]
09-10 17:20:28.270+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:20:28.270+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:20:28.270+0600 I/Tizen::App( 1366): (512) > Not registered pid(31014)
09-10 17:20:28.270+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:20:28.270+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:20:28.270+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 31014
09-10 17:20:28.270+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 31014
09-10 17:20:28.280+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2580
09-10 17:20:28.290+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:20:28.290+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 31014.
09-10 17:20:28.330+0600 W/CRASH_MANAGER(31651): worker.c: worker_job(1199) > 1131014626162147350642
