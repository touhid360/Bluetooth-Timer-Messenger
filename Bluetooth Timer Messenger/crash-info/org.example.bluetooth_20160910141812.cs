S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 4309
Date: 2016-09-10 14:18:12+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4309, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb7fc27c0
r2   = 0xb430f000, r3   = 0xb430f000
r4   = 0xb7f86c38, r5   = 0xbec585bc
r6   = 0xb6a0d310, r7   = 0xbec5841c
r8   = 0xb6a0e0f4, r9   = 0xb6a0e0f4
r10  = 0xb6a1c20c, fp   = 0x00000000
ip   = 0xb2a02b20, sp   = 0xbec56770
lr   = 0xb29f47d3, pc   = 0xb66f16f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     96412 KB
Buffers:     37532 KB
Cached:     266216 KB
VmPeak:     120628 KB
VmSize:     114284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25616 KB
VmRSS:       25616 KB
VmData:      44356 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36244 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4309 TID = 4309
4309 4313 4408 4410 

Maps Information
b0a01000 b1200000 rw-p [stack:4410]
b1d48000 b2547000 rw-p [stack:4408]
b2547000 b2558000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2568000 b256d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25f9000 b2601000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2612000 b2613000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2623000 b2637000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b264b000 b264c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b265c000 b265f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2670000 b2671000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2681000 b2683000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2693000 b2695000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26a5000 b26b5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26c5000 b26d1000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28e2000 b28f9000 r-xp /usr/lib/libnetwork.so.0.0.0
b290a000 b2948000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2959000 b2960000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2971000 b2980000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2990000 b29c5000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29d8000 b29de000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29ee000 b29fb000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b1c000 b2bff000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c36000 b2c5e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c70000 b346f000 rw-p [stack:4313]
b346f000 b3471000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3481000 b348b000 r-xp /lib/libnss_files-2.20-2014.11.so
b349c000 b34a5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34b6000 b34c7000 r-xp /lib/libnsl-2.20-2014.11.so
b34da000 b34e0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34f1000 b34f2000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b351a000 b3521000 r-xp /usr/lib/libminizip.so.1.0.0
b3531000 b3536000 r-xp /usr/lib/libstorage.so.0.1
b3546000 b359b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35b1000 b35c5000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35d5000 b3619000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3629000 b3631000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3641000 b3671000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3684000 b373d000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3751000 b37a5000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37b6000 b37d1000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37e1000 b38a2000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38b5000 b38c7000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38d7000 b38db000 r-xp /usr/lib/libogg.so.0.7.1
b38eb000 b390d000 r-xp /usr/lib/libvorbis.so.0.4.3
b391d000 b3a01000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a1d000 b3a2a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a3b000 b3a7e000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a93000 b3ada000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3aeb000 b3af1000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b02000 b3b09000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b19000 b3b59000 r-xp /usr/lib/libmdm.so.1.2.10
b3b69000 b3b71000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b80000 b3b90000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bb1000 b3c11000 r-xp /usr/lib/libasound.so.2.0.0
b3c23000 b3c59000 r-xp /usr/lib/libpulse.so.0.16.2
b3c6a000 b3c6d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c7d000 b3c80000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c90000 b3c95000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3ca5000 b3ca6000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cb6000 b3cc1000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cd5000 b3cdc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cec000 b3cf2000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d02000 b3d07000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d17000 b3d32000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d42000 b3d49000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d59000 b3d5c000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d6d000 b3d9b000 r-xp /usr/lib/libidn.so.11.5.44
b3dab000 b3dc1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dd2000 b3ddc000 r-xp /usr/lib/libcares.so.2.1.0
b3dec000 b3df6000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e06000 b3e08000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e18000 b3e19000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e29000 b3e2d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e3e000 b3e66000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e77000 b3ea0000 r-xp /usr/lib/libturbojpeg.so
b3ec0000 b3ec6000 r-xp /usr/lib/libgif.so.4.1.6
b3ed6000 b3f1c000 r-xp /usr/lib/libcurl.so.4.3.0
b3f2d000 b3f4e000 r-xp /usr/lib/libexif.so.12.3.3
b3f69000 b3f7e000 r-xp /usr/lib/libtts.so
b3f8f000 b3f97000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fa7000 b4067000 r-xp /usr/lib/libdali-core.so.0.0.0
b4072000 b4165000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4185000 b425f000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4276000 b4278000 r-xp /usr/lib/libboost_system.so.1.51.0
b4288000 b428e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b429e000 b42c1000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42d2000 b42d4000 r-xp /usr/lib/libappsvc.so.0.1.0
b42e4000 b42e6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42f7000 b42fc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4313000 b4315000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4325000 b432c000 r-xp /usr/lib/libsensord-share.so
b433c000 b4354000 r-xp /usr/lib/libsensor.so.1.1.0
b4365000 b4368000 r-xp /usr/lib/libXv.so.1.0.0
b4378000 b437d000 r-xp /usr/lib/libutilX.so.1.1.0
b438d000 b4392000 r-xp /usr/lib/libappcore-common.so.1.1
b43a2000 b43a9000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43bc000 b43c0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43d1000 b449b000 r-xp /usr/lib/libCOREGL.so.4.0
b44b2000 b44b5000 r-xp /usr/lib/libuuid.so.1.3.0
b44c6000 b44dd000 r-xp /usr/lib/libblkid.so.1.1.0
b44ee000 b44f0000 r-xp /usr/lib/libXau.so.6.0.0
b4500000 b4503000 r-xp /usr/lib/libEGL.so.1.4
b450b000 b4511000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4521000 b4523000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4534000 b4542000 r-xp /usr/lib/libGLESv2.so.2.0
b454b000 b45ad000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45c2000 b45da000 r-xp /usr/lib/libmount.so.1.1.0
b45eb000 b45ff000 r-xp /usr/lib/libxcb.so.1.1.0
b4610000 b4617000 r-xp /lib/libcrypt-2.20-2014.11.so
b464f000 b4660000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4671000 b4673000 r-xp /usr/lib/libiri.so
b4683000 b468e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b469f000 b46b4000 r-xp /lib/libexpat.so.1.5.2
b46c6000 b4784000 r-xp /usr/lib/libcairo.so.2.11200.14
b4797000 b479f000 r-xp /usr/lib/libdrm.so.2.4.0
b47af000 b47b2000 r-xp /usr/lib/libdri2.so.0.0.0
b47c3000 b4811000 r-xp /usr/lib/libssl.so.1.0.0
b4826000 b4832000 r-xp /usr/lib/libeeze.so.1.13.0
b4842000 b484b000 r-xp /usr/lib/libethumb.so.1.13.0
b485b000 b485e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b486e000 b4a25000 r-xp /usr/lib/libcrypto.so.1.0.0
b567c000 b5685000 r-xp /usr/lib/libXi.so.6.1.0
b5695000 b5697000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a7000 b56ab000 r-xp /usr/lib/libXtst.so.6.1.0
b56bb000 b56c1000 r-xp /usr/lib/libXrender.so.1.3.0
b56d1000 b56d7000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e8000 b56ea000 r-xp /usr/lib/libXinerama.so.1.0.0
b56fa000 b56fd000 r-xp /usr/lib/libXfixes.so.3.1.0
b570d000 b5718000 r-xp /usr/lib/libXext.so.6.4.0
b5728000 b572a000 r-xp /usr/lib/libXdamage.so.1.1.0
b573a000 b573c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b574d000 b582f000 r-xp /usr/lib/libX11.so.6.3.0
b5842000 b5849000 r-xp /usr/lib/libXcursor.so.1.0.2
b5859000 b5871000 r-xp /usr/lib/libudev.so.1.6.0
b5873000 b5876000 r-xp /lib/libattr.so.1.1.0
b5886000 b58a6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a8000 b58ad000 r-xp /usr/lib/libffi.so.6.0.2
b58bd000 b58d5000 r-xp /lib/libz.so.1.2.8
b58e5000 b58e7000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f7000 b59cc000 r-xp /usr/lib/libxml2.so.2.9.2
b59e1000 b5a7c000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a98000 b5a9b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aab000 b5ac4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad5000 b5ae6000 r-xp /lib/libresolv-2.20-2014.11.so
b5afa000 b5b74000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b89000 b5b8b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b9b000 b5ba2000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb2000 b5bca000 r-xp /usr/lib/libpng12.so.0.50.0
b5bdb000 b5bfe000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c1f000 b5c33000 r-xp /usr/lib/libector.so.1.13.0
b5c44000 b5c5c000 r-xp /usr/lib/liblua-5.1.so
b5c6d000 b5cc4000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cd8000 b5d00000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d11000 b5d24000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d35000 b5d6c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d7d000 b5d8b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d9b000 b5da3000 r-xp /usr/lib/libtbm.so.1.0.0
b5db3000 b5dc0000 r-xp /usr/lib/libeio.so.1.13.0
b5dd0000 b5dd2000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de2000 b5de7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5df7000 b5e0e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e20000 b5e40000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e50000 b5e70000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e72000 b5e78000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e88000 b5e99000 r-xp /usr/lib/libemotion.so.1.13.0
b5eaa000 b5eb1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ec1000 b5ed0000 r-xp /usr/lib/libeo.so.1.13.0
b5ee1000 b5ef3000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f04000 b5f09000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f19000 b5f32000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f42000 b5f5f000 r-xp /usr/lib/libeet.so.1.13.0
b5f78000 b5fc0000 r-xp /usr/lib/libeina.so.1.13.0
b5fd1000 b5fe1000 r-xp /usr/lib/libefl.so.1.13.0
b5ff2000 b60d7000 r-xp /usr/lib/libicuuc.so.51.1
b60f4000 b6234000 r-xp /usr/lib/libicui18n.so.51.1
b624b000 b6283000 r-xp /usr/lib/libecore_x.so.1.13.0
b6295000 b6298000 r-xp /lib/libcap.so.2.21
b62a8000 b62d1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e2000 b62e9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62fb000 b6332000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6343000 b642e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6441000 b64ba000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64cc000 b64d1000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64e1000 b64eb000 r-xp /usr/lib/libvconf.so.0.2.45
b64fb000 b64fd000 r-xp /usr/lib/libvasum.so.0.3.1
b650d000 b650f000 r-xp /usr/lib/libttrace.so.1.1
b651f000 b6522000 r-xp /usr/lib/libiniparser.so.0
b6532000 b6558000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6568000 b656d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b657e000 b6595000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65a6000 b6611000 r-xp /lib/libm-2.20-2014.11.so
b6622000 b6628000 r-xp /lib/librt-2.20-2014.11.so
b6639000 b6646000 r-xp /usr/lib/libunwind.so.8.0.1
b667c000 b67a0000 r-xp /lib/libc-2.20-2014.11.so
b67b5000 b67ce000 r-xp /lib/libgcc_s-4.9.so.1
b67de000 b68c0000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68d1000 b68fb000 r-xp /usr/lib/libdbus-1.so.3.8.12
b690c000 b6948000 r-xp /usr/lib/libsystemd.so.0.4.0
b694a000 b69cc000 r-xp /usr/lib/libedje.so.1.13.0
b69df000 b69fd000 r-xp /usr/lib/libecore.so.1.13.0
b6a1d000 b6ba4000 r-xp /usr/lib/libevas.so.1.13.0
b6bd9000 b6bed000 r-xp /lib/libpthread-2.20-2014.11.so
b6c01000 b6e36000 r-xp /usr/lib/libelementary.so.1.13.0
b6e64000 b6e68000 r-xp /usr/lib/libsmack.so.1.0.0
b6e78000 b6e7f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e8f000 b6e91000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea1000 b6ea4000 r-xp /usr/lib/libbundle.so.0.1.22
b6eb4000 b6eb6000 r-xp /lib/libdl-2.20-2014.11.so
b6ec7000 b6edf000 r-xp /usr/lib/libaul.so.0.1.0
b6ef3000 b6ef8000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f09000 b6f16000 r-xp /usr/lib/liblptcp.so
b6f28000 b6f2c000 r-xp /usr/lib/libsys-assert.so
b6f3d000 b6f5d000 r-xp /lib/ld-2.20-2014.11.so
b6f6e000 b6f73000 r-xp /usr/bin/launchpad-loader
b7f45000 b82d5000 rw-p [heap]
bec38000 bec59000 rw-p [stack]
bec38000 bec59000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4309)
Call Stack Count: 1
 0: (0xb66f16f0) [/lib/libc.so.6] + 0x756f0
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
D(  688): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.bt-syspopup
09-10 14:15:11.600+0600 I/APP_CORE( 4525): appcore-efl.c: __do_app(520) > [APP 4525] Event: RESET State: CREATED
09-10 14:15:11.600+0600 I/CAPI_APPFW_APPLICATION( 4525): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 14:15:11.800+0600 W/TIZEN_N_SOUND_MANAGER( 4525): sound_manager.c: sound_manager_get_session_type(234) > session hasn't been set, setting default session
09-10 14:15:11.800+0600 I/TIZEN_N_SOUND_MANAGER( 4525): sound_manager.c: sound_manager_get_session_type(273) > returns : type=0, ret=0x0
09-10 14:15:11.800+0600 W/TIZEN_N_SOUND_MANAGER( 4525): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=2
09-10 14:15:11.810+0600 W/TIZEN_N_SOUND_MANAGER( 4525): sound_manager.c: sound_manager_set_session_type(219) > << leave : type=2, ret=0x0
09-10 14:15:11.810+0600 E/TIZEN_N_SOUND_MANAGER( 4525): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_set_session_type] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:15:11.810+0600 E/TIZEN_N_SOUND_MANAGER( 4525): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_max_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:15:11.820+0600 I/TIZEN_N_SOUND_MANAGER( 4525): sound_manager.c: sound_manager_get_volume(84) > returns : type=1, volume=11, ret=0x0
09-10 14:15:11.820+0600 E/TIZEN_N_SOUND_MANAGER( 4525): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 14:15:11.870+0600 E/RESOURCED(  688): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
09-10 14:15:11.870+0600 E/RESOURCED(  688): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
09-10 14:15:11.870+0600 E/RESOURCED(  688): cgroup.c: place_pid_to_cgroup_by_fullpath(82) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
09-10 14:15:11.870+0600 E/RESOURCED(  688): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
09-10 14:15:11.870+0600 E/RESOURCED(  688): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
09-10 14:15:11.870+0600 E/RESOURCED(  688): cgroup.c: place_pid_to_cgroup_by_fullpath(82) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
09-10 14:15:11.880+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_create(1198) > [player_create] new handle : 0xb7aaa3f0
09-10 14:15:11.880+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_set_sound_type(1600) > [player_set_sound_type] sound type = 1
09-10 14:15:11.880+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_prepare(1382) > [player_prepare] Start
09-10 14:15:11.930+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(725) > [__msg_callback] Got message type : 0x3
09-10 14:15:11.930+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(751) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
09-10 14:15:11.930+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(946) > [__msg_callback] End
09-10 14:15:12.080+0600 E/RESOURCED(  688): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
09-10 14:15:12.080+0600 E/RESOURCED(  688): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
09-10 14:15:12.080+0600 E/RESOURCED(  688): cgroup.c: place_pid_to_cgroup_by_fullpath(82) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
09-10 14:15:12.180+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(725) > [__msg_callback] Got message type : 0x3
09-10 14:15:12.180+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(751) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
09-10 14:15:12.180+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(946) > [__msg_callback] End
09-10 14:15:12.180+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_prepare(1451) > [player_prepare] End
09-10 14:15:12.180+0600 W/TIZEN_N_PLAYER( 4525): player.c: __set_callback(571) > [__set_callback] Event type : 1 
09-10 14:15:12.180+0600 W/TIZEN_N_PLAYER( 4525): player.c: __set_callback(571) > [__set_callback] Event type : 2 
09-10 14:15:12.180+0600 W/TIZEN_N_PLAYER( 4525): player.c: __set_callback(571) > [__set_callback] Event type : 3 
09-10 14:15:12.190+0600 E/EFL     ( 4525): edje<4525> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:15:12.190+0600 E/EFL     ( 4525): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:15:12.190+0600 E/EFL     ( 4525): edje<4525> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:15:12.190+0600 E/EFL     ( 4525): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:15:12.190+0600 E/EFL     ( 4525): edje<4525> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:15:12.190+0600 E/EFL     ( 4525): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:15:12.190+0600 E/EFL     ( 4525): edje<4525> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:15:12.190+0600 E/EFL     ( 4525): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:15:12.210+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_start(1638) > [player_start] Start
09-10 14:15:12.210+0600 E/TIZEN_N_PLAYER( 4525): player.c: __player_convert_error_code(291) > [player_start] PLAYER_ERROR_SOUND_POLICY(0xfe6c0025) : core fw error(0x80000b03)
09-10 14:15:12.210+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_unprepare(1459) > [player_unprepare] Start
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(725) > [__msg_callback] Got message type : 0x3
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(751) > STATE CHANGED INTERNALLY - from : 3,  to : 0 (CAPI State : 2)
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: __msg_callback(946) > [__msg_callback] End
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_unprepare(1498) > [player_unprepare] End
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_destroy(1206) > [player_destroy] Start, handle to destroy : 0xb7aaa3f0
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: __message_cb_loop(640) > Retrived  message [5] from queue
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: __message_cb_loop(703) > PLAYER_MESSAGE_LOOP_EXIT
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_destroy(1221) > Adding message [5] to queue
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_destroy(1226) > message thread released
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_destroy(1236) > [player_destroy] Done mm_player_destroy
09-10 14:15:12.240+0600 W/TIZEN_N_PLAYER( 4525): player.c: player_destroy(1265) > [player_destroy] End
09-10 14:15:12.281+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:15:12.281+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:15:12.291+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 14:15:12.291+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:15:12.301+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:15:12.321+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785cd48), gem(24), surface(0xb78a7f50)
09-10 14:15:12.321+0600 W/APP_CORE( 4525): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000006
09-10 14:15:12.321+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78a6e78), gem(10), surface(0xb78bb9e0)
09-10 14:15:12.331+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 14:15:12.341+0600 I/APP_CORE( 4525): appcore-efl.c: __do_app(520) > [APP 4525] Event: RESUME State: CREATED
09-10 14:15:12.351+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(4525) status(3)
09-10 14:15:12.351+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb780a980), gem(23), surface(0xb78925e8)
09-10 14:15:12.351+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:15:12.351+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:15:12.351+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.bt-syspopup(4525)
09-10 14:15:12.351+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 4525, appid: com.samsung.bt-syspopup, status: fg
09-10 14:15:12.371+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:15:12.371+0600 I/APP_CORE( 4525): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 14:15:12.371+0600 I/APP_CORE( 4525): appcore-efl.c: __do_app(637) > [APP 4525] Initial Launching, call the resume_cb
09-10 14:15:12.371+0600 I/CAPI_APPFW_APPLICATION( 4525): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 14:15:12.501+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.bt-syspopup)
09-10 14:15:12.501+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.bt-syspopup, 4525.
09-10 14:15:13.231+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb773fd88), gem(31), surface(0xb78a0bf0)
09-10 14:15:13.281+0600 E/EFL     ( 4525): ecore_x<4525> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6857563
09-10 14:15:13.352+0600 E/EFL     ( 4525): ecore_x<4525> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6857625
09-10 14:15:13.382+0600 D/bluetooth( 4309): Callback: Socket of connection - 41.
09-10 14:15:13.382+0600 D/bluetooth( 4309): Callback: Role of connection - 1.
09-10 14:15:13.382+0600 D/bluetooth( 4309): Callback: Address of connection - 90:00:DB:03:35:2E.
09-10 14:15:13.392+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:15:13.412+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:15:13.432+0600 D/bluetooth( 4309): Socket fd: 41
09-10 14:15:13.432+0600 D/bluetooth( 4309): Data: Touhid Rahman
09-10 14:15:13.432+0600 D/bluetooth( 4309): Size: 30
09-10 14:15:13.442+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:15:13.442+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:15:13.442+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.bt-syspopup(4525)
09-10 14:15:13.442+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 4525, appid: com.samsung.bt-syspopup, status: bg
09-10 14:15:13.442+0600 I/Tizen::System( 1366): (259) > Active app [org.exampl], current [com.samsun] 
09-10 14:15:13.442+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:15:13.452+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:15:13.452+0600 I/CAPI_APPFW_APPLICATION( 4525): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:15:13.452+0600 I/CAPI_APPFW_APPLICATION( 4525): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:15:13.582+0600 I/TIZEN_N_SOUND_MANAGER( 4525): sound_manager.c: __sound_manager_finalize(715) > <ENTER>
09-10 14:15:13.582+0600 I/TIZEN_N_SOUND_MANAGER( 4525): sound_manager.c: __sound_manager_finalize(721) > <LEAVE>
09-10 14:15:13.602+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 4525 pgid = 4525
09-10 14:15:13.602+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(4525)
09-10 14:15:13.632+0600 I/UXT     ( 5830): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 14:15:13.682+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 14:15:13.682+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 14:15:13.682+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 14:15:13.682+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 4525
09-10 14:15:13.682+0600 I/Tizen::App( 1366): (243) > App[com.samsung.bt-syspopup] pid[4525] terminate event is forwarded
09-10 14:15:13.682+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:15:13.682+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.bt-syspopup, 4525, ]
09-10 14:15:13.682+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:15:13.682+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.bt-syspopup)
09-10 14:15:13.682+0600 I/Tizen::App( 1366): (512) > Not registered pid(4525)
09-10 14:15:13.682+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.bt-syspopup]
09-10 14:15:13.682+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:15:13.682+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 4525
09-10 14:15:13.682+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 4525
09-10 14:15:13.702+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:15:13.702+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.bt-syspopup, 4525.
09-10 14:15:17.616+0600 E/EFL     ( 4309): ecore_x<4309> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6861898
09-10 14:15:17.686+0600 E/EFL     ( 4309): ecore_x<4309> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6861952
09-10 14:15:17.836+0600 E/EFL     ( 4309): ecore_x<4309> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6862125
09-10 14:15:17.896+0600 E/EFL     ( 4309): ecore_x<4309> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6862188
09-10 14:15:18.036+0600 E/EFL     ( 4309): ecore_x<4309> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6862317
09-10 14:15:18.086+0600 E/EFL     ( 4309): ecore_x<4309> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6862369
09-10 14:15:18.447+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 14:15:41.049+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 14:15:48.045+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:15:48.045+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:15:48.065+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 14:15:48.065+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 14:15:48.065+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 14:15:48.065+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:13c1be0
09-10 14:15:48.065+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 14:15:48.065+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 14:15:48.065+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 14:15:48.075+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 14:15:48.075+0600 W/APP_CORE( 4309): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 14:15:48.075+0600 I/APP_CORE( 4309): appcore-efl.c: __do_app(520) > [APP 4309] Event: PAUSE State: RUNNING
09-10 14:15:48.075+0600 I/CAPI_APPFW_APPLICATION( 4309): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 14:15:48.085+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:15:48.085+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:15:48.085+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 14:15:48.095+0600 I/APP_CORE( 4309): appcore-efl.c: __do_app(520) > [APP 4309] Event: PAUSE State: PAUSED
09-10 14:15:48.095+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 4309): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 14:15:48.095+0600 E/APP_CORE( 4309): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 14:15:48.095+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:15:48.105+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7725910), gem(15), surface(0xb78925e8)
09-10 14:15:48.105+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 14:15:48.105+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:15:48.105+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:15:48.105+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 14:15:48.105+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 14:15:48.206+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 14:15:48.626+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(4309) status(4)
09-10 14:15:48.626+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(4309)
09-10 14:15:48.626+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 4309, appid: org.example.bluetooth, status: bg
09-10 14:15:48.636+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 14:15:48.636+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 14:15:48.646+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 14:15:48.676+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 14:15:48.676+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 14:15:48.676+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 14:15:48.676+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 14:15:48.676+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:15:48.676+0600 E/VCONF   (18475): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 14:15:48.676+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:15:48.676+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:15:48.676+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 14:15:48.676+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 14:15:48.676+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 14:15:48.676+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 14:15:48.686+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785af58), gem(10), surface(0xb78bb9e0)
09-10 14:15:48.686+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 14:15:48.686+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 14:15:48.686+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77d2888), gem(14), surface(0xb786c978)
09-10 14:15:48.686+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:15:48.686+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 14:15:48.686+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 14:15:48.686+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 14:15:48.686+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 14:15:48.686+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 14:15:48.696+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 5985
09-10 14:15:48.726+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 14:15:48.726+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:15:48.746+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:15:48.746+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 5985
09-10 14:15:48.746+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 5985, appid: com.samsung.weather-m-agent
09-10 14:15:48.766+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5985)
09-10 14:15:48.766+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 14:15:48.776+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 14:15:48.776+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 5985.
09-10 14:15:48.786+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 14:15:48.786+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 14:15:48.786+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 14:15:48.786+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 14:15:48.786+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 14:15:48.786+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 14:15:48.786+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 14:15:48.786+0600 E/RESOURCED(  688): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 14:15:48.796+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 14:15:48.796+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 14:15:48.796+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 14:15:48.796+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 14:15:48.806+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 14:15:48.826+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 14:15:48.866+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76af128), gem(22), surface(0xb78a0bf0)
09-10 14:15:49.016+0600 E/weather-agent( 5985): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 14:15:49.016+0600 E/weather-common( 5985): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 14:15:49.016+0600 E/weather-agent( 5985): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 14:15:49.036+0600 I/MESSAGE_PORT( 5985): message-port.c: __initialize(872) > initialize
09-10 14:15:49.046+0600 I/MESSAGE_PORT( 5985): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 14:15:49.086+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 14:15:49.086+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 14:15:49.086+0600 I/MESSAGE_PORT( 5985): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:15:49.086+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 14:15:49.086+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 14:15:49.086+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 14:15:49.096+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 14:15:49.096+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 14:15:49.096+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 14:15:49.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 14:15:49.106+0600 E/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 14:15:49.106+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 14:15:49.106+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 14:15:49.116+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:15:49.116+0600 E/MESSAGE_PORT( 5985): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 14:15:49.116+0600 E/weather-common( 5985): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 14:15:49.116+0600 E/weather-agent( 5985): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 14:15:49.116+0600 E/weather-agent( 5985): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 14:15:49.116+0600 I/MESSAGE_PORT( 5985): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 14:15:49.146+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 14:15:49.187+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 14:15:49.187+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 14:15:49.387+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83c2a28]
09-10 14:15:49.387+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 14:15:49.387+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83c2a28
09-10 14:15:49.387+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 14:15:49.397+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 14:15:49.397+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 14:15:49.417+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 14:15:49.417+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 14:15:49.427+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:15:49.457+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800b23da is not stable during recalc loop
09-10 14:15:49.517+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800b23da is not stable during recalc loop
09-10 14:15:49.517+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 14:15:49.527+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 14:15:50.127+0600 E/weather-agent( 5985): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 14:15:50.127+0600 I/CAPI_APPFW_APPLICATION( 5985): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 14:15:50.127+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:15:50.127+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:15:50.127+0600 E/weather-agent( 5985): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 14:15:50.278+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 14:15:50.278+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5985
09-10 14:15:50.278+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[5985] terminate event is forwarded
09-10 14:15:50.278+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:15:50.278+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 5985, ]
09-10 14:15:50.278+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:15:50.278+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 14:15:50.278+0600 I/Tizen::App( 1366): (512) > Not registered pid(5985)
09-10 14:15:50.278+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 14:15:50.278+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:15:50.278+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 5985
09-10 14:15:50.288+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:15:50.288+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 5985.
09-10 14:15:53.090+0600 I/APP_CORE( 4309): appcore-efl.c: __do_app(520) > [APP 4309] Event: MEM_FLUSH State: PAUSED
09-10 14:15:55.132+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 14:16:27.874+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 78
09-10 14:16:27.874+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 14:16:27.874+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
09-10 14:16:27.874+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
09-10 14:16:27.884+0600 E/INDICATOR(  685): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
09-10 14:18:11.976+0600 E/PKGMGR_SERVER( 6653): pkgmgr-server.c: main(2414) > package manager server start
09-10 14:18:12.046+0600 E/PKGMGR  ( 6650): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 4309
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 14:18:12.086+0600 W/AUL     ( 6656): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4309)
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(4309), cmd(4)
09-10 14:18:12.086+0600 W/AUL     ( 6656): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 4309
09-10 14:18:12.086+0600 I/APP_CORE( 4309): appcore-efl.c: __do_app(520) > [APP 4309] Event: TERMINATE State: PAUSED
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:18:12.086+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:18:12.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 14:18:12.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 14:18:12.096+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 4309): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 14:18:12.096+0600 E/APP_CORE( 4309): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 14:18:12.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 14:18:12.096+0600 E/APP_CORE( 4309): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 14:18:12.096+0600 I/CAPI_APPFW_APPLICATION( 4309): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 14:18:12.096+0600 E/CAPI_NETWORK_BLUETOOTH( 4309): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 14:18:12.156+0600 E/CAPI_NETWORK_BLUETOOTH( 4309): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 14:18:12.156+0600 E/CAPI_NETWORK_BLUETOOTH( 4309): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 14:18:12.156+0600 E/bluetooth( 4309): [bt_adapter_le_destroy_advertiser] Failed.
09-10 14:18:12.156+0600 I/CAPI_NETWORK_WIFI( 4309): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 14:18:12.156+0600 E/bluetooth( 4309): [wifi_deinitialize] Success.
09-10 14:18:12.186+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 14:18:12.186+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 14:18:12.186+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 14:18:12.186+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 14:18:12.186+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 14:18:12.186+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 14:18:12.186+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 14:18:12.186+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 14:18:12.206+0600 E/PKGMGR_SERVER( 6653): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6656]
09-10 14:18:12.206+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb789be00), gem(23), surface(0xb7824c98)
09-10 14:18:12.206+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 14:18:12.226+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb789be00), gem(23), surface(0xb78b2160)
09-10 14:18:12.226+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76af128), gem(22), surface(0xb7884630)
09-10 14:18:12.236+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7725910), gem(15), surface(0xb787c298)
09-10 14:18:12.276+0600 E/EFL     ( 4309): elementary<4309> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 14:18:12.426+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 4309 pgid = 4309
09-10 14:18:12.426+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(4309)
09-10 14:18:12.506+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 14:18:12.506+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 14:18:12.506+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 14:18:12.506+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[4309] terminate event is forwarded
09-10 14:18:12.506+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 14:18:12.506+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 4309, ]
09-10 14:18:12.506+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 14:18:12.506+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 14:18:12.506+0600 I/Tizen::App( 1366): (512) > Not registered pid(4309)
09-10 14:18:12.506+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 14:18:12.506+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 14:18:12.516+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 4309
09-10 14:18:12.516+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 4309
09-10 14:18:12.536+0600 E/RESOURCED(  688): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.870
09-10 14:18:12.546+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 14:18:12.546+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 4309.
09-10 14:18:12.596+0600 W/CRASH_MANAGER( 6663): worker.c: worker_job(1199) > 1104309626162147349549
