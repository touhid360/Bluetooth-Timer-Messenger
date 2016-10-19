S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 7455
Date: 2016-09-10 17:43:20+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7455, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb83e6658
r2   = 0xb42c1000, r3   = 0xb42c1000
r4   = 0xbe91a5bc, r5   = 0xb69c00f4
r6   = 0xb69bf310, r7   = 0xbe91a41c
r8   = 0xb69c00f4, r9   = 0xb69c00f4
r10  = 0xb69ce20c, fp   = 0x00000000
ip   = 0xb29b4504, sp   = 0xbe919798
lr   = 0xb29a9daf, pc   = 0xb66a36f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     52716 KB
Buffers:     44420 KB
Cached:     289160 KB
VmPeak:     105584 KB
VmSize:     103128 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25008 KB
VmRSS:       25008 KB
VmData:      34720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7455 TID = 7455
7455 7457 7905 7908 

Maps Information
b1301000 b1b00000 rw-p [stack:7908]
b1d00000 b24ff000 rw-p [stack:7905]
b24ff000 b2510000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2520000 b2525000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25b1000 b25b9000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25ca000 b25cb000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25db000 b25ef000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2603000 b2604000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2614000 b2617000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2628000 b2629000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2639000 b263b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b264b000 b264d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b265d000 b266d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b267d000 b2689000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b289a000 b28b1000 r-xp /usr/lib/libnetwork.so.0.0.0
b28c2000 b2900000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2911000 b2918000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2929000 b2938000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2948000 b297d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2990000 b2996000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29a6000 b29ad000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ace000 b2bb1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2be8000 b2c10000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c22000 b3421000 rw-p [stack:7457]
b3421000 b3423000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3433000 b343d000 r-xp /lib/libnss_files-2.20-2014.11.so
b344e000 b3457000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3468000 b3479000 r-xp /lib/libnsl-2.20-2014.11.so
b348c000 b3492000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34a3000 b34a4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34cc000 b34d3000 r-xp /usr/lib/libminizip.so.1.0.0
b34e3000 b34e8000 r-xp /usr/lib/libstorage.so.0.1
b34f8000 b354d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3563000 b3577000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3587000 b35cb000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35db000 b35e3000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b35f3000 b3623000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3636000 b36ef000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3703000 b3757000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3768000 b3783000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3793000 b3854000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3867000 b3879000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3889000 b388d000 r-xp /usr/lib/libogg.so.0.7.1
b389d000 b38bf000 r-xp /usr/lib/libvorbis.so.0.4.3
b38cf000 b39b3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39cf000 b39dc000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39ed000 b3a30000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a45000 b3a8c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3a9d000 b3aa3000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ab4000 b3abb000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3acb000 b3b0b000 r-xp /usr/lib/libmdm.so.1.2.10
b3b1b000 b3b23000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b32000 b3b42000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b63000 b3bc3000 r-xp /usr/lib/libasound.so.2.0.0
b3bd5000 b3c0b000 r-xp /usr/lib/libpulse.so.0.16.2
b3c1c000 b3c1f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c2f000 b3c32000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c42000 b3c47000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c57000 b3c58000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c68000 b3c73000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c87000 b3c8e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c9e000 b3ca4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cb4000 b3cb9000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cc9000 b3ce4000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3cf4000 b3cfb000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d0b000 b3d0e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d1f000 b3d4d000 r-xp /usr/lib/libidn.so.11.5.44
b3d5d000 b3d73000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d84000 b3d8e000 r-xp /usr/lib/libcares.so.2.1.0
b3d9e000 b3da8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3db8000 b3dba000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3dca000 b3dcb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3ddb000 b3ddf000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3df0000 b3e18000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e29000 b3e52000 r-xp /usr/lib/libturbojpeg.so
b3e72000 b3e78000 r-xp /usr/lib/libgif.so.4.1.6
b3e88000 b3ece000 r-xp /usr/lib/libcurl.so.4.3.0
b3edf000 b3f00000 r-xp /usr/lib/libexif.so.12.3.3
b3f1b000 b3f30000 r-xp /usr/lib/libtts.so
b3f41000 b3f49000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f59000 b4019000 r-xp /usr/lib/libdali-core.so.0.0.0
b4024000 b4117000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4137000 b4211000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4228000 b422a000 r-xp /usr/lib/libboost_system.so.1.51.0
b423a000 b4240000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4250000 b4273000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4284000 b4286000 r-xp /usr/lib/libappsvc.so.0.1.0
b4296000 b4298000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42a9000 b42ae000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42c5000 b42c7000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42d7000 b42de000 r-xp /usr/lib/libsensord-share.so
b42ee000 b4306000 r-xp /usr/lib/libsensor.so.1.1.0
b4317000 b431a000 r-xp /usr/lib/libXv.so.1.0.0
b432a000 b432f000 r-xp /usr/lib/libutilX.so.1.1.0
b433f000 b4344000 r-xp /usr/lib/libappcore-common.so.1.1
b4354000 b435b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b436e000 b4372000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4383000 b444d000 r-xp /usr/lib/libCOREGL.so.4.0
b4464000 b4467000 r-xp /usr/lib/libuuid.so.1.3.0
b4478000 b448f000 r-xp /usr/lib/libblkid.so.1.1.0
b44a0000 b44a2000 r-xp /usr/lib/libXau.so.6.0.0
b44b2000 b44b5000 r-xp /usr/lib/libEGL.so.1.4
b44bd000 b44c3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44d3000 b44d5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44e6000 b44f4000 r-xp /usr/lib/libGLESv2.so.2.0
b44fd000 b455f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4574000 b458c000 r-xp /usr/lib/libmount.so.1.1.0
b459d000 b45b1000 r-xp /usr/lib/libxcb.so.1.1.0
b45c2000 b45c9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4601000 b4612000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4623000 b4625000 r-xp /usr/lib/libiri.so
b4635000 b4640000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4651000 b4666000 r-xp /lib/libexpat.so.1.5.2
b4678000 b4736000 r-xp /usr/lib/libcairo.so.2.11200.14
b4749000 b4751000 r-xp /usr/lib/libdrm.so.2.4.0
b4761000 b4764000 r-xp /usr/lib/libdri2.so.0.0.0
b4775000 b47c3000 r-xp /usr/lib/libssl.so.1.0.0
b47d8000 b47e4000 r-xp /usr/lib/libeeze.so.1.13.0
b47f4000 b47fd000 r-xp /usr/lib/libethumb.so.1.13.0
b480d000 b4810000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4820000 b49d7000 r-xp /usr/lib/libcrypto.so.1.0.0
b562e000 b5637000 r-xp /usr/lib/libXi.so.6.1.0
b5647000 b5649000 r-xp /usr/lib/libXgesture.so.7.0.0
b5659000 b565d000 r-xp /usr/lib/libXtst.so.6.1.0
b566d000 b5673000 r-xp /usr/lib/libXrender.so.1.3.0
b5683000 b5689000 r-xp /usr/lib/libXrandr.so.2.2.0
b569a000 b569c000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ac000 b56af000 r-xp /usr/lib/libXfixes.so.3.1.0
b56bf000 b56ca000 r-xp /usr/lib/libXext.so.6.4.0
b56da000 b56dc000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ec000 b56ee000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56ff000 b57e1000 r-xp /usr/lib/libX11.so.6.3.0
b57f4000 b57fb000 r-xp /usr/lib/libXcursor.so.1.0.2
b580b000 b5823000 r-xp /usr/lib/libudev.so.1.6.0
b5825000 b5828000 r-xp /lib/libattr.so.1.1.0
b5838000 b5858000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b585a000 b585f000 r-xp /usr/lib/libffi.so.6.0.2
b586f000 b5887000 r-xp /lib/libz.so.1.2.8
b5897000 b5899000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58a9000 b597e000 r-xp /usr/lib/libxml2.so.2.9.2
b5993000 b5a2e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a4a000 b5a4d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a5d000 b5a76000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a87000 b5a98000 r-xp /lib/libresolv-2.20-2014.11.so
b5aac000 b5b26000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b3b000 b5b3d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b4d000 b5b54000 r-xp /usr/lib/libembryo.so.1.13.0
b5b64000 b5b7c000 r-xp /usr/lib/libpng12.so.0.50.0
b5b8d000 b5bb0000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd1000 b5be5000 r-xp /usr/lib/libector.so.1.13.0
b5bf6000 b5c0e000 r-xp /usr/lib/liblua-5.1.so
b5c1f000 b5c76000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8a000 b5cb2000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc3000 b5cd6000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ce7000 b5d1e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d2f000 b5d3d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d4d000 b5d55000 r-xp /usr/lib/libtbm.so.1.0.0
b5d65000 b5d72000 r-xp /usr/lib/libeio.so.1.13.0
b5d82000 b5d84000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d94000 b5d99000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5da9000 b5dc0000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd2000 b5df2000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e02000 b5e22000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e24000 b5e2a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e3a000 b5e4b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e5c000 b5e63000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e73000 b5e82000 r-xp /usr/lib/libeo.so.1.13.0
b5e93000 b5ea5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eb6000 b5ebb000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ecb000 b5ee4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ef4000 b5f11000 r-xp /usr/lib/libeet.so.1.13.0
b5f2a000 b5f72000 r-xp /usr/lib/libeina.so.1.13.0
b5f83000 b5f93000 r-xp /usr/lib/libefl.so.1.13.0
b5fa4000 b6089000 r-xp /usr/lib/libicuuc.so.51.1
b60a6000 b61e6000 r-xp /usr/lib/libicui18n.so.51.1
b61fd000 b6235000 r-xp /usr/lib/libecore_x.so.1.13.0
b6247000 b624a000 r-xp /lib/libcap.so.2.21
b625a000 b6283000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6294000 b629b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62ad000 b62e4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62f5000 b63e0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63f3000 b646c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b647e000 b6483000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6493000 b649d000 r-xp /usr/lib/libvconf.so.0.2.45
b64ad000 b64af000 r-xp /usr/lib/libvasum.so.0.3.1
b64bf000 b64c1000 r-xp /usr/lib/libttrace.so.1.1
b64d1000 b64d4000 r-xp /usr/lib/libiniparser.so.0
b64e4000 b650a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b651a000 b651f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6530000 b6547000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6558000 b65c3000 r-xp /lib/libm-2.20-2014.11.so
b65d4000 b65da000 r-xp /lib/librt-2.20-2014.11.so
b65eb000 b65f8000 r-xp /usr/lib/libunwind.so.8.0.1
b662e000 b6752000 r-xp /lib/libc-2.20-2014.11.so
b6767000 b6780000 r-xp /lib/libgcc_s-4.9.so.1
b6790000 b6872000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6883000 b68ad000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68be000 b68fa000 r-xp /usr/lib/libsystemd.so.0.4.0
b68fc000 b697e000 r-xp /usr/lib/libedje.so.1.13.0
b6991000 b69af000 r-xp /usr/lib/libecore.so.1.13.0
b69cf000 b6b56000 r-xp /usr/lib/libevas.so.1.13.0
b6b8b000 b6b9f000 r-xp /lib/libpthread-2.20-2014.11.so
b6bb3000 b6de8000 r-xp /usr/lib/libelementary.so.1.13.0
b6e16000 b6e1a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e2a000 b6e31000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e41000 b6e43000 r-xp /usr/lib/libdlog.so.0.0.0
b6e53000 b6e56000 r-xp /usr/lib/libbundle.so.0.1.22
b6e66000 b6e68000 r-xp /lib/libdl-2.20-2014.11.so
b6e79000 b6e91000 r-xp /usr/lib/libaul.so.0.1.0
b6ea5000 b6eaa000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ebb000 b6ec8000 r-xp /usr/lib/liblptcp.so
b6eda000 b6ede000 r-xp /usr/lib/libsys-assert.so
b6eef000 b6f0f000 r-xp /lib/ld-2.20-2014.11.so
b6f20000 b6f25000 r-xp /usr/bin/launchpad-loader
b828b000 b85bd000 rw-p [heap]
be8fa000 be91b000 rw-p [stack]
b828b000 b85bd000 rw-p [heap]
be8fa000 be91b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7455)
Call Stack Count: 1
 0: (0xb66a36f0) [/lib/libc.so.6] + 0x756f0
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
ther-m : com.samsung.weather-m-agent] 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:43:13.292+0600 E/MESSAGE_PORT( 7938): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 17:43:13.292+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 7938): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:43:13.292+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:43:13.302+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:43:13.302+0600 E/MESSAGE_PORT( 7938): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 17:43:13.302+0600 E/weather-common( 7938): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 17:43:13.302+0600 E/weather-agent( 7938): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 17:43:13.302+0600 E/weather-agent( 7938): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 17:43:13.302+0600 I/MESSAGE_PORT( 7938): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:43:13.302+0600 I/MESSAGE_PORT( 7938): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:43:13.322+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:43:13.372+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 17:43:13.372+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 17:43:13.572+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb82ffe28]
09-10 17:43:13.572+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:43:13.572+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:43:13.572+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:43:13.572+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb82ffe28
09-10 17:43:13.582+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:43:13.582+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:43:13.582+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:43:13.582+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 17:43:13.592+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:43:13.592+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:43:13.602+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:43:13.622+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80158242 is not stable during recalc loop
09-10 17:43:13.662+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18557212
09-10 17:43:13.692+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80158242 is not stable during recalc loop
09-10 17:43:13.692+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:43:13.702+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:43:13.762+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18557317
09-10 17:43:13.762+0600 E/LOCKSCREEN(  869): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80001:VIEW_GESTURED
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80001 event_info:0
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:4:LKD_EVT_WILL_UNLOCK
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:4 event_info:0
09-10 17:43:13.762+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event_delay(1042) > [lockd_event_delay:1042:W] dealyed event:2:UNLOCK wait for:0.330000
09-10 17:43:13.762+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 17:43:14.092+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:2 event_info:0
09-10 17:43:14.092+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:7
09-10 17:43:14.092+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
09-10 17:43:14.092+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:43:14.102+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:43:14.102+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:43:14.102+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:43:14.102+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:43:14.102+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_set(725) > [_lcd_timeout_timer_set:725:W] lcd off timer set:30.000000
09-10 17:43:14.112+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:43:14.112+0600 I/APP_CORE( 7455): appcore-efl.c: __do_app(520) > [APP 7455] Event: RESUME State: CREATED
09-10 17:43:14.122+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:43:14.122+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(4)
09-10 17:43:14.122+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(869)
09-10 17:43:14.122+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: bg
09-10 17:43:14.122+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(7455) status(3)
09-10 17:43:14.132+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:43:14.132+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:43:14.132+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(7455)
09-10 17:43:14.132+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 7455, appid: org.example.bluetooth, status: fg
09-10 17:43:14.132+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:43:14.142+0600 I/APP_CORE( 7455): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 17:43:14.142+0600 I/APP_CORE( 7455): appcore-efl.c: __do_app(637) > [APP 7455] Initial Launching, call the resume_cb
09-10 17:43:14.142+0600 I/CAPI_APPFW_APPLICATION( 7455): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:43:14.152+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [invisible]
09-10 17:43:14.152+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10002:WIN_BECOME_INVISIBLE
09-10 17:43:14.152+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10002 event_info:0
09-10 17:43:14.152+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:43:14.152+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:43:14.152+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
09-10 17:43:14.152+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 17:43:14.152+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:43:14.152+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:43:14.152+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 17:43:14.152+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 17:43:14.152+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 17:43:14.152+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 17:43:14.152+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 17:43:14.172+0600 I/Tizen::System( 1366): (259) > Active app [org.exampl], current [com.samsun] 
09-10 17:43:14.172+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:43:14.172+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 17:43:14.172+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:43:14.182+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:43:14.253+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-10 17:43:14.253+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:43:14.253+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:43:14.253+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:43:14.253+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:43:14.263+0600 E/LOCKSCREEN(  869): background-view.c: background_image_next_set(309) > [background_image_next_set:309:E] fopen wallpaper txt file failed.
09-10 17:43:14.303+0600 E/weather-agent( 7938): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:43:14.303+0600 I/CAPI_APPFW_APPLICATION( 7938): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:43:14.303+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:43:14.303+0600 E/weather-agent( 7938): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:43:14.303+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:43:14.443+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:43:14.443+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 7938
09-10 17:43:14.443+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[7938] terminate event is forwarded
09-10 17:43:14.443+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:43:14.443+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7938, ]
09-10 17:43:14.443+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:43:14.443+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:43:14.443+0600 I/Tizen::App( 1366): (512) > Not registered pid(7938)
09-10 17:43:14.443+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:43:14.443+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:43:14.443+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7938
09-10 17:43:14.443+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:43:14.453+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:43:14.453+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7938.
09-10 17:43:16.355+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18559905
09-10 17:43:16.405+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76af128), gem(10), surface(0xb78b9810)
09-10 17:43:16.405+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __onEcoreEventMsgReceived(962) > [0;31m* Critical * Quickpanel handle is enabled.[0;m
09-10 17:43:16.575+0600 E/EFL     (  283): <283> e_mod_processmgr.c:486 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
09-10 17:43:16.575+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18560138
09-10 17:43:16.585+0600 W/LOCKSCREEN(  869): event.c: _ecore_event_client_message_cb(122) > [_ecore_event_client_message_cb:122:W] quickpanel is opened
09-10 17:43:16.585+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:100000:QUICKPANEL_ON
09-10 17:43:16.585+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:100000 event_info:0
09-10 17:43:16.595+0600 I/APP_CORE(  991): appcore-efl.c: __do_app(520) > [APP 991] Event: RESUME State: PAUSED
09-10 17:43:16.595+0600 I/CAPI_APPFW_APPLICATION(  991): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:43:16.595+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(991) status(3)
09-10 17:43:16.595+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:43:16.595+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:43:16.595+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.quickpanel(991)
09-10 17:43:16.595+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 991, appid: com.samsung.quickpanel, status: fg
09-10 17:43:16.605+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:43:16.845+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __onEcoreEventMsgReceived(973) > [0;31m* Critical * Quickpanel is opened.[0;m
09-10 17:43:16.895+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb78448e8), gem(21), surface(0xb7893350)
09-10 17:43:16.985+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18560538
09-10 17:43:16.985+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18560538
09-10 17:43:17.055+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18560601
09-10 17:43:17.556+0600 E/EFL     (  991): edje<991> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/setting_icon_wvga has a non-fixed part 'bg.image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:43:17.576+0600 I/Tizen::System( 1366): (340) > Setting event[http://tizen.org/setting/network.bluetooth] is occured.
09-10 17:43:17.576+0600 I/Tizen::System( 1366): (362) > Event is delivered to b7f61910.
09-10 17:43:17.916+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:43:17.916+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:43:17.916+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:43:17.916+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:43:17.916+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:43:17.916+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:43:18.006+0600 D/bluetooth( 7455): [adapter_state_changed_cb] Bluetooth is disabled!
09-10 17:43:18.006+0600 I/Tizen::System( 1366): (1389) > Bluetooth callback is invoked. result:0, adapter_state:0, user_data:b804c5b8
09-10 17:43:18.006+0600 E/Tizen::System( 1366): (1393) > Bluetooth processing is under way.
09-10 17:43:18.006+0600 I/QUICKPANEL(  991): BluetoothQuickBtnControl.cpp: __onBluetoothStatusChanged(147) > [0;32mbluetooth state : 0[0;m
09-10 17:43:18.036+0600 E/EFL     (  991): edje<991> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/setting_icon_wvga has a non-fixed part 'bg.image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:43:18.407+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18561959
09-10 17:43:18.417+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18561959
09-10 17:43:18.427+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18561979
09-10 17:43:18.427+0600 E/EFL     (  283): <283> e_mod_processmgr.c:486 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
09-10 17:43:18.427+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18561979
09-10 17:43:18.457+0600 E/EFL     (  283): <283> e_mod_processmgr.c:486 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
09-10 17:43:18.687+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __onEcoreEventMsgReceived(973) > [0;31m* Critical * Quickpanel is opened.[0;m
09-10 17:43:18.877+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18562430
09-10 17:43:18.887+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18562430
09-10 17:43:19.027+0600 E/EFL     (  283): ecore_x<283> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18562580
09-10 17:43:19.027+0600 E/EFL     (  283): <283> e_mod_processmgr.c:486 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
09-10 17:43:19.037+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(991) status(4)
09-10 17:43:19.037+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.quickpanel(991)
09-10 17:43:19.037+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 991, appid: com.samsung.quickpanel, status: bg
09-10 17:43:19.037+0600 E/EFL     (  991): ecore_x<991> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18562580
09-10 17:43:19.047+0600 I/APP_CORE(  991): appcore-efl.c: __do_app(520) > [APP 991] Event: PAUSE State: RUNNING
09-10 17:43:19.047+0600 I/CAPI_APPFW_APPLICATION(  991): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:43:19.167+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 17:43:19.277+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __onEcoreEventMsgReceived(973) > [0;31m* Critical * Quickpanel is opened.[0;m
09-10 17:43:19.277+0600 W/LOCKSCREEN(  869): event.c: _ecore_event_client_message_cb(119) > [_ecore_event_client_message_cb:119:W] quickpanel is closed
09-10 17:43:19.277+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:100001:QUICKPANEL_OFF
09-10 17:43:19.277+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:100001 event_info:0
09-10 17:43:19.277+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __onEcoreEventMsgReceived(934) > [0;31m* Critical * Quickpanel is closed.[0;m
09-10 17:43:19.287+0600 E/QUICKPANEL(  991): QuickpanelApp.cpp: __ungrabKeyEvent(534) > [0;31m* Critical * failed to ungrab KEY_SELECT[0;m
09-10 17:43:19.297+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:43:19.498+0600 E/EFL     ( 7455): ecore_x<7455> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18563050
09-10 17:43:19.498+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18563050
09-10 17:43:19.498+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 17:43:19.498+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 17:43:19.498+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:43:19.798+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 17:43:19.798+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 17:43:19.798+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 17:43:19.798+0600 E/STARTER (  763): )
09-10 17:43:19.798+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 17:43:19.798+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:43:19.798+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:43:19.808+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 17:43:19.808+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:43:19.818+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 17:43:19.818+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 17:43:19.818+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 17:43:19.818+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 17:43:19.828+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:43:19.828+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 17:43:19.828+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:43:19.828+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 17:43:19.828+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:43:19.828+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 17:43:19.828+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 17:43:19.828+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 17:43:19.848+0600 E/CAPI_APPFW_APPLICATION( 5441): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:43:19.848+0600 E/CAPI_APPFW_APPLICATION( 5441): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:43:19.848+0600 E/CAPI_APPFW_APPLICATION( 5441): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:43:19.848+0600 E/CAPI_APPFW_APPLICATION( 5441): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:43:19.848+0600 E/CAPI_APPFW_APPLICATION( 5441): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:43:19.848+0600 I/CAPI_APPFW_APPLICATION( 5441): app_main.c: ui_app_main(789) > app_efl_main
09-10 17:43:19.848+0600 I/CAPI_APPFW_APPLICATION( 5441): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 17:43:19.868+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77692b8), gem(10), surface(0xb7893350)
09-10 17:43:19.868+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77692b8), gem(10), surface(0xb78b9810)
09-10 17:43:19.868+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 17:43:19.878+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 17:43:19.878+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 17:43:19.928+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7850178), gem(21), surface(0xb787e520)
09-10 17:43:19.928+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 5441, appid: com.samsung.task-mgr
09-10 17:43:19.928+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 17:43:19.938+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5441)
09-10 17:43:19.948+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:43:20.008+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 17:43:20.008+0600 W/TASK_MGR_LITE( 5441): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 17:43:20.018+0600 I/GXT_SIB ( 5441): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 17:43:20.078+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:43:20.078+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:43:20.078+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:43:20.078+0600 E/RUA     ( 5441): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 19, ncols : 5
09-10 17:43:20.078+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 17:43:20.078+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:43:20.088+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 7455
09-10 17:43:20.088+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 17:43:20.088+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 17:43:20.118+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 17:43:20.118+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18563666
09-10 17:43:20.118+0600 E/EFL     ( 7455): ecore_x<7455> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18563666
09-10 17:43:20.118+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 17:43:20.118+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 17:43:20.118+0600 E/STARTER (  763): )
09-10 17:43:20.118+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 17:43:20.128+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 17:43:20.128+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:43:20.128+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 17:43:20.128+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:43:20.128+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:43:20.138+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:43:20.158+0600 I/TIZEN_N_SOUND_MANAGER( 6620): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 17:43:20.158+0600 E/TIZEN_N_SOUND_MANAGER( 6620): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:43:20.158+0600 I/APP_CORE( 5441): appcore-efl.c: __do_app(520) > [APP 5441] Event: RESET State: CREATED
09-10 17:43:20.158+0600 I/CAPI_APPFW_APPLICATION( 5441): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 17:43:20.158+0600 I/TIZEN_N_SOUND_MANAGER( 6620): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 17:43:20.158+0600 E/TIZEN_N_SOUND_MANAGER( 6620): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:43:20.158+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:43:20.178+0600 E/EFL     ( 5441): edje<5441> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:43:20.178+0600 E/EFL     ( 5441): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:43:20.178+0600 E/EFL     ( 5441): edje<5441> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:43:20.178+0600 E/EFL     ( 5441): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:43:20.178+0600 W/APP_CORE( 5441): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200003
09-10 17:43:20.178+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 17:43:20.238+0600 I/MALI    ( 5441): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb8668b78)
09-10 17:43:20.258+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77cd5f8), gem(31), surface(0xb78ae510)
09-10 17:43:20.258+0600 I/MALI    ( 5441): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:43:20.268+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(5441) status(0)
09-10 17:43:20.268+0600 I/APP_CORE( 5441): appcore-efl.c: __do_app(520) > [APP 5441] Event: RESUME State: CREATED
09-10 17:43:20.268+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:43:20.278+0600 I/APP_CORE( 7455): appcore-efl.c: __do_app(520) > [APP 7455] Event: PAUSE State: RUNNING
09-10 17:43:20.278+0600 I/CAPI_APPFW_APPLICATION( 7455): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:43:20.278+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(5441) status(3)
09-10 17:43:20.278+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:43:20.278+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:43:20.278+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(5441)
09-10 17:43:20.278+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 5441, appid: com.samsung.task-mgr, status: fg
09-10 17:43:20.288+0600 I/APP_CORE( 5441): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 17:43:20.288+0600 I/APP_CORE( 5441): appcore-efl.c: __do_app(637) > [APP 5441] Initial Launching, call the resume_cb
09-10 17:43:20.288+0600 I/CAPI_APPFW_APPLICATION( 5441): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:43:20.288+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 7455): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 14
09-10 17:43:20.288+0600 E/APP_CORE( 7455): appcore-efl.c: _capture_and_make_file(1631) > win[6200002] widget[480] height[800]
09-10 17:43:20.288+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:43:20.298+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76a8f50), gem(28), surface(0xb78b9810)
09-10 17:43:20.298+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:43:20.679+0600 E/EFL     ( 5441): ecore_x<5441> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18564229
09-10 17:43:20.739+0600 E/EFL     ( 5441): ecore_x<5441> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18564290
09-10 17:43:20.739+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:43:20.739+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 7455
09-10 17:43:20.739+0600 W/AUL     ( 5441): launch.c: app_request_to_launchpad(396) > request cmd(4) to(7455)
09-10 17:43:20.739+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 17:43:20.739+0600 I/APP_CORE( 7455): appcore-efl.c: __do_app(520) > [APP 7455] Event: TERMINATE State: PAUSED
09-10 17:43:20.749+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(7455), cmd(4)
09-10 17:43:20.749+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:43:20.749+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:43:20.749+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:43:20.749+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:43:20.749+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 7455): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:43:20.749+0600 E/APP_CORE( 7455): appcore-efl.c: _capture_and_make_file(1631) > win[6200002] widget[480] height[800]
09-10 17:43:20.749+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:43:20.749+0600 E/APP_CORE( 7455): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:43:20.749+0600 I/CAPI_APPFW_APPLICATION( 7455): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:43:20.749+0600 E/CAPI_NETWORK_BLUETOOTH( 7455): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:43:20.759+0600 W/AUL     ( 5441): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 17:43:20.789+0600 I/MALI    ( 5441): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:43:20.809+0600 E/CAPI_NETWORK_BLUETOOTH( 7455): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:43:20.809+0600 E/CAPI_NETWORK_BLUETOOTH( 7455): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:43:20.809+0600 E/bluetooth( 7455): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:43:20.809+0600 I/MALI    ( 5441): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:43:20.819+0600 I/CAPI_NETWORK_WIFI( 7455): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:43:20.819+0600 E/bluetooth( 7455): [wifi_deinitialize] Success.
09-10 17:43:20.859+0600 I/MALI    ( 5441): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:43:20.889+0600 E/EFL     ( 7455): elementary<7455> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 17:43:20.989+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 17:43:20.989+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 5441.
09-10 17:43:20.999+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2865
09-10 17:43:21.059+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:43:21.059+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:43:21.059+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(5441)
09-10 17:43:21.059+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 5441, appid: com.samsung.task-mgr, status: bg
09-10 17:43:21.059+0600 I/CAPI_APPFW_APPLICATION( 5441): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:43:21.059+0600 W/TASK_MGR_LITE( 5441): task-mgr-lite.c: _pause_app(406) > 
09-10 17:43:21.059+0600 I/CAPI_APPFW_APPLICATION( 5441): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:43:21.089+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7455 pgid = 7455
09-10 17:43:21.089+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(7455)
09-10 17:43:21.099+0600 E/TASK_MGR_LITE( 5441): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 17:43:21.119+0600 W/CRASH_MANAGER( 8009): worker.c: worker_job(1199) > 1107455626162147350780
