S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 22492
Date: 2016-09-10 16:50:07+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 22492, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb8cc8b58
r2   = 0xb42b5000, r3   = 0xb42b5000
r4   = 0xbedb85bc, r5   = 0xb69b40f4
r6   = 0xb69b3310, r7   = 0xbedb841c
r8   = 0xb69b40f4, r9   = 0xb69b40f4
r10  = 0xb69c220c, fp   = 0x00000000
ip   = 0xb29a833c, sp   = 0xbedb7798
lr   = 0xb299d867, pc   = 0xb66976f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     47348 KB
Buffers:     43416 KB
Cached:     291608 KB
VmPeak:     114900 KB
VmSize:     112368 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25024 KB
VmRSS:       25024 KB
VmData:      43956 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 22492 TID = 22492
22492 22525 22701 22702 22705 

Maps Information
b0901000 b1100000 rw-p [stack:22705]
b1301000 b1b00000 rw-p [stack:22702]
b1cf3000 b24f2000 rw-p [stack:22701]
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
b2ac2000 b2ba5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bdc000 b2c04000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c16000 b3415000 rw-p [stack:22525]
b3415000 b3417000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3427000 b3431000 r-xp /lib/libnss_files-2.20-2014.11.so
b3442000 b344b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b345c000 b346d000 r-xp /lib/libnsl-2.20-2014.11.so
b3480000 b3486000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3497000 b3498000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34c0000 b34c7000 r-xp /usr/lib/libminizip.so.1.0.0
b34d7000 b34dc000 r-xp /usr/lib/libstorage.so.0.1
b34ec000 b3541000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3557000 b356b000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b357b000 b35bf000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35cf000 b35d7000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35e7000 b3617000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b362a000 b36e3000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b36f7000 b374b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b375c000 b3777000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3787000 b3848000 r-xp /usr/lib/libprotobuf.so.9.0.1
b385b000 b386d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b387d000 b3881000 r-xp /usr/lib/libogg.so.0.7.1
b3891000 b38b3000 r-xp /usr/lib/libvorbis.so.0.4.3
b38c3000 b39a7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39c3000 b39d0000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39e1000 b3a24000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a39000 b3a80000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a91000 b3a97000 r-xp /usr/lib/libjson-c.so.2.0.1
b3aa8000 b3aaf000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3abf000 b3aff000 r-xp /usr/lib/libmdm.so.1.2.10
b3b0f000 b3b17000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b26000 b3b36000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b57000 b3bb7000 r-xp /usr/lib/libasound.so.2.0.0
b3bc9000 b3bff000 r-xp /usr/lib/libpulse.so.0.16.2
b3c10000 b3c13000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c23000 b3c26000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c36000 b3c3b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c4b000 b3c4c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c5c000 b3c67000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c7b000 b3c82000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c92000 b3c98000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3ca8000 b3cad000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cbd000 b3cd8000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3ce8000 b3cef000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3cff000 b3d02000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d13000 b3d41000 r-xp /usr/lib/libidn.so.11.5.44
b3d51000 b3d67000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d78000 b3d82000 r-xp /usr/lib/libcares.so.2.1.0
b3d92000 b3d9c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dac000 b3dae000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dbe000 b3dbf000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3dcf000 b3dd3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3de4000 b3e0c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e1d000 b3e46000 r-xp /usr/lib/libturbojpeg.so
b3e66000 b3e6c000 r-xp /usr/lib/libgif.so.4.1.6
b3e7c000 b3ec2000 r-xp /usr/lib/libcurl.so.4.3.0
b3ed3000 b3ef4000 r-xp /usr/lib/libexif.so.12.3.3
b3f0f000 b3f24000 r-xp /usr/lib/libtts.so
b3f35000 b3f3d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f4d000 b400d000 r-xp /usr/lib/libdali-core.so.0.0.0
b4018000 b410b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b412b000 b4205000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b421c000 b421e000 r-xp /usr/lib/libboost_system.so.1.51.0
b422e000 b4234000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4244000 b4267000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4278000 b427a000 r-xp /usr/lib/libappsvc.so.0.1.0
b428a000 b428c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b429d000 b42a2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b9000 b42bb000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42cb000 b42d2000 r-xp /usr/lib/libsensord-share.so
b42e2000 b42fa000 r-xp /usr/lib/libsensor.so.1.1.0
b430b000 b430e000 r-xp /usr/lib/libXv.so.1.0.0
b431e000 b4323000 r-xp /usr/lib/libutilX.so.1.1.0
b4333000 b4338000 r-xp /usr/lib/libappcore-common.so.1.1
b4348000 b434f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4362000 b4366000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4377000 b4441000 r-xp /usr/lib/libCOREGL.so.4.0
b4458000 b445b000 r-xp /usr/lib/libuuid.so.1.3.0
b446c000 b4483000 r-xp /usr/lib/libblkid.so.1.1.0
b4494000 b4496000 r-xp /usr/lib/libXau.so.6.0.0
b44a6000 b44a9000 r-xp /usr/lib/libEGL.so.1.4
b44b1000 b44b7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44c7000 b44c9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44da000 b44e8000 r-xp /usr/lib/libGLESv2.so.2.0
b44f1000 b4553000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4568000 b4580000 r-xp /usr/lib/libmount.so.1.1.0
b4591000 b45a5000 r-xp /usr/lib/libxcb.so.1.1.0
b45b6000 b45bd000 r-xp /lib/libcrypt-2.20-2014.11.so
b45f5000 b4606000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4617000 b4619000 r-xp /usr/lib/libiri.so
b4629000 b4634000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4645000 b465a000 r-xp /lib/libexpat.so.1.5.2
b466c000 b472a000 r-xp /usr/lib/libcairo.so.2.11200.14
b473d000 b4745000 r-xp /usr/lib/libdrm.so.2.4.0
b4755000 b4758000 r-xp /usr/lib/libdri2.so.0.0.0
b4769000 b47b7000 r-xp /usr/lib/libssl.so.1.0.0
b47cc000 b47d8000 r-xp /usr/lib/libeeze.so.1.13.0
b47e8000 b47f1000 r-xp /usr/lib/libethumb.so.1.13.0
b4801000 b4804000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4814000 b49cb000 r-xp /usr/lib/libcrypto.so.1.0.0
b5622000 b562b000 r-xp /usr/lib/libXi.so.6.1.0
b563b000 b563d000 r-xp /usr/lib/libXgesture.so.7.0.0
b564d000 b5651000 r-xp /usr/lib/libXtst.so.6.1.0
b5661000 b5667000 r-xp /usr/lib/libXrender.so.1.3.0
b5677000 b567d000 r-xp /usr/lib/libXrandr.so.2.2.0
b568e000 b5690000 r-xp /usr/lib/libXinerama.so.1.0.0
b56a0000 b56a3000 r-xp /usr/lib/libXfixes.so.3.1.0
b56b3000 b56be000 r-xp /usr/lib/libXext.so.6.4.0
b56ce000 b56d0000 r-xp /usr/lib/libXdamage.so.1.1.0
b56e0000 b56e2000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56f3000 b57d5000 r-xp /usr/lib/libX11.so.6.3.0
b57e8000 b57ef000 r-xp /usr/lib/libXcursor.so.1.0.2
b57ff000 b5817000 r-xp /usr/lib/libudev.so.1.6.0
b5819000 b581c000 r-xp /lib/libattr.so.1.1.0
b582c000 b584c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b584e000 b5853000 r-xp /usr/lib/libffi.so.6.0.2
b5863000 b587b000 r-xp /lib/libz.so.1.2.8
b588b000 b588d000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b589d000 b5972000 r-xp /usr/lib/libxml2.so.2.9.2
b5987000 b5a22000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a3e000 b5a41000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a51000 b5a6a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a7b000 b5a8c000 r-xp /lib/libresolv-2.20-2014.11.so
b5aa0000 b5b1a000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b2f000 b5b31000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b41000 b5b48000 r-xp /usr/lib/libembryo.so.1.13.0
b5b58000 b5b70000 r-xp /usr/lib/libpng12.so.0.50.0
b5b81000 b5ba4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc5000 b5bd9000 r-xp /usr/lib/libector.so.1.13.0
b5bea000 b5c02000 r-xp /usr/lib/liblua-5.1.so
b5c13000 b5c6a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c7e000 b5ca6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb7000 b5cca000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cdb000 b5d12000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d23000 b5d31000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d41000 b5d49000 r-xp /usr/lib/libtbm.so.1.0.0
b5d59000 b5d66000 r-xp /usr/lib/libeio.so.1.13.0
b5d76000 b5d78000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d88000 b5d8d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d9d000 b5db4000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc6000 b5de6000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df6000 b5e16000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e18000 b5e1e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e2e000 b5e3f000 r-xp /usr/lib/libemotion.so.1.13.0
b5e50000 b5e57000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e67000 b5e76000 r-xp /usr/lib/libeo.so.1.13.0
b5e87000 b5e99000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eaa000 b5eaf000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ebf000 b5ed8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ee8000 b5f05000 r-xp /usr/lib/libeet.so.1.13.0
b5f1e000 b5f66000 r-xp /usr/lib/libeina.so.1.13.0
b5f77000 b5f87000 r-xp /usr/lib/libefl.so.1.13.0
b5f98000 b607d000 r-xp /usr/lib/libicuuc.so.51.1
b609a000 b61da000 r-xp /usr/lib/libicui18n.so.51.1
b61f1000 b6229000 r-xp /usr/lib/libecore_x.so.1.13.0
b623b000 b623e000 r-xp /lib/libcap.so.2.21
b624e000 b6277000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6288000 b628f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62a1000 b62d8000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62e9000 b63d4000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e7000 b6460000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6472000 b6477000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6487000 b6491000 r-xp /usr/lib/libvconf.so.0.2.45
b64a1000 b64a3000 r-xp /usr/lib/libvasum.so.0.3.1
b64b3000 b64b5000 r-xp /usr/lib/libttrace.so.1.1
b64c5000 b64c8000 r-xp /usr/lib/libiniparser.so.0
b64d8000 b64fe000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b650e000 b6513000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6524000 b653b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b654c000 b65b7000 r-xp /lib/libm-2.20-2014.11.so
b65c8000 b65ce000 r-xp /lib/librt-2.20-2014.11.so
b65df000 b65ec000 r-xp /usr/lib/libunwind.so.8.0.1
b6622000 b6746000 r-xp /lib/libc-2.20-2014.11.so
b675b000 b6774000 r-xp /lib/libgcc_s-4.9.so.1
b6784000 b6866000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6877000 b68a1000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b2000 b68ee000 r-xp /usr/lib/libsystemd.so.0.4.0
b68f0000 b6972000 r-xp /usr/lib/libedje.so.1.13.0
b6985000 b69a3000 r-xp /usr/lib/libecore.so.1.13.0
b69c3000 b6b4a000 r-xp /usr/lib/libevas.so.1.13.0
b6b7f000 b6b93000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba7000 b6ddc000 r-xp /usr/lib/libelementary.so.1.13.0
b6e0a000 b6e0e000 r-xp /usr/lib/libsmack.so.1.0.0
b6e1e000 b6e25000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e35000 b6e37000 r-xp /usr/lib/libdlog.so.0.0.0
b6e47000 b6e4a000 r-xp /usr/lib/libbundle.so.0.1.22
b6e5a000 b6e5c000 r-xp /lib/libdl-2.20-2014.11.so
b6e6d000 b6e85000 r-xp /usr/lib/libaul.so.0.1.0
b6e99000 b6e9e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eaf000 b6ebc000 r-xp /usr/lib/liblptcp.so
b6ece000 b6ed2000 r-xp /usr/lib/libsys-assert.so
b6ee3000 b6f03000 r-xp /lib/ld-2.20-2014.11.so
b6f14000 b6f19000 r-xp /usr/bin/launchpad-loader
b8c55000 b8f88000 rw-p [heap]
bed98000 bedb9000 rw-p [stack]
b8c55000 b8f88000 rw-p [heap]
bed98000 bedb9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22492)
Call Stack Count: 1
 0: (0xb66976f0) [/lib/libc.so.6] + 0x756f0
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
 part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:49:55.586+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800ec803 is not stable during recalc loop
