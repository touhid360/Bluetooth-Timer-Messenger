S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 6606
Date: 2016-09-10 17:41:50+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6606, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb8c6d398
r2   = 0xb42b4000, r3   = 0xb42b4000
r4   = 0xbefd35bc, r5   = 0xb69b30f4
r6   = 0xb69b2310, r7   = 0xbefd341c
r8   = 0xb69b30f4, r9   = 0xb69b30f4
r10  = 0xb69c120c, fp   = 0x00000000
ip   = 0xb29a7830, sp   = 0xbefd2798
lr   = 0xb299cfdf, pc   = 0xb66966f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     48936 KB
Buffers:     44344 KB
Cached:     288696 KB
VmPeak:     105584 KB
VmSize:     104628 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24884 KB
VmRSS:       24884 KB
VmData:      34720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6606 TID = 6606
6606 6630 6796 

Maps Information
b1cf3000 b24f2000 rw-p [stack:6796]
b24f2000 b2503000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2513000 b2518000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25a4000 b25ac000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25bd000 b25be000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25ce000 b25e2000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b25f6000 b25f7000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2607000 b260a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b261b000 b261c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b262c000 b262e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b263e000 b2640000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2650000 b2660000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2670000 b267c000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b288d000 b28a4000 r-xp /usr/lib/libnetwork.so.0.0.0
b28b5000 b28f3000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2904000 b290b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b291c000 b292b000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b293b000 b2970000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2983000 b2989000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2999000 b29a0000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ac1000 b2ba4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bdb000 b2c03000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c15000 b3414000 rw-p [stack:6630]
b3414000 b3416000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3426000 b3430000 r-xp /lib/libnss_files-2.20-2014.11.so
b3441000 b344a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b345b000 b346c000 r-xp /lib/libnsl-2.20-2014.11.so
b347f000 b3485000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3496000 b3497000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34bf000 b34c6000 r-xp /usr/lib/libminizip.so.1.0.0
b34d6000 b34db000 r-xp /usr/lib/libstorage.so.0.1
b34eb000 b3540000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3556000 b356a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b357a000 b35be000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35ce000 b35d6000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35e6000 b3616000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3629000 b36e2000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36f6000 b374a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b375b000 b3776000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3786000 b3847000 r-xp /usr/lib/libprotobuf.so.9.0.1
b385a000 b386c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b387c000 b3880000 r-xp /usr/lib/libogg.so.0.7.1
b3890000 b38b2000 r-xp /usr/lib/libvorbis.so.0.4.3
b38c2000 b39a6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39c2000 b39cf000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39e0000 b3a23000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a38000 b3a7f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a90000 b3a96000 r-xp /usr/lib/libjson-c.so.2.0.1
b3aa7000 b3aae000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3abe000 b3afe000 r-xp /usr/lib/libmdm.so.1.2.10
b3b0e000 b3b16000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b25000 b3b35000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b56000 b3bb6000 r-xp /usr/lib/libasound.so.2.0.0
b3bc8000 b3bfe000 r-xp /usr/lib/libpulse.so.0.16.2
b3c0f000 b3c12000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c22000 b3c25000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c35000 b3c3a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c4a000 b3c4b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c5b000 b3c66000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c7a000 b3c81000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c91000 b3c97000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3ca7000 b3cac000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cbc000 b3cd7000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3ce7000 b3cee000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3cfe000 b3d01000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d12000 b3d40000 r-xp /usr/lib/libidn.so.11.5.44
b3d50000 b3d66000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d77000 b3d81000 r-xp /usr/lib/libcares.so.2.1.0
b3d91000 b3d9b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dab000 b3dad000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dbd000 b3dbe000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dce000 b3dd2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3de3000 b3e0b000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e1c000 b3e45000 r-xp /usr/lib/libturbojpeg.so
b3e65000 b3e6b000 r-xp /usr/lib/libgif.so.4.1.6
b3e7b000 b3ec1000 r-xp /usr/lib/libcurl.so.4.3.0
b3ed2000 b3ef3000 r-xp /usr/lib/libexif.so.12.3.3
b3f0e000 b3f23000 r-xp /usr/lib/libtts.so
b3f34000 b3f3c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f4c000 b400c000 r-xp /usr/lib/libdali-core.so.0.0.0
b4017000 b410a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b412a000 b4204000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b421b000 b421d000 r-xp /usr/lib/libboost_system.so.1.51.0
b422d000 b4233000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4243000 b4266000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4277000 b4279000 r-xp /usr/lib/libappsvc.so.0.1.0
b4289000 b428b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b429c000 b42a1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b8000 b42ba000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42ca000 b42d1000 r-xp /usr/lib/libsensord-share.so
b42e1000 b42f9000 r-xp /usr/lib/libsensor.so.1.1.0
b430a000 b430d000 r-xp /usr/lib/libXv.so.1.0.0
b431d000 b4322000 r-xp /usr/lib/libutilX.so.1.1.0
b4332000 b4337000 r-xp /usr/lib/libappcore-common.so.1.1
b4347000 b434e000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4361000 b4365000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4376000 b4440000 r-xp /usr/lib/libCOREGL.so.4.0
b4457000 b445a000 r-xp /usr/lib/libuuid.so.1.3.0
b446b000 b4482000 r-xp /usr/lib/libblkid.so.1.1.0
b4493000 b4495000 r-xp /usr/lib/libXau.so.6.0.0
b44a5000 b44a8000 r-xp /usr/lib/libEGL.so.1.4
b44b0000 b44b6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44c6000 b44c8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44d9000 b44e7000 r-xp /usr/lib/libGLESv2.so.2.0
b44f0000 b4552000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4567000 b457f000 r-xp /usr/lib/libmount.so.1.1.0
b4590000 b45a4000 r-xp /usr/lib/libxcb.so.1.1.0
b45b5000 b45bc000 r-xp /lib/libcrypt-2.20-2014.11.so
b45f4000 b4605000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4616000 b4618000 r-xp /usr/lib/libiri.so
b4628000 b4633000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4644000 b4659000 r-xp /lib/libexpat.so.1.5.2
b466b000 b4729000 r-xp /usr/lib/libcairo.so.2.11200.14
b473c000 b4744000 r-xp /usr/lib/libdrm.so.2.4.0
b4754000 b4757000 r-xp /usr/lib/libdri2.so.0.0.0
b4768000 b47b6000 r-xp /usr/lib/libssl.so.1.0.0
b47cb000 b47d7000 r-xp /usr/lib/libeeze.so.1.13.0
b47e7000 b47f0000 r-xp /usr/lib/libethumb.so.1.13.0
b4800000 b4803000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4813000 b49ca000 r-xp /usr/lib/libcrypto.so.1.0.0
b5621000 b562a000 r-xp /usr/lib/libXi.so.6.1.0
b563a000 b563c000 r-xp /usr/lib/libXgesture.so.7.0.0
b564c000 b5650000 r-xp /usr/lib/libXtst.so.6.1.0
b5660000 b5666000 r-xp /usr/lib/libXrender.so.1.3.0
b5676000 b567c000 r-xp /usr/lib/libXrandr.so.2.2.0
b568d000 b568f000 r-xp /usr/lib/libXinerama.so.1.0.0
b569f000 b56a2000 r-xp /usr/lib/libXfixes.so.3.1.0
b56b2000 b56bd000 r-xp /usr/lib/libXext.so.6.4.0
b56cd000 b56cf000 r-xp /usr/lib/libXdamage.so.1.1.0
b56df000 b56e1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56f2000 b57d4000 r-xp /usr/lib/libX11.so.6.3.0
b57e7000 b57ee000 r-xp /usr/lib/libXcursor.so.1.0.2
b57fe000 b5816000 r-xp /usr/lib/libudev.so.1.6.0
b5818000 b581b000 r-xp /lib/libattr.so.1.1.0
b582b000 b584b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b584d000 b5852000 r-xp /usr/lib/libffi.so.6.0.2
b5862000 b587a000 r-xp /lib/libz.so.1.2.8
b588a000 b588c000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b589c000 b5971000 r-xp /usr/lib/libxml2.so.2.9.2
b5986000 b5a21000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a3d000 b5a40000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a50000 b5a69000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a7a000 b5a8b000 r-xp /lib/libresolv-2.20-2014.11.so
b5a9f000 b5b19000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b2e000 b5b30000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b40000 b5b47000 r-xp /usr/lib/libembryo.so.1.13.0
b5b57000 b5b6f000 r-xp /usr/lib/libpng12.so.0.50.0
b5b80000 b5ba3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc4000 b5bd8000 r-xp /usr/lib/libector.so.1.13.0
b5be9000 b5c01000 r-xp /usr/lib/liblua-5.1.so
b5c12000 b5c69000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c7d000 b5ca5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb6000 b5cc9000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cda000 b5d11000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d22000 b5d30000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d40000 b5d48000 r-xp /usr/lib/libtbm.so.1.0.0
b5d58000 b5d65000 r-xp /usr/lib/libeio.so.1.13.0
b5d75000 b5d77000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d87000 b5d8c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d9c000 b5db3000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc5000 b5de5000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df5000 b5e15000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e17000 b5e1d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e2d000 b5e3e000 r-xp /usr/lib/libemotion.so.1.13.0
b5e4f000 b5e56000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e66000 b5e75000 r-xp /usr/lib/libeo.so.1.13.0
b5e86000 b5e98000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea9000 b5eae000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ebe000 b5ed7000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ee7000 b5f04000 r-xp /usr/lib/libeet.so.1.13.0
b5f1d000 b5f65000 r-xp /usr/lib/libeina.so.1.13.0
b5f76000 b5f86000 r-xp /usr/lib/libefl.so.1.13.0
b5f97000 b607c000 r-xp /usr/lib/libicuuc.so.51.1
b6099000 b61d9000 r-xp /usr/lib/libicui18n.so.51.1
b61f0000 b6228000 r-xp /usr/lib/libecore_x.so.1.13.0
b623a000 b623d000 r-xp /lib/libcap.so.2.21
b624d000 b6276000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6287000 b628e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62a0000 b62d7000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62e8000 b63d3000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e6000 b645f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6471000 b6476000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6486000 b6490000 r-xp /usr/lib/libvconf.so.0.2.45
b64a0000 b64a2000 r-xp /usr/lib/libvasum.so.0.3.1
b64b2000 b64b4000 r-xp /usr/lib/libttrace.so.1.1
b64c4000 b64c7000 r-xp /usr/lib/libiniparser.so.0
b64d7000 b64fd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b650d000 b6512000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6523000 b653a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b654b000 b65b6000 r-xp /lib/libm-2.20-2014.11.so
b65c7000 b65cd000 r-xp /lib/librt-2.20-2014.11.so
b65de000 b65eb000 r-xp /usr/lib/libunwind.so.8.0.1
b6621000 b6745000 r-xp /lib/libc-2.20-2014.11.so
b675a000 b6773000 r-xp /lib/libgcc_s-4.9.so.1
b6783000 b6865000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6876000 b68a0000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b1000 b68ed000 r-xp /usr/lib/libsystemd.so.0.4.0
b68ef000 b6971000 r-xp /usr/lib/libedje.so.1.13.0
b6984000 b69a2000 r-xp /usr/lib/libecore.so.1.13.0
b69c2000 b6b49000 r-xp /usr/lib/libevas.so.1.13.0
b6b7e000 b6b92000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba6000 b6ddb000 r-xp /usr/lib/libelementary.so.1.13.0
b6e09000 b6e0d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e1d000 b6e24000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e34000 b6e36000 r-xp /usr/lib/libdlog.so.0.0.0
b6e46000 b6e49000 r-xp /usr/lib/libbundle.so.0.1.22
b6e59000 b6e5b000 r-xp /lib/libdl-2.20-2014.11.so
b6e6c000 b6e84000 r-xp /usr/lib/libaul.so.0.1.0
b6e98000 b6e9d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eae000 b6ebb000 r-xp /usr/lib/liblptcp.so
b6ecd000 b6ed1000 r-xp /usr/lib/libsys-assert.so
b6ee2000 b6f02000 r-xp /lib/ld-2.20-2014.11.so
b6f13000 b6f18000 r-xp /usr/bin/launchpad-loader
b8c04000 b8f36000 rw-p [heap]
befb3000 befd4000 rw-p [stack]
b8c04000 b8f36000 rw-p [heap]
befb3000 befd4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6606)
Call Stack Count: 1
 0: (0xb66966f0) [/lib/libc.so.6] + 0x756f0
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
.487+0600 E/rpm-installer( 6615): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
09-10 17:40:14.487+0600 E/rpm-installer( 6615): rpm-appcore-intf.c: main(106) > ------------------------------------------------
09-10 17:40:14.657+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: start, val: update
09-10 17:40:14.657+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [start], Value = [update], install = [1]
09-10 17:40:14.657+0600 W/AUL_AMD (  648): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
09-10 17:40:14.667+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 30
09-10 17:40:14.667+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [30]
09-10 17:40:14.667+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [30], install = [1]
09-10 17:40:14.737+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb835e6d8]
09-10 17:40:14.737+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:40:14.737+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:40:14.737+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:40:14.737+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb835e6d8
09-10 17:40:14.747+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:40:14.757+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:14.757+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:14.757+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:14.757+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:14.757+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:14.757+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:14.757+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:40:14.757+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:40:14.757+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 17:40:14.767+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:40:14.767+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:40:14.777+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:40:14.838+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800f0b04 is not stable during recalc loop
09-10 17:40:14.958+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800f0b04 is not stable during recalc loop
09-10 17:40:14.958+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:40:14.968+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:40:14.988+0600 E/rpm-installer( 6615): coretpk-parser.c: _coretpk_parser_get_manifest_info(1377) > (doc == NULL) xmlParseFile() failed.
09-10 17:40:14.988+0600 E/rpm-installer( 6615): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
09-10 17:40:15.098+0600 E/weather-agent( 6577): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:40:15.098+0600 I/CAPI_APPFW_APPLICATION( 6577): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:40:15.098+0600 E/PKGMGR_PARSER( 6615): pkgmgr_parser.c: __check_theme(158) > theme for uninstallation.
09-10 17:40:15.108+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:40:15.108+0600 E/weather-agent( 6577): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:40:15.108+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:40:15.118+0600 I/PRIVACY-MANAGER-CLIENT( 6615): SocketClient.cpp: SocketClient(37) > Client created
09-10 17:40:15.118+0600 I/PRIVACY-MANAGER-SERVER(  933): SocketService.cpp: mainloop(257) > Got incoming connection
09-10 17:40:15.128+0600 I/PRIVACY-MANAGER-CLIENT( 6615): SocketClient.cpp: connect(62) > Client connected
09-10 17:40:15.128+0600 I/PRIVACY-MANAGER-CLIENT( 6615): SocketClient.cpp: disconnect(72) > Client disconnected
09-10 17:40:15.128+0600 E/PKGMGR_CERT( 6615): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
09-10 17:40:15.138+0600 E/PKGMGR_CERT( 6615): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
09-10 17:40:15.148+0600 E/PKGMGR_CERT( 6615): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
09-10 17:40:15.188+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 17:40:15.188+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/6620/status successfully
09-10 17:40:15.188+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 17:40:15.198+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:40:15.198+0600 E/PKGMGR_INFO(  648): pkgmgrinfo_private.c: __db_busy_handler(250) > __db_busy_handler(count=0) is called. pid=[648]
09-10 17:40:15.228+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 17:40:15.228+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 18:00:00 (UTC).
09-10 17:40:15.228+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 17:40:15.238+0600 E/rpm-installer( 6615): coretpk-installer.c: _coretpk_installer_package_reinstall(6348) > _coretpk_installer_package_reinstall(org.example.bluetooth) failed.
09-10 17:40:15.258+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: fail
09-10 17:40:15.258+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [fail], install = [1]
09-10 17:40:15.258+0600 E/ESD     (  915): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
09-10 17:40:15.278+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.bluetooth",~) returned -1
09-10 17:40:15.278+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
09-10 17:40:15.288+0600 W/AUL_AMD (  648): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
09-10 17:40:15.328+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:15.328+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:15.328+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:15.338+0600 I/CAPI_NETWORK_WIFI( 6620): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 17:40:15.338+0600 I/CAPI_NETWORK_WIFI( 6620): libnetwork.c: _wifi_set_power_on_off_cb(1666) > Wi-Fi registered device state changed callback
09-10 17:40:15.438+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 6620): media_content.c: media_content_connect(856) > [32m[6620]ref count : 0
09-10 17:40:15.438+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 6620): media_content.c: media_content_connect(888) > [32m[6620]ref count changed to: 1
09-10 17:40:15.458+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:40:15.468+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 6577
09-10 17:40:15.468+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[6577] terminate event is forwarded
09-10 17:40:15.468+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:40:15.468+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6577, ]
09-10 17:40:15.468+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:40:15.468+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:40:15.468+0600 I/Tizen::App( 1366): (512) > Not registered pid(6577)
09-10 17:40:15.468+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:40:15.468+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:40:15.468+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6577
09-10 17:40:15.468+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:40:15.468+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:40:15.468+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6577.
09-10 17:40:15.949+0600 E/rpm-installer( 6615): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 17:40:15.949+0600 E/rpm-installer( 6615): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 17:40:15.949+0600 E/rpm-installer( 6615): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 17:40:15.979+0600 E/PKGMGR_SERVER( 6612): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6615]
09-10 17:40:16.199+0600 I/UXT     ( 6606): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 17:40:16.349+0600 E/EFL     ( 5463): ecore_x<5463> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18379899
09-10 17:40:16.419+0600 E/EFL     ( 5463): ecore_x<5463> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18379970
09-10 17:40:16.449+0600 E/PKGMGR_SERVER( 6612): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 17:40:16.449+0600 E/PKGMGR_SERVER( 6612): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 17:40:16.769+0600 E/EFL     ( 5463): ecore_x<5463> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18380319
09-10 17:40:16.839+0600 E/EFL     ( 5463): ecore_x<5463> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18380390
09-10 17:40:16.900+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:40:16.900+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:40:16.900+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.tizen.system-syspopup(5463)
09-10 17:40:16.900+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 5463, appid: org.tizen.system-syspopup, status: bg
09-10 17:40:16.920+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:40:16.930+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:40:16.960+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:40:16.980+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.tizen.] 
09-10 17:40:16.980+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:40:16.980+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:40:17.240+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5463 pgid = 5463
09-10 17:40:17.240+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(5463)
09-10 17:40:17.270+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:40:17.270+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:40:17.270+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:40:17.270+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 5463
09-10 17:40:17.270+0600 I/Tizen::App( 1366): (243) > App[org.tizen.system-syspopup] pid[5463] terminate event is forwarded
09-10 17:40:17.270+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:40:17.270+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.tizen.system-syspopup, 5463, ]
09-10 17:40:17.270+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:40:17.270+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.tizen.system-syspopup)
09-10 17:40:17.270+0600 I/Tizen::App( 1366): (512) > Not registered pid(5463)
09-10 17:40:17.270+0600 I/Tizen::System( 1366): (246) > Terminated app [org.tizen.system-syspopup]
09-10 17:40:17.280+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:40:17.280+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5463
09-10 17:40:17.280+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 5463
09-10 17:40:17.280+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2807
09-10 17:40:17.290+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:40:17.290+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:40:17.290+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.tizen.system-syspopup, 5463.
09-10 17:40:19.762+0600 E/PKGMGR  ( 6699): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
09-10 17:40:19.862+0600 E/PKGMGR_SERVER( 6701): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:40:19.922+0600 E/PKGMGR_SERVER( 6701): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk]
09-10 17:40:19.932+0600 E/PKGMGR_INFO( 6701): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] not found in DB
09-10 17:40:19.943+0600 E/BACKEND_LIB( 6701): librpm.c: __installer_util_delete_dir(179) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-10 17:40:19.953+0600 E/PKGMGR_SERVER( 6701): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-10 17:40:19.953+0600 E/PKGMGR  ( 6699): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[66990002]
09-10 17:40:20.023+0600 E/rpm-installer( 6705): rpm-appcore-intf.c: main(104) > ------------------------------------------------
09-10 17:40:20.023+0600 E/rpm-installer( 6705): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
09-10 17:40:20.023+0600 E/rpm-installer( 6705): rpm-appcore-intf.c: main(106) > ------------------------------------------------
09-10 17:40:20.093+0600 E/PKGMGR_INSTALLER( 6705): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
09-10 17:40:20.093+0600 E/rpm-installer( 6705): rpm-appcore-intf.c: main(191) > [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] is tpk package.
09-10 17:40:20.113+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:40:20.113+0600 E/rpm-installer( 6705): coretpk-parser.c: _coretpk_parser_is_svc_app(1225) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
09-10 17:40:20.113+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [install-location] is empty.
09-10 17:40:20.113+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 17:40:20.113+0600 E/rpm-installer( 6705): coretpk-parser.c: _coretpk_parser_is_widget(1191) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
09-10 17:40:20.113+0600 E/rpm-installer( 6705): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 17:40:20.253+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: start, val: install
09-10 17:40:20.253+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [start], Value = [install], install = [1]
09-10 17:40:20.273+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 30
09-10 17:40:20.273+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [30]
09-10 17:40:20.273+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [30], install = [1]
09-10 17:40:20.283+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.283+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.283+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.283+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.283+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.283+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.413+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_check_vip_tag(474) > (ret == 1) metadata(watchface) is empty.
09-10 17:40:20.413+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [ui-gadget] is empty.
09-10 17:40:20.413+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_get_dpi_type(778) > key for dpi is found, get the dpi.
09-10 17:40:20.413+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_get_dpi_type(787) > device dpi is [233]
09-10 17:40:20.413+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_append_path(343) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-10 17:40:20.413+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 17:40:20.423+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_allow_onboot(582) > (ret == 1) metadata is empty.
09-10 17:40:20.423+0600 E/rpm-installer( 6705): coretpk-parser.c: __coretpk_parser_allow_autorestart(644) > (ret == 1) metadata is empty.
09-10 17:40:20.433+0600 E/PKGMGR_PARSER( 6705): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2682) > Manifest is Valid
09-10 17:40:20.433+0600 E/PKGMGR_PARSER( 6705): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-10 17:40:20.453+0600 E/PKGMGR_PARSER( 6705): pkgmgr_parser_db.c: __verify_label_cb(353) > package_label is PKGMGR_PARSER_EMPTY_STR
09-10 17:40:20.503+0600 I/PRIVACY-MANAGER-CLIENT( 6705): SocketClient.cpp: SocketClient(37) > Client created
09-10 17:40:20.763+0600 E/PKGMGR_PARSER( 6705): pkgmgr_parser.c: __check_theme(146) > theme for installation.
09-10 17:40:20.773+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-10 17:40:20.773+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 100
09-10 17:40:20.773+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 100
09-10 17:40:20.773+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 25 1
09-10 17:40:20.773+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 26 1
09-10 17:40:20.773+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 27 1
09-10 17:40:20.773+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 28 1
09-10 17:40:20.793+0600 E/PKGMGR_CERT( 6705): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
09-10 17:40:20.793+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.793+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.793+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.803+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 60
09-10 17:40:20.803+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [60]
09-10 17:40:20.803+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [60], install = [1]
09-10 17:40:20.813+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(154) > Enter
09-10 17:40:20.813+0600 I/SHAREDRULE_CLIENT(  592): SocketConnection.h: SocketConnection(47) > Created
09-10 17:40:20.813+0600 I/SHAREDRULE_SERVER(  589): SocketService.cpp: mainloop(234) > Got incoming connection
09-10 17:40:20.813+0600 I/SHAREDRULE_SERVER(  589): SocketConnection.h: SocketConnection(47) > Created
09-10 17:40:20.833+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(190) > return result : 0
09-10 17:40:20.833+0600 E/rpm-installer( 6705): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 17:40:20.863+0600 E/rpm-installer( 6705): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
09-10 17:40:20.863+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 100
09-10 17:40:20.863+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [100]
09-10 17:40:20.863+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [100], install = [1]
09-10 17:40:20.873+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.873+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:20.873+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:21.344+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:40:21.344+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:40:21.354+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 17:40:21.354+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 17:40:21.354+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 17:40:21.354+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:14d2ce8
09-10 17:40:21.354+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 17:40:21.354+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => WILL PAUSE
09-10 17:40:21.364+0600 W/APP_CORE(  869): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 17:40:21.364+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 17:40:21.364+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:40:21.364+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:40:21.364+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 17:40:21.364+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 17:40:21.364+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 17:40:21.364+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 17:40:21.364+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 17:40:21.374+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 17:40:21.454+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:40:21.454+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:40:21.454+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:40:21.454+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:40:21.454+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:40:21.554+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-10 17:40:21.554+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-10 17:40:21.554+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-10 17:40:21.554+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:21.554+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: ok
09-10 17:40:21.554+0600 I/Tizen::App( 1366): (78) > Installation is Completed. [Package = org.example.bluetooth]
09-10 17:40:21.554+0600 I/Tizen::App( 1366): (671) > Enter. package(org.example.bluetooth), installationResult(0)
09-10 17:40:21.594+0600 I/Tizen::App( 1366): (1360) > package(org.example.bluetooth), version(1.0.0), type(tpk), displayName(Timer Messenger), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.bluetooth), storeClient(), appRootPath(/opt/usr/apps/org.example.bluetooth)
09-10 17:40:21.604+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:21.604+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:40:21.614+0600 I/Tizen::App( 1366): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.bluetooth]
09-10 17:40:21.624+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.bluetooth]
09-10 17:40:21.624+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.bluetooth]
09-10 17:40:21.624+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-10 17:40:21.624+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-10 17:40:21.624+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.bluetooth]
09-10 17:40:21.634+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-10 17:40:21.644+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 17:40:21.644+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 17:40:21.644+0600 E/PKGMGR_INFO( 1366): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-10 17:40:21.644+0600 I/Tizen::App( 1366): (683) > Application count(1) in this package
09-10 17:40:21.644+0600 I/Tizen::App( 1366): (840) > Enter.
09-10 17:40:21.644+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[Timer Messenger] enable[1] system[0]
09-10 17:40:21.644+0600 E/HOME_APPS(  873): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.bluetooth] mdm is not enabled
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (703) > Exit.
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [ok], install = [96]
09-10 17:40:21.654+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[Timer Messenger] enable[1] system[0]
09-10 17:40:21.654+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: UpdateBoxData(1330) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], New icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png]!!!!!
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.bluetooth.info]
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (131) > Enter
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (137) > org.example.bluetooth does not have launch condition
09-10 17:40:21.654+0600 I/Tizen::App( 1366): (883) > Exit.
09-10 17:40:21.664+0600 E/util-view(  873): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=22 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-10 17:40:21.694+0600 E/rpm-installer( 6705): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 17:40:21.694+0600 E/rpm-installer( 6705): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 17:40:21.694+0600 E/rpm-installer( 6705): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 17:40:21.704+0600 E/PKGMGR_SERVER( 6701): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6705]
09-10 17:40:21.894+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:40:21.914+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:40:21.914+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:40:21.934+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 17:40:21.934+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 17:40:21.934+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 17:40:21.934+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 17:40:21.934+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 17:40:21.944+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], Loading state:[1]
09-10 17:40:21.944+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 17:40:22.445+0600 E/PKGMGR_SERVER( 6701): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 17:40:22.445+0600 E/PKGMGR_SERVER( 6701): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 17:40:26.369+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 17:40:27.500+0600 W/AUL     ( 6792): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.bluetooth)
09-10 17:40:27.500+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:40:27.510+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-10 17:40:27.520+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-10 17:40:27.520+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 17:40:27.520+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 6792
09-10 17:40:27.520+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 17:40:27.530+0600 E/RESOURCED(15587): block.c: block_prelaunch_state(138) > insert data org.example.bluetooth, table num : 1
09-10 17:40:27.530+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:40:27.530+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 17:40:27.530+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:40:27.530+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.bluetooth has already loaded
09-10 17:40:27.530+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:40:27.530+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 17:40:27.530+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 17:40:27.530+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 17:40:27.550+0600 I/CAPI_APPFW_APPLICATION( 6606): app_main.c: ui_app_main(789) > app_efl_main
09-10 17:40:27.550+0600 I/CAPI_APPFW_APPLICATION( 6606): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 17:40:27.580+0600 E/TBM     ( 6606): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 17:40:27.630+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 6606, appid: org.example.bluetooth
09-10 17:40:27.630+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 17:40:27.650+0600 W/AUL     ( 6792): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6606)
09-10 17:40:27.660+0600 E/CAPI_NETWORK_WIFI( 6606): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 17:40:27.680+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 17:40:27.870+0600 I/CAPI_NETWORK_WIFI( 6606): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 17:40:27.870+0600 D/bluetooth( 6606): [wifi_initialize] Success.
09-10 17:40:28.070+0600 I/APP_CORE( 6606): appcore-efl.c: __do_app(520) > [APP 6606] Event: RESET State: CREATED
09-10 17:40:28.070+0600 I/CAPI_APPFW_APPLICATION( 6606): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 17:40:28.070+0600 E/EFL     ( 6606): edje<6606> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:40:28.070+0600 E/EFL     ( 6606): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:40:28.080+0600 E/EFL     ( 6606): edje<6606> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:40:28.080+0600 E/EFL     ( 6606): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:40:28.090+0600 E/EFL     ( 6606): edje<6606> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:40:28.090+0600 E/EFL     ( 6606): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:40:28.181+0600 W/APP_CORE( 6606): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
09-10 17:40:28.181+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 17:40:28.271+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(21), surface(0xb78ba300)
09-10 17:40:28.271+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78aa360), gem(18), surface(0xb7877090)
09-10 17:40:28.281+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(21), surface(0xb78a7188)
09-10 17:40:28.281+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775e358), gem(14), surface(0xb78a7f18)
09-10 17:40:28.291+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 17:40:28.291+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 17:40:28.291+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 17:40:28.291+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(6606) status(4)
09-10 17:40:28.321+0600 I/APP_CORE( 6606): appcore-efl.c: __do_app(520) > [APP 6606] Event: PAUSE State: CREATED
09-10 17:40:28.321+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 6606): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:40:28.321+0600 E/APP_CORE( 6606): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 17:40:28.321+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:40:28.331+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb773d7a0), gem(10), surface(0xb787e520)
09-10 17:40:28.461+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77e60a8), gem(28), surface(0xb78a7188)
09-10 17:40:28.651+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:40:28.651+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 17:40:28.651+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76af128), gem(28), surface(0xb787e520)
09-10 17:40:28.691+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 17:40:28.691+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 6606.
09-10 17:40:28.691+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2814
09-10 17:40:28.701+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(6606) status(0)
09-10 17:40:28.701+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:40:29.051+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78448e8), gem(10), surface(0xb78ae510)
09-10 17:40:29.522+0600 I/UXT     ( 6803): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 17:40:32.635+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(6606)
09-10 17:40:32.635+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 6606, appid: org.example.bluetooth, status: bg
09-10 17:41:49.760+0600 E/PKGMGR_SERVER( 7102): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:41:49.830+0600 E/PKGMGR  ( 7099): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 17:41:49.870+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:41:49.870+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 6606
09-10 17:41:49.870+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:41:49.870+0600 W/AUL     ( 7105): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6606)
09-10 17:41:49.870+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(6606), cmd(4)
09-10 17:41:49.880+0600 I/APP_CORE( 6606): appcore-efl.c: __do_app(520) > [APP 6606] Event: TERMINATE State: CREATED
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:41:49.880+0600 W/AUL     ( 7105): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 17:41:49.880+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 6606): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 17:41:49.880+0600 E/APP_CORE( 6606): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 17:41:49.880+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:41:49.880+0600 E/APP_CORE( 6606): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:41:49.880+0600 I/CAPI_APPFW_APPLICATION( 6606): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:41:49.890+0600 E/CAPI_NETWORK_BLUETOOTH( 6606): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:41:49.890+0600 E/PKGMGR_SERVER( 7102): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7105]
09-10 17:41:49.950+0600 E/CAPI_NETWORK_BLUETOOTH( 6606): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:41:49.950+0600 E/CAPI_NETWORK_BLUETOOTH( 6606): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:41:49.950+0600 E/bluetooth( 6606): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:41:49.950+0600 I/CAPI_NETWORK_WIFI( 6606): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:41:49.960+0600 E/bluetooth( 6606): [wifi_deinitialize] Success.
09-10 17:41:49.970+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776c550), gem(26), surface(0xb78ba300)
09-10 17:41:49.990+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78903f8), gem(18), surface(0xb7877090)
09-10 17:41:49.990+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(10), surface(0xb78a7188)
09-10 17:41:50.000+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775e358), gem(14), surface(0xb78a7f18)
09-10 17:41:50.010+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:41:50.010+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:41:50.010+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:41:50.010+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:41:50.010+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:41:50.020+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:41:50.040+0600 E/EFL     ( 6606): elementary<6606> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 17:41:50.050+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb776c550), gem(26), surface(0xb787e520)
09-10 17:41:50.211+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6606 pgid = 6606
09-10 17:41:50.211+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(6606)
09-10 17:41:50.261+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:41:50.261+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:41:50.261+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:41:50.271+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[6606] terminate event is forwarded
09-10 17:41:50.271+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:41:50.271+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 6606, ]
09-10 17:41:50.271+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:41:50.271+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:41:50.271+0600 I/Tizen::App( 1366): (512) > Not registered pid(6606)
09-10 17:41:50.271+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:41:50.271+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:41:50.271+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 6606
09-10 17:41:50.271+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6606
09-10 17:41:50.281+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:41:50.291+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:41:50.291+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 6606.
09-10 17:41:50.361+0600 W/CRASH_MANAGER( 7114): worker.c: worker_job(1199) > 1106606626162147350771
