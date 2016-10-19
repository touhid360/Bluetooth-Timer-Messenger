S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 16792
Date: 2016-09-10 16:31:57+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16792, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb73abee8
r2   = 0xb438d000, r3   = 0xb438d000
r4   = 0xbed635bc, r5   = 0xb6a8c0f4
r6   = 0xb6a8b310, r7   = 0xbed6341c
r8   = 0xb6a8c0f4, r9   = 0xb6a8c0f4
r10  = 0xb6a9a20c, fp   = 0x00000000
ip   = 0xb2a80d24, sp   = 0xbed62798
lr   = 0xb2a761c7, pc   = 0xb676f6f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     48340 KB
Buffers:     43240 KB
Cached:     290488 KB
VmPeak:     106880 KB
VmSize:     103524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25784 KB
VmRSS:       25784 KB
VmData:      35112 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36224 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 16792 TID = 16792
16792 16796 16916 

Maps Information
b1dcb000 b25ca000 rw-p [stack:16916]
b25ca000 b25db000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25eb000 b25f0000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b267c000 b2684000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2695000 b2696000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b26a6000 b26ba000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26ce000 b26cf000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26df000 b26e2000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26f3000 b26f4000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2704000 b2706000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2716000 b2718000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2728000 b2738000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2748000 b2754000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2965000 b297c000 r-xp /usr/lib/libnetwork.so.0.0.0
b298d000 b29cb000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29dc000 b29e3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29f4000 b2a03000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a13000 b2a48000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a5b000 b2a61000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a71000 b2a79000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b9a000 b2c7d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2cb4000 b2cdc000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cee000 b34ed000 rw-p [stack:16796]
b34ed000 b34ef000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34ff000 b3509000 r-xp /lib/libnss_files-2.20-2014.11.so
b351a000 b3523000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3534000 b3545000 r-xp /lib/libnsl-2.20-2014.11.so
b3558000 b355e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b356f000 b3570000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3598000 b359f000 r-xp /usr/lib/libminizip.so.1.0.0
b35af000 b35b4000 r-xp /usr/lib/libstorage.so.0.1
b35c4000 b3619000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b362f000 b3643000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3653000 b3697000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b36a7000 b36af000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36bf000 b36ef000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3702000 b37bb000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37cf000 b3823000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3834000 b384f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b385f000 b3920000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3933000 b3945000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3955000 b3959000 r-xp /usr/lib/libogg.so.0.7.1
b3969000 b398b000 r-xp /usr/lib/libvorbis.so.0.4.3
b399b000 b3a7f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a9b000 b3aa8000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3ab9000 b3afc000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b11000 b3b58000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b69000 b3b6f000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b80000 b3b87000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b97000 b3bd7000 r-xp /usr/lib/libmdm.so.1.2.10
b3be7000 b3bef000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bfe000 b3c0e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c2f000 b3c8f000 r-xp /usr/lib/libasound.so.2.0.0
b3ca1000 b3cd7000 r-xp /usr/lib/libpulse.so.0.16.2
b3ce8000 b3ceb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cfb000 b3cfe000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d0e000 b3d13000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d23000 b3d24000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d34000 b3d3f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d53000 b3d5a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d6a000 b3d70000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d80000 b3d85000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d95000 b3db0000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3dc0000 b3dc7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dd7000 b3dda000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3deb000 b3e19000 r-xp /usr/lib/libidn.so.11.5.44
b3e29000 b3e3f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e50000 b3e5a000 r-xp /usr/lib/libcares.so.2.1.0
b3e6a000 b3e74000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e84000 b3e86000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e96000 b3e97000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3ea7000 b3eab000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3ebc000 b3ee4000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ef5000 b3f1e000 r-xp /usr/lib/libturbojpeg.so
b3f3e000 b3f44000 r-xp /usr/lib/libgif.so.4.1.6
b3f54000 b3f9a000 r-xp /usr/lib/libcurl.so.4.3.0
b3fab000 b3fcc000 r-xp /usr/lib/libexif.so.12.3.3
b3fe7000 b3ffc000 r-xp /usr/lib/libtts.so
b400d000 b4015000 r-xp /usr/lib/libfeedback.so.0.1.4
b4025000 b40e5000 r-xp /usr/lib/libdali-core.so.0.0.0
b40f0000 b41e3000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4203000 b42dd000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42f4000 b42f6000 r-xp /usr/lib/libboost_system.so.1.51.0
b4306000 b430c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b431c000 b433f000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4350000 b4352000 r-xp /usr/lib/libappsvc.so.0.1.0
b4362000 b4364000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4375000 b437a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4391000 b4393000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b43a3000 b43aa000 r-xp /usr/lib/libsensord-share.so
b43ba000 b43d2000 r-xp /usr/lib/libsensor.so.1.1.0
b43e3000 b43e6000 r-xp /usr/lib/libXv.so.1.0.0
b43f6000 b43fb000 r-xp /usr/lib/libutilX.so.1.1.0
b440b000 b4410000 r-xp /usr/lib/libappcore-common.so.1.1
b4420000 b4427000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b443a000 b443e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b444f000 b4519000 r-xp /usr/lib/libCOREGL.so.4.0
b4530000 b4533000 r-xp /usr/lib/libuuid.so.1.3.0
b4544000 b455b000 r-xp /usr/lib/libblkid.so.1.1.0
b456c000 b456e000 r-xp /usr/lib/libXau.so.6.0.0
b457e000 b4581000 r-xp /usr/lib/libEGL.so.1.4
b4589000 b458f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b459f000 b45a1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45b2000 b45c0000 r-xp /usr/lib/libGLESv2.so.2.0
b45c9000 b462b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4640000 b4658000 r-xp /usr/lib/libmount.so.1.1.0
b4669000 b467d000 r-xp /usr/lib/libxcb.so.1.1.0
b468e000 b4695000 r-xp /lib/libcrypt-2.20-2014.11.so
b46cd000 b46de000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46ef000 b46f1000 r-xp /usr/lib/libiri.so
b4701000 b470c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b471d000 b4732000 r-xp /lib/libexpat.so.1.5.2
b4744000 b4802000 r-xp /usr/lib/libcairo.so.2.11200.14
b4815000 b481d000 r-xp /usr/lib/libdrm.so.2.4.0
b482d000 b4830000 r-xp /usr/lib/libdri2.so.0.0.0
b4841000 b488f000 r-xp /usr/lib/libssl.so.1.0.0
b48a4000 b48b0000 r-xp /usr/lib/libeeze.so.1.13.0
b48c0000 b48c9000 r-xp /usr/lib/libethumb.so.1.13.0
b48d9000 b48dc000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48ec000 b4aa3000 r-xp /usr/lib/libcrypto.so.1.0.0
b56fa000 b5703000 r-xp /usr/lib/libXi.so.6.1.0
b5713000 b5715000 r-xp /usr/lib/libXgesture.so.7.0.0
b5725000 b5729000 r-xp /usr/lib/libXtst.so.6.1.0
b5739000 b573f000 r-xp /usr/lib/libXrender.so.1.3.0
b574f000 b5755000 r-xp /usr/lib/libXrandr.so.2.2.0
b5766000 b5768000 r-xp /usr/lib/libXinerama.so.1.0.0
b5778000 b577b000 r-xp /usr/lib/libXfixes.so.3.1.0
b578b000 b5796000 r-xp /usr/lib/libXext.so.6.4.0
b57a6000 b57a8000 r-xp /usr/lib/libXdamage.so.1.1.0
b57b8000 b57ba000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57cb000 b58ad000 r-xp /usr/lib/libX11.so.6.3.0
b58c0000 b58c7000 r-xp /usr/lib/libXcursor.so.1.0.2
b58d7000 b58ef000 r-xp /usr/lib/libudev.so.1.6.0
b58f1000 b58f4000 r-xp /lib/libattr.so.1.1.0
b5904000 b5924000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5926000 b592b000 r-xp /usr/lib/libffi.so.6.0.2
b593b000 b5953000 r-xp /lib/libz.so.1.2.8
b5963000 b5965000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5975000 b5a4a000 r-xp /usr/lib/libxml2.so.2.9.2
b5a5f000 b5afa000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b16000 b5b19000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b29000 b5b42000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b53000 b5b64000 r-xp /lib/libresolv-2.20-2014.11.so
b5b78000 b5bf2000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5c07000 b5c09000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c19000 b5c20000 r-xp /usr/lib/libembryo.so.1.13.0
b5c30000 b5c48000 r-xp /usr/lib/libpng12.so.0.50.0
b5c59000 b5c7c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9d000 b5cb1000 r-xp /usr/lib/libector.so.1.13.0
b5cc2000 b5cda000 r-xp /usr/lib/liblua-5.1.so
b5ceb000 b5d42000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d56000 b5d7e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d8f000 b5da2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db3000 b5dea000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dfb000 b5e09000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e19000 b5e21000 r-xp /usr/lib/libtbm.so.1.0.0
b5e31000 b5e3e000 r-xp /usr/lib/libeio.so.1.13.0
b5e4e000 b5e50000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e60000 b5e65000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e75000 b5e8c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e9e000 b5ebe000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ece000 b5eee000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef0000 b5ef6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f06000 b5f17000 r-xp /usr/lib/libemotion.so.1.13.0
b5f28000 b5f2f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f3f000 b5f4e000 r-xp /usr/lib/libeo.so.1.13.0
b5f5f000 b5f71000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f82000 b5f87000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f97000 b5fb0000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc0000 b5fdd000 r-xp /usr/lib/libeet.so.1.13.0
b5ff6000 b603e000 r-xp /usr/lib/libeina.so.1.13.0
b604f000 b605f000 r-xp /usr/lib/libefl.so.1.13.0
b6070000 b6155000 r-xp /usr/lib/libicuuc.so.51.1
b6172000 b62b2000 r-xp /usr/lib/libicui18n.so.51.1
b62c9000 b6301000 r-xp /usr/lib/libecore_x.so.1.13.0
b6313000 b6316000 r-xp /lib/libcap.so.2.21
b6326000 b634f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6360000 b6367000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6379000 b63b0000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c1000 b64ac000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64bf000 b6538000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654a000 b654f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b655f000 b6569000 r-xp /usr/lib/libvconf.so.0.2.45
b6579000 b657b000 r-xp /usr/lib/libvasum.so.0.3.1
b658b000 b658d000 r-xp /usr/lib/libttrace.so.1.1
b659d000 b65a0000 r-xp /usr/lib/libiniparser.so.0
b65b0000 b65d6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e6000 b65eb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65fc000 b6613000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6624000 b668f000 r-xp /lib/libm-2.20-2014.11.so
b66a0000 b66a6000 r-xp /lib/librt-2.20-2014.11.so
b66b7000 b66c4000 r-xp /usr/lib/libunwind.so.8.0.1
b66fa000 b681e000 r-xp /lib/libc-2.20-2014.11.so
b6833000 b684c000 r-xp /lib/libgcc_s-4.9.so.1
b685c000 b693e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b694f000 b6979000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698a000 b69c6000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c8000 b6a4a000 r-xp /usr/lib/libedje.so.1.13.0
b6a5d000 b6a7b000 r-xp /usr/lib/libecore.so.1.13.0
b6a9b000 b6c22000 r-xp /usr/lib/libevas.so.1.13.0
b6c57000 b6c6b000 r-xp /lib/libpthread-2.20-2014.11.so
b6c7f000 b6eb4000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee2000 b6ee6000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef6000 b6efd000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f0d000 b6f0f000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1f000 b6f22000 r-xp /usr/lib/libbundle.so.0.1.22
b6f32000 b6f34000 r-xp /lib/libdl-2.20-2014.11.so
b6f45000 b6f5d000 r-xp /usr/lib/libaul.so.0.1.0
b6f71000 b6f76000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f87000 b6f94000 r-xp /usr/lib/liblptcp.so
b6fa6000 b6faa000 r-xp /usr/lib/libsys-assert.so
b6fbb000 b6fdb000 r-xp /lib/ld-2.20-2014.11.so
b6fec000 b6ff1000 r-xp /usr/bin/launchpad-loader
b733e000 b76d2000 rw-p [heap]
bed43000 bed64000 rw-p [stack]
b733e000 b76d2000 rw-p [heap]
bed43000 bed64000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16792)
Call Stack Count: 1
 0: (0xb676f6f0) [/lib/libc.so.6] + 0x756f0
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
b(1281) > trigger_at_time(30), start(10-9-2016, 16:32:20), repeat(0), interval(0), type(-1073741822)
09-10 16:31:49.746+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 16:31:49.746+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 16:31:49.746+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 16:31:49.746+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:31:49.746+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 16:31:49.756+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:49.766+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:49.766+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:31:49.766+0600 W/AUL     (  622): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.keepit-service-standby)
09-10 16:31:49.777+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:49.777+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_wifi_state(739) > Wi-Fi state: 2
09-10 16:31:49.787+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:49.787+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:31:49.787+0600 E/AUL_AMD (  648): amd_request.c: __request_handler(940) > no appinfo
09-10 16:31:49.787+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 20
09-10 16:31:49.787+0600 W/AUL     (  622): launch.c: app_request_to_launchpad(425) > request cmd(0) result(-13)
09-10 16:31:49.787+0600 W/AUL     (  622): launch.c: app_request_to_launchpad(396) > request cmd(0) to(net.netpopup)
09-10 16:31:49.797+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/net-config, ret : 0
09-10 16:31:49.807+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/net-config, ret : 0
09-10 16:31:49.807+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:31:49.807+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 622
09-10 16:31:49.807+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2531) > no appinfo
09-10 16:31:49.807+0600 E/AUL_AMD (  648): amd_launch.c: __real_send(1012) > send fail to client: -122
09-10 16:31:49.807+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 38
09-10 16:31:49.807+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
09-10 16:31:49.807+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
09-10 16:31:49.807+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:31:49.807+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1473503540, Sat Sep 10 16:32:20 2016
09-10 16:31:49.807+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 43958932, next duetime: 1473503540
09-10 16:31:49.807+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(43958932)
09-10 16:31:49.807+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1473507109), due_time(1473503540)
09-10 16:31:49.807+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 16:31:49.807+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 10:32:20 (UTC).
09-10 16:31:49.807+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 16:31:49.817+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/net-config, ret : 0
09-10 16:31:49.827+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/net-config, ret : 0
09-10 16:31:49.827+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:31:49.827+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 622
09-10 16:31:49.827+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:31:49.827+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:31:49.827+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:31:49.827+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:31:49.827+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for net.netpopup has already loaded
09-10 16:31:49.827+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:31:49.827+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:31:49.827+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:31:49.827+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:31:49.847+0600 I/CAPI_APPFW_APPLICATION(16920): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:31:49.847+0600 I/CAPI_APPFW_APPLICATION(16920): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:31:49.847+0600 I/APP_CORE(16920): appcore-efl.c: __do_app(520) > [APP 16920] Event: RESET State: CREATED
09-10 16:31:49.847+0600 I/CAPI_APPFW_APPLICATION(16920): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:31:49.877+0600 I/CAPI_APPFW_APPLICATION(16920): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:31:49.927+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 16920, appid: net.netpopup
09-10 16:31:49.927+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:31:49.937+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:31:49.937+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:31:49.947+0600 W/AUL     (  622): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16920)
09-10 16:31:49.947+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 16:31:49.947+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:31:49.947+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:31:49.947+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 16:31:49.947+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:31:49.947+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 16:31:49.977+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : net.netpopup
09-10 16:31:49.987+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(742) > state: CONFIGURATION
09-10 16:31:50.007+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(670) > Connection open error NONE
09-10 16:31:50.007+0600 W/INDICATOR(  685): toast_popup.c: _post_toast_message_callback(217) > [Connected to Wi-Fi network BaBu.][0]
09-10 16:31:50.167+0600 I/MALI    (  685): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb81e26e0)
09-10 16:31:50.187+0600 I/MALI    (  685): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:50.187+0600 W/APP_CORE(  685): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c002bd
09-10 16:31:50.227+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb778b848), gem(22), surface(0xb7726830)
09-10 16:31:50.227+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78795e8), gem(18), surface(0xb78a1810)
09-10 16:31:50.267+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7867c40), gem(10), surface(0xb787e520)
09-10 16:31:50.347+0600 I/Tizen::Net::Wifi( 1366): (941) > The background scan result updated.
09-10 16:31:50.557+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb783bd80), gem(29), surface(0xb78ae1a0)
09-10 16:31:50.757+0600 I/CAPI_NETWORK_WIFI(14668): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 16:31:50.757+0600 I/CAPI_NETWORK_WIFI(16792): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 16:31:50.757+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 16:31:50.757+0600 I/CAPI_NETWORK_CONNECTION( 1366): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 16:31:50.757+0600 I/CAPI_NETWORK_WIFI( 1366): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 16:31:50.757+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(502) > State changed IND
09-10 16:31:50.757+0600 I/CAPI_NETWORK_CONNECTION( 1572): libnetwork.c: __libnet_evt_cb(510) > state: CONNECTED
09-10 16:31:50.757+0600 I/CAPI_NETWORK_WIFI( 1572): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 16:31:50.757+0600 I/CAPI_NETWORK_WIFI(  991): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 16:31:50.757+0600 I/CAPI_NETWORK_WIFI(  685): libnetwork.c: __libnet_evt_cb(742) > state: CONNECTED
09-10 16:31:50.767+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [INIT] : waiting...
09-10 16:31:50.808+0600 I/Tizen::Net::Wifi( 1366): (742) > _WifiService is not registered.
09-10 16:31:50.928+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:31:50.928+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 16:31:50.968+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16920 pgid = 16920
09-10 16:31:50.968+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(16920)
09-10 16:31:50.968+0600 E/Tizen::App( 1366): (703) > Cannot acquire app for 16920.
09-10 16:31:50.978+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2183
09-10 16:31:50.988+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 16:31:50.988+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 16:31:50.988+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 16:31:50.988+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(43958932) zone(/)
09-10 16:31:50.988+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 16:31:50.988+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 11:31:49 (UTC).
09-10 16:31:50.988+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 16:31:50.988+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[43958932] is removed.
09-10 16:31:51.018+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:31:51.018+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:31:51.018+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:31:51.018+0600 I/Tizen::App( 1366): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16920.
09-10 16:31:51.018+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 16920
09-10 16:31:51.018+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16920
09-10 16:31:51.018+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16920
09-10 16:31:51.028+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2184
09-10 16:31:51.028+0600 E/PUSHD   ( 1116): io.c: server_recv(270) > Fail to recv using curl
09-10 16:31:51.028+0600 E/PUSHD   ( 1116): proc.c: _receive_packet(2325) > ERROR : invalid return when receiving header [-1]
09-10 16:31:51.028+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 16:31:51.028+0600 W/PUSHD   ( 1116): State transition: [INIT]-> [PING]
09-10 16:31:51.028+0600 W/PUSHD   ( 1116): spp.c: _uds_list_changed_cb(2296) > UDS mode is off
09-10 16:31:51.028+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 16:31:51.038+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:51.048+0600 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:51.048+0600 E/ALARM_MANAGER( 1116): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(1500), start(10-9-2016, 16:56:51), repeat(0), interval(0), type(-1073741822)
09-10 16:31:51.058+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
09-10 16:31:51.058+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1116/status successfully
09-10 16:31:51.058+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
09-10 16:31:51.058+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:31:51.068+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:51.078+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:51.078+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:31:51.088+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:51.098+0600 I/AUL_AMD (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
09-10 16:31:51.098+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 38
09-10 16:31:51.098+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
09-10 16:31:51.098+0600 E/AUL_AMD (  648): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
09-10 16:31:51.098+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1473505011, Sat Sep 10 16:56:51 2016
09-10 16:31:51.098+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 507377938, next duetime: 1473505011
09-10 16:31:51.098+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(507377938)
09-10 16:31:51.098+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1473507109), due_time(1473505011)
09-10 16:31:51.098+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-10 16:31:51.098+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 10-9-2016, 10:56:51 (UTC).
09-10 16:31:51.128+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-10 16:31:51.138+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3139) > 
09-10 16:31:51.138+0600 W/PUSHD   ( 1116): State transition: [PING]-> [RUN]
09-10 16:31:51.138+0600 W/PUSHD   ( 1116): spp.c: _transit_state(3147) > State [RUN] : waiting...
09-10 16:31:51.328+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=14362168
09-10 16:31:51.408+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=14362219
09-10 16:31:51.438+0600 D/bluetooth(16792): Succeeded to get Wi-Fi device state.
09-10 16:31:51.989+0600 I/UXT     (17238): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 16:31:52.669+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=14363513
09-10 16:31:53.120+0600 W/INDICATOR(  685): toast_popup.c: _popup_timeout_cb(90) > 
09-10 16:31:53.240+0600 W/INDICATOR(  685): toast_popup.c: _popup_dismissed_cb(66) > 
09-10 16:31:53.770+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=14364620
09-10 16:31:54.791+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:31:54.791+0600 E/CAPI_NETWORK_CONNECTION( 1359): connection.c: __connection_cb_proxy_changed_cb_idle(334) > Unknown Proxy address type: IP() 
09-10 16:31:54.791+0600 I/CAPI_NETWORK_CONNECTION( 1359): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:31:54.942+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 16:31:54.982+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=14365830
09-10 16:31:55.052+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=14365902
09-10 16:31:55.973+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=14366815
09-10 16:31:55.973+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=14366815
09-10 16:31:55.973+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 16:31:55.973+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 16:31:55.973+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:31:56.273+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:31:56.273+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:31:56.273+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:31:56.273+0600 E/STARTER (  763): )
09-10 16:31:56.273+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:31:56.273+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:31:56.273+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:31:56.283+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 16:31:56.283+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 16:31:56.293+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 16:31:56.293+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 16:31:56.293+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 16:31:56.293+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 16:31:56.293+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 16:31:56.303+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 16:31:56.303+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 16:31:56.303+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 16:31:56.303+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 16:31:56.303+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 16:31:56.303+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 16:31:56.303+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 16:31:56.323+0600 E/CAPI_APPFW_APPLICATION(16932): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:31:56.323+0600 E/CAPI_APPFW_APPLICATION(16932): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:31:56.323+0600 E/CAPI_APPFW_APPLICATION(16932): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:31:56.323+0600 E/CAPI_APPFW_APPLICATION(16932): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:31:56.323+0600 E/CAPI_APPFW_APPLICATION(16932): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 16:31:56.323+0600 I/CAPI_APPFW_APPLICATION(16932): app_main.c: ui_app_main(789) > app_efl_main
09-10 16:31:56.323+0600 I/CAPI_APPFW_APPLICATION(16932): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 16:31:56.333+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b28e8), gem(10), surface(0xb7726830)
09-10 16:31:56.333+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b28e8), gem(10), surface(0xb78ae1a0)
09-10 16:31:56.343+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:31:56.343+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 16:31:56.343+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 16:31:56.393+0600 W/TASK_MGR_LITE(16932): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 16:31:56.403+0600 I/GXT_SIB (16932): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 16:31:56.403+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 16932, appid: com.samsung.task-mgr
09-10 16:31:56.403+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 16:31:56.413+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:31:56.413+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16932)
09-10 16:31:56.453+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:31:56.453+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:31:56.463+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:31:56.473+0600 E/RUA     (16932): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 19, ncols : 5
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 16:31:56.473+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:31:56.473+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 16792
09-10 16:31:56.473+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 16:31:56.473+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 16:31:56.483+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 16:31:56.483+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:31:56.523+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 16:31:56.523+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:31:56.543+0600 I/TIZEN_N_SOUND_MANAGER(14668): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 16:31:56.543+0600 E/TIZEN_N_SOUND_MANAGER(14668): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:31:56.553+0600 I/TIZEN_N_SOUND_MANAGER(14668): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 16:31:56.553+0600 E/TIZEN_N_SOUND_MANAGER(14668): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 16:31:56.553+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78552b8), gem(22), surface(0xb787e520)
09-10 16:31:56.553+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:31:56.623+0600 I/APP_CORE(16932): appcore-efl.c: __do_app(520) > [APP 16932] Event: RESET State: CREATED
09-10 16:31:56.623+0600 I/CAPI_APPFW_APPLICATION(16932): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 16:31:56.633+0600 E/EFL     (16932): edje<16932> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:31:56.633+0600 E/EFL     (16932): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:31:56.633+0600 E/EFL     (16932): edje<16932> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 16:31:56.633+0600 E/EFL     (16932): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 16:31:56.643+0600 W/APP_CORE(16932): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200003
09-10 16:31:56.643+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 16:31:56.683+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 16:31:56.683+0600 E/EFL     (16792): ecore_x<16792> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=14367534
09-10 16:31:56.683+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=14367534
09-10 16:31:56.683+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 16:31:56.683+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 16:31:56.683+0600 E/STARTER (  763): )
09-10 16:31:56.693+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 16:31:56.693+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 16:31:56.693+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 16:31:56.693+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 16:31:56.713+0600 I/MALI    (16932): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb7c8e768)
09-10 16:31:56.723+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7775020), gem(29), surface(0xb78ba300)
09-10 16:31:56.723+0600 I/MALI    (16932): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:56.733+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(16932) status(0)
09-10 16:31:56.733+0600 I/APP_CORE(16932): appcore-efl.c: __do_app(520) > [APP 16932] Event: RESUME State: CREATED
09-10 16:31:56.743+0600 I/APP_CORE(16932): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 16:31:56.743+0600 I/APP_CORE(16932): appcore-efl.c: __do_app(637) > [APP 16932] Initial Launching, call the resume_cb
09-10 16:31:56.743+0600 I/CAPI_APPFW_APPLICATION(16932): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:31:56.753+0600 I/APP_CORE(16792): appcore-efl.c: __do_app(520) > [APP 16792] Event: PAUSE State: RUNNING
09-10 16:31:56.753+0600 I/CAPI_APPFW_APPLICATION(16792): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:31:56.753+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb785ad60), gem(18), surface(0xb7891a08)
09-10 16:31:56.753+0600 I/TIZEN_N_EFL_UTIL_WINDOW(16792): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 16:31:56.753+0600 E/APP_CORE(16792): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:31:56.753+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:31:56.753+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(16792) status(4)
09-10 16:31:56.753+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(16792)
09-10 16:31:56.753+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 16792, appid: org.example.bluetooth, status: bg
09-10 16:31:56.763+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(16932) status(3)
09-10 16:31:56.763+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:31:56.763+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:31:56.763+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(16932)
09-10 16:31:56.763+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 16932, appid: com.samsung.task-mgr, status: fg
09-10 16:31:56.763+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:31:56.773+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:31:57.274+0600 E/EFL     (16932): ecore_x<16932> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=14368124
09-10 16:31:57.344+0600 E/EFL     (16932): ecore_x<16932> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=14368195
09-10 16:31:57.354+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 16:31:57.354+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 16792
09-10 16:31:57.354+0600 W/AUL     (16932): launch.c: app_request_to_launchpad(396) > request cmd(4) to(16792)
09-10 16:31:57.354+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 16:31:57.354+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(16792), cmd(4)
09-10 16:31:57.354+0600 W/AUL     (16932): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 16:31:57.354+0600 I/APP_CORE(16792): appcore-efl.c: __do_app(520) > [APP 16792] Event: TERMINATE State: PAUSED
09-10 16:31:57.364+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:31:57.364+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:31:57.364+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:31:57.364+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:31:57.364+0600 I/TIZEN_N_EFL_UTIL_WINDOW(16792): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 16:31:57.364+0600 E/APP_CORE(16792): appcore-efl.c: _capture_and_make_file(1631) > win[5c00002] widget[480] height[800]
09-10 16:31:57.364+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 16:31:57.364+0600 E/APP_CORE(16792): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 16:31:57.364+0600 I/CAPI_APPFW_APPLICATION(16792): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:31:57.364+0600 E/CAPI_NETWORK_BLUETOOTH(16792): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 16:31:57.394+0600 I/MALI    (16932): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:57.404+0600 I/MALI    (16932): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:57.424+0600 I/MALI    (16932): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:57.494+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 16:31:57.494+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 16932.
09-10 16:31:57.514+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2188
09-10 16:31:57.644+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 16:31:57.644+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 16:31:57.644+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(16932)
09-10 16:31:57.644+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 16932, appid: com.samsung.task-mgr, status: bg
09-10 16:31:57.644+0600 I/CAPI_APPFW_APPLICATION(16932): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 16:31:57.644+0600 W/TASK_MGR_LITE(16932): task-mgr-lite.c: _pause_app(406) > 
09-10 16:31:57.644+0600 I/CAPI_APPFW_APPLICATION(16932): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 16:31:57.654+0600 E/TASK_MGR_LITE(16932): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 16:31:57.664+0600 E/CAPI_NETWORK_BLUETOOTH(16792): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 16:31:57.664+0600 E/CAPI_NETWORK_BLUETOOTH(16792): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 16:31:57.664+0600 E/bluetooth(16792): [bt_adapter_le_destroy_advertiser] Failed.
09-10 16:31:57.664+0600 I/CAPI_NETWORK_WIFI(16792): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 16:31:57.664+0600 E/bluetooth(16792): [wifi_deinitialize] Success.
09-10 16:31:57.694+0600 E/APP_CORE(16932): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 16:31:57.694+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:31:57.704+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 16:31:57.704+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 16:31:57.704+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 16:31:57.714+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 16:31:57.714+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 16:31:57.724+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 16:31:57.764+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78795e8), gem(10), surface(0xb78ae1a0)
09-10 16:31:57.784+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:57.804+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78795e8), gem(10), surface(0xb787e520)
09-10 16:31:57.834+0600 I/MALI    (16932): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 16:31:57.834+0600 I/MALI    (16932): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=16932   close drm_fd=28 
09-10 16:31:57.834+0600 I/MALI    (16932): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 16:31:57.834+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785ad60), gem(29), surface(0xb7726830)
09-10 16:31:57.834+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb785ad60), gem(29), surface(0xb7891a08)
09-10 16:31:57.844+0600 E/EFL     (16792): elementary<16792> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 16:31:57.854+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 16:31:57.854+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 16:31:57.854+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 16:31:57.864+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 16:31:57.884+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 16:31:57.894+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78306d8), gem(13), surface(0xb7726830)
09-10 16:31:57.924+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 16:31:57.924+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 16:31:57.964+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 16:31:58.005+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 16:31:58.035+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 16:31:58.055+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb82ec998]
09-10 16:31:58.055+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 2
09-10 16:31:58.055+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb82ec998
09-10 16:31:58.065+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
09-10 16:31:58.065+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
09-10 16:31:58.065+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 16:31:58.065+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 16:31:58.065+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 16:31:58.125+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76e1e18), gem(13), surface(0xb7891a08)
09-10 16:31:58.245+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:58.245+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16792 pgid = 16792
09-10 16:31:58.245+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(16792)
09-10 16:31:58.265+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:58.275+0600 I/Tizen::Net::Wifi( 1366): (1085) > _WifiService is not registered.
09-10 16:31:58.275+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 16:31:58.355+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:31:58.355+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:31:58.355+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:31:58.365+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[16792] terminate event is forwarded
09-10 16:31:58.365+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:31:58.365+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 16792, ]
09-10 16:31:58.365+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:31:58.365+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 16:31:58.365+0600 I/Tizen::App( 1366): (512) > Not registered pid(16792)
09-10 16:31:58.365+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 16:31:58.365+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 16:31:58.365+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16792
09-10 16:31:58.365+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 16792
09-10 16:31:58.385+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2189
09-10 16:31:58.405+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16932 pgid = 16932
09-10 16:31:58.405+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(16932)
09-10 16:31:58.425+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 16:31:58.425+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 16792.
09-10 16:31:58.465+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 16:31:58.465+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 16:31:58.465+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 16:31:58.495+0600 I/Tizen::App( 1366): (243) > App[com.samsung.task-mgr] pid[16932] terminate event is forwarded
09-10 16:31:58.495+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 16:31:58.495+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.task-mgr, 16932, ]
09-10 16:31:58.495+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 16:31:58.495+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.task-mgr)
09-10 16:31:58.495+0600 I/Tizen::App( 1366): (512) > Not registered pid(16932)
09-10 16:31:58.495+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.task-mgr]
09-10 16:31:58.495+0600 W/CRASH_MANAGER(17281): worker.c: worker_job(1199) > 1116792626162147350351