09-10 16:49:55.656+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800ec803 is not stable during recalc loop
09-10 16:49:55.656+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 16:49:55.666+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 16:49:56.287+0600 E/weather-agent(22611): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 16:49:56.287+0600 I/CAPI_APPFW_APPLICATION(22611): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 16:49:56.297+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:49:56.297+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:49:56.297+0600 E/weather-agent(22611): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 16:49:56.467+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 16:49:56.477+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 22611
09-10 16:49:56.477+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[22611] terminate event is forwarded
09-10 16:49:56.477+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:49:56.477+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 22611, ]
09-10 16:49:56.477+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:49:56.477+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 16:49:56.477+0600 I/Tizen::App( 1366): (512) > Not registered pid(22611)
09-10 16:49:56.477+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 16:49:56.477+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:49:56.477+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 22611
09-10 16:49:56.477+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:49:56.477+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 22611.
09-10 16:50:00.080+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 16:50:00.090+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 4:50 p.m.
09-10 16:50:00.090+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 4:50 p.m."
09-10 16:50:00.090+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 4:50 p.m."
09-10 16:50:00.090+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 16:50:00.090+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145881951 Time: <font_size=31> </font_size> <font_size=31> 4:50 p.m.</font_size></font>"
09-10 16:50:00.571+0600 W/AUL     (22695): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.bluetooth)
09-10 16:50:00.571+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:50:00.581+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-10 16:50:00.591+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-10 16:50:00.591+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:50:00.591+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 22695
09-10 16:50:00.591+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:50:00.601+0600 E/RESOURCED(15587): block.c: block_prelaunch_state(138) > insert data org.example.bluetooth, table num : 1
09-10 16:50:00.601+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:50:00.601+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:50:00.601+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:50:00.601+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.bluetooth has already loaded
09-10 16:50:00.601+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:50:00.601+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:50:00.601+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:50:00.601+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:50:00.621+0600 I/CAPI_APPFW_APPLICATION(22492): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:50:00.621+0600 I/CAPI_APPFW_APPLICATION(22492): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:50:00.651+0600 E/TBM     (22492): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 16:50:00.701+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 22492, appid: org.example.bluetooth
09-10 16:50:00.701+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:50:00.721+0600 W/AUL     (22695): launch.c: app_request_to_launchpad(425) > request cmd(0) result(22492)
09-10 16:50:00.731+0600 E/CAPI_NETWORK_WIFI(22492): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 16:50:00.771+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 16:50:00.971+0600 I/CAPI_NETWORK_WIFI(22492): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 16:50:00.971+0600 D/bluetooth(22492): [wifi_initialize] Success.
09-10 16:50:01.231+0600 I/APP_CORE(22492): appcore-efl.c: __do_app(520) > [APP 22492] Event: RESET State: CREATED
09-10 16:50:01.231+0600 I/CAPI_APPFW_APPLICATION(22492): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:50:01.231+0600 E/EFL     (22492): edje<22492> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:50:01.231+0600 E/EFL     (22492): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:50:01.241+0600 E/EFL     (22492): edje<22492> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:50:01.241+0600 E/EFL     (22492): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:50:01.251+0600 E/EFL     (22492): edje<22492> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:50:01.251+0600 E/EFL     (22492): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:50:01.291+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:50:01.361+0600 W/APP_CORE(22492): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5400002
09-10 16:50:01.361+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 16:50:01.462+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7760de8), gem(32), surface(0xb78bfb28)
09-10 16:50:01.462+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7798ea0), gem(13), surface(0xb78a2ff8)
09-10 16:50:01.472+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7760de8), gem(32), surface(0xb786c770)
09-10 16:50:01.472+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77692b8), gem(15), surface(0xb78be508)
09-10 16:50:01.482+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775a010), gem(24), surface(0xb78c5f60)
09-10 16:50:01.492+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 16:50:01.492+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 16:50:01.492+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 16:50:01.492+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(22492) status(4)
09-10 16:50:01.532+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77d4b90), gem(26), surface(0xb78a7f18)
09-10 16:50:01.532+0600 I/APP_CORE(22492): appcore-efl.c: __do_app(520) > [APP 22492] Event: PAUSE State: CREATED
09-10 16:50:01.542+0600 I/TIZEN_N_EFL_UTIL_WINDOW(22492): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 4
09-10 16:50:01.542+0600 E/APP_CORE(22492): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 16:50:01.542+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:50:01.712+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:50:01.712+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 16:50:01.722+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78448e8), gem(33), surface(0xb78ba120)
09-10 16:50:01.762+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 16:50:01.762+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 22492.
09-10 16:50:01.762+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2281
09-10 16:50:01.842+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(22492) status(0)
09-10 16:50:01.842+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:50:01.852+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7798ea0), gem(33), surface(0xb78ba120)
09-10 16:50:02.152+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7760de8), gem(26), surface(0xb78ba300)
09-10 16:50:02.693+0600 I/UXT     (22708): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 16:50:02.983+0600 E/EFL     (18770): ecore_x<18770> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15453832
09-10 16:50:03.023+0600 E/EFL     (18770): ecore_x<18770> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15453872
09-10 16:50:03.063+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:50:03.063+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:50:03.073+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.tizen.system-syspopup(18770)
09-10 16:50:03.073+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18770, appid: org.tizen.system-syspopup, status: bg
09-10 16:50:03.073+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:03.093+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:03.093+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:50:03.113+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.tizen.] 
09-10 16:50:03.123+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:50:03.123+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:50:03.383+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 18770 pgid = 18770
09-10 16:50:03.383+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(18770)
09-10 16:50:03.413+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:50:03.413+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:50:03.413+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:50:03.423+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 18770
09-10 16:50:03.423+0600 I/Tizen::App( 1366): (243) > App[org.tizen.system-syspopup] pid[18770] terminate event is forwarded
09-10 16:50:03.423+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:50:03.423+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.tizen.system-syspopup, 18770, ]
09-10 16:50:03.423+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:50:03.423+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.tizen.system-syspopup)
09-10 16:50:03.423+0600 I/Tizen::App( 1366): (512) > Not registered pid(18770)
09-10 16:50:03.423+0600 I/Tizen::System( 1366): (246) > Terminated app [org.tizen.system-syspopup]
09-10 16:50:03.423+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:50:03.423+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18770
09-10 16:50:03.423+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 18770
09-10 16:50:03.423+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2284
09-10 16:50:03.433+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:50:03.433+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.tizen.system-syspopup, 18770.
09-10 16:50:03.674+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15454520
09-10 16:50:03.794+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15454645
09-10 16:50:03.794+0600 E/LOCKSCREEN(  869): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80001:VIEW_GESTURED
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80001 event_info:0
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:4:LKD_EVT_WILL_UNLOCK
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:4 event_info:0
09-10 16:50:03.794+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event_delay(1042) > [lockd_event_delay:1042:W] dealyed event:2:UNLOCK wait for:0.330000
09-10 16:50:03.794+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 16:50:04.134+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:2 event_info:0
09-10 16:50:04.134+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:7
09-10 16:50:04.134+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
09-10 16:50:04.134+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 16:50:04.134+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 16:50:04.134+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:50:04.134+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 16:50:04.134+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 16:50:04.134+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_set(725) > [_lcd_timeout_timer_set:725:W] lcd off timer set:30.000000
09-10 16:50:04.144+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:04.144+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [invisible]
09-10 16:50:04.144+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10002:WIN_BECOME_INVISIBLE
09-10 16:50:04.144+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10002 event_info:0
09-10 16:50:04.144+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
09-10 16:50:04.144+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 16:50:04.144+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:50:04.144+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:50:04.144+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 16:50:04.144+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 16:50:04.144+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 16:50:04.144+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 16:50:04.144+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 16:50:04.144+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:50:04.144+0600 E/VCONF   ( 9347): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 16:50:04.144+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:04.154+0600 I/APP_CORE(22492): appcore-efl.c: __do_app(520) > [APP 22492] Event: RESUME State: CREATED
09-10 16:50:04.154+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:50:04.164+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(4)
09-10 16:50:04.164+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(869)
09-10 16:50:04.164+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: bg
09-10 16:50:04.164+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(22492) status(3)
09-10 16:50:04.164+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:50:04.164+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:50:04.164+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(22492)
09-10 16:50:04.164+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 22492, appid: org.example.bluetooth, status: fg
09-10 16:50:04.174+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:50:04.184+0600 I/APP_CORE(22492): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 16:50:04.184+0600 I/APP_CORE(22492): appcore-efl.c: __do_app(637) > [APP 22492] Initial Launching, call the resume_cb
09-10 16:50:04.184+0600 I/CAPI_APPFW_APPLICATION(22492): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:50:04.184+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 16:50:04.194+0600 I/Tizen::System( 1366): (259) > Active app [org.exampl], current [com.samsun] 
09-10 16:50:04.194+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:50:04.204+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:50:04.244+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-10 16:50:04.244+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 16:50:04.244+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 16:50:04.244+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 16:50:04.244+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 16:50:04.254+0600 E/LOCKSCREEN(  869): background-view.c: background_image_next_set(309) > [background_image_next_set:309:E] fopen wallpaper txt file failed.
09-10 16:50:04.935+0600 E/EFL     (22492): ecore_x<22492> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15455785
09-10 16:50:05.005+0600 E/EFL     (22492): ecore_x<22492> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15455856
09-10 16:50:05.015+0600 E/VCONF   (22492): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
09-10 16:50:05.015+0600 E/VCONF   (22492): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
09-10 16:50:05.015+0600 E/VCONF   (22492): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
09-10 16:50:05.015+0600 E/VCONF   (22492): vconf.c: vconf_get_bool(2729) > vconf_get_bool(22492) : db/ise/keysound error
09-10 16:50:05.015+0600 E/VCONF   (22492): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
09-10 16:50:05.015+0600 E/VCONF   (22492): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
09-10 16:50:05.696+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=15456544
09-10 16:50:05.696+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 16:50:05.696+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 16:50:05.696+0600 E/EFL     (22492): ecore_x<22492> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=15456544
09-10 16:50:05.696+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:50:05.996+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:50:05.996+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:50:05.996+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:50:05.996+0600 E/STARTER (  763): )
09-10 16:50:05.996+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:50:05.996+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:50:05.996+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:50:06.016+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 16:50:06.016+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:50:06.026+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 16:50:06.026+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:50:06.026+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 16:50:06.026+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:50:06.036+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:50:06.036+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:50:06.036+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:50:06.036+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 16:50:06.036+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:50:06.036+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:50:06.036+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:50:06.036+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:50:06.056+0600 E/CAPI_APPFW_APPLICATION(18353): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:50:06.056+0600 E/CAPI_APPFW_APPLICATION(18353): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:50:06.056+0600 E/CAPI_APPFW_APPLICATION(18353): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:50:06.056+0600 E/CAPI_APPFW_APPLICATION(18353): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:50:06.056+0600 E/CAPI_APPFW_APPLICATION(18353): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:50:06.056+0600 I/CAPI_APPFW_APPLICATION(18353): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:50:06.056+0600 I/CAPI_APPFW_APPLICATION(18353): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:50:06.076+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77aef10), gem(19), surface(0xb787ceb0)
09-10 16:50:06.076+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77aef10), gem(19), surface(0xb78ba120)
09-10 16:50:06.076+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:50:06.086+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 16:50:06.086+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 16:50:06.136+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb775a010), gem(21), surface(0xb787e520)
09-10 16:50:06.136+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 18353, appid: com.samsung.task-mgr
09-10 16:50:06.136+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:50:06.136+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(18353)
09-10 16:50:06.146+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:50:06.186+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 16:50:06.196+0600 W/TASK_MGR_LITE(18353): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 16:50:06.256+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:06.256+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:06.256+0600 I/GXT_SIB (18353): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:50:06.286+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 16:50:06.286+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:50:06.316+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:50:06.316+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:50:06.326+0600 E/RUA     (18353): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 19, ncols : 5
09-10 16:50:06.326+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:50:06.326+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 22492
09-10 16:50:06.326+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 16:50:06.326+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 16:50:06.336+0600 I/TIZEN_N_SOUND_MANAGER(22594): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 16:50:06.336+0600 E/TIZEN_N_SOUND_MANAGER(22594): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:50:06.346+0600 I/TIZEN_N_SOUND_MANAGER(22594): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 16:50:06.346+0600 E/TIZEN_N_SOUND_MANAGER(22594): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:50:06.346+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:50:06.386+0600 I/APP_CORE(18353): appcore-efl.c: __do_app(520) > [APP 18353] Event: RESET State: CREATED
09-10 16:50:06.386+0600 I/CAPI_APPFW_APPLICATION(18353): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:50:06.396+0600 E/EFL     (18353): edje<18353> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:50:06.396+0600 E/EFL     (18353): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:50:06.396+0600 E/EFL     (18353): edje<18353> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:50:06.396+0600 E/EFL     (18353): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:50:06.396+0600 W/APP_CORE(18353): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200003
09-10 16:50:06.396+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 16:50:06.416+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 16:50:06.416+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=15457258
09-10 16:50:06.416+0600 E/EFL     (22492): ecore_x<22492> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=15457258
09-10 16:50:06.416+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:50:06.416+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:50:06.416+0600 E/STARTER (  763): )
09-10 16:50:06.416+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:50:06.416+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:50:06.416+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:50:06.416+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:50:06.456+0600 I/MALI    (18353): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb7367350)
09-10 16:50:06.476+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77f96c8), gem(26), surface(0xb78ae800)
09-10 16:50:06.476+0600 I/MALI    (18353): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:50:06.486+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18353) status(0)
09-10 16:50:06.486+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:50:06.486+0600 I/APP_CORE(22492): appcore-efl.c: __do_app(520) > [APP 22492] Event: PAUSE State: RUNNING
09-10 16:50:06.486+0600 I/CAPI_APPFW_APPLICATION(22492): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:50:06.486+0600 I/APP_CORE(18353): appcore-efl.c: __do_app(520) > [APP 18353] Event: RESUME State: CREATED
09-10 16:50:06.496+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(18353) status(3)
09-10 16:50:06.496+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:50:06.496+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:50:06.496+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(18353)
09-10 16:50:06.496+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18353, appid: com.samsung.task-mgr, status: fg
09-10 16:50:06.496+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7823e00), gem(24), surface(0xb78ba120)
09-10 16:50:06.496+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:50:06.496+0600 I/TIZEN_N_EFL_UTIL_WINDOW(22492): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
09-10 16:50:06.496+0600 E/APP_CORE(22492): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 16:50:06.506+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:50:06.516+0600 I/APP_CORE(18353): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 16:50:06.516+0600 I/APP_CORE(18353): appcore-efl.c: __do_app(637) > [APP 18353] Initial Launching, call the resume_cb
09-10 16:50:06.516+0600 I/CAPI_APPFW_APPLICATION(18353): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:50:06.987+0600 E/EFL     (18353): ecore_x<18353> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=15457829
09-10 16:50:07.047+0600 E/EFL     (18353): ecore_x<18353> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=15457890
09-10 16:50:07.047+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:50:07.047+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 22492
09-10 16:50:07.047+0600 W/AUL     (18353): launch.c: app_request_to_launchpad(396) > request cmd(4) to(22492)
09-10 16:50:07.047+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 16:50:07.057+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(22492), cmd(4)
09-10 16:50:07.057+0600 I/APP_CORE(22492): appcore-efl.c: __do_app(520) > [APP 22492] Event: TERMINATE State: PAUSED
09-10 16:50:07.057+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:50:07.057+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:50:07.057+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:50:07.057+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:50:07.057+0600 I/TIZEN_N_EFL_UTIL_WINDOW(22492): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 16:50:07.057+0600 E/APP_CORE(22492): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 16:50:07.057+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:50:07.057+0600 E/APP_CORE(22492): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 16:50:07.057+0600 I/CAPI_APPFW_APPLICATION(22492): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:50:07.057+0600 E/CAPI_NETWORK_BLUETOOTH(22492): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 16:50:07.067+0600 W/AUL     (18353): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 16:50:07.107+0600 I/MALI    (18353): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:50:07.127+0600 I/MALI    (18353): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:50:07.137+0600 I/MALI    (18353): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:50:07.277+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2286
09-10 16:50:07.287+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 16:50:07.287+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 18353.
09-10 16:50:07.297+0600 E/CAPI_NETWORK_BLUETOOTH(22492): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 16:50:07.297+0600 E/CAPI_NETWORK_BLUETOOTH(22492): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 16:50:07.297+0600 E/bluetooth(22492): [bt_adapter_le_destroy_advertiser] Failed.
09-10 16:50:07.317+0600 I/CAPI_NETWORK_WIFI(22492): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:50:07.317+0600 E/bluetooth(22492): [wifi_deinitialize] Success.
09-10 16:50:07.357+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:50:07.357+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:50:07.357+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(18353)
09-10 16:50:07.357+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 18353, appid: com.samsung.task-mgr, status: bg
09-10 16:50:07.357+0600 I/CAPI_APPFW_APPLICATION(18353): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:50:07.357+0600 W/TASK_MGR_LITE(18353): task-mgr-lite.c: _pause_app(406) > 
09-10 16:50:07.357+0600 I/CAPI_APPFW_APPLICATION(18353): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:50:07.367+0600 E/EFL     (22492): elementary<22492> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 16:50:07.377+0600 E/TASK_MGR_LITE(18353): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 16:50:07.387+0600 E/APP_CORE(18353): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 16:50:07.387+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:07.397+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 16:50:07.397+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:50:07.397+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:50:07.397+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 16:50:07.397+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 16:50:07.407+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775a010), gem(23), surface(0xb787e520)
09-10 16:50:07.407+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:50:07.417+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778ae60), gem(13), surface(0xb787ceb0)
09-10 16:50:07.457+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7823e00), gem(19), surface(0xb78ba120)
09-10 16:50:07.457+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7823e00), gem(19), surface(0xb78ba300)
09-10 16:50:07.487+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 16:50:07.487+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:50:07.487+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 16:50:07.497+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:50:07.507+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:50:07.537+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb775a010), gem(23), surface(0xb78ba120)
09-10 16:50:07.548+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 16:50:07.548+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 16:50:07.548+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 16:50:07.568+0600 W/CRASH_MANAGER(22320): worker.c: worker_job(1199) > 1122492626162147350460
