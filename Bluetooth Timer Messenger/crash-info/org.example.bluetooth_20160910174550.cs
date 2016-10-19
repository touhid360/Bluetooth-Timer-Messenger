S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 7911
Date: 2016-09-10 17:45:50+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7911, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb7edc650
r2   = 0xb4379000, r3   = 0xb4379000
r4   = 0xbe8ec5bc, r5   = 0xb6a780f4
r6   = 0xb6a77310, r7   = 0xbe8ec41c
r8   = 0xb6a780f4, r9   = 0xb6a780f4
r10  = 0xb6a8620c, fp   = 0x00000000
ip   = 0xb2a6c504, sp   = 0xbe8eb798
lr   = 0xb2a61daf, pc   = 0xb675b6f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     48272 KB
Buffers:     44444 KB
Cached:     289732 KB
VmPeak:     111372 KB
VmSize:     104988 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25436 KB
VmRSS:       25384 KB
VmData:      35084 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7911 TID = 7911
7911 7915 8027 

Maps Information
b1db8000 b25b7000 rw-p [stack:8027]
b25b7000 b25c8000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25d8000 b25dd000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2669000 b2671000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2682000 b2683000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2693000 b26a7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26bb000 b26bc000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26cc000 b26cf000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26e0000 b26e1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26f1000 b26f3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2703000 b2705000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2715000 b2725000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2735000 b2741000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2952000 b2969000 r-xp /usr/lib/libnetwork.so.0.0.0
b297a000 b29b8000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29c9000 b29d0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29e1000 b29f0000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a00000 b2a35000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a48000 b2a4e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a5e000 b2a65000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b86000 b2c69000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ca0000 b2cc8000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cda000 b34d9000 rw-p [stack:7915]
b34d9000 b34db000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34eb000 b34f5000 r-xp /lib/libnss_files-2.20-2014.11.so
b3506000 b350f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3520000 b3531000 r-xp /lib/libnsl-2.20-2014.11.so
b3544000 b354a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b355b000 b355c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3584000 b358b000 r-xp /usr/lib/libminizip.so.1.0.0
b359b000 b35a0000 r-xp /usr/lib/libstorage.so.0.1
b35b0000 b3605000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b361b000 b362f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b363f000 b3683000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3693000 b369b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36ab000 b36db000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36ee000 b37a7000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37bb000 b380f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3820000 b383b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b384b000 b390c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b391f000 b3931000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3941000 b3945000 r-xp /usr/lib/libogg.so.0.7.1
b3955000 b3977000 r-xp /usr/lib/libvorbis.so.0.4.3
b3987000 b3a6b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a87000 b3a94000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3aa5000 b3ae8000 r-xp /usr/lib/libsndfile.so.1.0.25
b3afd000 b3b44000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b55000 b3b5b000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b6c000 b3b73000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b83000 b3bc3000 r-xp /usr/lib/libmdm.so.1.2.10
b3bd3000 b3bdb000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bea000 b3bfa000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c1b000 b3c7b000 r-xp /usr/lib/libasound.so.2.0.0
b3c8d000 b3cc3000 r-xp /usr/lib/libpulse.so.0.16.2
b3cd4000 b3cd7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3ce7000 b3cea000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cfa000 b3cff000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d0f000 b3d10000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d20000 b3d2b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d3f000 b3d46000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d56000 b3d5c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d6c000 b3d71000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d81000 b3d9c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3dac000 b3db3000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dc3000 b3dc6000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3dd7000 b3e05000 r-xp /usr/lib/libidn.so.11.5.44
b3e15000 b3e2b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e3c000 b3e46000 r-xp /usr/lib/libcares.so.2.1.0
b3e56000 b3e60000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e70000 b3e72000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e82000 b3e83000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e93000 b3e97000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3ea8000 b3ed0000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ee1000 b3f0a000 r-xp /usr/lib/libturbojpeg.so
b3f2a000 b3f30000 r-xp /usr/lib/libgif.so.4.1.6
b3f40000 b3f86000 r-xp /usr/lib/libcurl.so.4.3.0
b3f97000 b3fb8000 r-xp /usr/lib/libexif.so.12.3.3
b3fd3000 b3fe8000 r-xp /usr/lib/libtts.so
b3ff9000 b4001000 r-xp /usr/lib/libfeedback.so.0.1.4
b4011000 b40d1000 r-xp /usr/lib/libdali-core.so.0.0.0
b40dc000 b41cf000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41ef000 b42c9000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42e0000 b42e2000 r-xp /usr/lib/libboost_system.so.1.51.0
b42f2000 b42f8000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4308000 b432b000 r-xp /usr/lib/libboost_thread.so.1.51.0
b433c000 b433e000 r-xp /usr/lib/libappsvc.so.0.1.0
b434e000 b4350000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4361000 b4366000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b437d000 b437f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b438f000 b4396000 r-xp /usr/lib/libsensord-share.so
b43a6000 b43be000 r-xp /usr/lib/libsensor.so.1.1.0
b43cf000 b43d2000 r-xp /usr/lib/libXv.so.1.0.0
b43e2000 b43e7000 r-xp /usr/lib/libutilX.so.1.1.0
b43f7000 b43fc000 r-xp /usr/lib/libappcore-common.so.1.1
b440c000 b4413000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4426000 b442a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b443b000 b4505000 r-xp /usr/lib/libCOREGL.so.4.0
b451c000 b451f000 r-xp /usr/lib/libuuid.so.1.3.0
b4530000 b4547000 r-xp /usr/lib/libblkid.so.1.1.0
b4558000 b455a000 r-xp /usr/lib/libXau.so.6.0.0
b456a000 b456d000 r-xp /usr/lib/libEGL.so.1.4
b4575000 b457b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b458b000 b458d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b459e000 b45ac000 r-xp /usr/lib/libGLESv2.so.2.0
b45b5000 b4617000 r-xp /usr/lib/libpixman-1.so.0.28.2
b462c000 b4644000 r-xp /usr/lib/libmount.so.1.1.0
b4655000 b4669000 r-xp /usr/lib/libxcb.so.1.1.0
b467a000 b4681000 r-xp /lib/libcrypt-2.20-2014.11.so
b46b9000 b46ca000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46db000 b46dd000 r-xp /usr/lib/libiri.so
b46ed000 b46f8000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4709000 b471e000 r-xp /lib/libexpat.so.1.5.2
b4730000 b47ee000 r-xp /usr/lib/libcairo.so.2.11200.14
b4801000 b4809000 r-xp /usr/lib/libdrm.so.2.4.0
b4819000 b481c000 r-xp /usr/lib/libdri2.so.0.0.0
b482d000 b487b000 r-xp /usr/lib/libssl.so.1.0.0
b4890000 b489c000 r-xp /usr/lib/libeeze.so.1.13.0
b48ac000 b48b5000 r-xp /usr/lib/libethumb.so.1.13.0
b48c5000 b48c8000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48d8000 b4a8f000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e6000 b56ef000 r-xp /usr/lib/libXi.so.6.1.0
b56ff000 b5701000 r-xp /usr/lib/libXgesture.so.7.0.0
b5711000 b5715000 r-xp /usr/lib/libXtst.so.6.1.0
b5725000 b572b000 r-xp /usr/lib/libXrender.so.1.3.0
b573b000 b5741000 r-xp /usr/lib/libXrandr.so.2.2.0
b5752000 b5754000 r-xp /usr/lib/libXinerama.so.1.0.0
b5764000 b5767000 r-xp /usr/lib/libXfixes.so.3.1.0
b5777000 b5782000 r-xp /usr/lib/libXext.so.6.4.0
b5792000 b5794000 r-xp /usr/lib/libXdamage.so.1.1.0
b57a4000 b57a6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b7000 b5899000 r-xp /usr/lib/libX11.so.6.3.0
b58ac000 b58b3000 r-xp /usr/lib/libXcursor.so.1.0.2
b58c3000 b58db000 r-xp /usr/lib/libudev.so.1.6.0
b58dd000 b58e0000 r-xp /lib/libattr.so.1.1.0
b58f0000 b5910000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5912000 b5917000 r-xp /usr/lib/libffi.so.6.0.2
b5927000 b593f000 r-xp /lib/libz.so.1.2.8
b594f000 b5951000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5961000 b5a36000 r-xp /usr/lib/libxml2.so.2.9.2
b5a4b000 b5ae6000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b02000 b5b05000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b15000 b5b2e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b3f000 b5b50000 r-xp /lib/libresolv-2.20-2014.11.so
b5b64000 b5bde000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bf3000 b5bf5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c05000 b5c0c000 r-xp /usr/lib/libembryo.so.1.13.0
b5c1c000 b5c34000 r-xp /usr/lib/libpng12.so.0.50.0
b5c45000 b5c68000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c89000 b5c9d000 r-xp /usr/lib/libector.so.1.13.0
b5cae000 b5cc6000 r-xp /usr/lib/liblua-5.1.so
b5cd7000 b5d2e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d42000 b5d6a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d7b000 b5d8e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d9f000 b5dd6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5de7000 b5df5000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e05000 b5e0d000 r-xp /usr/lib/libtbm.so.1.0.0
b5e1d000 b5e2a000 r-xp /usr/lib/libeio.so.1.13.0
b5e3a000 b5e3c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e4c000 b5e51000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e61000 b5e78000 r-xp /usr/lib/libefreet.so.1.13.0
b5e8a000 b5eaa000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eba000 b5eda000 r-xp /usr/lib/libecore_con.so.1.13.0
b5edc000 b5ee2000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ef2000 b5f03000 r-xp /usr/lib/libemotion.so.1.13.0
b5f14000 b5f1b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f2b000 b5f3a000 r-xp /usr/lib/libeo.so.1.13.0
b5f4b000 b5f5d000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f6e000 b5f73000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f83000 b5f9c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fac000 b5fc9000 r-xp /usr/lib/libeet.so.1.13.0
b5fe2000 b602a000 r-xp /usr/lib/libeina.so.1.13.0
b603b000 b604b000 r-xp /usr/lib/libefl.so.1.13.0
b605c000 b6141000 r-xp /usr/lib/libicuuc.so.51.1
b615e000 b629e000 r-xp /usr/lib/libicui18n.so.51.1
b62b5000 b62ed000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ff000 b6302000 r-xp /lib/libcap.so.2.21
b6312000 b633b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b634c000 b6353000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6365000 b639c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63ad000 b6498000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64ab000 b6524000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6536000 b653b000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b654b000 b6555000 r-xp /usr/lib/libvconf.so.0.2.45
b6565000 b6567000 r-xp /usr/lib/libvasum.so.0.3.1
b6577000 b6579000 r-xp /usr/lib/libttrace.so.1.1
b6589000 b658c000 r-xp /usr/lib/libiniparser.so.0
b659c000 b65c2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65d2000 b65d7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65e8000 b65ff000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6610000 b667b000 r-xp /lib/libm-2.20-2014.11.so
b668c000 b6692000 r-xp /lib/librt-2.20-2014.11.so
b66a3000 b66b0000 r-xp /usr/lib/libunwind.so.8.0.1
b66e6000 b680a000 r-xp /lib/libc-2.20-2014.11.so
b681f000 b6838000 r-xp /lib/libgcc_s-4.9.so.1
b6848000 b692a000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b693b000 b6965000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6976000 b69b2000 r-xp /usr/lib/libsystemd.so.0.4.0
b69b4000 b6a36000 r-xp /usr/lib/libedje.so.1.13.0
b6a49000 b6a67000 r-xp /usr/lib/libecore.so.1.13.0
b6a87000 b6c0e000 r-xp /usr/lib/libevas.so.1.13.0
b6c43000 b6c57000 r-xp /lib/libpthread-2.20-2014.11.so
b6c6b000 b6ea0000 r-xp /usr/lib/libelementary.so.1.13.0
b6ece000 b6ed2000 r-xp /usr/lib/libsmack.so.1.0.0
b6ee2000 b6ee9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ef9000 b6efb000 r-xp /usr/lib/libdlog.so.0.0.0
b6f0b000 b6f0e000 r-xp /usr/lib/libbundle.so.0.1.22
b6f1e000 b6f20000 r-xp /lib/libdl-2.20-2014.11.so
b6f31000 b6f49000 r-xp /usr/lib/libaul.so.0.1.0
b6f5d000 b6f62000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f73000 b6f80000 r-xp /usr/lib/liblptcp.so
b6f92000 b6f96000 r-xp /usr/lib/libsys-assert.so
b6fa7000 b6fc7000 r-xp /lib/ld-2.20-2014.11.so
b6fd8000 b6fdd000 r-xp /usr/bin/launchpad-loader
b7e76000 b8205000 rw-p [heap]
be8cc000 be8ed000 rw-p [stack]
b7e76000 b8205000 rw-p [heap]
be8cc000 be8ed000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7911)
Call Stack Count: 1
 0: (0xb675b6f0) [/lib/libc.so.6] + 0x756f0
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
I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff05 value =0x1[0m
09-10 17:44:44.260+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff06 value =0x0[0m
09-10 17:44:44.260+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff07 value =0x1[0m
09-10 17:44:44.260+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff08 value =0x1[0m
09-10 17:44:44.260+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff09 value =0x0[0m
09-10 17:44:44.260+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff0a value =0x1[0m
09-10 17:44:44.260+0600 I/IME_LITE(  734): selectpage.cpp: ResetSelection(28) > [0;36m[0m
09-10 17:44:44.270+0600 I/APP_CORE( 7911): appcore-efl.c: __do_app(520) > [APP 7911] Event: RESUME State: PAUSED
09-10 17:44:44.270+0600 I/CAPI_APPFW_APPLICATION( 7911): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:44:44.270+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:44:44.270+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:44:44.270+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:44:44.270+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:44:44.270+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:44:44.270+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xe0 value =0x0[0m
09-10 17:44:44.270+0600 E/IME_LITE(  734): isf_xt9_imengine.cpp: process_helper_event(2481) > [0;31munknow cmd=0xe0[0m
09-10 17:44:44.300+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-10 17:44:44.300+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:44:44.300+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:44:44.300+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:44:44.300+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:44:44.300+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff02 value =0x1[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff03 value =0x1[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff04 value =0x1[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff05 value =0x1[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff06 value =0x0[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff07 value =0x1[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff08 value =0x1[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff09 value =0x0[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0xff0a value =0x1[0m
09-10 17:44:44.310+0600 I/IME_LITE(  734): selectpage.cpp: ResetSelection(28) > [0;36m[0m
09-10 17:44:44.310+0600 E/LOCKSCREEN(  869): background-view.c: background_image_next_set(309) > [background_image_next_set:309:E] fopen wallpaper txt file failed.
09-10 17:44:44.360+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:44:44.411+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:44:44.421+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785d5e8), gem(13), surface(0xb78b9810)
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:44:44.421+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:44:44.431+0600 I/ISE_MULTI(  821): isemain.cpp: slot_set_caps_mode(792) > [0;36m[hidden state:false] mode=0[0m
09-10 17:44:44.471+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:44:44.481+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7781180), gem(21), surface(0xb787e520)
09-10 17:44:44.501+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77448a0), gem(29), surface(0xb78ae1a0)
09-10 17:44:44.501+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 17:44:44.511+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7781180), gem(21), surface(0xb78ba300)
09-10 17:44:44.511+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77448a0), gem(29), surface(0xb78c5f58)
09-10 17:44:44.521+0600 I/MALI    (  821): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:44:44.521+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78b6110), gem(31), surface(0xb7877090)
09-10 17:44:44.521+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(821) status(3)
09-10 17:44:44.541+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77540c8), gem(19), surface(0xb789f458)
09-10 17:44:44.571+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
09-10 17:44:44.571+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
09-10 17:44:44.581+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb781e030), gem(19), surface(0xb78ba300)
09-10 17:44:46.282+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18649800
09-10 17:44:46.282+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18649832
09-10 17:44:46.282+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:44:46.282+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 17:44:46.312+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5e00002 FAILED!
09-10 17:44:46.392+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7781180), gem(21), surface(0xb78a7f18)
09-10 17:44:46.402+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb781e030), gem(19), surface(0xb78c5f58)
09-10 17:44:46.443+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:44:46.493+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:44:47.173+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18650719
09-10 17:44:47.383+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18650931
09-10 17:44:47.383+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:44:47.383+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 17:44:47.383+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:44:47.383+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:44:48.204+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:44:49.205+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 17:44:53.850+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18657407
09-10 17:44:53.910+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18657467
09-10 17:44:54.250+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18657805
09-10 17:44:54.330+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18657887
09-10 17:44:54.420+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18657975
09-10 17:44:54.500+0600 E/EFL     ( 7911): ecore_x<7911> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18658048
09-10 17:44:55.291+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 17:45:00.636+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 17:45:00.636+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 5:45 p.m.
09-10 17:45:00.636+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 5:45 p.m."
09-10 17:45:00.636+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 5:45 p.m."
09-10 17:45:00.636+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 17:45:00.636+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146456571 Time: <font_size=31> </font_size> <font_size=31> 5:45 p.m.</font_size></font>"
09-10 17:45:17.273+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 17:45:24.269+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:45:24.269+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:45:24.289+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 17:45:24.289+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 17:45:24.289+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 17:45:24.289+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:14dd178
09-10 17:45:24.289+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 17:45:24.289+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 17:45:24.299+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:45:24.299+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 17:45:24.299+0600 W/APP_CORE( 7911): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 17:45:24.299+0600 I/APP_CORE( 7911): appcore-efl.c: __do_app(520) > [APP 7911] Event: PAUSE State: RUNNING
09-10 17:45:24.299+0600 I/CAPI_APPFW_APPLICATION( 7911): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:45:24.309+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 17:45:24.319+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:45:24.319+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:45:24.329+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 17:45:24.860+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb781a770), gem(15), surface(0xb78ae1a0)
09-10 17:45:24.860+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:45:24.860+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:45:24.900+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778aa48), gem(13), surface(0xb787e520)
09-10 17:45:24.910+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:45:24.910+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:45:24.910+0600 I/APP_CORE( 7911): appcore-efl.c: __do_app(520) > [APP 7911] Event: PAUSE State: PAUSED
09-10 17:45:24.910+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 7911): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 17:45:24.910+0600 E/APP_CORE( 7911): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 17:45:24.910+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:45:24.920+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 17:45:24.920+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:45:24.920+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:45:24.920+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 17:45:24.920+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 17:45:24.930+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(7911) status(4)
09-10 17:45:24.930+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(7911)
09-10 17:45:24.930+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 7911, appid: org.example.bluetooth, status: bg
09-10 17:45:24.960+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 17:45:24.960+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:45:24.970+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:45:25.000+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:45:25.000+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 17:45:25.010+0600 I/TIZEN_N_SOUND_MANAGER( 6620): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 17:45:25.010+0600 E/TIZEN_N_SOUND_MANAGER( 6620): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:45:25.020+0600 I/TIZEN_N_SOUND_MANAGER( 6620): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 17:45:25.020+0600 E/TIZEN_N_SOUND_MANAGER( 6620): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:45:25.020+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:45:25.070+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 17:45:25.110+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 17:45:25.110+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 17:45:25.120+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7837bc8), gem(14), surface(0xb78b9810)
09-10 17:45:25.120+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 17:45:25.120+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:45:25.120+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:45:25.120+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 17:45:25.120+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 17:45:25.130+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:45:25.130+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:45:25.130+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:45:25.130+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:45:25.130+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 17:45:25.130+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77c98c0), gem(21), surface(0xb78ba300)
09-10 17:45:25.130+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:45:25.130+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 17:45:25.130+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 17:45:25.130+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 17:45:25.140+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 17:45:25.140+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:45:25.140+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 17:45:25.140+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:45:25.140+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 8748
09-10 17:45:25.140+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:45:25.190+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 8748
09-10 17:45:25.190+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 8748, appid: com.samsung.weather-m-agent
09-10 17:45:25.200+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 17:45:25.200+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 8748.
09-10 17:45:25.210+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8748)
09-10 17:45:25.220+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 17:45:25.220+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 17:45:25.220+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 17:45:25.220+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 17:45:25.220+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 17:45:25.220+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 17:45:25.230+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:45:25.230+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:45:25.240+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:45:25.240+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:45:25.240+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:45:25.370+0600 E/weather-agent( 8748): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 17:45:25.370+0600 E/weather-common( 8748): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 17:45:25.370+0600 E/weather-agent( 8748): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 17:45:25.380+0600 I/MESSAGE_PORT( 8748): message-port.c: __initialize(872) > initialize
09-10 17:45:25.391+0600 I/MESSAGE_PORT( 8748): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 17:45:25.421+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:45:25.421+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:45:25.421+0600 I/MESSAGE_PORT( 8748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:45:25.421+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 17:45:25.421+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 17:45:25.421+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:45:25.431+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:45:25.431+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 17:45:25.431+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:45:25.441+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:45:25.441+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:45:25.441+0600 I/MESSAGE_PORT( 8748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:45:25.441+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 17:45:25.441+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 17:45:25.441+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:45:25.441+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:45:25.451+0600 E/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 17:45:25.451+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 17:45:25.451+0600 I/MESSAGE_PORT( 8748): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:45:25.461+0600 E/MESSAGE_PORT( 8748): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 17:45:25.461+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 17:45:25.461+0600 E/weather-common( 8748): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 17:45:25.461+0600 E/weather-agent( 8748): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 17:45:25.461+0600 E/weather-agent( 8748): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 17:45:25.461+0600 I/MESSAGE_PORT( 8748): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:45:25.461+0600 I/MESSAGE_PORT( 8748): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:45:25.461+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:45:25.491+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:45:25.541+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 17:45:25.541+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 17:45:25.761+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb82ffe50]
09-10 17:45:25.761+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:45:25.761+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:45:25.761+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:45:25.761+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb82ffe50
09-10 17:45:25.761+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:45:25.771+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:45:25.771+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:45:25.771+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 17:45:25.771+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:45:25.771+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:45:25.781+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:45:25.811+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8016846b is not stable during recalc loop
09-10 17:45:25.881+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8016846b is not stable during recalc loop
09-10 17:45:25.891+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:45:25.901+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:45:26.462+0600 E/weather-agent( 8748): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:45:26.462+0600 I/CAPI_APPFW_APPLICATION( 8748): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:45:26.462+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:45:26.462+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:45:26.462+0600 E/weather-agent( 8748): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:45:26.612+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:45:26.612+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8748
09-10 17:45:26.612+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[8748] terminate event is forwarded
09-10 17:45:26.612+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:45:26.612+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 8748, ]
09-10 17:45:26.612+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:45:26.612+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:45:26.612+0600 I/Tizen::App( 1366): (512) > Not registered pid(8748)
09-10 17:45:26.612+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:45:26.612+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:45:26.612+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 8748
09-10 17:45:26.612+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:45:26.622+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:45:26.622+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 8748.
09-10 17:45:29.314+0600 I/APP_CORE( 7911): appcore-efl.c: __do_app(520) > [APP 7911] Event: MEM_FLUSH State: PAUSED
09-10 17:45:31.466+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:45:50.195+0600 E/PKGMGR_SERVER( 8893): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:45:50.265+0600 E/PKGMGR  ( 8891): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 17:45:50.305+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:45:50.305+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 7911
09-10 17:45:50.305+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:45:50.305+0600 W/AUL     ( 8896): launch.c: app_request_to_launchpad(396) > request cmd(5) to(7911)
09-10 17:45:50.305+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 17:45:50.315+0600 I/APP_CORE( 7911): appcore-efl.c: __do_app(520) > [APP 7911] Event: TERMINATE State: PAUSED
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(7911), cmd(4)
09-10 17:45:50.315+0600 W/AUL     ( 8896): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:45:50.315+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 7911): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:45:50.315+0600 E/APP_CORE( 7911): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 17:45:50.315+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:45:50.315+0600 E/APP_CORE( 7911): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:45:50.315+0600 I/CAPI_APPFW_APPLICATION( 7911): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:45:50.325+0600 E/CAPI_NETWORK_BLUETOOTH( 7911): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:45:50.325+0600 E/PKGMGR_SERVER( 8893): pkgmgr-server.c: sighandler(417) > child NORMAL exit [8896]
09-10 17:45:50.385+0600 E/CAPI_NETWORK_BLUETOOTH( 7911): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:45:50.385+0600 E/CAPI_NETWORK_BLUETOOTH( 7911): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:45:50.385+0600 E/bluetooth( 7911): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:45:50.385+0600 I/CAPI_NETWORK_WIFI( 7911): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:45:50.395+0600 E/bluetooth( 7911): [wifi_deinitialize] Success.
09-10 17:45:50.425+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:45:50.425+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:45:50.425+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:45:50.425+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:45:50.425+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:45:50.435+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:45:50.435+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb773caf0), gem(23), surface(0xb7877090)
09-10 17:45:50.445+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:45:50.455+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb789f620), gem(18), surface(0xb78c5f58)
09-10 17:45:50.465+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77c98c0), gem(21), surface(0xb789f458)
09-10 17:45:50.465+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7837bc8), gem(14), surface(0xb78a7f18)
09-10 17:45:50.485+0600 E/EFL     ( 7911): elementary<7911> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 17:45:50.505+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb773caf0), gem(23), surface(0xb787e520)
09-10 17:45:50.655+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7911 pgid = 7911
09-10 17:45:50.655+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(7911)
09-10 17:45:50.745+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:45:50.745+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:45:50.745+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:45:50.755+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[7911] terminate event is forwarded
09-10 17:45:50.755+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:45:50.755+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 7911, ]
09-10 17:45:50.755+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:45:50.755+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:45:50.755+0600 I/Tizen::App( 1366): (512) > Not registered pid(7911)
09-10 17:45:50.755+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:45:50.755+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:45:50.755+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 7911
09-10 17:45:50.755+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7911
09-10 17:45:50.775+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:45:50.775+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:45:50.775+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 7911.
09-10 17:45:50.805+0600 W/CRASH_MANAGER( 8903): worker.c: worker_job(1199) > 1107911626162147350795
