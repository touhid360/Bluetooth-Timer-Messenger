S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 29014
Date: 2016-09-10 17:18:35+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 29014, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00007156
r2   = 0x00000006, r3   = 0xb448f4c0
r4   = 0x00000002, r5   = 0xb448f000
r6   = 0xb679409c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb69dc300
ip   = 0x00000000, sp   = 0xbee50f0c
lr   = 0xb668af18, pc   = 0xb6689b84
cpsr = 0x200d0010

Memory Information
MemTotal:   730440 KB
MemFree:     46124 KB
Buffers:     43892 KB
Cached:     294876 KB
VmPeak:     109916 KB
VmSize:     105032 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25600 KB
VmRSS:       25520 KB
VmData:      35128 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 29014 TID = 29014
29014 29019 29100 

Maps Information
b1d30000 b252f000 rw-p [stack:29100]
b252f000 b2540000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2550000 b2555000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25e1000 b25e9000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25fa000 b25fb000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b260b000 b261f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2633000 b2634000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2644000 b2647000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2658000 b2659000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2669000 b266b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b267b000 b267d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b268d000 b269d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26ad000 b26b9000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28ca000 b28e1000 r-xp /usr/lib/libnetwork.so.0.0.0
b28f2000 b2930000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2941000 b2948000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2959000 b2968000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2978000 b29ad000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29c0000 b29c6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29d6000 b29dd000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2afe000 b2be1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c18000 b2c40000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c52000 b3451000 rw-p [stack:29019]
b3451000 b3453000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3463000 b346d000 r-xp /lib/libnss_files-2.20-2014.11.so
b347e000 b3487000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3498000 b34a9000 r-xp /lib/libnsl-2.20-2014.11.so
b34bc000 b34c2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34d3000 b34d4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34fc000 b3503000 r-xp /usr/lib/libminizip.so.1.0.0
b3513000 b3518000 r-xp /usr/lib/libstorage.so.0.1
b3528000 b357d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3593000 b35a7000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35b7000 b35fb000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b360b000 b3613000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3623000 b3653000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3666000 b371f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3733000 b3787000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3798000 b37b3000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37c3000 b3884000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3897000 b38a9000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38b9000 b38bd000 r-xp /usr/lib/libogg.so.0.7.1
b38cd000 b38ef000 r-xp /usr/lib/libvorbis.so.0.4.3
b38ff000 b39e3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39ff000 b3a0c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a1d000 b3a60000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a75000 b3abc000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3acd000 b3ad3000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ae4000 b3aeb000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3afb000 b3b3b000 r-xp /usr/lib/libmdm.so.1.2.10
b3b4b000 b3b53000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b62000 b3b72000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b93000 b3bf3000 r-xp /usr/lib/libasound.so.2.0.0
b3c05000 b3c3b000 r-xp /usr/lib/libpulse.so.0.16.2
b3c4c000 b3c4f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c5f000 b3c62000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c72000 b3c77000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c87000 b3c88000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c98000 b3ca3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cb7000 b3cbe000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cce000 b3cd4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3ce4000 b3ce9000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cf9000 b3d14000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d24000 b3d2b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d3b000 b3d3e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d4f000 b3d7d000 r-xp /usr/lib/libidn.so.11.5.44
b3d8d000 b3da3000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3db4000 b3dbe000 r-xp /usr/lib/libcares.so.2.1.0
b3dce000 b3dd8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3de8000 b3dea000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dfa000 b3dfb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e0b000 b3e0f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e20000 b3e48000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e59000 b3e82000 r-xp /usr/lib/libturbojpeg.so
b3ea2000 b3ea8000 r-xp /usr/lib/libgif.so.4.1.6
b3eb8000 b3efe000 r-xp /usr/lib/libcurl.so.4.3.0
b3f0f000 b3f30000 r-xp /usr/lib/libexif.so.12.3.3
b3f4b000 b3f60000 r-xp /usr/lib/libtts.so
b3f71000 b3f79000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f89000 b4049000 r-xp /usr/lib/libdali-core.so.0.0.0
b4054000 b4147000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4167000 b4241000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4258000 b425a000 r-xp /usr/lib/libboost_system.so.1.51.0
b426a000 b4270000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4280000 b42a3000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42b4000 b42b6000 r-xp /usr/lib/libappsvc.so.0.1.0
b42c6000 b42c8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42d9000 b42de000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42f5000 b42f7000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4307000 b430e000 r-xp /usr/lib/libsensord-share.so
b431e000 b4336000 r-xp /usr/lib/libsensor.so.1.1.0
b4347000 b434a000 r-xp /usr/lib/libXv.so.1.0.0
b435a000 b435f000 r-xp /usr/lib/libutilX.so.1.1.0
b436f000 b4374000 r-xp /usr/lib/libappcore-common.so.1.1
b4384000 b438b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b439e000 b43a2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43b3000 b447d000 r-xp /usr/lib/libCOREGL.so.4.0
b4494000 b4497000 r-xp /usr/lib/libuuid.so.1.3.0
b44a8000 b44bf000 r-xp /usr/lib/libblkid.so.1.1.0
b44d0000 b44d2000 r-xp /usr/lib/libXau.so.6.0.0
b44e2000 b44e5000 r-xp /usr/lib/libEGL.so.1.4
b44ed000 b44f3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4503000 b4505000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4516000 b4524000 r-xp /usr/lib/libGLESv2.so.2.0
b452d000 b458f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45a4000 b45bc000 r-xp /usr/lib/libmount.so.1.1.0
b45cd000 b45e1000 r-xp /usr/lib/libxcb.so.1.1.0
b45f2000 b45f9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4631000 b4642000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4653000 b4655000 r-xp /usr/lib/libiri.so
b4665000 b4670000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4681000 b4696000 r-xp /lib/libexpat.so.1.5.2
b46a8000 b4766000 r-xp /usr/lib/libcairo.so.2.11200.14
b4779000 b4781000 r-xp /usr/lib/libdrm.so.2.4.0
b4791000 b4794000 r-xp /usr/lib/libdri2.so.0.0.0
b47a5000 b47f3000 r-xp /usr/lib/libssl.so.1.0.0
b4808000 b4814000 r-xp /usr/lib/libeeze.so.1.13.0
b4824000 b482d000 r-xp /usr/lib/libethumb.so.1.13.0
b483d000 b4840000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4850000 b4a07000 r-xp /usr/lib/libcrypto.so.1.0.0
b565e000 b5667000 r-xp /usr/lib/libXi.so.6.1.0
b5677000 b5679000 r-xp /usr/lib/libXgesture.so.7.0.0
b5689000 b568d000 r-xp /usr/lib/libXtst.so.6.1.0
b569d000 b56a3000 r-xp /usr/lib/libXrender.so.1.3.0
b56b3000 b56b9000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ca000 b56cc000 r-xp /usr/lib/libXinerama.so.1.0.0
b56dc000 b56df000 r-xp /usr/lib/libXfixes.so.3.1.0
b56ef000 b56fa000 r-xp /usr/lib/libXext.so.6.4.0
b570a000 b570c000 r-xp /usr/lib/libXdamage.so.1.1.0
b571c000 b571e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b572f000 b5811000 r-xp /usr/lib/libX11.so.6.3.0
b5824000 b582b000 r-xp /usr/lib/libXcursor.so.1.0.2
b583b000 b5853000 r-xp /usr/lib/libudev.so.1.6.0
b5855000 b5858000 r-xp /lib/libattr.so.1.1.0
b5868000 b5888000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b588a000 b588f000 r-xp /usr/lib/libffi.so.6.0.2
b589f000 b58b7000 r-xp /lib/libz.so.1.2.8
b58c7000 b58c9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d9000 b59ae000 r-xp /usr/lib/libxml2.so.2.9.2
b59c3000 b5a5e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a7a000 b5a7d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a8d000 b5aa6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ab7000 b5ac8000 r-xp /lib/libresolv-2.20-2014.11.so
b5adc000 b5b56000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b6b000 b5b6d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b7d000 b5b84000 r-xp /usr/lib/libembryo.so.1.13.0
b5b94000 b5bac000 r-xp /usr/lib/libpng12.so.0.50.0
b5bbd000 b5be0000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c01000 b5c15000 r-xp /usr/lib/libector.so.1.13.0
b5c26000 b5c3e000 r-xp /usr/lib/liblua-5.1.so
b5c4f000 b5ca6000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cba000 b5ce2000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cf3000 b5d06000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d17000 b5d4e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d5f000 b5d6d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d7d000 b5d85000 r-xp /usr/lib/libtbm.so.1.0.0
b5d95000 b5da2000 r-xp /usr/lib/libeio.so.1.13.0
b5db2000 b5db4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc4000 b5dc9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd9000 b5df0000 r-xp /usr/lib/libefreet.so.1.13.0
b5e02000 b5e22000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e32000 b5e52000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e54000 b5e5a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e6a000 b5e7b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e8c000 b5e93000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea3000 b5eb2000 r-xp /usr/lib/libeo.so.1.13.0
b5ec3000 b5ed5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee6000 b5eeb000 r-xp /usr/lib/libecore_file.so.1.13.0
b5efb000 b5f14000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f24000 b5f41000 r-xp /usr/lib/libeet.so.1.13.0
b5f5a000 b5fa2000 r-xp /usr/lib/libeina.so.1.13.0
b5fb3000 b5fc3000 r-xp /usr/lib/libefl.so.1.13.0
b5fd4000 b60b9000 r-xp /usr/lib/libicuuc.so.51.1
b60d6000 b6216000 r-xp /usr/lib/libicui18n.so.51.1
b622d000 b6265000 r-xp /usr/lib/libecore_x.so.1.13.0
b6277000 b627a000 r-xp /lib/libcap.so.2.21
b628a000 b62b3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c4000 b62cb000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62dd000 b6314000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6325000 b6410000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6423000 b649c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ae000 b64b3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c3000 b64cd000 r-xp /usr/lib/libvconf.so.0.2.45
b64dd000 b64df000 r-xp /usr/lib/libvasum.so.0.3.1
b64ef000 b64f1000 r-xp /usr/lib/libttrace.so.1.1
b6501000 b6504000 r-xp /usr/lib/libiniparser.so.0
b6514000 b653a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b654a000 b654f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6560000 b6577000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6588000 b65f3000 r-xp /lib/libm-2.20-2014.11.so
b6604000 b660a000 r-xp /lib/librt-2.20-2014.11.so
b661b000 b6628000 r-xp /usr/lib/libunwind.so.8.0.1
b665e000 b6782000 r-xp /lib/libc-2.20-2014.11.so
b6797000 b67b0000 r-xp /lib/libgcc_s-4.9.so.1
b67c0000 b68a2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b3000 b68dd000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ee000 b692a000 r-xp /usr/lib/libsystemd.so.0.4.0
b692c000 b69ae000 r-xp /usr/lib/libedje.so.1.13.0
b69c1000 b69df000 r-xp /usr/lib/libecore.so.1.13.0
b69ff000 b6b86000 r-xp /usr/lib/libevas.so.1.13.0
b6bbb000 b6bcf000 r-xp /lib/libpthread-2.20-2014.11.so
b6be3000 b6e18000 r-xp /usr/lib/libelementary.so.1.13.0
b6e46000 b6e4a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e5a000 b6e61000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e71000 b6e73000 r-xp /usr/lib/libdlog.so.0.0.0
b6e83000 b6e86000 r-xp /usr/lib/libbundle.so.0.1.22
b6e96000 b6e98000 r-xp /lib/libdl-2.20-2014.11.so
b6ea9000 b6ec1000 r-xp /usr/lib/libaul.so.0.1.0
b6ed5000 b6eda000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eeb000 b6ef8000 r-xp /usr/lib/liblptcp.so
b6f0a000 b6f0e000 r-xp /usr/lib/libsys-assert.so
b6f1f000 b6f3f000 r-xp /lib/ld-2.20-2014.11.so
b6f50000 b6f55000 r-xp /usr/bin/launchpad-loader
b82a9000 b863a000 rw-p [heap]
bee31000 bee52000 rw-p [stack]
b82a9000 b863a000 rw-p [heap]
bee31000 bee52000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29014)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6689b84) [/lib/libc.so.6] + 0x2bb84
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
easymode : check retry err (-21/2).
09-10 17:14:44.585+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:14:44.585+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:14:44.585+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:14:44.595+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_helper_event(2262) > [0;33mXT9_CMD_INPUTMODE value = 14[0m
09-10 17:14:44.595+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:14:44.595+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/homescreen/easymode
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_check_retry_err(1368) > db/setting/homescreen/easymode : check retry err (-21/2).
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
09-10 17:14:44.635+0600 E/VCONF   (  821): vconf.c: vconf_get_bool(2729) > vconf_get_bool(821) : db/setting/homescreen/easymode error
09-10 17:14:45.425+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16848974
09-10 17:14:45.425+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16848974
09-10 17:14:45.455+0600 I/MALI    (  821): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:14:45.465+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77d4b90), gem(30), surface(0xb78b6098)
09-10 17:14:45.505+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16849069
09-10 17:14:45.516+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:14:45.516+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:14:45.516+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:14:45.516+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 17:14:45.516+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:14:45.586+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16849146
09-10 17:14:45.586+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16849146
09-10 17:14:45.676+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16849229
09-10 17:14:45.676+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:14:45.676+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:14:45.676+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:14:45.676+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 17:14:45.676+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:14:46.116+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16849674
09-10 17:14:46.116+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16849674
09-10 17:14:46.126+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:14:46.126+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:14:46.126+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
09-10 17:14:46.126+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=7[0m
09-10 17:14:46.126+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:14:46.236+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16849789
09-10 17:14:46.667+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16850223
09-10 17:14:46.667+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16850223
09-10 17:14:46.747+0600 E/EFL     (  821): ecore_x<821> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16850306
09-10 17:14:46.757+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
09-10 17:14:46.757+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
09-10 17:14:46.757+0600 W/IME_LITE(  734): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
09-10 17:14:46.757+0600 I/ISE_MULTI(  821): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=8[0m
09-10 17:14:46.757+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
09-10 17:14:47.387+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16850865
09-10 17:14:47.387+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16850940
09-10 17:14:47.387+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:14:47.387+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
09-10 17:14:47.397+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5200002 FAILED!
09-10 17:14:47.457+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78950c0), gem(18), surface(0xb78a2f18)
09-10 17:14:47.457+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
09-10 17:14:47.457+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78a1258), gem(21), surface(0xb78ba300)
09-10 17:14:49.139+0600 E/EFL     (29014): eo<29014> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb82ead80 is not pointing to a valid object. Maybe it has already been freed.
09-10 17:14:49.139+0600 E/EFL     (29014): eo<29014> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb82ead80) is an invalid ref.
09-10 17:14:52.112+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16855663
09-10 17:14:52.192+0600 E/EFL     (29014): ecore_x<29014> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16855735
09-10 17:14:52.192+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:14:52.192+0600 I/ISE_MULTI(  821): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:true][0m
09-10 17:14:52.192+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:14:52.192+0600 I/IME_LITE(  734): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
09-10 17:14:56.496+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 17:14:57.467+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 17:14:57.477+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 17:14:57.477+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:14:57.477+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:14:57.477+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:14:57.477+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:14:57.477+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:15:00.460+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 17:15:00.470+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 17:15:00.470+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:15:00.470+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:15:00.470+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:15:00.470+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:15:00.470+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:15:00.610+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 17:15:00.610+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 5:15 p.m.
09-10 17:15:00.610+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 5:15 p.m."
09-10 17:15:00.610+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 5:15 p.m."
09-10 17:15:00.610+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 17:15:00.610+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145767081 Time: <font_size=31> </font_size> <font_size=31> 5:15 p.m.</font_size></font>"
09-10 17:15:15.124+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 17:15:22.121+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:15:22.121+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:15:22.151+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 17:15:22.151+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 17:15:22.151+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 17:15:22.151+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:13930d0
09-10 17:15:22.151+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 17:15:22.151+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 17:15:22.161+0600 W/APP_CORE(29014): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 17:15:22.161+0600 I/APP_CORE(29014): appcore-efl.c: __do_app(520) > [APP 29014] Event: PAUSE State: RUNNING
09-10 17:15:22.161+0600 I/CAPI_APPFW_APPLICATION(29014): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:15:22.161+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:15:22.161+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 17:15:22.171+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:15:22.171+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:15:22.171+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 17:15:22.231+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 17:15:22.692+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb781d268), gem(14), surface(0xb78ae1a0)
09-10 17:15:22.702+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:15:22.702+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:15:22.702+0600 I/APP_CORE(29014): appcore-efl.c: __do_app(520) > [APP 29014] Event: PAUSE State: PAUSED
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 17:15:22.712+0600 I/TIZEN_N_EFL_UTIL_WINDOW(29014): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 6
09-10 17:15:22.712+0600 E/APP_CORE(29014): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 17:15:22.712+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 17:15:22.712+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 17:15:22.712+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 17:15:22.722+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:15:22.722+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:15:22.722+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 17:15:22.722+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 17:15:22.752+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 17:15:22.752+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776c550), gem(18), surface(0xb787e520)
09-10 17:15:22.762+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:15:22.762+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:15:22.762+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:15:22.762+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:15:22.762+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:15:22.762+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:15:22.762+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 17:15:22.762+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 17:15:22.762+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(29014) status(4)
09-10 17:15:22.762+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(29014)
09-10 17:15:22.762+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 29014, appid: org.example.bluetooth, status: bg
09-10 17:15:22.772+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:15:22.772+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:15:22.772+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:15:22.782+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 17:15:22.802+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 17:15:22.812+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 17:15:22.812+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:15:22.822+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 17:15:22.822+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 17:15:22.822+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 17:15:22.822+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 17:15:22.822+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 17:15:22.822+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 17:15:22.832+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7706ae8), gem(15), surface(0xb7833af8)
09-10 17:15:22.832+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:15:22.842+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 17:15:22.842+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:15:22.842+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:15:22.842+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:15:22.842+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:15:22.842+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:15:22.842+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 17:15:22.852+0600 I/TIZEN_N_SOUND_MANAGER(28857): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 17:15:22.852+0600 E/TIZEN_N_SOUND_MANAGER(28857): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:15:22.852+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:15:22.852+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 17:15:22.852+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 17:15:22.862+0600 I/TIZEN_N_SOUND_MANAGER(28857): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 17:15:22.862+0600 E/TIZEN_N_SOUND_MANAGER(28857): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:15:22.862+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 17:15:22.862+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:15:22.862+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 17:15:22.862+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:15:22.862+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 29961
09-10 17:15:22.872+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:15:22.912+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 29961
09-10 17:15:22.912+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 29961, appid: com.samsung.weather-m-agent
09-10 17:15:22.912+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(29961)
09-10 17:15:22.922+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:15:22.962+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 17:15:22.962+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 29961.
09-10 17:15:23.002+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77b2c80), gem(19), surface(0xb78a5590)
09-10 17:15:23.162+0600 E/weather-agent(29961): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 17:15:23.162+0600 E/weather-common(29961): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 17:15:23.162+0600 E/weather-agent(29961): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 17:15:23.182+0600 I/MESSAGE_PORT(29961): message-port.c: __initialize(872) > initialize
09-10 17:15:23.192+0600 I/MESSAGE_PORT(29961): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 17:15:23.232+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:15:23.232+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:15:23.232+0600 I/MESSAGE_PORT(29961): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:15:23.232+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 17:15:23.232+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 17:15:23.232+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:15:23.232+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:15:23.232+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 17:15:23.232+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:15:23.242+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:15:23.242+0600 E/MESSAGE_PORT(29961): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 17:15:23.242+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 17:15:23.242+0600 I/MESSAGE_PORT(29961): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:15:23.242+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:15:23.252+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:15:23.252+0600 E/MESSAGE_PORT(29961): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 17:15:23.252+0600 E/weather-common(29961): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 17:15:23.252+0600 E/weather-agent(29961): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 17:15:23.252+0600 E/weather-agent(29961): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 17:15:23.252+0600 I/MESSAGE_PORT(29961): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:15:23.252+0600 I/MESSAGE_PORT(29961): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:15:23.272+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:15:23.312+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 17:15:23.312+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 17:15:23.483+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83e83c0]
09-10 17:15:23.483+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 17:15:23.483+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83e83c0
09-10 17:15:23.483+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 17:15:23.493+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:15:23.493+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:15:23.513+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:15:23.513+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:15:23.533+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:15:23.563+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80180437 is not stable during recalc loop
09-10 17:15:23.633+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80180437 is not stable during recalc loop
09-10 17:15:23.633+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:15:23.643+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:15:24.253+0600 E/weather-agent(29961): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:15:24.253+0600 I/CAPI_APPFW_APPLICATION(29961): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:15:24.253+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:15:24.253+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:15:24.253+0600 E/weather-agent(29961): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:15:24.393+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:15:24.393+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 29961
09-10 17:15:24.393+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[29961] terminate event is forwarded
09-10 17:15:24.393+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:15:24.393+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 29961, ]
09-10 17:15:24.393+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:15:24.393+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:15:24.393+0600 I/Tizen::App( 1366): (512) > Not registered pid(29961)
09-10 17:15:24.393+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:15:24.393+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:15:24.393+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 29961
09-10 17:15:24.403+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:15:24.403+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 29961.
09-10 17:15:27.166+0600 I/APP_CORE(29014): appcore-efl.c: __do_app(520) > [APP 29014] Event: MEM_FLUSH State: PAUSED
09-10 17:15:29.258+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:17:39.535+0600 I/CAPI_CONTENT_MEDIA_CONTENT(28857): media_content.c: media_content_disconnect(940) > [32m[28857]ref count changed to: 0
09-10 17:17:39.535+0600 I/CAPI_NETWORK_WIFI(28857): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:17:39.555+0600 E/ALARM_MANAGER(28857): alarm-lib-stub.c: _send_alarm_delete_all(434) > alarm_manager_call_alarm_delete_all_sync() failed. return_code[0]
09-10 17:17:39.555+0600 E/ALARM_MANAGER(28857): alarm-lib-stub.c: _send_alarm_delete_all(436) > dbus error message: The connection is closed
09-10 17:18:34.739+0600 E/PKGMGR_SERVER(30836): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:18:34.809+0600 E/PKGMGR  (30834): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 17:18:34.849+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:18:34.849+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 29014
09-10 17:18:34.849+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:18:34.859+0600 W/AUL     (30839): launch.c: app_request_to_launchpad(396) > request cmd(5) to(29014)
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(29014), cmd(4)
09-10 17:18:34.859+0600 W/AUL     (30839): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 29014
09-10 17:18:34.859+0600 I/APP_CORE(29014): appcore-efl.c: __do_app(520) > [APP 29014] Event: TERMINATE State: PAUSED
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:18:34.859+0600 I/TIZEN_N_EFL_UTIL_WINDOW(29014): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:18:34.859+0600 E/APP_CORE(29014): appcore-efl.c: _capture_and_make_file(1631) > win[5200002] widget[480] height[800]
09-10 17:18:34.859+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:18:34.859+0600 E/APP_CORE(29014): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:18:34.859+0600 I/CAPI_APPFW_APPLICATION(29014): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:18:34.869+0600 E/CAPI_NETWORK_BLUETOOTH(29014): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:18:34.949+0600 E/CAPI_NETWORK_BLUETOOTH(29014): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:18:34.949+0600 E/CAPI_NETWORK_BLUETOOTH(29014): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:18:34.949+0600 E/bluetooth(29014): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:18:34.959+0600 I/CAPI_NETWORK_WIFI(29014): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:18:34.959+0600 E/bluetooth(29014): [wifi_deinitialize] Success.
09-10 17:18:34.959+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:18:34.959+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 17:18:34.969+0600 E/PKGMGR_SERVER(30836): pkgmgr-server.c: sighandler(417) > child NORMAL exit [30839]
09-10 17:18:34.979+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:18:34.979+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:18:34.979+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:18:34.979+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:18:34.979+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:18:34.989+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:18:35.009+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78865b8), gem(22), surface(0xb78ba300)
09-10 17:18:35.009+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:18:35.029+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb779ad00), gem(13), surface(0xb78a7f18)
09-10 17:18:35.039+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b2c80), gem(19), surface(0xb78a7188)
09-10 17:18:35.049+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7706ae8), gem(15), surface(0xb78b9638)
09-10 17:18:35.059+0600 E/EFL     (29014): ecore<29014> lib/ecore/ecore_main.c:1552 _ecore_main_fd_handlers_bads_rem() Removing bad fds
09-10 17:18:35.059+0600 E/EFL     (29014): ecore<29014> lib/ecore/ecore_main.c:1561 _ecore_main_fd_handlers_bads_rem() Found bad fd at index 23
09-10 17:18:35.059+0600 E/EFL     (29014): ecore<29014> lib/ecore/ecore_main.c:1564 _ecore_main_fd_handlers_bads_rem() Fd set for error! calling user
09-10 17:18:35.099+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78865b8), gem(22), surface(0xb787e520)
09-10 17:18:35.230+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 29014 pgid = 29014
09-10 17:18:35.230+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(29014)
09-10 17:18:35.310+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:18:35.310+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:18:35.310+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:18:35.320+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[29014] terminate event is forwarded
09-10 17:18:35.320+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:18:35.320+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 29014, ]
09-10 17:18:35.320+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:18:35.320+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:18:35.320+0600 I/Tizen::App( 1366): (512) > Not registered pid(29014)
09-10 17:18:35.320+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:18:35.320+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:18:35.320+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 29014
09-10 17:18:35.320+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 29014
09-10 17:18:35.330+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2545
09-10 17:18:35.350+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:18:35.350+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 29014.
09-10 17:18:35.390+0600 W/CRASH_MANAGER(30848): worker.c: worker_job(1199) > 0629014626162147350631
