S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 6340
Date: 2016-09-10 15:57:33+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6340, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb77a17e8
r2   = 0xb430d000, r3   = 0xb430d000
r4   = 0xb777ec38, r5   = 0xbe8b65bc
r6   = 0xb6a0b310, r7   = 0xbe8b641c
r8   = 0xb6a0c0f4, r9   = 0xb6a0c0f4
r10  = 0xb6a1a20c, fp   = 0x00000000
ip   = 0xb2a00cec, sp   = 0xbe8b4770
lr   = 0xb29f54db, pc   = 0xb66ef6f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     55912 KB
Buffers:     42476 KB
Cached:     286624 KB
VmPeak:     105592 KB
VmSize:     104636 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24872 KB
VmRSS:       24872 KB
VmData:      34720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36228 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6340 TID = 6340
6340 6344 6804 

Maps Information
b1d4a000 b2549000 rw-p [stack:6804]
b2549000 b255a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b256a000 b256f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25fb000 b2603000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2614000 b2615000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2625000 b2639000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b264d000 b264e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b265e000 b2661000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2672000 b2673000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2683000 b2685000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2695000 b2697000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26a7000 b26b7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26c7000 b26d3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28e4000 b28fb000 r-xp /usr/lib/libnetwork.so.0.0.0
b290c000 b294a000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b295b000 b2962000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2973000 b2982000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2992000 b29c7000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29da000 b29e0000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29f0000 b29f9000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b1a000 b2bfd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c34000 b2c5c000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c6e000 b346d000 rw-p [stack:6344]
b346d000 b346f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b347f000 b3489000 r-xp /lib/libnss_files-2.20-2014.11.so
b349a000 b34a3000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34b4000 b34c5000 r-xp /lib/libnsl-2.20-2014.11.so
b34d8000 b34de000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34ef000 b34f0000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3518000 b351f000 r-xp /usr/lib/libminizip.so.1.0.0
b352f000 b3534000 r-xp /usr/lib/libstorage.so.0.1
b3544000 b3599000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35af000 b35c3000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35d3000 b3617000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3627000 b362f000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b363f000 b366f000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3682000 b373b000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b374f000 b37a3000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37b4000 b37cf000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37df000 b38a0000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38b3000 b38c5000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38d5000 b38d9000 r-xp /usr/lib/libogg.so.0.7.1
b38e9000 b390b000 r-xp /usr/lib/libvorbis.so.0.4.3
b391b000 b39ff000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a1b000 b3a28000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a39000 b3a7c000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a91000 b3ad8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3ae9000 b3aef000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b00000 b3b07000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b17000 b3b57000 r-xp /usr/lib/libmdm.so.1.2.10
b3b67000 b3b6f000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b7e000 b3b8e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3baf000 b3c0f000 r-xp /usr/lib/libasound.so.2.0.0
b3c21000 b3c57000 r-xp /usr/lib/libpulse.so.0.16.2
b3c68000 b3c6b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c7b000 b3c7e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c8e000 b3c93000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3ca3000 b3ca4000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cb4000 b3cbf000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cd3000 b3cda000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cea000 b3cf0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d00000 b3d05000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d15000 b3d30000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d40000 b3d47000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d57000 b3d5a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d6b000 b3d99000 r-xp /usr/lib/libidn.so.11.5.44
b3da9000 b3dbf000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dd0000 b3dda000 r-xp /usr/lib/libcares.so.2.1.0
b3dea000 b3df4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e04000 b3e06000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e16000 b3e17000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e27000 b3e2b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e3c000 b3e64000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e75000 b3e9e000 r-xp /usr/lib/libturbojpeg.so
b3ebe000 b3ec4000 r-xp /usr/lib/libgif.so.4.1.6
b3ed4000 b3f1a000 r-xp /usr/lib/libcurl.so.4.3.0
b3f2b000 b3f4c000 r-xp /usr/lib/libexif.so.12.3.3
b3f67000 b3f7c000 r-xp /usr/lib/libtts.so
b3f8d000 b3f95000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fa5000 b4065000 r-xp /usr/lib/libdali-core.so.0.0.0
b4070000 b4163000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4183000 b425d000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4274000 b4276000 r-xp /usr/lib/libboost_system.so.1.51.0
b4286000 b428c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b429c000 b42bf000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42d0000 b42d2000 r-xp /usr/lib/libappsvc.so.0.1.0
b42e2000 b42e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42f5000 b42fa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4311000 b4313000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4323000 b432a000 r-xp /usr/lib/libsensord-share.so
b433a000 b4352000 r-xp /usr/lib/libsensor.so.1.1.0
b4363000 b4366000 r-xp /usr/lib/libXv.so.1.0.0
b4376000 b437b000 r-xp /usr/lib/libutilX.so.1.1.0
b438b000 b4390000 r-xp /usr/lib/libappcore-common.so.1.1
b43a0000 b43a7000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43ba000 b43be000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43cf000 b4499000 r-xp /usr/lib/libCOREGL.so.4.0
b44b0000 b44b3000 r-xp /usr/lib/libuuid.so.1.3.0
b44c4000 b44db000 r-xp /usr/lib/libblkid.so.1.1.0
b44ec000 b44ee000 r-xp /usr/lib/libXau.so.6.0.0
b44fe000 b4501000 r-xp /usr/lib/libEGL.so.1.4
b4509000 b450f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b451f000 b4521000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4532000 b4540000 r-xp /usr/lib/libGLESv2.so.2.0
b4549000 b45ab000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45c0000 b45d8000 r-xp /usr/lib/libmount.so.1.1.0
b45e9000 b45fd000 r-xp /usr/lib/libxcb.so.1.1.0
b460e000 b4615000 r-xp /lib/libcrypt-2.20-2014.11.so
b464d000 b465e000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b466f000 b4671000 r-xp /usr/lib/libiri.so
b4681000 b468c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b469d000 b46b2000 r-xp /lib/libexpat.so.1.5.2
b46c4000 b4782000 r-xp /usr/lib/libcairo.so.2.11200.14
b4795000 b479d000 r-xp /usr/lib/libdrm.so.2.4.0
b47ad000 b47b0000 r-xp /usr/lib/libdri2.so.0.0.0
b47c1000 b480f000 r-xp /usr/lib/libssl.so.1.0.0
b4824000 b4830000 r-xp /usr/lib/libeeze.so.1.13.0
b4840000 b4849000 r-xp /usr/lib/libethumb.so.1.13.0
b4859000 b485c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b486c000 b4a23000 r-xp /usr/lib/libcrypto.so.1.0.0
b567a000 b5683000 r-xp /usr/lib/libXi.so.6.1.0
b5693000 b5695000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a5000 b56a9000 r-xp /usr/lib/libXtst.so.6.1.0
b56b9000 b56bf000 r-xp /usr/lib/libXrender.so.1.3.0
b56cf000 b56d5000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e6000 b56e8000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f8000 b56fb000 r-xp /usr/lib/libXfixes.so.3.1.0
b570b000 b5716000 r-xp /usr/lib/libXext.so.6.4.0
b5726000 b5728000 r-xp /usr/lib/libXdamage.so.1.1.0
b5738000 b573a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b574b000 b582d000 r-xp /usr/lib/libX11.so.6.3.0
b5840000 b5847000 r-xp /usr/lib/libXcursor.so.1.0.2
b5857000 b586f000 r-xp /usr/lib/libudev.so.1.6.0
b5871000 b5874000 r-xp /lib/libattr.so.1.1.0
b5884000 b58a4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a6000 b58ab000 r-xp /usr/lib/libffi.so.6.0.2
b58bb000 b58d3000 r-xp /lib/libz.so.1.2.8
b58e3000 b58e5000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f5000 b59ca000 r-xp /usr/lib/libxml2.so.2.9.2
b59df000 b5a7a000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a96000 b5a99000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa9000 b5ac2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad3000 b5ae4000 r-xp /lib/libresolv-2.20-2014.11.so
b5af8000 b5b72000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b87000 b5b89000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b99000 b5ba0000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb0000 b5bc8000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd9000 b5bfc000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c1d000 b5c31000 r-xp /usr/lib/libector.so.1.13.0
b5c42000 b5c5a000 r-xp /usr/lib/liblua-5.1.so
b5c6b000 b5cc2000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cd6000 b5cfe000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d0f000 b5d22000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d33000 b5d6a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d7b000 b5d89000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d99000 b5da1000 r-xp /usr/lib/libtbm.so.1.0.0
b5db1000 b5dbe000 r-xp /usr/lib/libeio.so.1.13.0
b5dce000 b5dd0000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de0000 b5de5000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5df5000 b5e0c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e1e000 b5e3e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e4e000 b5e6e000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e70000 b5e76000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e86000 b5e97000 r-xp /usr/lib/libemotion.so.1.13.0
b5ea8000 b5eaf000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ebf000 b5ece000 r-xp /usr/lib/libeo.so.1.13.0
b5edf000 b5ef1000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f02000 b5f07000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f17000 b5f30000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f40000 b5f5d000 r-xp /usr/lib/libeet.so.1.13.0
b5f76000 b5fbe000 r-xp /usr/lib/libeina.so.1.13.0
b5fcf000 b5fdf000 r-xp /usr/lib/libefl.so.1.13.0
b5ff0000 b60d5000 r-xp /usr/lib/libicuuc.so.51.1
b60f2000 b6232000 r-xp /usr/lib/libicui18n.so.51.1
b6249000 b6281000 r-xp /usr/lib/libecore_x.so.1.13.0
b6293000 b6296000 r-xp /lib/libcap.so.2.21
b62a6000 b62cf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e0000 b62e7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62f9000 b6330000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6341000 b642c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b643f000 b64b8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ca000 b64cf000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64df000 b64e9000 r-xp /usr/lib/libvconf.so.0.2.45
b64f9000 b64fb000 r-xp /usr/lib/libvasum.so.0.3.1
b650b000 b650d000 r-xp /usr/lib/libttrace.so.1.1
b651d000 b6520000 r-xp /usr/lib/libiniparser.so.0
b6530000 b6556000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6566000 b656b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b657c000 b6593000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65a4000 b660f000 r-xp /lib/libm-2.20-2014.11.so
b6620000 b6626000 r-xp /lib/librt-2.20-2014.11.so
b6637000 b6644000 r-xp /usr/lib/libunwind.so.8.0.1
b667a000 b679e000 r-xp /lib/libc-2.20-2014.11.so
b67b3000 b67cc000 r-xp /lib/libgcc_s-4.9.so.1
b67dc000 b68be000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68cf000 b68f9000 r-xp /usr/lib/libdbus-1.so.3.8.12
b690a000 b6946000 r-xp /usr/lib/libsystemd.so.0.4.0
b6948000 b69ca000 r-xp /usr/lib/libedje.so.1.13.0
b69dd000 b69fb000 r-xp /usr/lib/libecore.so.1.13.0
b6a1b000 b6ba2000 r-xp /usr/lib/libevas.so.1.13.0
b6bd7000 b6beb000 r-xp /lib/libpthread-2.20-2014.11.so
b6bff000 b6e34000 r-xp /usr/lib/libelementary.so.1.13.0
b6e62000 b6e66000 r-xp /usr/lib/libsmack.so.1.0.0
b6e76000 b6e7d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e8d000 b6e8f000 r-xp /usr/lib/libdlog.so.0.0.0
b6e9f000 b6ea2000 r-xp /usr/lib/libbundle.so.0.1.22
b6eb2000 b6eb4000 r-xp /lib/libdl-2.20-2014.11.so
b6ec5000 b6edd000 r-xp /usr/lib/libaul.so.0.1.0
b6ef1000 b6ef6000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f07000 b6f14000 r-xp /usr/lib/liblptcp.so
b6f26000 b6f2a000 r-xp /usr/lib/libsys-assert.so
b6f3b000 b6f5b000 r-xp /lib/ld-2.20-2014.11.so
b6f6c000 b6f71000 r-xp /usr/bin/launchpad-loader
b773d000 b7a6f000 rw-p [heap]
be896000 be8b7000 rw-p [stack]
b773d000 b7a6f000 rw-p [heap]
be896000 be8b7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6340)
Call Stack Count: 1
 0: (0xb66ef6f0) [/lib/libc.so.6] + 0x756f0
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
drule(291) > sharedrule for org.example.bluetooth has already loaded
09-10 15:56:07.590+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 15:56:07.590+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 15:56:07.600+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 15:56:07.600+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 15:56:07.610+0600 I/CAPI_APPFW_APPLICATION( 5657): app_main.c: ui_app_main(789) > app_efl_main
09-10 15:56:07.620+0600 I/CAPI_APPFW_APPLICATION( 5657): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 15:56:07.640+0600 E/TBM     ( 5657): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 15:56:07.700+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 5657, appid: org.example.bluetooth
09-10 15:56:07.700+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 15:56:07.710+0600 W/AUL     ( 6329): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5657)
09-10 15:56:07.720+0600 E/CAPI_NETWORK_WIFI( 5657): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 15:56:07.760+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 15:56:07.951+0600 I/CAPI_NETWORK_WIFI( 5657): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 15:56:07.951+0600 D/bluetooth( 5657): [wifi_initialize] Success.
09-10 15:56:08.161+0600 I/APP_CORE( 5657): appcore-efl.c: __do_app(520) > [APP 5657] Event: RESET State: CREATED
09-10 15:56:08.161+0600 I/CAPI_APPFW_APPLICATION( 5657): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 15:56:08.161+0600 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:56:08.161+0600 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:56:08.171+0600 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:56:08.171+0600 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:56:08.171+0600 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:56:08.171+0600 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:56:08.261+0600 W/APP_CORE( 5657): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5400002
09-10 15:56:08.271+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 15:56:08.351+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775aad0), gem(18), surface(0xb78ba300)
09-10 15:56:08.361+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7892290), gem(13), surface(0xb78b9638)
09-10 15:56:08.361+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775aad0), gem(18), surface(0xb78bf950)
09-10 15:56:08.371+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7798ce8), gem(15), surface(0xb78be958)
09-10 15:56:08.381+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 15:56:08.381+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 15:56:08.381+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 15:56:08.381+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(5657) status(4)
09-10 15:56:08.411+0600 I/APP_CORE( 5657): appcore-efl.c: __do_app(520) > [APP 5657] Event: PAUSE State: CREATED
09-10 15:56:08.411+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 5657): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 15:56:08.411+0600 E/APP_CORE( 5657): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 15:56:08.421+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:56:08.421+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb776de68), gem(10), surface(0xb787e520)
09-10 15:56:08.571+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7707360), gem(22), surface(0xb78bf950)
09-10 15:56:08.711+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:56:08.711+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 15:56:08.731+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb778ae60), gem(22), surface(0xb787e520)
09-10 15:56:08.751+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1859
09-10 15:56:08.761+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 15:56:08.761+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 5657.
09-10 15:56:08.761+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(5657) status(0)
09-10 15:56:08.761+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:56:09.132+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb775aad0), gem(10), surface(0xb78ba300)
09-10 15:56:09.642+0600 I/UXT     ( 6340): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 15:56:12.705+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(5657)
09-10 15:56:12.705+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 5657, appid: org.example.bluetooth, status: bg
09-10 15:56:46.268+0600 E/PKGMGR_SERVER( 6511): pkgmgr-server.c: main(2414) > package manager server start
09-10 15:56:46.338+0600 E/PKGMGR  ( 6508): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 15:56:46.378+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:56:46.378+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5657
09-10 15:56:46.378+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:56:46.378+0600 W/AUL     ( 6514): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5657)
09-10 15:56:46.378+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(5657), cmd(4)
09-10 15:56:46.388+0600 I/APP_CORE( 5657): appcore-efl.c: __do_app(520) > [APP 5657] Event: TERMINATE State: CREATED
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:56:46.388+0600 W/AUL     ( 6514): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 15:56:46.388+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 5657): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 15:56:46.388+0600 E/APP_CORE( 5657): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 15:56:46.388+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:56:46.388+0600 E/APP_CORE( 5657): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 15:56:46.388+0600 I/CAPI_APPFW_APPLICATION( 5657): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:56:46.398+0600 E/CAPI_NETWORK_BLUETOOTH( 5657): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 15:56:46.398+0600 E/PKGMGR_SERVER( 6511): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6514]
09-10 15:56:46.458+0600 E/CAPI_NETWORK_BLUETOOTH( 5657): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 15:56:46.458+0600 E/CAPI_NETWORK_BLUETOOTH( 5657): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 15:56:46.458+0600 E/bluetooth( 5657): [bt_adapter_le_destroy_advertiser] Failed.
09-10 15:56:46.458+0600 I/CAPI_NETWORK_WIFI( 5657): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 15:56:46.458+0600 E/bluetooth( 5657): [wifi_deinitialize] Success.
09-10 15:56:46.478+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768eb50), gem(21), surface(0xb78a2d70)
09-10 15:56:46.488+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768eb50), gem(21), surface(0xb78b9638)
09-10 15:56:46.498+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778ae60), gem(22), surface(0xb78bf950)
09-10 15:56:46.498+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7798ce8), gem(15), surface(0xb788a2a0)
09-10 15:56:46.518+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 15:56:46.518+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:56:46.518+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:56:46.518+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 15:56:46.518+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 15:56:46.528+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:56:46.819+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5657 pgid = 5657
09-10 15:56:46.819+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(5657)
09-10 15:56:46.849+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:56:46.849+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:56:46.849+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:56:46.849+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[5657] terminate event is forwarded
09-10 15:56:46.849+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:56:46.849+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 5657, ]
09-10 15:56:46.849+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:56:46.849+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 15:56:46.849+0600 I/Tizen::App( 1366): (512) > Not registered pid(5657)
09-10 15:56:46.849+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 15:56:46.849+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:56:46.849+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 5657
09-10 15:56:46.849+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5657
09-10 15:56:46.859+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1864
09-10 15:56:46.869+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:56:46.869+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 5657.
09-10 15:56:48.370+0600 E/PKGMGR_SERVER( 6511): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 15:56:48.370+0600 E/PKGMGR_SERVER( 6511): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 15:56:51.393+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 15:56:51.393+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 15:56:52.874+0600 E/PKGMGR  ( 6627): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
09-10 15:56:52.975+0600 E/PKGMGR_SERVER( 6630): pkgmgr-server.c: main(2414) > package manager server start
09-10 15:56:53.035+0600 E/PKGMGR_SERVER( 6630): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.bluetooth]
09-10 15:56:53.045+0600 E/PKGMGR_SERVER( 6630): pm-mdm.c: _get_package_info_from_file(115) > [0;31m[_get_package_info_from_file(): 115](ret < 0) access() failed. path: org.example.bluetooth errno: 2 (No such file or directory)[0;m
09-10 15:56:53.045+0600 E/PKGMGR  ( 6627): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[66270002]
09-10 15:56:53.125+0600 E/rpm-installer( 6633): rpm-appcore-intf.c: main(104) > ------------------------------------------------
09-10 15:56:53.125+0600 E/rpm-installer( 6633): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
09-10 15:56:53.125+0600 E/rpm-installer( 6633): rpm-appcore-intf.c: main(106) > ------------------------------------------------
09-10 15:56:53.235+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: start, val: update
09-10 15:56:53.235+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [start], Value = [update], install = [1]
09-10 15:56:53.245+0600 W/AUL_AMD (  648): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
09-10 15:56:53.255+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 30
09-10 15:56:53.255+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [30]
09-10 15:56:53.255+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [30], install = [1]
09-10 15:56:53.265+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.265+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.265+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.265+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.265+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.265+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.405+0600 E/rpm-installer( 6633): coretpk-parser.c: _coretpk_parser_get_manifest_info(1377) > (doc == NULL) xmlParseFile() failed.
09-10 15:56:53.405+0600 E/rpm-installer( 6633): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
09-10 15:56:53.475+0600 E/PKGMGR_PARSER( 6633): pkgmgr_parser.c: __check_theme(158) > theme for uninstallation.
09-10 15:56:53.495+0600 I/PRIVACY-MANAGER-CLIENT( 6633): SocketClient.cpp: SocketClient(37) > Client created
09-10 15:56:53.495+0600 I/PRIVACY-MANAGER-CLIENT( 6633): SocketClient.cpp: connect(62) > Client connected
09-10 15:56:53.495+0600 I/PRIVACY-MANAGER-SERVER(  933): SocketService.cpp: mainloop(257) > Got incoming connection
09-10 15:56:53.495+0600 I/PRIVACY-MANAGER-CLIENT( 6633): SocketClient.cpp: disconnect(72) > Client disconnected
09-10 15:56:53.505+0600 E/PKGMGR_CERT( 6633): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
09-10 15:56:53.505+0600 E/PKGMGR_CERT( 6633): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
09-10 15:56:53.525+0600 E/PKGMGR_CERT( 6633): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
09-10 15:56:53.565+0600 E/rpm-installer( 6633): coretpk-installer.c: _coretpk_installer_package_reinstall(6348) > _coretpk_installer_package_reinstall(org.example.bluetooth) failed.
09-10 15:56:53.585+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.585+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.585+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:53.585+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: fail
09-10 15:56:53.585+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [fail], install = [1]
09-10 15:56:53.585+0600 E/ESD     (  915): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
09-10 15:56:53.595+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.bluetooth",~) returned -1
09-10 15:56:53.595+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
09-10 15:56:53.595+0600 W/AUL_AMD (  648): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
09-10 15:56:54.086+0600 E/rpm-installer( 6633): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 15:56:54.086+0600 E/rpm-installer( 6633): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 15:56:54.086+0600 E/rpm-installer( 6633): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 15:56:54.096+0600 E/PKGMGR_SERVER( 6630): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6633]
09-10 15:56:55.367+0600 E/PKGMGR_SERVER( 6630): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 15:56:55.367+0600 E/PKGMGR_SERVER( 6630): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 15:56:58.500+0600 E/PKGMGR  ( 6705): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
09-10 15:56:58.590+0600 E/PKGMGR_SERVER( 6708): pkgmgr-server.c: main(2414) > package manager server start
09-10 15:56:58.650+0600 E/PKGMGR_SERVER( 6708): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk]
09-10 15:56:58.660+0600 E/PKGMGR_INFO( 6708): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] not found in DB
09-10 15:56:58.670+0600 E/BACKEND_LIB( 6708): librpm.c: __installer_util_delete_dir(179) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-10 15:56:58.680+0600 E/PKGMGR_SERVER( 6708): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-10 15:56:58.680+0600 E/PKGMGR  ( 6705): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[67050002]
09-10 15:56:58.760+0600 E/rpm-installer( 6711): rpm-appcore-intf.c: main(104) > ------------------------------------------------
09-10 15:56:58.760+0600 E/rpm-installer( 6711): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
09-10 15:56:58.760+0600 E/rpm-installer( 6711): rpm-appcore-intf.c: main(106) > ------------------------------------------------
09-10 15:56:58.820+0600 E/PKGMGR_INSTALLER( 6711): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
09-10 15:56:58.820+0600 E/rpm-installer( 6711): rpm-appcore-intf.c: main(191) > [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] is tpk package.
09-10 15:56:58.840+0600 E/rpm-installer( 6711): coretpk-parser.c: _coretpk_parser_is_svc_app(1225) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
09-10 15:56:58.840+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [install-location] is empty.
09-10 15:56:58.840+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 15:56:58.840+0600 E/rpm-installer( 6711): coretpk-parser.c: _coretpk_parser_is_widget(1191) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
09-10 15:56:58.840+0600 E/rpm-installer( 6711): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 15:56:58.970+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: start, val: install
09-10 15:56:58.970+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [start], Value = [install], install = [1]
09-10 15:56:58.980+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 30
09-10 15:56:58.980+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [30]
09-10 15:56:58.980+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [30], install = [1]
09-10 15:56:58.990+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:58.990+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:58.990+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:58.990+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:58.990+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:58.990+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:59.090+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_check_vip_tag(474) > (ret == 1) metadata(watchface) is empty.
09-10 15:56:59.090+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [ui-gadget] is empty.
09-10 15:56:59.090+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_get_dpi_type(778) > key for dpi is found, get the dpi.
09-10 15:56:59.090+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_get_dpi_type(787) > device dpi is [233]
09-10 15:56:59.100+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_append_path(343) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-10 15:56:59.100+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 15:56:59.100+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_allow_onboot(582) > (ret == 1) metadata is empty.
09-10 15:56:59.100+0600 E/rpm-installer( 6711): coretpk-parser.c: __coretpk_parser_allow_autorestart(644) > (ret == 1) metadata is empty.
09-10 15:56:59.110+0600 E/PKGMGR_PARSER( 6711): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2682) > Manifest is Valid
09-10 15:56:59.110+0600 E/PKGMGR_PARSER( 6711): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-10 15:56:59.121+0600 E/PKGMGR_PARSER( 6711): pkgmgr_parser_db.c: __verify_label_cb(353) > package_label is PKGMGR_PARSER_EMPTY_STR
09-10 15:56:59.171+0600 I/PRIVACY-MANAGER-CLIENT( 6711): SocketClient.cpp: SocketClient(37) > Client created
09-10 15:56:59.441+0600 E/PKGMGR_PARSER( 6711): pkgmgr_parser.c: __check_theme(146) > theme for installation.
09-10 15:56:59.461+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-10 15:56:59.461+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 100
09-10 15:56:59.461+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 100
09-10 15:56:59.461+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 25 1
09-10 15:56:59.461+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 26 1
09-10 15:56:59.461+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 27 1
09-10 15:56:59.461+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 28 1
09-10 15:56:59.481+0600 E/PKGMGR_CERT( 6711): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
09-10 15:56:59.491+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 60
09-10 15:56:59.491+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [60]
09-10 15:56:59.491+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [60], install = [1]
09-10 15:56:59.491+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:59.491+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:59.491+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:59.501+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(154) > Enter
09-10 15:56:59.501+0600 I/SHAREDRULE_CLIENT(  592): SocketConnection.h: SocketConnection(47) > Created
09-10 15:56:59.501+0600 I/SHAREDRULE_SERVER(  589): SocketService.cpp: mainloop(234) > Got incoming connection
09-10 15:56:59.501+0600 I/SHAREDRULE_SERVER(  589): SocketConnection.h: SocketConnection(47) > Created
09-10 15:56:59.511+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(190) > return result : 0
09-10 15:56:59.511+0600 E/rpm-installer( 6711): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 15:56:59.541+0600 E/rpm-installer( 6711): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
09-10 15:56:59.551+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 100
09-10 15:56:59.551+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [100]
09-10 15:56:59.551+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [100], install = [1]
09-10 15:56:59.561+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:59.561+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:56:59.561+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:57:00.172+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-10 15:57:00.172+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-10 15:57:00.172+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-10 15:57:00.172+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: ok
09-10 15:57:00.172+0600 I/Tizen::App( 1366): (78) > Installation is Completed. [Package = org.example.bluetooth]
09-10 15:57:00.172+0600 I/Tizen::App( 1366): (671) > Enter. package(org.example.bluetooth), installationResult(0)
09-10 15:57:00.182+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:57:00.182+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:57:00.182+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 15:57:00.212+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-10 15:57:00.232+0600 I/Tizen::App( 1366): (1360) > package(org.example.bluetooth), version(1.0.0), type(tpk), displayName(Timer Messenger), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.bluetooth), storeClient(), appRootPath(/opt/usr/apps/org.example.bluetooth)
09-10 15:57:00.252+0600 I/Tizen::App( 1366): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.bluetooth]
09-10 15:57:00.262+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 15:57:00.262+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 15:57:00.262+0600 E/PKGMGR_INFO( 1366): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-10 15:57:00.262+0600 I/Tizen::App( 1366): (683) > Application count(1) in this package
09-10 15:57:00.262+0600 I/Tizen::App( 1366): (840) > Enter.
09-10 15:57:00.272+0600 I/Tizen::App( 1366): (703) > Exit.
09-10 15:57:00.272+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [ok], install = [1]
09-10 15:57:00.282+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 15:57:00.282+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 15:57:00.282+0600 I/Tizen::App( 1366): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.bluetooth.info]
09-10 15:57:00.282+0600 I/Tizen::App( 1366): (131) > Enter
09-10 15:57:00.282+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.bluetooth]
09-10 15:57:00.282+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.bluetooth]
09-10 15:57:00.282+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-10 15:57:00.282+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-10 15:57:00.282+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.bluetooth]
09-10 15:57:00.282+0600 I/Tizen::App( 1366): (137) > org.example.bluetooth does not have launch condition
09-10 15:57:00.282+0600 I/Tizen::App( 1366): (883) > Exit.
09-10 15:57:00.292+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[Timer Messenger] enable[1] system[0]
09-10 15:57:00.292+0600 E/HOME_APPS(  873): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.bluetooth] mdm is not enabled
09-10 15:57:00.292+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[Timer Messenger] enable[1] system[0]
09-10 15:57:00.302+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: UpdateBoxData(1330) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], New icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png]!!!!!
09-10 15:57:00.312+0600 E/util-view(  873): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=22 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-10 15:57:00.322+0600 E/rpm-installer( 6711): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 15:57:00.322+0600 E/rpm-installer( 6711): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 15:57:00.322+0600 E/rpm-installer( 6711): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 15:57:00.322+0600 E/PKGMGR_SERVER( 6708): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6711]
09-10 15:57:00.352+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], Loading state:[1]
09-10 15:57:00.352+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7737e90), gem(13), surface(0xb787e520)
09-10 15:57:01.373+0600 E/PKGMGR_SERVER( 6708): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 15:57:01.373+0600 E/PKGMGR_SERVER( 6708): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 15:57:06.067+0600 W/AUL     ( 6796): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.bluetooth)
09-10 15:57:06.067+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 15:57:06.077+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-10 15:57:06.077+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-10 15:57:06.077+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 15:57:06.077+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 6796
09-10 15:57:06.077+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 15:57:06.097+0600 E/RESOURCED(15587): block.c: block_prelaunch_state(138) > insert data org.example.bluetooth, table num : 1
09-10 15:57:06.097+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 15:57:06.097+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 15:57:06.097+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 15:57:06.097+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.bluetooth has already loaded
09-10 15:57:06.097+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 15:57:06.097+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 15:57:06.097+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 15:57:06.097+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 15:57:06.117+0600 I/CAPI_APPFW_APPLICATION( 6340): app_main.c: ui_app_main(789) > app_efl_main
09-10 15:57:06.117+0600 I/CAPI_APPFW_APPLICATION( 6340): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 15:57:06.147+0600 E/TBM     ( 6340): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 15:57:06.197+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 6340, appid: org.example.bluetooth
09-10 15:57:06.197+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 15:57:06.207+0600 W/AUL     ( 6796): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6340)
09-10 15:57:06.217+0600 E/CAPI_NETWORK_WIFI( 6340): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 15:57:06.247+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 15:57:06.448+0600 I/CAPI_NETWORK_WIFI( 6340): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 15:57:06.448+0600 D/bluetooth( 6340): [wifi_initialize] Success.
09-10 15:57:06.648+0600 I/APP_CORE( 6340): appcore-efl.c: __do_app(520) > [APP 6340] Event: RESET State: CREATED
09-10 15:57:06.648+0600 I/CAPI_APPFW_APPLICATION( 6340): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 15:57:06.648+0600 E/EFL     ( 6340): edje<6340> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:57:06.648+0600 E/EFL     ( 6340): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:57:06.658+0600 E/EFL     ( 6340): edje<6340> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:57:06.658+0600 E/EFL     ( 6340): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:57:06.668+0600 E/EFL     ( 6340): edje<6340> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:57:06.668+0600 E/EFL     ( 6340): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:57:06.748+0600 W/APP_CORE( 6340): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200002
09-10 15:57:06.758+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 15:57:06.838+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7707360), gem(18), surface(0xb78ba300)
09-10 15:57:06.848+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb768eb50), gem(21), surface(0xb78925e8)
09-10 15:57:06.848+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7707360), gem(18), surface(0xb7867b40)
09-10 15:57:06.858+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7798ce8), gem(15), surface(0xb78be958)
09-10 15:57:06.868+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 15:57:06.868+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 15:57:06.868+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 15:57:06.868+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(6340) status(4)
09-10 15:57:06.908+0600 I/APP_CORE( 6340): appcore-efl.c: __do_app(520) > [APP 6340] Event: PAUSE State: CREATED
09-10 15:57:06.908+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 6340): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 15:57:06.908+0600 E/APP_CORE( 6340): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 15:57:06.908+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:57:06.918+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7805ab0), gem(10), surface(0xb787e520)
09-10 15:57:07.068+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb776de68), gem(22), surface(0xb7867b40)
09-10 15:57:07.198+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:57:07.198+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 15:57:07.218+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb776de68), gem(22), surface(0xb787e520)
09-10 15:57:07.238+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 15:57:07.238+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 6340.
09-10 15:57:07.248+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1875
09-10 15:57:07.258+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(6340) status(0)
09-10 15:57:07.258+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:57:07.629+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7707360), gem(10), surface(0xb78ba300)
09-10 15:57:08.099+0600 I/UXT     ( 6808): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 15:57:11.202+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(6340)
09-10 15:57:11.202+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 6340, appid: org.example.bluetooth, status: bg
09-10 15:57:33.424+0600 E/PKGMGR_SERVER( 6930): pkgmgr-server.c: main(2414) > package manager server start
09-10 15:57:33.484+0600 E/PKGMGR  ( 6928): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 15:57:33.534+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:57:33.534+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 6340
09-10 15:57:33.534+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:57:33.534+0600 W/AUL     ( 6934): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6340)
09-10 15:57:33.534+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 15:57:33.534+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(6340), cmd(4)
09-10 15:57:33.534+0600 I/APP_CORE( 6340): appcore-efl.c: __do_app(520) > [APP 6340] Event: TERMINATE State: CREATED
09-10 15:57:33.534+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:57:33.534+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:57:33.544+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:57:33.544+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:57:33.544+0600 W/AUL     ( 6934): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 15:57:33.544+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:57:33.544+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 15:57:33.544+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 6340): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 15:57:33.544+0600 E/APP_CORE( 6340): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 15:57:33.544+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:57:33.544+0600 E/APP_CORE( 6340): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 15:57:33.544+0600 I/CAPI_APPFW_APPLICATION( 6340): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:57:33.544+0600 E/CAPI_NETWORK_BLUETOOTH( 6340): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 15:57:33.554+0600 E/PKGMGR_SERVER( 6930): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6934]
09-10 15:57:33.614+0600 E/CAPI_NETWORK_BLUETOOTH( 6340): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 15:57:33.614+0600 E/CAPI_NETWORK_BLUETOOTH( 6340): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 15:57:33.614+0600 E/bluetooth( 6340): [bt_adapter_le_destroy_advertiser] Failed.
09-10 15:57:33.614+0600 I/CAPI_NETWORK_WIFI( 6340): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 15:57:33.614+0600 E/bluetooth( 6340): [wifi_deinitialize] Success.
09-10 15:57:33.624+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76accf0), gem(13), surface(0xb78a2d70)
09-10 15:57:33.634+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 15:57:33.634+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:57:33.634+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:57:33.634+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 15:57:33.634+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 15:57:33.644+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78306d8), gem(21), surface(0xb772ea48)
09-10 15:57:33.644+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:57:33.654+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(22), surface(0xb78bf950)
09-10 15:57:33.654+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7798ce8), gem(15), surface(0xb786c878)
09-10 15:57:33.694+0600 E/EFL     ( 6340): elementary<6340> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 15:57:33.704+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76accf0), gem(13), surface(0xb787e520)
09-10 15:57:33.844+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6340 pgid = 6340
09-10 15:57:33.844+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(6340)
09-10 15:57:33.924+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:57:33.924+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:57:33.924+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:57:33.924+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[6340] terminate event is forwarded
09-10 15:57:33.924+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:57:33.924+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 6340, ]
09-10 15:57:33.924+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:57:33.924+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 15:57:33.924+0600 I/Tizen::App( 1366): (512) > Not registered pid(6340)
09-10 15:57:33.924+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 15:57:33.924+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:57:33.934+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 6340
09-10 15:57:33.934+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6340
09-10 15:57:33.944+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1880
09-10 15:57:33.964+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:57:33.964+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 6340.
09-10 15:57:34.015+0600 W/CRASH_MANAGER( 6940): worker.c: worker_job(1199) > 1106340626162147350145
