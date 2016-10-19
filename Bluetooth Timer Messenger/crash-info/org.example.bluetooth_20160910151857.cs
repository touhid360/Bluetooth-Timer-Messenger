S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 27891
Date: 2016-09-10 15:18:57+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 27891, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb818e438
r2   = 0xb4398000, r3   = 0xb4398000
r4   = 0xb8156c38, r5   = 0xbe91d5bc
r6   = 0xb6a96310, r7   = 0xbe91d41c
r8   = 0xb6a970f4, r9   = 0xb6a970f4
r10  = 0xb6aa520c, fp   = 0x00000000
ip   = 0xb2a8b654, sp   = 0xbe91b770
lr   = 0xb2a7fcc3, pc   = 0xb677a6f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     65000 KB
Buffers:     41172 KB
Cached:     284960 KB
VmPeak:     106888 KB
VmSize:     103664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25776 KB
VmRSS:       25776 KB
VmData:      35244 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36232 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 27891 TID = 27891
27891 27893 27927 

Maps Information
b1dd4000 b25d3000 rw-p [stack:27927]
b25d3000 b25e4000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25f4000 b25f9000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2685000 b268d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b269e000 b269f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b26af000 b26c3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26d7000 b26d8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26e8000 b26eb000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26fc000 b26fd000 r-xp /usr/lib/libxshmfence.so.1.0.0
b270d000 b270f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b271f000 b2721000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2731000 b2741000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2751000 b275d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b296e000 b2985000 r-xp /usr/lib/libnetwork.so.0.0.0
b2996000 b29d4000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29e5000 b29ec000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29fd000 b2a0c000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a1c000 b2a51000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a64000 b2a6a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a7a000 b2a84000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ba5000 b2c88000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2cbf000 b2ce7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cf9000 b34f8000 rw-p [stack:27893]
b34f8000 b34fa000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b350a000 b3514000 r-xp /lib/libnss_files-2.20-2014.11.so
b3525000 b352e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b353f000 b3550000 r-xp /lib/libnsl-2.20-2014.11.so
b3563000 b3569000 r-xp /lib/libnss_compat-2.20-2014.11.so
b357a000 b357b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b35a3000 b35aa000 r-xp /usr/lib/libminizip.so.1.0.0
b35ba000 b35bf000 r-xp /usr/lib/libstorage.so.0.1
b35cf000 b3624000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b363a000 b364e000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b365e000 b36a2000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b36b2000 b36ba000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36ca000 b36fa000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b370d000 b37c6000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37da000 b382e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b383f000 b385a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b386a000 b392b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b393e000 b3950000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3960000 b3964000 r-xp /usr/lib/libogg.so.0.7.1
b3974000 b3996000 r-xp /usr/lib/libvorbis.so.0.4.3
b39a6000 b3a8a000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3aa6000 b3ab3000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3ac4000 b3b07000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b1c000 b3b63000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b74000 b3b7a000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b8b000 b3b92000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ba2000 b3be2000 r-xp /usr/lib/libmdm.so.1.2.10
b3bf2000 b3bfa000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3c09000 b3c19000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c3a000 b3c9a000 r-xp /usr/lib/libasound.so.2.0.0
b3cac000 b3ce2000 r-xp /usr/lib/libpulse.so.0.16.2
b3cf3000 b3cf6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3d06000 b3d09000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d19000 b3d1e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d2e000 b3d2f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d3f000 b3d4a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d5e000 b3d65000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d75000 b3d7b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d8b000 b3d90000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3da0000 b3dbb000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3dcb000 b3dd2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3de2000 b3de5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3df6000 b3e24000 r-xp /usr/lib/libidn.so.11.5.44
b3e34000 b3e4a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e5b000 b3e65000 r-xp /usr/lib/libcares.so.2.1.0
b3e75000 b3e7f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e8f000 b3e91000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3ea1000 b3ea2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3eb2000 b3eb6000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3ec7000 b3eef000 r-xp /usr/lib/libui-extension.so.0.1.0
b3f00000 b3f29000 r-xp /usr/lib/libturbojpeg.so
b3f49000 b3f4f000 r-xp /usr/lib/libgif.so.4.1.6
b3f5f000 b3fa5000 r-xp /usr/lib/libcurl.so.4.3.0
b3fb6000 b3fd7000 r-xp /usr/lib/libexif.so.12.3.3
b3ff2000 b4007000 r-xp /usr/lib/libtts.so
b4018000 b4020000 r-xp /usr/lib/libfeedback.so.0.1.4
b4030000 b40f0000 r-xp /usr/lib/libdali-core.so.0.0.0
b40fb000 b41ee000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b420e000 b42e8000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42ff000 b4301000 r-xp /usr/lib/libboost_system.so.1.51.0
b4311000 b4317000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4327000 b434a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b435b000 b435d000 r-xp /usr/lib/libappsvc.so.0.1.0
b436d000 b436f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4380000 b4385000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b439c000 b439e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b43ae000 b43b5000 r-xp /usr/lib/libsensord-share.so
b43c5000 b43dd000 r-xp /usr/lib/libsensor.so.1.1.0
b43ee000 b43f1000 r-xp /usr/lib/libXv.so.1.0.0
b4401000 b4406000 r-xp /usr/lib/libutilX.so.1.1.0
b4416000 b441b000 r-xp /usr/lib/libappcore-common.so.1.1
b442b000 b4432000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4445000 b4449000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b445a000 b4524000 r-xp /usr/lib/libCOREGL.so.4.0
b453b000 b453e000 r-xp /usr/lib/libuuid.so.1.3.0
b454f000 b4566000 r-xp /usr/lib/libblkid.so.1.1.0
b4577000 b4579000 r-xp /usr/lib/libXau.so.6.0.0
b4589000 b458c000 r-xp /usr/lib/libEGL.so.1.4
b4594000 b459a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b45aa000 b45ac000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45bd000 b45cb000 r-xp /usr/lib/libGLESv2.so.2.0
b45d4000 b4636000 r-xp /usr/lib/libpixman-1.so.0.28.2
b464b000 b4663000 r-xp /usr/lib/libmount.so.1.1.0
b4674000 b4688000 r-xp /usr/lib/libxcb.so.1.1.0
b4699000 b46a0000 r-xp /lib/libcrypt-2.20-2014.11.so
b46d8000 b46e9000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46fa000 b46fc000 r-xp /usr/lib/libiri.so
b470c000 b4717000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4728000 b473d000 r-xp /lib/libexpat.so.1.5.2
b474f000 b480d000 r-xp /usr/lib/libcairo.so.2.11200.14
b4820000 b4828000 r-xp /usr/lib/libdrm.so.2.4.0
b4838000 b483b000 r-xp /usr/lib/libdri2.so.0.0.0
b484c000 b489a000 r-xp /usr/lib/libssl.so.1.0.0
b48af000 b48bb000 r-xp /usr/lib/libeeze.so.1.13.0
b48cb000 b48d4000 r-xp /usr/lib/libethumb.so.1.13.0
b48e4000 b48e7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48f7000 b4aae000 r-xp /usr/lib/libcrypto.so.1.0.0
b5705000 b570e000 r-xp /usr/lib/libXi.so.6.1.0
b571e000 b5720000 r-xp /usr/lib/libXgesture.so.7.0.0
b5730000 b5734000 r-xp /usr/lib/libXtst.so.6.1.0
b5744000 b574a000 r-xp /usr/lib/libXrender.so.1.3.0
b575a000 b5760000 r-xp /usr/lib/libXrandr.so.2.2.0
b5771000 b5773000 r-xp /usr/lib/libXinerama.so.1.0.0
b5783000 b5786000 r-xp /usr/lib/libXfixes.so.3.1.0
b5796000 b57a1000 r-xp /usr/lib/libXext.so.6.4.0
b57b1000 b57b3000 r-xp /usr/lib/libXdamage.so.1.1.0
b57c3000 b57c5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57d6000 b58b8000 r-xp /usr/lib/libX11.so.6.3.0
b58cb000 b58d2000 r-xp /usr/lib/libXcursor.so.1.0.2
b58e2000 b58fa000 r-xp /usr/lib/libudev.so.1.6.0
b58fc000 b58ff000 r-xp /lib/libattr.so.1.1.0
b590f000 b592f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5931000 b5936000 r-xp /usr/lib/libffi.so.6.0.2
b5946000 b595e000 r-xp /lib/libz.so.1.2.8
b596e000 b5970000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5980000 b5a55000 r-xp /usr/lib/libxml2.so.2.9.2
b5a6a000 b5b05000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b21000 b5b24000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b34000 b5b4d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b5e000 b5b6f000 r-xp /lib/libresolv-2.20-2014.11.so
b5b83000 b5bfd000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5c12000 b5c14000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c24000 b5c2b000 r-xp /usr/lib/libembryo.so.1.13.0
b5c3b000 b5c53000 r-xp /usr/lib/libpng12.so.0.50.0
b5c64000 b5c87000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ca8000 b5cbc000 r-xp /usr/lib/libector.so.1.13.0
b5ccd000 b5ce5000 r-xp /usr/lib/liblua-5.1.so
b5cf6000 b5d4d000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d61000 b5d89000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d9a000 b5dad000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dbe000 b5df5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e06000 b5e14000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e24000 b5e2c000 r-xp /usr/lib/libtbm.so.1.0.0
b5e3c000 b5e49000 r-xp /usr/lib/libeio.so.1.13.0
b5e59000 b5e5b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e6b000 b5e70000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e80000 b5e97000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea9000 b5ec9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed9000 b5ef9000 r-xp /usr/lib/libecore_con.so.1.13.0
b5efb000 b5f01000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f11000 b5f22000 r-xp /usr/lib/libemotion.so.1.13.0
b5f33000 b5f3a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f4a000 b5f59000 r-xp /usr/lib/libeo.so.1.13.0
b5f6a000 b5f7c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f8d000 b5f92000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fa2000 b5fbb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fcb000 b5fe8000 r-xp /usr/lib/libeet.so.1.13.0
b6001000 b6049000 r-xp /usr/lib/libeina.so.1.13.0
b605a000 b606a000 r-xp /usr/lib/libefl.so.1.13.0
b607b000 b6160000 r-xp /usr/lib/libicuuc.so.51.1
b617d000 b62bd000 r-xp /usr/lib/libicui18n.so.51.1
b62d4000 b630c000 r-xp /usr/lib/libecore_x.so.1.13.0
b631e000 b6321000 r-xp /lib/libcap.so.2.21
b6331000 b635a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b636b000 b6372000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6384000 b63bb000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63cc000 b64b7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64ca000 b6543000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6555000 b655a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b656a000 b6574000 r-xp /usr/lib/libvconf.so.0.2.45
b6584000 b6586000 r-xp /usr/lib/libvasum.so.0.3.1
b6596000 b6598000 r-xp /usr/lib/libttrace.so.1.1
b65a8000 b65ab000 r-xp /usr/lib/libiniparser.so.0
b65bb000 b65e1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65f1000 b65f6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6607000 b661e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b662f000 b669a000 r-xp /lib/libm-2.20-2014.11.so
b66ab000 b66b1000 r-xp /lib/librt-2.20-2014.11.so
b66c2000 b66cf000 r-xp /usr/lib/libunwind.so.8.0.1
b6705000 b6829000 r-xp /lib/libc-2.20-2014.11.so
b683e000 b6857000 r-xp /lib/libgcc_s-4.9.so.1
b6867000 b6949000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b695a000 b6984000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6995000 b69d1000 r-xp /usr/lib/libsystemd.so.0.4.0
b69d3000 b6a55000 r-xp /usr/lib/libedje.so.1.13.0
b6a68000 b6a86000 r-xp /usr/lib/libecore.so.1.13.0
b6aa6000 b6c2d000 r-xp /usr/lib/libevas.so.1.13.0
b6c62000 b6c76000 r-xp /lib/libpthread-2.20-2014.11.so
b6c8a000 b6ebf000 r-xp /usr/lib/libelementary.so.1.13.0
b6eed000 b6ef1000 r-xp /usr/lib/libsmack.so.1.0.0
b6f01000 b6f08000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f18000 b6f1a000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2a000 b6f2d000 r-xp /usr/lib/libbundle.so.0.1.22
b6f3d000 b6f3f000 r-xp /lib/libdl-2.20-2014.11.so
b6f50000 b6f68000 r-xp /usr/lib/libaul.so.0.1.0
b6f7c000 b6f81000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f92000 b6f9f000 r-xp /usr/lib/liblptcp.so
b6fb1000 b6fb5000 r-xp /usr/lib/libsys-assert.so
b6fc6000 b6fe6000 r-xp /lib/ld-2.20-2014.11.so
b6ff7000 b6ffc000 r-xp /usr/bin/launchpad-loader
b8115000 b84ca000 rw-p [heap]
be8fd000 be91e000 rw-p [stack]
b8115000 b84ca000 rw-p [heap]
be8fd000 be91e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27891)
Call Stack Count: 1
 0: (0xb677a6f0) [/lib/libc.so.6] + 0x756f0
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
F   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:18:41.589+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:18:41.589+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:18:41.589+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:18:41.589+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:18:41.589+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:18:41.589+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 15:18:41.599+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 15:18:41.830+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10568849
09-10 15:18:41.830+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10568849
09-10 15:18:41.910+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10568933
09-10 15:18:41.910+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:41.910+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:41.920+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:41.920+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:41.920+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 15:18:41.960+0600 I/ISE_MULTI(  821): isemain.cpp: slot_set_caps_mode(792) > [0;36m[hidden state:false] mode=0[0m
09-10 15:18:41.960+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=1[0m
09-10 15:18:42.570+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10569593
09-10 15:18:42.570+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10569593
09-10 15:18:42.641+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10569665
09-10 15:18:42.651+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:42.651+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:42.651+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:42.651+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:42.661+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=2[0m
09-10 15:18:43.962+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10570982
09-10 15:18:43.962+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10570982
09-10 15:18:44.032+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10571053
09-10 15:18:44.032+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:44.032+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:44.032+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:44.032+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 15:18:44.042+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:44.042+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:44.042+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=3[0m
09-10 15:18:44.042+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:44.042+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:44.432+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10571453
09-10 15:18:44.432+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10571453
09-10 15:18:44.512+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10571537
09-10 15:18:44.522+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:44.522+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:44.522+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:44.522+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=4[0m
09-10 15:18:44.522+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:45.023+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:18:45.023+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10572047
09-10 15:18:45.033+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10572047
09-10 15:18:45.083+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:18:45.093+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10572118
09-10 15:18:45.103+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:45.103+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:45.103+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:45.103+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=5[0m
09-10 15:18:45.103+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:45.844+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10572865
09-10 15:18:45.844+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10572865
09-10 15:18:45.914+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10572936
09-10 15:18:45.924+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:45.924+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:45.924+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 15:18:45.924+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:45.924+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:45.924+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:45.924+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:45.924+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:45.934+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=6[0m
09-10 15:18:46.634+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10573649
09-10 15:18:46.634+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10573649
09-10 15:18:46.714+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10573732
09-10 15:18:46.714+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:46.714+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:46.714+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:46.714+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 15:18:46.724+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:47.435+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10574456
09-10 15:18:47.435+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10574456
09-10 15:18:47.475+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10574508
09-10 15:18:47.485+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 15:18:47.485+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 15:18:47.485+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 15:18:47.485+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 15:18:47.485+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 15:18:47.846+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10574843
09-10 15:18:47.846+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10574874
09-10 15:18:47.846+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:18:47.846+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 15:18:47.866+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6000002 FAILED!
09-10 15:18:47.916+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 15:18:47.916+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb774d4b8), gem(13), surface(0xb7833af8)
09-10 15:18:47.926+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77fc768), gem(10), surface(0xb78ba300)
09-10 15:18:48.636+0600 E/EFL     (27891): eo<27891> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb8156c38 is not pointing to a valid object. Maybe it has already been freed.
09-10 15:18:48.636+0600 E/EFL     (27891): eo<27891> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb8156c38) is an invalid ref.
09-10 15:18:48.696+0600 D/bluetooth(27891): [bt_socket_connect_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
09-10 15:18:52.800+0600 D/bluetooth(27891): Callback: Socket of connection - 49.
09-10 15:18:52.800+0600 D/bluetooth(27891): Callback: Role of connection - 2.
09-10 15:18:52.800+0600 D/bluetooth(27891): Callback: Address of connection - 90:00:DB:03:35:2E.
09-10 15:18:52.830+0600 D/bluetooth(27891): Socket fd: 49
09-10 15:18:52.830+0600 D/bluetooth(27891): Data: 
09-10 15:18:52.830+0600 D/bluetooth(27891): Size: 30
09-10 15:18:54.752+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10581777
09-10 15:18:54.772+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10581794
09-10 15:18:54.782+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:18:54.782+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 15:18:54.782+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:18:54.782+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 15:18:55.123+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10582143
09-10 15:18:55.193+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10582216
09-10 15:18:55.293+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10582313
09-10 15:18:55.363+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10582386
09-10 15:18:55.513+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10582530
09-10 15:18:55.583+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10582603
09-10 15:18:55.793+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10582809
09-10 15:18:55.793+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 15:18:55.793+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 15:18:55.793+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:18:55.793+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=10582809
09-10 15:18:56.094+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 15:18:56.094+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 15:18:56.094+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 15:18:56.094+0600 E/STARTER (  763): )
09-10 15:18:56.094+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 15:18:56.094+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:18:56.094+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:18:56.104+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 15:18:56.104+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 15:18:56.114+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 15:18:56.114+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 15:18:56.114+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 15:18:56.114+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 15:18:56.124+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 15:18:56.124+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 15:18:56.124+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 15:18:56.124+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 15:18:56.124+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 15:18:56.124+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 15:18:56.124+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 15:18:56.124+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 15:18:56.144+0600 E/CAPI_APPFW_APPLICATION(27942): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:18:56.144+0600 E/CAPI_APPFW_APPLICATION(27942): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:18:56.144+0600 E/CAPI_APPFW_APPLICATION(27942): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:18:56.144+0600 E/CAPI_APPFW_APPLICATION(27942): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:18:56.144+0600 E/CAPI_APPFW_APPLICATION(27942): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 15:18:56.144+0600 I/CAPI_APPFW_APPLICATION(27942): app_main.c: ui_app_main(789) > app_efl_main
09-10 15:18:56.144+0600 I/CAPI_APPFW_APPLICATION(27942): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 15:18:56.164+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785af58), gem(13), surface(0xb7808968)
09-10 15:18:56.164+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785af58), gem(13), surface(0xb7833af8)
09-10 15:18:56.164+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 15:18:56.174+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 15:18:56.174+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 15:18:56.214+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78448e8), gem(22), surface(0xb7891878)
09-10 15:18:56.224+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 27942, appid: com.samsung.task-mgr
09-10 15:18:56.224+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 15:18:56.234+0600 W/TASK_MGR_LITE(27942): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 15:18:56.234+0600 I/GXT_SIB (27942): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 15:18:56.244+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(27942)
09-10 15:18:56.244+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:18:56.304+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 15:18:56.304+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:18:56.314+0600 E/RUA     (27942): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 19, ncols : 5
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 15:18:56.314+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:18:56.314+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 27891
09-10 15:18:56.314+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:18:56.314+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:18:56.314+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 15:18:56.314+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 15:18:56.374+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 15:18:56.374+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:18:56.384+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:18:56.394+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 15:18:56.394+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:18:56.394+0600 I/APP_CORE(27942): appcore-efl.c: __do_app(520) > [APP 27942] Event: RESET State: CREATED
09-10 15:18:56.394+0600 I/CAPI_APPFW_APPLICATION(27942): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 15:18:56.394+0600 I/TIZEN_N_SOUND_MANAGER(24881): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 15:18:56.394+0600 E/TIZEN_N_SOUND_MANAGER(24881): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 15:18:56.394+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:18:56.404+0600 E/EFL     (27942): edje<27942> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:18:56.404+0600 E/EFL     (27942): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:18:56.404+0600 E/EFL     (27942): edje<27942> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:18:56.404+0600 E/EFL     (27942): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:18:56.414+0600 W/APP_CORE(27942): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200003
09-10 15:18:56.414+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 15:18:56.484+0600 I/MALI    (27942): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb7a86e70)
09-10 15:18:56.494+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7775320), gem(26), surface(0xb78ba300)
09-10 15:18:56.504+0600 I/MALI    (27942): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:18:56.504+0600 I/APP_CORE(27891): appcore-efl.c: __do_app(520) > [APP 27891] Event: PAUSE State: RUNNING
09-10 15:18:56.504+0600 I/CAPI_APPFW_APPLICATION(27891): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:18:56.504+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(27891) status(4)
09-10 15:18:56.504+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(27891)
09-10 15:18:56.504+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27891, appid: org.example.bluetooth, status: bg
09-10 15:18:56.504+0600 I/TIZEN_N_EFL_UTIL_WINDOW(27891): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 15:18:56.504+0600 E/APP_CORE(27891): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 15:18:56.504+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:18:56.514+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(27942) status(3)
09-10 15:18:56.514+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:18:56.514+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:18:56.514+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(27942)
09-10 15:18:56.514+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27942, appid: com.samsung.task-mgr, status: fg
09-10 15:18:56.524+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:18:56.524+0600 I/APP_CORE(27942): appcore-efl.c: __do_app(520) > [APP 27942] Event: RESUME State: CREATED
09-10 15:18:56.534+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(27942) status(0)
09-10 15:18:56.534+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:18:56.534+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10583536
09-10 15:18:56.534+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 15:18:56.534+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 15:18:56.534+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 15:18:56.534+0600 E/STARTER (  763): )
09-10 15:18:56.534+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7703b00), gem(24), surface(0xb78925e8)
09-10 15:18:56.534+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 15:18:56.544+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 15:18:56.544+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:18:56.544+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:18:56.554+0600 I/APP_CORE(27942): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 15:18:56.554+0600 I/APP_CORE(27942): appcore-efl.c: __do_app(637) > [APP 27942] Initial Launching, call the resume_cb
09-10 15:18:56.554+0600 I/CAPI_APPFW_APPLICATION(27942): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 15:18:56.634+0600 E/EFL     (27891): ecore_x<27891> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=10583536
09-10 15:18:57.145+0600 E/EFL     (27942): ecore_x<27942> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=10584158
09-10 15:18:57.215+0600 E/EFL     (27942): ecore_x<27942> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=10584231
09-10 15:18:57.215+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:18:57.215+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 27891
09-10 15:18:57.215+0600 W/AUL     (27942): launch.c: app_request_to_launchpad(396) > request cmd(4) to(27891)
09-10 15:18:57.215+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 15:18:57.225+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(27891), cmd(4)
09-10 15:18:57.225+0600 W/AUL     (27942): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 15:18:57.225+0600 I/APP_CORE(27891): appcore-efl.c: __do_app(520) > [APP 27891] Event: TERMINATE State: PAUSED
09-10 15:18:57.225+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:18:57.225+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:18:57.225+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:18:57.225+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:18:57.225+0600 I/TIZEN_N_EFL_UTIL_WINDOW(27891): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 15:18:57.225+0600 E/APP_CORE(27891): appcore-efl.c: _capture_and_make_file(1631) > win[6000002] widget[480] height[800]
09-10 15:18:57.235+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:18:57.235+0600 E/APP_CORE(27891): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 15:18:57.235+0600 I/CAPI_APPFW_APPLICATION(27891): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:18:57.235+0600 E/CAPI_NETWORK_BLUETOOTH(27891): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 15:18:57.255+0600 I/MALI    (27942): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:18:57.275+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 15:18:57.275+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 27942.
09-10 15:18:57.285+0600 I/MALI    (27942): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:18:57.295+0600 I/MALI    (27942): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:18:57.305+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1489
09-10 15:18:57.505+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:18:57.505+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:18:57.505+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(27942)
09-10 15:18:57.505+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27942, appid: com.samsung.task-mgr, status: bg
09-10 15:18:57.505+0600 I/CAPI_APPFW_APPLICATION(27942): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:18:57.505+0600 W/TASK_MGR_LITE(27942): task-mgr-lite.c: _pause_app(406) > 
09-10 15:18:57.505+0600 I/CAPI_APPFW_APPLICATION(27942): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:18:57.515+0600 E/CAPI_NETWORK_BLUETOOTH(27891): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 15:18:57.515+0600 E/CAPI_NETWORK_BLUETOOTH(27891): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 15:18:57.515+0600 E/bluetooth(27891): [bt_adapter_le_destroy_advertiser] Failed.
09-10 15:18:57.525+0600 I/CAPI_NETWORK_WIFI(27891): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 15:18:57.525+0600 E/bluetooth(27891): [wifi_deinitialize] Success.
09-10 15:18:57.525+0600 E/TASK_MGR_LITE(27942): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 15:18:57.545+0600 E/APP_CORE(27942): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 15:18:57.555+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:18:57.565+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 15:18:57.565+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:18:57.565+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:18:57.565+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 15:18:57.565+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 15:18:57.575+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:18:57.585+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7805ab0), gem(13), surface(0xb7833af8)
09-10 15:18:57.595+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:18:57.605+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7805ab0), gem(13), surface(0xb7891878)
09-10 15:18:57.645+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7703b00), gem(26), surface(0xb7808968)
09-10 15:18:57.645+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7703b00), gem(26), surface(0xb78925e8)
09-10 15:18:57.655+0600 E/EFL     (27891): elementary<27891> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 15:18:57.675+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:18:57.675+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 15:18:57.675+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 15:18:57.675+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 15:18:57.695+0600 I/MALI    (27942): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 15:18:57.695+0600 I/MALI    (27942): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=27942   close drm_fd=28 
09-10 15:18:57.695+0600 I/MALI    (27942): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 15:18:57.695+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:18:57.715+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 15:18:57.715+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb785af58), gem(18), surface(0xb7808968)
09-10 15:18:57.725+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 15:18:57.785+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 15:18:57.785+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 15:18:57.805+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 15:18:57.815+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8300ad8]
09-10 15:18:57.815+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 15:18:57.815+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 15:18:57.815+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 15:18:57.815+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8300ad8
09-10 15:18:57.815+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 15:18:57.815+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-10 15:18:57.815+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-10 15:18:57.815+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 15:18:57.815+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 15:18:57.815+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 15:18:58.005+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76accf0), gem(18), surface(0xb77b7b98)
09-10 15:18:58.076+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:18:58.086+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 27942 pgid = 27942
09-10 15:18:58.086+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(27942)
09-10 15:18:58.086+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:18:58.126+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:18:58.126+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:18:58.126+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:18:58.136+0600 I/Tizen::App( 1366): (243) > App[com.samsung.task-mgr] pid[27942] terminate event is forwarded
09-10 15:18:58.136+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:18:58.136+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.task-mgr, 27942, ]
09-10 15:18:58.136+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:18:58.136+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.task-mgr)
09-10 15:18:58.136+0600 I/Tizen::App( 1366): (512) > Not registered pid(27942)
09-10 15:18:58.136+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.task-mgr]
09-10 15:18:58.136+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:18:58.136+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 27942
09-10 15:18:58.136+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 27942
09-10 15:18:58.136+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 27942
09-10 15:18:58.156+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:18:58.166+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:18:58.166+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.task-mgr, 27942.
09-10 15:18:58.226+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 27891 pgid = 27891
09-10 15:18:58.226+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(27891)
09-10 15:18:58.306+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:18:58.306+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:18:58.306+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:18:58.306+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[27891] terminate event is forwarded
09-10 15:18:58.306+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:18:58.306+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 27891, ]
09-10 15:18:58.306+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:18:58.306+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 15:18:58.306+0600 I/Tizen::App( 1366): (512) > Not registered pid(27891)
09-10 15:18:58.306+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 15:18:58.306+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:18:58.316+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 27891
09-10 15:18:58.316+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 27891
09-10 15:18:58.326+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:18:58.336+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:18:58.336+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 27891.
09-10 15:18:58.376+0600 W/CRASH_MANAGER(28275): worker.c: worker_job(1199) > 1127891626162147349913
