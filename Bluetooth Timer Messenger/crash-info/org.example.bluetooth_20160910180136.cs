S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 13081
Date: 2016-09-10 18:01:36+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13081, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb81bbbd0
r2   = 0xb4380000, r3   = 0xb4380000
r4   = 0xbe8ee5bc, r5   = 0xb6a7f0f4
r6   = 0xb6a7e310, r7   = 0xbe8ee41c
r8   = 0xb6a7f0f4, r9   = 0xb6a7f0f4
r10  = 0xb6a8d20c, fp   = 0x00000000
ip   = 0xb2a73e5c, sp   = 0xbe8ed798
lr   = 0xb2a69873, pc   = 0xb67626f0
cpsr = 0x80010030

Memory Information
MemTotal:   730440 KB
MemFree:     45476 KB
Buffers:     44648 KB
Cached:     291748 KB
VmPeak:     111412 KB
VmSize:     105028 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25520 KB
VmRSS:       25448 KB
VmData:      35128 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36216 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 13081 TID = 13081
13081 13084 13209 

Maps Information
b1dc0000 b25bf000 rw-p [stack:13209]
b25bf000 b25d0000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25e0000 b25e5000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2671000 b2679000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b268a000 b268b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b269b000 b26af000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26c3000 b26c4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26d4000 b26d7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26e8000 b26e9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26f9000 b26fb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b270b000 b270d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b271d000 b272d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b273d000 b2749000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b295a000 b2971000 r-xp /usr/lib/libnetwork.so.0.0.0
b2982000 b29c0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29d1000 b29d8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29e9000 b29f8000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a08000 b2a3d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a50000 b2a56000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a66000 b2a6c000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b8d000 b2c70000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ca7000 b2ccf000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ce1000 b34e0000 rw-p [stack:13084]
b34e0000 b34e2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34f2000 b34fc000 r-xp /lib/libnss_files-2.20-2014.11.so
b350d000 b3516000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3527000 b3538000 r-xp /lib/libnsl-2.20-2014.11.so
b354b000 b3551000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3562000 b3563000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b358b000 b3592000 r-xp /usr/lib/libminizip.so.1.0.0
b35a2000 b35a7000 r-xp /usr/lib/libstorage.so.0.1
b35b7000 b360c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3622000 b3636000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3646000 b368a000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b369a000 b36a2000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36b2000 b36e2000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36f5000 b37ae000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37c2000 b3816000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3827000 b3842000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3852000 b3913000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3926000 b3938000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3948000 b394c000 r-xp /usr/lib/libogg.so.0.7.1
b395c000 b397e000 r-xp /usr/lib/libvorbis.so.0.4.3
b398e000 b3a72000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a8e000 b3a9b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3aac000 b3aef000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b04000 b3b4b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b5c000 b3b62000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b73000 b3b7a000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b8a000 b3bca000 r-xp /usr/lib/libmdm.so.1.2.10
b3bda000 b3be2000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bf1000 b3c01000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c22000 b3c82000 r-xp /usr/lib/libasound.so.2.0.0
b3c94000 b3cca000 r-xp /usr/lib/libpulse.so.0.16.2
b3cdb000 b3cde000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cee000 b3cf1000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d01000 b3d06000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d16000 b3d17000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d27000 b3d32000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d46000 b3d4d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d5d000 b3d63000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d73000 b3d78000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d88000 b3da3000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3db3000 b3dba000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dca000 b3dcd000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3dde000 b3e0c000 r-xp /usr/lib/libidn.so.11.5.44
b3e1c000 b3e32000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e43000 b3e4d000 r-xp /usr/lib/libcares.so.2.1.0
b3e5d000 b3e67000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e77000 b3e79000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e89000 b3e8a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e9a000 b3e9e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eaf000 b3ed7000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ee8000 b3f11000 r-xp /usr/lib/libturbojpeg.so
b3f31000 b3f37000 r-xp /usr/lib/libgif.so.4.1.6
b3f47000 b3f8d000 r-xp /usr/lib/libcurl.so.4.3.0
b3f9e000 b3fbf000 r-xp /usr/lib/libexif.so.12.3.3
b3fda000 b3fef000 r-xp /usr/lib/libtts.so
b4000000 b4008000 r-xp /usr/lib/libfeedback.so.0.1.4
b4018000 b40d8000 r-xp /usr/lib/libdali-core.so.0.0.0
b40e3000 b41d6000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41f6000 b42d0000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42e7000 b42e9000 r-xp /usr/lib/libboost_system.so.1.51.0
b42f9000 b42ff000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b430f000 b4332000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4343000 b4345000 r-xp /usr/lib/libappsvc.so.0.1.0
b4355000 b4357000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4368000 b436d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4384000 b4386000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4396000 b439d000 r-xp /usr/lib/libsensord-share.so
b43ad000 b43c5000 r-xp /usr/lib/libsensor.so.1.1.0
b43d6000 b43d9000 r-xp /usr/lib/libXv.so.1.0.0
b43e9000 b43ee000 r-xp /usr/lib/libutilX.so.1.1.0
b43fe000 b4403000 r-xp /usr/lib/libappcore-common.so.1.1
b4413000 b441a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b442d000 b4431000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4442000 b450c000 r-xp /usr/lib/libCOREGL.so.4.0
b4523000 b4526000 r-xp /usr/lib/libuuid.so.1.3.0
b4537000 b454e000 r-xp /usr/lib/libblkid.so.1.1.0
b455f000 b4561000 r-xp /usr/lib/libXau.so.6.0.0
b4571000 b4574000 r-xp /usr/lib/libEGL.so.1.4
b457c000 b4582000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4592000 b4594000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45a5000 b45b3000 r-xp /usr/lib/libGLESv2.so.2.0
b45bc000 b461e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4633000 b464b000 r-xp /usr/lib/libmount.so.1.1.0
b465c000 b4670000 r-xp /usr/lib/libxcb.so.1.1.0
b4681000 b4688000 r-xp /lib/libcrypt-2.20-2014.11.so
b46c0000 b46d1000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46e2000 b46e4000 r-xp /usr/lib/libiri.so
b46f4000 b46ff000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4710000 b4725000 r-xp /lib/libexpat.so.1.5.2
b4737000 b47f5000 r-xp /usr/lib/libcairo.so.2.11200.14
b4808000 b4810000 r-xp /usr/lib/libdrm.so.2.4.0
b4820000 b4823000 r-xp /usr/lib/libdri2.so.0.0.0
b4834000 b4882000 r-xp /usr/lib/libssl.so.1.0.0
b4897000 b48a3000 r-xp /usr/lib/libeeze.so.1.13.0
b48b3000 b48bc000 r-xp /usr/lib/libethumb.so.1.13.0
b48cc000 b48cf000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48df000 b4a96000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ed000 b56f6000 r-xp /usr/lib/libXi.so.6.1.0
b5706000 b5708000 r-xp /usr/lib/libXgesture.so.7.0.0
b5718000 b571c000 r-xp /usr/lib/libXtst.so.6.1.0
b572c000 b5732000 r-xp /usr/lib/libXrender.so.1.3.0
b5742000 b5748000 r-xp /usr/lib/libXrandr.so.2.2.0
b5759000 b575b000 r-xp /usr/lib/libXinerama.so.1.0.0
b576b000 b576e000 r-xp /usr/lib/libXfixes.so.3.1.0
b577e000 b5789000 r-xp /usr/lib/libXext.so.6.4.0
b5799000 b579b000 r-xp /usr/lib/libXdamage.so.1.1.0
b57ab000 b57ad000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57be000 b58a0000 r-xp /usr/lib/libX11.so.6.3.0
b58b3000 b58ba000 r-xp /usr/lib/libXcursor.so.1.0.2
b58ca000 b58e2000 r-xp /usr/lib/libudev.so.1.6.0
b58e4000 b58e7000 r-xp /lib/libattr.so.1.1.0
b58f7000 b5917000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5919000 b591e000 r-xp /usr/lib/libffi.so.6.0.2
b592e000 b5946000 r-xp /lib/libz.so.1.2.8
b5956000 b5958000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5968000 b5a3d000 r-xp /usr/lib/libxml2.so.2.9.2
b5a52000 b5aed000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b09000 b5b0c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b1c000 b5b35000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b46000 b5b57000 r-xp /lib/libresolv-2.20-2014.11.so
b5b6b000 b5be5000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bfa000 b5bfc000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c0c000 b5c13000 r-xp /usr/lib/libembryo.so.1.13.0
b5c23000 b5c3b000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4c000 b5c6f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c90000 b5ca4000 r-xp /usr/lib/libector.so.1.13.0
b5cb5000 b5ccd000 r-xp /usr/lib/liblua-5.1.so
b5cde000 b5d35000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d49000 b5d71000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d82000 b5d95000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da6000 b5ddd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dee000 b5dfc000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e0c000 b5e14000 r-xp /usr/lib/libtbm.so.1.0.0
b5e24000 b5e31000 r-xp /usr/lib/libeio.so.1.13.0
b5e41000 b5e43000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e53000 b5e58000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e68000 b5e7f000 r-xp /usr/lib/libefreet.so.1.13.0
b5e91000 b5eb1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec1000 b5ee1000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee3000 b5ee9000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ef9000 b5f0a000 r-xp /usr/lib/libemotion.so.1.13.0
b5f1b000 b5f22000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f32000 b5f41000 r-xp /usr/lib/libeo.so.1.13.0
b5f52000 b5f64000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f75000 b5f7a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8a000 b5fa3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb3000 b5fd0000 r-xp /usr/lib/libeet.so.1.13.0
b5fe9000 b6031000 r-xp /usr/lib/libeina.so.1.13.0
b6042000 b6052000 r-xp /usr/lib/libefl.so.1.13.0
b6063000 b6148000 r-xp /usr/lib/libicuuc.so.51.1
b6165000 b62a5000 r-xp /usr/lib/libicui18n.so.51.1
b62bc000 b62f4000 r-xp /usr/lib/libecore_x.so.1.13.0
b6306000 b6309000 r-xp /lib/libcap.so.2.21
b6319000 b6342000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6353000 b635a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b636c000 b63a3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b4000 b649f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b2000 b652b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b653d000 b6542000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6552000 b655c000 r-xp /usr/lib/libvconf.so.0.2.45
b656c000 b656e000 r-xp /usr/lib/libvasum.so.0.3.1
b657e000 b6580000 r-xp /usr/lib/libttrace.so.1.1
b6590000 b6593000 r-xp /usr/lib/libiniparser.so.0
b65a3000 b65c9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65d9000 b65de000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ef000 b6606000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6617000 b6682000 r-xp /lib/libm-2.20-2014.11.so
b6693000 b6699000 r-xp /lib/librt-2.20-2014.11.so
b66aa000 b66b7000 r-xp /usr/lib/libunwind.so.8.0.1
b66ed000 b6811000 r-xp /lib/libc-2.20-2014.11.so
b6826000 b683f000 r-xp /lib/libgcc_s-4.9.so.1
b684f000 b6931000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6942000 b696c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b697d000 b69b9000 r-xp /usr/lib/libsystemd.so.0.4.0
b69bb000 b6a3d000 r-xp /usr/lib/libedje.so.1.13.0
b6a50000 b6a6e000 r-xp /usr/lib/libecore.so.1.13.0
b6a8e000 b6c15000 r-xp /usr/lib/libevas.so.1.13.0
b6c4a000 b6c5e000 r-xp /lib/libpthread-2.20-2014.11.so
b6c72000 b6ea7000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed5000 b6ed9000 r-xp /usr/lib/libsmack.so.1.0.0
b6ee9000 b6ef0000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f00000 b6f02000 r-xp /usr/lib/libdlog.so.0.0.0
b6f12000 b6f15000 r-xp /usr/lib/libbundle.so.0.1.22
b6f25000 b6f27000 r-xp /lib/libdl-2.20-2014.11.so
b6f38000 b6f50000 r-xp /usr/lib/libaul.so.0.1.0
b6f64000 b6f69000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7a000 b6f87000 r-xp /usr/lib/liblptcp.so
b6f99000 b6f9d000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fce000 r-xp /lib/ld-2.20-2014.11.so
b6fdf000 b6fe4000 r-xp /usr/bin/launchpad-loader
b8152000 b84e3000 rw-p [heap]
be8ce000 be8ef000 rw-p [stack]
b8152000 b84e3000 rw-p [heap]
be8ce000 be8ef000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13081)
Call Stack Count: 1
 0: (0xb67626f0) [/lib/libc.so.6] + 0x756f0
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
21): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 18:00:32.596+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 18:00:32.596+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 18:00:32.596+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 18:00:32.596+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 18:00:32.596+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 18:00:32.596+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 18:00:32.966+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19596520
09-10 18:00:32.966+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19596520
09-10 18:00:32.996+0600 I/MALI    (  821): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 18:00:33.016+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb777d1c0), gem(27), surface(0xb78b9638)
09-10 18:00:33.026+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19596582
09-10 18:00:33.036+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:33.036+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:33.036+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:33.036+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:33.046+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 18:00:33.076+0600 I/ISE_MULTI(  821): isemain.cpp: slot_set_caps_mode(792) > [0;36m[hidden state:false] mode=0[0m
09-10 18:00:33.076+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=1[0m
09-10 18:00:33.526+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19597079
09-10 18:00:33.526+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19597079
09-10 18:00:33.577+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19597131
09-10 18:00:33.577+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:33.587+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:33.587+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:33.587+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:33.587+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=2[0m
09-10 18:00:34.527+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19598082
09-10 18:00:34.527+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19598082
09-10 18:00:34.568+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19598122
09-10 18:00:34.568+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:34.568+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:34.578+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:34.578+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 18:00:34.578+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:34.578+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:34.578+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=3[0m
09-10 18:00:34.578+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:34.578+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:35.448+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19599008
09-10 18:00:35.458+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19599008
09-10 18:00:35.528+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19599079
09-10 18:00:35.528+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:35.528+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:35.528+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:35.528+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=4[0m
09-10 18:00:35.528+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:35.639+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19599189
09-10 18:00:35.639+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19599189
09-10 18:00:35.699+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19599252
09-10 18:00:35.699+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:35.709+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:35.709+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:35.709+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:35.709+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=5[0m
09-10 18:00:36.469+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19600028
09-10 18:00:36.479+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19600028
09-10 18:00:36.539+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19600092
09-10 18:00:36.539+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:36.539+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:36.539+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 18:00:36.539+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:36.539+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:36.539+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:36.549+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:36.549+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:36.549+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=6[0m
09-10 18:00:37.020+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19600577
09-10 18:00:37.030+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19600577
09-10 18:00:37.100+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19600650
09-10 18:00:37.100+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:37.110+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:37.110+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:37.110+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:37.110+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 18:00:37.701+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19601255
09-10 18:00:37.701+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=19601255
09-10 18:00:37.751+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=19601308
09-10 18:00:37.761+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 18:00:37.761+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 18:00:37.761+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 18:00:37.761+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 18:00:37.771+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 18:00:38.241+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=19601739
09-10 18:00:38.241+0600 E/EFL     (13081): ecore_x<13081> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=19601793
09-10 18:00:38.241+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 18:00:38.241+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 18:00:38.261+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5e00002 FAILED!
09-10 18:00:38.271+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 18:00:38.311+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7725580), gem(13), surface(0xb787e520)
09-10 18:00:38.321+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7768f08), gem(22), surface(0xb78b9638)
09-10 18:00:40.093+0600 E/EFL     (13081): eo<13081> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb8193378 is not pointing to a valid object. Maybe it has already been freed.
09-10 18:00:40.093+0600 E/EFL     (13081): eo<13081> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb8193378) is an invalid ref.
09-10 18:00:40.143+0600 D/bluetooth(13081): [bt_socket_connect_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
09-10 18:00:40.693+0600 E/bluetooth(13081): [socket_connection_state_changed_cb] Failed. result = -29359868.
09-10 18:01:00.072+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 18:01:00.072+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 6:01 p.m.
09-10 18:01:00.072+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 6:01 p.m."
09-10 18:01:00.072+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 6:01 p.m."
09-10 18:01:00.072+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 18:01:00.072+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147387085 Time: <font_size=31> </font_size> <font_size=31> 6:01 p.m.</font_size></font>"
09-10 18:01:01.203+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 18:01:08.200+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 18:01:08.200+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 18:01:08.220+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 18:01:08.220+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 18:01:08.220+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 18:01:08.220+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:13784a0
09-10 18:01:08.220+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 18:01:08.220+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 18:01:08.220+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 18:01:08.230+0600 W/APP_CORE(13081): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 18:01:08.230+0600 I/APP_CORE(13081): appcore-efl.c: __do_app(520) > [APP 13081] Event: PAUSE State: RUNNING
09-10 18:01:08.230+0600 I/CAPI_APPFW_APPLICATION(13081): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 18:01:08.230+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 18:01:08.230+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 18:01:08.230+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 18:01:08.230+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 18:01:08.260+0600 I/APP_CORE(13081): appcore-efl.c: __do_app(520) > [APP 13081] Event: PAUSE State: PAUSED
09-10 18:01:08.310+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 18:01:08.771+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 18:01:08.771+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 18:01:08.771+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77ea860), gem(14), surface(0xb787e520)
09-10 18:01:08.781+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 18:01:08.811+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 18:01:08.811+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 18:01:08.811+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 18:01:08.811+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 18:01:08.821+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 18:01:08.821+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 18:01:08.821+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 18:01:08.821+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 18:01:08.821+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 18:01:08.821+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 18:01:08.821+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 18:01:08.821+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 18:01:08.821+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 18:01:08.821+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 18:01:08.821+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 18:01:08.821+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 18:01:08.821+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 18:01:08.831+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 18:01:08.831+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 18:01:08.831+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78756b0), gem(10), surface(0xb78ae1a0)
09-10 18:01:08.831+0600 I/TIZEN_N_EFL_UTIL_WINDOW(13081): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 569
09-10 18:01:08.831+0600 E/APP_CORE(13081): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 18:01:08.831+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 18:01:08.831+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 18:01:08.831+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 18:01:08.831+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 18:01:08.831+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 18:01:08.831+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 18:01:08.841+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 13748
09-10 18:01:08.841+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 18:01:08.861+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77bce38), gem(15), surface(0xb78ba300)
09-10 18:01:08.881+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 18:01:08.881+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 18:01:08.891+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 13748
09-10 18:01:08.891+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 13748, appid: com.samsung.weather-m-agent
09-10 18:01:08.891+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(13748)
09-10 18:01:08.901+0600 I/TIZEN_N_SOUND_MANAGER(11566): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 18:01:08.901+0600 E/TIZEN_N_SOUND_MANAGER(11566): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 18:01:08.901+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 18:01:08.901+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(13081) status(4)
09-10 18:01:08.901+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(13081)
09-10 18:01:08.901+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 13081, appid: org.example.bluetooth, status: bg
09-10 18:01:08.901+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 18:01:08.901+0600 I/TIZEN_N_SOUND_MANAGER(11566): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 18:01:08.901+0600 E/TIZEN_N_SOUND_MANAGER(11566): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 18:01:08.911+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 18:01:08.911+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 18:01:08.911+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 18:01:08.911+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 18:01:08.911+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 18:01:08.911+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 18:01:08.921+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 18:01:08.921+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 18:01:08.931+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 18:01:08.931+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 18:01:08.931+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 18:01:08.931+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 18:01:08.941+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 18:01:08.951+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 18:01:08.951+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 13748.
09-10 18:01:08.951+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 18:01:09.051+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 18:01:09.051+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 18:01:09.051+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 18:01:09.051+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 18:01:09.061+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 18:01:09.111+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77c6e80), gem(13), surface(0xb7877090)
09-10 18:01:09.171+0600 E/weather-agent(13748): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 18:01:09.171+0600 E/weather-common(13748): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 18:01:09.181+0600 E/weather-agent(13748): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 18:01:09.191+0600 I/MESSAGE_PORT(13748): message-port.c: __initialize(872) > initialize
09-10 18:01:09.201+0600 I/MESSAGE_PORT(13748): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 18:01:09.241+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 18:01:09.241+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 18:01:09.241+0600 I/MESSAGE_PORT(13748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 18:01:09.241+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 18:01:09.241+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 18:01:09.241+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 18:01:09.241+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 18:01:09.241+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 18:01:09.241+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 18:01:09.251+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 18:01:09.251+0600 E/MESSAGE_PORT(13748): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 18:01:09.251+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 18:01:09.251+0600 I/MESSAGE_PORT(13748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 18:01:09.251+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 18:01:09.261+0600 E/MESSAGE_PORT(13748): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 18:01:09.261+0600 E/weather-common(13748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 18:01:09.261+0600 E/weather-agent(13748): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 18:01:09.261+0600 E/weather-agent(13748): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 18:01:09.261+0600 I/MESSAGE_PORT(13748): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 18:01:09.261+0600 I/MESSAGE_PORT(13748): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 18:01:09.261+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 18:01:09.281+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 18:01:09.321+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 18:01:09.321+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 18:01:09.512+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb835d9a0]
09-10 18:01:09.512+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 18:01:09.512+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 18:01:09.512+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 18:01:09.512+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb835d9a0
09-10 18:01:09.512+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 18:01:09.522+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 18:01:09.522+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 18:01:09.522+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 18:01:09.522+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 18:01:09.522+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 18:01:09.532+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 18:01:09.552+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8018104d is not stable during recalc loop
09-10 18:01:09.622+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8018104d is not stable during recalc loop
09-10 18:01:09.622+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 18:01:09.632+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 18:01:10.262+0600 E/weather-agent(13748): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 18:01:10.262+0600 I/CAPI_APPFW_APPLICATION(13748): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 18:01:10.262+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 18:01:10.262+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 18:01:10.262+0600 E/weather-agent(13748): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 18:01:10.422+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 18:01:10.422+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 13748
09-10 18:01:10.422+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[13748] terminate event is forwarded
09-10 18:01:10.422+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 18:01:10.422+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 13748, ]
09-10 18:01:10.422+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 18:01:10.422+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 18:01:10.422+0600 I/Tizen::App( 1366): (512) > Not registered pid(13748)
09-10 18:01:10.422+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 18:01:10.422+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 18:01:10.422+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 13748
09-10 18:01:10.422+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 18:01:10.422+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 18:01:10.422+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 13748.
09-10 18:01:13.225+0600 I/APP_CORE(13081): appcore-efl.c: __do_app(520) > [APP 13081] Event: MEM_FLUSH State: PAUSED
09-10 18:01:15.267+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 18:01:35.877+0600 E/PKGMGR_SERVER(13898): pkgmgr-server.c: main(2414) > package manager server start
09-10 18:01:35.947+0600 E/PKGMGR  (13896): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 13081
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 18:01:35.997+0600 W/AUL     (13902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(13081)
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 18:01:35.997+0600 I/APP_CORE(13081): appcore-efl.c: __do_app(520) > [APP 13081] Event: TERMINATE State: PAUSED
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(13081), cmd(4)
09-10 18:01:35.997+0600 W/AUL     (13902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 18:01:35.997+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 18:01:36.007+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 18:01:36.007+0600 I/TIZEN_N_EFL_UTIL_WINDOW(13081): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 18:01:36.007+0600 E/APP_CORE(13081): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 18:01:36.007+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 18:01:36.007+0600 E/APP_CORE(13081): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 18:01:36.007+0600 I/CAPI_APPFW_APPLICATION(13081): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 18:01:36.007+0600 E/CAPI_NETWORK_BLUETOOTH(13081): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 18:01:36.017+0600 E/PKGMGR_SERVER(13898): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13902]
09-10 18:01:36.068+0600 E/CAPI_NETWORK_BLUETOOTH(13081): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 18:01:36.068+0600 E/CAPI_NETWORK_BLUETOOTH(13081): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 18:01:36.068+0600 E/bluetooth(13081): [bt_adapter_le_destroy_advertiser] Failed.
09-10 18:01:36.078+0600 I/CAPI_NETWORK_WIFI(13081): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 18:01:36.078+0600 E/bluetooth(13081): [wifi_deinitialize] Success.
09-10 18:01:36.098+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 18:01:36.098+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 18:01:36.098+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 18:01:36.098+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 18:01:36.098+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 18:01:36.098+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 18:01:36.118+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7842078), gem(24), surface(0xb78925e8)
09-10 18:01:36.118+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 18:01:36.128+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb773d7a0), gem(18), surface(0xb785cf20)
09-10 18:01:36.128+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78756b0), gem(10), surface(0xb7876f60)
09-10 18:01:36.138+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77bce38), gem(15), surface(0xb784e4b0)
09-10 18:01:36.168+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7842078), gem(24), surface(0xb78ae1a0)
09-10 18:01:36.188+0600 E/EFL     (13081): elementary<13081> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 18:01:36.348+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7854060), gem(18), surface(0xb78ae1a0)
09-10 18:01:36.368+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 13081 pgid = 13081
09-10 18:01:36.368+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(13081)
09-10 18:01:36.408+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 18:01:36.408+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 18:01:36.408+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 18:01:36.408+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 13081
09-10 18:01:36.408+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[13081] terminate event is forwarded
09-10 18:01:36.408+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 18:01:36.408+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 13081, ]
09-10 18:01:36.408+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 18:01:36.408+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 18:01:36.408+0600 I/Tizen::App( 1366): (512) > Not registered pid(13081)
09-10 18:01:36.408+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 18:01:36.408+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 18:01:36.418+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 13081
09-10 18:01:36.418+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3038
09-10 18:01:36.428+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 18:01:36.428+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 18:01:36.428+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 13081.
09-10 18:01:36.478+0600 W/CRASH_MANAGER(13913): worker.c: worker_job(1199) > 1113081626162147350889
