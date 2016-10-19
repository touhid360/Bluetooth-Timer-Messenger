S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 31164
Date: 2016-09-10 15:39:38+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 31164, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb784d2f8
r2   = 0xb438c000, r3   = 0xb438c000
r4   = 0xb7752c38, r5   = 0xbe9ee5bc
r6   = 0xb6a8a310, r7   = 0xbe9ee41c
r8   = 0xb6a8b0f4, r9   = 0xb6a8b0f4
r10  = 0xb6a9920c, fp   = 0x00000000
ip   = 0xb2a7f388, sp   = 0xbe9ec770
lr   = 0xb2a73abf, pc   = 0xb676e6f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     50732 KB
Buffers:     41788 KB
Cached:     286440 KB
VmPeak:     109084 KB
VmSize:     103516 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25260 KB
VmRSS:       25260 KB
VmData:      35100 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36228 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 31164 TID = 31164
31164 31168 31255 

Maps Information
b1dc8000 b25c7000 rw-p [stack:31255]
b25c7000 b25d8000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25e8000 b25ed000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2679000 b2681000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2692000 b2693000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b26a3000 b26b7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26cb000 b26cc000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26dc000 b26df000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26f0000 b26f1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2701000 b2703000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2713000 b2715000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2725000 b2735000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2745000 b2751000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2962000 b2979000 r-xp /usr/lib/libnetwork.so.0.0.0
b298a000 b29c8000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29d9000 b29e0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29f1000 b2a00000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a10000 b2a45000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a58000 b2a5e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a6e000 b2a77000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b99000 b2c7c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2cb3000 b2cdb000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ced000 b34ec000 rw-p [stack:31168]
b34ec000 b34ee000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34fe000 b3508000 r-xp /lib/libnss_files-2.20-2014.11.so
b3519000 b3522000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3533000 b3544000 r-xp /lib/libnsl-2.20-2014.11.so
b3557000 b355d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b356e000 b356f000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3597000 b359e000 r-xp /usr/lib/libminizip.so.1.0.0
b35ae000 b35b3000 r-xp /usr/lib/libstorage.so.0.1
b35c3000 b3618000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b362e000 b3642000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3652000 b3696000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b36a6000 b36ae000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36be000 b36ee000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3701000 b37ba000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37ce000 b3822000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3833000 b384e000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b385e000 b391f000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3932000 b3944000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3954000 b3958000 r-xp /usr/lib/libogg.so.0.7.1
b3968000 b398a000 r-xp /usr/lib/libvorbis.so.0.4.3
b399a000 b3a7e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a9a000 b3aa7000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3ab8000 b3afb000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b10000 b3b57000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b68000 b3b6e000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b7f000 b3b86000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b96000 b3bd6000 r-xp /usr/lib/libmdm.so.1.2.10
b3be6000 b3bee000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bfd000 b3c0d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c2e000 b3c8e000 r-xp /usr/lib/libasound.so.2.0.0
b3ca0000 b3cd6000 r-xp /usr/lib/libpulse.so.0.16.2
b3ce7000 b3cea000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cfa000 b3cfd000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d0d000 b3d12000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d22000 b3d23000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d33000 b3d3e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d52000 b3d59000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d69000 b3d6f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d7f000 b3d84000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d94000 b3daf000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3dbf000 b3dc6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dd6000 b3dd9000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3dea000 b3e18000 r-xp /usr/lib/libidn.so.11.5.44
b3e28000 b3e3e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e4f000 b3e59000 r-xp /usr/lib/libcares.so.2.1.0
b3e69000 b3e73000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e83000 b3e85000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e95000 b3e96000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3ea6000 b3eaa000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3ebb000 b3ee3000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ef4000 b3f1d000 r-xp /usr/lib/libturbojpeg.so
b3f3d000 b3f43000 r-xp /usr/lib/libgif.so.4.1.6
b3f53000 b3f99000 r-xp /usr/lib/libcurl.so.4.3.0
b3faa000 b3fcb000 r-xp /usr/lib/libexif.so.12.3.3
b3fe6000 b3ffb000 r-xp /usr/lib/libtts.so
b400c000 b4014000 r-xp /usr/lib/libfeedback.so.0.1.4
b4024000 b40e4000 r-xp /usr/lib/libdali-core.so.0.0.0
b40ef000 b41e2000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4202000 b42dc000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42f3000 b42f5000 r-xp /usr/lib/libboost_system.so.1.51.0
b4305000 b430b000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b431b000 b433e000 r-xp /usr/lib/libboost_thread.so.1.51.0
b434f000 b4351000 r-xp /usr/lib/libappsvc.so.0.1.0
b4361000 b4363000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4374000 b4379000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4390000 b4392000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b43a2000 b43a9000 r-xp /usr/lib/libsensord-share.so
b43b9000 b43d1000 r-xp /usr/lib/libsensor.so.1.1.0
b43e2000 b43e5000 r-xp /usr/lib/libXv.so.1.0.0
b43f5000 b43fa000 r-xp /usr/lib/libutilX.so.1.1.0
b440a000 b440f000 r-xp /usr/lib/libappcore-common.so.1.1
b441f000 b4426000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4439000 b443d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b444e000 b4518000 r-xp /usr/lib/libCOREGL.so.4.0
b452f000 b4532000 r-xp /usr/lib/libuuid.so.1.3.0
b4543000 b455a000 r-xp /usr/lib/libblkid.so.1.1.0
b456b000 b456d000 r-xp /usr/lib/libXau.so.6.0.0
b457d000 b4580000 r-xp /usr/lib/libEGL.so.1.4
b4588000 b458e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b459e000 b45a0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45b1000 b45bf000 r-xp /usr/lib/libGLESv2.so.2.0
b45c8000 b462a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b463f000 b4657000 r-xp /usr/lib/libmount.so.1.1.0
b4668000 b467c000 r-xp /usr/lib/libxcb.so.1.1.0
b468d000 b4694000 r-xp /lib/libcrypt-2.20-2014.11.so
b46cc000 b46dd000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46ee000 b46f0000 r-xp /usr/lib/libiri.so
b4700000 b470b000 r-xp /usr/lib/libgpg-error.so.0.15.0
b471c000 b4731000 r-xp /lib/libexpat.so.1.5.2
b4743000 b4801000 r-xp /usr/lib/libcairo.so.2.11200.14
b4814000 b481c000 r-xp /usr/lib/libdrm.so.2.4.0
b482c000 b482f000 r-xp /usr/lib/libdri2.so.0.0.0
b4840000 b488e000 r-xp /usr/lib/libssl.so.1.0.0
b48a3000 b48af000 r-xp /usr/lib/libeeze.so.1.13.0
b48bf000 b48c8000 r-xp /usr/lib/libethumb.so.1.13.0
b48d8000 b48db000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48eb000 b4aa2000 r-xp /usr/lib/libcrypto.so.1.0.0
b56f9000 b5702000 r-xp /usr/lib/libXi.so.6.1.0
b5712000 b5714000 r-xp /usr/lib/libXgesture.so.7.0.0
b5724000 b5728000 r-xp /usr/lib/libXtst.so.6.1.0
b5738000 b573e000 r-xp /usr/lib/libXrender.so.1.3.0
b574e000 b5754000 r-xp /usr/lib/libXrandr.so.2.2.0
b5765000 b5767000 r-xp /usr/lib/libXinerama.so.1.0.0
b5777000 b577a000 r-xp /usr/lib/libXfixes.so.3.1.0
b578a000 b5795000 r-xp /usr/lib/libXext.so.6.4.0
b57a5000 b57a7000 r-xp /usr/lib/libXdamage.so.1.1.0
b57b7000 b57b9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57ca000 b58ac000 r-xp /usr/lib/libX11.so.6.3.0
b58bf000 b58c6000 r-xp /usr/lib/libXcursor.so.1.0.2
b58d6000 b58ee000 r-xp /usr/lib/libudev.so.1.6.0
b58f0000 b58f3000 r-xp /lib/libattr.so.1.1.0
b5903000 b5923000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5925000 b592a000 r-xp /usr/lib/libffi.so.6.0.2
b593a000 b5952000 r-xp /lib/libz.so.1.2.8
b5962000 b5964000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5974000 b5a49000 r-xp /usr/lib/libxml2.so.2.9.2
b5a5e000 b5af9000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b15000 b5b18000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b28000 b5b41000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b52000 b5b63000 r-xp /lib/libresolv-2.20-2014.11.so
b5b77000 b5bf1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5c06000 b5c08000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c18000 b5c1f000 r-xp /usr/lib/libembryo.so.1.13.0
b5c2f000 b5c47000 r-xp /usr/lib/libpng12.so.0.50.0
b5c58000 b5c7b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9c000 b5cb0000 r-xp /usr/lib/libector.so.1.13.0
b5cc1000 b5cd9000 r-xp /usr/lib/liblua-5.1.so
b5cea000 b5d41000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d55000 b5d7d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d8e000 b5da1000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db2000 b5de9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dfa000 b5e08000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e18000 b5e20000 r-xp /usr/lib/libtbm.so.1.0.0
b5e30000 b5e3d000 r-xp /usr/lib/libeio.so.1.13.0
b5e4d000 b5e4f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e5f000 b5e64000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e74000 b5e8b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e9d000 b5ebd000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ecd000 b5eed000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eef000 b5ef5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f05000 b5f16000 r-xp /usr/lib/libemotion.so.1.13.0
b5f27000 b5f2e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f3e000 b5f4d000 r-xp /usr/lib/libeo.so.1.13.0
b5f5e000 b5f70000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f81000 b5f86000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f96000 b5faf000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fbf000 b5fdc000 r-xp /usr/lib/libeet.so.1.13.0
b5ff5000 b603d000 r-xp /usr/lib/libeina.so.1.13.0
b604e000 b605e000 r-xp /usr/lib/libefl.so.1.13.0
b606f000 b6154000 r-xp /usr/lib/libicuuc.so.51.1
b6171000 b62b1000 r-xp /usr/lib/libicui18n.so.51.1
b62c8000 b6300000 r-xp /usr/lib/libecore_x.so.1.13.0
b6312000 b6315000 r-xp /lib/libcap.so.2.21
b6325000 b634e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b635f000 b6366000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6378000 b63af000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c0000 b64ab000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64be000 b6537000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6549000 b654e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b655e000 b6568000 r-xp /usr/lib/libvconf.so.0.2.45
b6578000 b657a000 r-xp /usr/lib/libvasum.so.0.3.1
b658a000 b658c000 r-xp /usr/lib/libttrace.so.1.1
b659c000 b659f000 r-xp /usr/lib/libiniparser.so.0
b65af000 b65d5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e5000 b65ea000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65fb000 b6612000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6623000 b668e000 r-xp /lib/libm-2.20-2014.11.so
b669f000 b66a5000 r-xp /lib/librt-2.20-2014.11.so
b66b6000 b66c3000 r-xp /usr/lib/libunwind.so.8.0.1
b66f9000 b681d000 r-xp /lib/libc-2.20-2014.11.so
b6832000 b684b000 r-xp /lib/libgcc_s-4.9.so.1
b685b000 b693d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b694e000 b6978000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6989000 b69c5000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c7000 b6a49000 r-xp /usr/lib/libedje.so.1.13.0
b6a5c000 b6a7a000 r-xp /usr/lib/libecore.so.1.13.0
b6a9a000 b6c21000 r-xp /usr/lib/libevas.so.1.13.0
b6c56000 b6c6a000 r-xp /lib/libpthread-2.20-2014.11.so
b6c7e000 b6eb3000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee1000 b6ee5000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef5000 b6efc000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f0c000 b6f0e000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1e000 b6f21000 r-xp /usr/lib/libbundle.so.0.1.22
b6f31000 b6f33000 r-xp /lib/libdl-2.20-2014.11.so
b6f44000 b6f5c000 r-xp /usr/lib/libaul.so.0.1.0
b6f70000 b6f75000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f86000 b6f93000 r-xp /usr/lib/liblptcp.so
b6fa5000 b6fa9000 r-xp /usr/lib/libsys-assert.so
b6fba000 b6fda000 r-xp /lib/ld-2.20-2014.11.so
b6feb000 b6ff0000 r-xp /usr/bin/launchpad-loader
b7711000 b7aa2000 rw-p [heap]
be9ce000 be9ef000 rw-p [stack]
b7711000 b7aa2000 rw-p [heap]
be9ce000 be9ef000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31164)
Call Stack Count: 1
 0: (0xb676e6f0) [/lib/libc.so.6] + 0x756f0
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
tatus(4)
09-10 15:37:07.898+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.contacts(31269)
09-10 15:37:07.898+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 31269, appid: com.samsung.contacts, status: bg
09-10 15:37:07.898+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:37:07.908+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 15:37:07.908+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 15:37:07.908+0600 I/APP_CORE(31269): appcore-efl.c: __do_app(520) > [APP 31269] Event: PAUSE State: RUNNING
09-10 15:37:07.908+0600 I/CAPI_APPFW_APPLICATION(31269): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:37:07.908+0600 I/WAPP    (31269): WApp.cpp: __onPause(79) > [0;34m>>>HIT<<<[0;m
09-10 15:37:07.908+0600 I/PHONE   (31269): ContactsApp.cpp: onPause(73) > [0;34m>>>HIT<<<[0;m
09-10 15:37:07.908+0600 W/UI_GADGET(31269): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
09-10 15:37:07.918+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7885ca8), gem(13), surface(0xb7876938)
09-10 15:37:07.918+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 15:37:07.928+0600 I/TIZEN_N_EFL_UTIL_WINDOW(31269): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 13
09-10 15:37:07.928+0600 E/APP_CORE(31269): appcore-efl.c: _capture_and_make_file(1631) > win[6200003] widget[480] height[800]
09-10 15:37:07.928+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:37:07.938+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:37:07.958+0600 E/EFL     (  873): ecore_x<873> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=11082527
09-10 15:37:07.958+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
09-10 15:37:07.958+0600 E/EFL     (  873): ecore_x<873> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=11082594
09-10 15:37:07.958+0600 E/cluster-view(  873): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
09-10 15:37:07.988+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 15:37:08.028+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 15:37:08.048+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83c16d8]
09-10 15:37:08.048+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 15:37:08.048+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 15:37:08.048+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 15:37:08.048+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83c16d8
09-10 15:37:08.058+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 15:37:08.058+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-10 15:37:08.058+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-10 15:37:08.058+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 15:37:08.058+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 15:37:08.058+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 15:37:08.149+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76a91b8), gem(13), surface(0xb782fa90)
09-10 15:37:08.269+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:37:08.289+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:37:08.349+0600 I/PHONE   (31269): CtTabView.cpp: __createRestViewTimerCb(474) > [0;34m>>>HIT<<<[0;m
09-10 15:37:08.349+0600 I/WAPP    (31269): WView.cpp: create(125) > [0;34m>>>HIT<<<[0;m
09-10 15:37:08.349+0600 I/PHONE   (31269): PhLogMainListView.cpp: onCreate(367) > [0;34m>>>HIT<<<[0;m
09-10 15:37:08.359+0600 E/AUL_RESOURCE_MANAGER(31269): aul_rsc_mgr.c: __get_cache(416) > IO_ERROR(0xfffffffb), find list resource_cache
09-10 15:37:08.439+0600 I/PHONE   (31269): PhLogMainListView.cpp: onCreated(380) > [0;34m>>>HIT<<<[0;m
09-10 15:37:08.449+0600 I/PHONE   (31269): PhLogDbMgr.cpp: PhLogDbMgr(64) > [0;32mBEGIN >>>>[0;m
09-10 15:37:08.459+0600 I/PHONE   (31269): PhLogMainListView.cpp: onSetAsPageContent(432) > [0;34m>>>HIT<<<[0;m
09-10 15:37:08.459+0600 I/PHONE   (31269): PhLogDbMgr.cpp: loadLogList(480) > [0;32mBEGIN >>>>[0;m
09-10 15:37:08.459+0600 I/PHONE   (31269): PhLogDbMgr.cpp: __getLogListDataFromDb(150) > [0;32mBEGIN >>>>[0;m
09-10 15:37:08.459+0600 I/PHONE   (31269): PhLogDbMgr.cpp: __getLogListDataFromDb(297) > [0;34m>>>HIT<<<[0;m
09-10 15:37:08.459+0600 E/PHONE   (31269): PhLogDbMgr.cpp: loadLogList(500) > [0;31m* Critical * contacts_list_get_current_record_p() Failed(-61)[0;m
09-10 15:37:08.459+0600 I/PHONE   (31269): PhLogDbMgr.cpp: loadLogList(550) > [0;32msort by logTIme[0;m
09-10 15:37:08.459+0600 I/PHONE   (31269): PhLogListView.cpp: setNoContentLayout(80) > [0;32mBEGIN >>>>[0;m
09-10 15:37:08.459+0600 E/AUL_RESOURCE_MANAGER(31269): aul_rsc_mgr.c: __get_cache(416) > IO_ERROR(0xfffffffb), find list resource_cache
09-10 15:37:08.459+0600 E/AUL_RESOURCE_MANAGER(31269): aul_rsc_mgr.c: __get_cache(416) > IO_ERROR(0xfffffffb), find list resource_cache
09-10 15:37:08.839+0600 I/UXT     (31693): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 15:37:08.909+0600 E/TBM     (31693): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 15:37:09.029+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 15:37:09.059+0600 E/EFL     (31693): edje<31693> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:37:09.059+0600 E/EFL     (31693): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:37:09.059+0600 E/EFL     (31693): edje<31693> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:37:09.059+0600 E/EFL     (31693): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:37:09.059+0600 E/EFL     (31693): edje<31693> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:37:09.059+0600 E/EFL     (31693): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:37:09.410+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 15:37:10.431+0600 I/APP_CORE(31164): appcore-efl.c: __do_app(520) > [APP 31164] Event: MEM_FLUSH State: PAUSED
09-10 15:37:12.943+0600 I/APP_CORE(31269): appcore-efl.c: __do_app(520) > [APP 31269] Event: MEM_FLUSH State: PAUSED
09-10 15:37:15.476+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:37:16.317+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:37:16.787+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:37:16.907+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:37:17.027+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:37:17.207+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
09-10 15:37:17.568+0600 E/VCONF   (  609): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/usb_connection_mode
09-10 15:37:17.568+0600 E/VCONF   (  609): vconf.c: _vconf_check_retry_err(1368) > db/setting/usb_connection_mode : check retry err (-21/2).
09-10 15:37:17.568+0600 E/VCONF   (  609): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/usb_connection_mode) step(-21) failed(2 / No such file or directory) retry(0) 
09-10 15:37:17.568+0600 E/VCONF   (  609): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/usb_connection_mode) step(-21) failed(2 / No such file or directory)
09-10 15:37:17.568+0600 E/VCONF   (  609): vconf.c: vconf_get_int(2650) > vconf_get_int(609) : db/setting/usb_connection_mode error
09-10 15:37:17.568+0600 E/VCONF   (  609): vconf-kdb.c: _vconf_kdb_add_notify(329) > _vconf_kdb_add_notify : key(db/usb/sel_mode) has same callback(0xb6f34d78)
09-10 15:37:17.578+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:37:17.578+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:37:17.578+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:37:17.578+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 15:37:17.578+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 15:37:17.968+0600 I/CAPI_CONTENT_MEDIA_CONTENT(31753): media_content.c: media_content_connect(856) > [32m[31753]ref count : 0
09-10 15:37:17.968+0600 I/CAPI_CONTENT_MEDIA_CONTENT(31753): media_content.c: media_content_connect(888) > [32m[31753]ref count changed to: 1
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 400 is changed to 1
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:400
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:400
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 100 is changed to 1
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:100
09-10 15:37:18.168+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:100
09-10 15:37:18.218+0600 I/AUL     (31751): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 15:37:18.248+0600 I/AUL     (31751): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 15:37:18.258+0600 E/RESOURCED(15587): heart-battery.c: heart_battery_calculate_prediction(1055) > No battery capacity history data
09-10 15:37:18.268+0600 I/AUL     (31751): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
09-10 15:37:18.288+0600 E/INDICATOR(  685): battery.c: show_digits(405) > show_digits[405]	 "Show digits: 100"
09-10 15:37:18.288+0600 I/INDICATOR(  685): battery.c: show_battery_icon(376) > "Percentage:(1) / Level:(10) / batt_Full:(0) / battery_charging(1)"
09-10 15:37:18.288+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 15:37:18.288+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:37:18.288+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:37:18.288+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 15:37:18.288+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 15:37:18.288+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 15:37:18.288+0600 I/AUL     (31751): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
09-10 15:37:18.288+0600 E/CAPI_APPFW_APP_MANAGER(31751): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 15:37:18.308+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 15:37:18.329+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 15:37:18.349+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 15:37:18.369+0600 I/AUL     (  769): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
09-10 15:37:18.369+0600 E/CAPI_APPFW_APP_MANAGER(  769): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 15:37:18.449+0600 I/AUL     (31318): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 15:37:18.499+0600 I/AUL     (31318): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 15:37:18.499+0600 I/AUL     (31318): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 15:37:18.509+0600 E/QUICKPANEL(  991): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
09-10 15:37:18.519+0600 I/QUICKPANEL(  991): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 1[0;m
09-10 15:37:18.539+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 15:37:18.539+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 15:37:18.539+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 15:37:18.539+0600 E/QUICKPANEL(  991): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
09-10 15:37:18.549+0600 I/AUL     (31318): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bluetooth-share, ret : 0
09-10 15:37:18.549+0600 E/CAPI_APPFW_APP_MANAGER(31318): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
09-10 15:37:18.549+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
09-10 15:37:18.549+0600 W/QUICKPANEL(  991): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
09-10 15:37:18.549+0600 E/EFL     (  991): eo<991> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
09-10 15:37:18.549+0600 I/QUICKPANEL(  991): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
09-10 15:37:18.589+0600 E/INDICATOR(  685): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
09-10 15:37:21.321+0600 E/VCONF   (31756): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:37:41.191+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
09-10 15:37:48.188+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:37:48.188+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:37:48.198+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 15:37:48.198+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 15:37:48.198+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 15:37:48.228+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 15:37:48.228+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 15:37:48.228+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 15:37:48.228+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:13d8c30
09-10 15:37:48.228+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 15:37:48.228+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
09-10 15:37:48.228+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 15:37:48.238+0600 W/APP_CORE(  873): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 15:37:48.238+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: RUNNING
09-10 15:37:48.238+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 15:37:48.238+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 15:37:48.248+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 15:37:48.258+0600 E/VCONF   (31756): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:37:48.258+0600 E/VCONF   (31756): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:37:48.258+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
09-10 15:37:48.808+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 15:37:48.808+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 15:37:48.808+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 15:37:48.818+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76a91b8), gem(15), surface(0xb7808968)
09-10 15:37:48.848+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: PAUSED
09-10 15:37:48.858+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77f54c8), gem(13), surface(0xb78ae1a0)
09-10 15:37:48.868+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:37:48.868+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 15:37:48.898+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(3)
09-10 15:37:48.898+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 15:37:48.898+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 15:37:48.898+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(869)
09-10 15:37:48.898+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: fg
09-10 15:37:48.898+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 15:37:48.898+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 15:37:48.898+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 15:37:48.898+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 15:37:48.898+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 15:37:48.908+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:37:48.918+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 15:37:48.928+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 15:37:48.928+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 15:37:48.968+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7798ce8), gem(18), surface(0xb782fa90)
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
09-10 15:37:49.008+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [visible]
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
09-10 15:37:49.008+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
09-10 15:37:49.018+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
09-10 15:37:49.018+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb785d020), gem(14), surface(0xb787c430)
09-10 15:37:49.018+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
09-10 15:37:49.018+0600 W/APP_CORE(  869): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
09-10 15:37:49.018+0600 E/VCONF   (31756): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:37:49.018+0600 E/VCONF   (31756): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 15:37:49.028+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 15:37:49.028+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:37:49.028+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:37:49.028+0600 E/EFL     (  869): edje<869> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 15:37:49.028+0600 E/EFL     (  869): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 15:37:49.028+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 15:37:49.028+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 15:37:49.028+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 15:37:49.028+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 15:37:49.038+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 15:37:49.038+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 15:37:49.038+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 15:37:49.038+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 15:37:49.038+0600 I/MALI    (  873): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 15:37:49.038+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 31922
09-10 15:37:49.038+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 15:37:49.089+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 31922
09-10 15:37:49.089+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 31922, appid: com.samsung.weather-m-agent
09-10 15:37:49.099+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 15:37:49.099+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 31922.
09-10 15:37:49.109+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(31922)
09-10 15:37:49.119+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 15:37:49.119+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 15:37:49.119+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 15:37:49.119+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 15:37:49.119+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 15:37:49.119+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 15:37:49.129+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 15:37:49.129+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 15:37:49.129+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 15:37:49.129+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 15:37:49.129+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 15:37:49.279+0600 E/weather-agent(31922): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 15:37:49.279+0600 E/weather-common(31922): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 15:37:49.279+0600 E/weather-agent(31922): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 15:37:49.299+0600 I/MESSAGE_PORT(31922): message-port.c: __initialize(872) > initialize
09-10 15:37:49.299+0600 I/MESSAGE_PORT(31922): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 15:37:49.339+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 15:37:49.339+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 15:37:49.339+0600 I/MESSAGE_PORT(31922): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:37:49.339+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 15:37:49.339+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 15:37:49.339+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 15:37:49.339+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 15:37:49.339+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 15:37:49.339+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 15:37:49.339+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 15:37:49.349+0600 E/MESSAGE_PORT(31922): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 15:37:49.349+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 15:37:49.349+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 15:37:49.359+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 15:37:49.359+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 15:37:49.359+0600 I/MESSAGE_PORT(31922): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 15:37:49.359+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 15:37:49.359+0600 I/MESSAGE_PORT(31922): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 15:37:49.359+0600 I/MESSAGE_PORT(31922): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 15:37:49.359+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 15:37:49.359+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:37:49.359+0600 E/MESSAGE_PORT(31922): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 15:37:49.359+0600 E/weather-common(31922): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 15:37:49.359+0600 E/weather-agent(31922): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 15:37:49.359+0600 E/weather-agent(31922): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 15:37:49.369+0600 I/MESSAGE_PORT(31922): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 15:37:49.369+0600 I/MESSAGE_PORT(31922): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 15:37:49.389+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 15:37:49.429+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 15:37:49.429+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 15:37:49.649+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb8351288]
09-10 15:37:49.649+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 15:37:49.649+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 15:37:49.649+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 15:37:49.649+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb8351288
09-10 15:37:49.649+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 15:37:49.659+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 15:37:49.659+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 15:37:49.659+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 15:37:49.659+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 15:37:49.659+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 15:37:49.669+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 15:37:49.689+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8015f6af is not stable during recalc loop
09-10 15:37:49.749+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8015f6af is not stable during recalc loop
09-10 15:37:49.759+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 15:37:49.759+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 15:37:50.370+0600 E/weather-agent(31922): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 15:37:50.370+0600 I/CAPI_APPFW_APPLICATION(31922): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 15:37:50.370+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:37:50.370+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:37:50.370+0600 E/weather-agent(31922): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 15:37:50.510+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 15:37:50.520+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 31922
09-10 15:37:50.520+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[31922] terminate event is forwarded
09-10 15:37:50.520+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:37:50.520+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 31922, ]
09-10 15:37:50.520+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:37:50.520+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 15:37:50.520+0600 I/Tizen::App( 1366): (512) > Not registered pid(31922)
09-10 15:37:50.520+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 15:37:50.520+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:37:50.520+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 31922
09-10 15:37:50.520+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:37:50.530+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:37:50.530+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 31922.
09-10 15:37:50.530+0600 I/Tizen::System( 1366): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
09-10 15:37:53.243+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: MEM_FLUSH State: PAUSED
09-10 15:37:55.375+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 15:38:37.446+0600 I/SERVICE_MANAGER_LIB(31682): service-manager.c: service_manager_unregister_listener2(564) > [34m[31682]service_manager_unregister_object[0m
09-10 15:39:38.045+0600 E/PKGMGR_SERVER(32511): pkgmgr-server.c: main(2414) > package manager server start
09-10 15:39:38.105+0600 E/PKGMGR  (32509): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 15:39:38.145+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:39:38.145+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 31164
09-10 15:39:38.155+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 15:39:38.155+0600 W/AUL     (32516): launch.c: app_request_to_launchpad(396) > request cmd(5) to(31164)
09-10 15:39:38.155+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 15:39:38.155+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(31164), cmd(4)
09-10 15:39:38.155+0600 W/AUL     (32516): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 15:39:38.165+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:39:38.165+0600 I/APP_CORE(31164): appcore-efl.c: __do_app(520) > [APP 31164] Event: TERMINATE State: PAUSED
09-10 15:39:38.165+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 31164
09-10 15:39:38.165+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:39:38.165+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:39:38.165+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 15:39:38.165+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 15:39:38.165+0600 I/TIZEN_N_EFL_UTIL_WINDOW(31164): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 15:39:38.165+0600 E/APP_CORE(31164): appcore-efl.c: _capture_and_make_file(1631) > win[5400002] widget[480] height[800]
09-10 15:39:38.165+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 15:39:38.165+0600 E/APP_CORE(31164): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 15:39:38.165+0600 I/CAPI_APPFW_APPLICATION(31164): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 15:39:38.165+0600 E/CAPI_NETWORK_BLUETOOTH(31164): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 15:39:38.225+0600 E/CAPI_NETWORK_BLUETOOTH(31164): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 15:39:38.225+0600 E/CAPI_NETWORK_BLUETOOTH(31164): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 15:39:38.225+0600 E/bluetooth(31164): [bt_adapter_le_destroy_advertiser] Failed.
09-10 15:39:38.235+0600 I/CAPI_NETWORK_WIFI(31164): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 15:39:38.235+0600 E/bluetooth(31164): [wifi_deinitialize] Success.
09-10 15:39:38.265+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 15:39:38.265+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 15:39:38.275+0600 E/PKGMGR_SERVER(32511): pkgmgr-server.c: sighandler(417) > child NORMAL exit [32516]
09-10 15:39:38.295+0600 E/EFL     (31164): elementary<31164> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 15:39:38.455+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 31164 pgid = 31164
09-10 15:39:38.455+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(31164)
09-10 15:39:38.505+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 15:39:38.505+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 15:39:38.505+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 15:39:38.505+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[31164] terminate event is forwarded
09-10 15:39:38.505+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 15:39:38.505+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 31164, ]
09-10 15:39:38.505+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 15:39:38.505+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 15:39:38.505+0600 I/Tizen::App( 1366): (512) > Not registered pid(31164)
09-10 15:39:38.505+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 15:39:38.505+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 15:39:38.505+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 31164
09-10 15:39:38.505+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 31164
09-10 15:39:38.515+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1665
09-10 15:39:38.525+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 15:39:38.525+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 15:39:38.525+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 31164.
09-10 15:39:38.565+0600 W/CRASH_MANAGER(32522): worker.c: worker_job(1199) > 1131164626162147350037
