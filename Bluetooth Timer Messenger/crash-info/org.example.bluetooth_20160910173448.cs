S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 4395
Date: 2016-09-10 17:34:48+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4395, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb7e32f20
r2   = 0xb42d3000, r3   = 0xb42d3000
r4   = 0xbef7f5bc, r5   = 0xb69d20f4
r6   = 0xb69d1310, r7   = 0xbef7f41c
r8   = 0xb69d20f4, r9   = 0xb69d20f4
r10  = 0xb69e020c, fp   = 0x00000000
ip   = 0xb29c6a44, sp   = 0xbef7e798
lr   = 0xb29bc183, pc   = 0xb66b56f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     44452 KB
Buffers:     44248 KB
Cached:     287852 KB
VmPeak:     105584 KB
VmSize:     104628 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24868 KB
VmRSS:       24868 KB
VmData:      34720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4395 TID = 4395
4395 4421 4580 

Maps Information
b1d12000 b2511000 rw-p [stack:4580]
b2511000 b2522000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2532000 b2537000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25c3000 b25cb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25dc000 b25dd000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25ed000 b2601000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2615000 b2616000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2626000 b2629000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b263a000 b263b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b264b000 b264d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b265d000 b265f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b266f000 b267f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b268f000 b269b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28ac000 b28c3000 r-xp /usr/lib/libnetwork.so.0.0.0
b28d4000 b2912000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2923000 b292a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b293b000 b294a000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b295a000 b298f000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29a2000 b29a8000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29b8000 b29bf000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2ae0000 b2bc3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2bfa000 b2c22000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c34000 b3433000 rw-p [stack:4421]
b3433000 b3435000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3445000 b344f000 r-xp /lib/libnss_files-2.20-2014.11.so
b3460000 b3469000 r-xp /lib/libnss_nis-2.20-2014.11.so
b347a000 b348b000 r-xp /lib/libnsl-2.20-2014.11.so
b349e000 b34a4000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34b5000 b34b6000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34de000 b34e5000 r-xp /usr/lib/libminizip.so.1.0.0
b34f5000 b34fa000 r-xp /usr/lib/libstorage.so.0.1
b350a000 b355f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3575000 b3589000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3599000 b35dd000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35ed000 b35f5000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3605000 b3635000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3648000 b3701000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3715000 b3769000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b377a000 b3795000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37a5000 b3866000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3879000 b388b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b389b000 b389f000 r-xp /usr/lib/libogg.so.0.7.1
b38af000 b38d1000 r-xp /usr/lib/libvorbis.so.0.4.3
b38e1000 b39c5000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39e1000 b39ee000 r-xp /usr/lib/libmdm-common.so.1.0.98
b39ff000 b3a42000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a57000 b3a9e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3aaf000 b3ab5000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ac6000 b3acd000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3add000 b3b1d000 r-xp /usr/lib/libmdm.so.1.2.10
b3b2d000 b3b35000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b44000 b3b54000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b75000 b3bd5000 r-xp /usr/lib/libasound.so.2.0.0
b3be7000 b3c1d000 r-xp /usr/lib/libpulse.so.0.16.2
b3c2e000 b3c31000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c41000 b3c44000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c54000 b3c59000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c69000 b3c6a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c7a000 b3c85000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3c99000 b3ca0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cb0000 b3cb6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cc6000 b3ccb000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3cdb000 b3cf6000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d06000 b3d0d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d1d000 b3d20000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d31000 b3d5f000 r-xp /usr/lib/libidn.so.11.5.44
b3d6f000 b3d85000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3d96000 b3da0000 r-xp /usr/lib/libcares.so.2.1.0
b3db0000 b3dba000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dca000 b3dcc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3ddc000 b3ddd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3ded000 b3df1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e02000 b3e2a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e3b000 b3e64000 r-xp /usr/lib/libturbojpeg.so
b3e84000 b3e8a000 r-xp /usr/lib/libgif.so.4.1.6
b3e9a000 b3ee0000 r-xp /usr/lib/libcurl.so.4.3.0
b3ef1000 b3f12000 r-xp /usr/lib/libexif.so.12.3.3
b3f2d000 b3f42000 r-xp /usr/lib/libtts.so
b3f53000 b3f5b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f6b000 b402b000 r-xp /usr/lib/libdali-core.so.0.0.0
b4036000 b4129000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4149000 b4223000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b423a000 b423c000 r-xp /usr/lib/libboost_system.so.1.51.0
b424c000 b4252000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4262000 b4285000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4296000 b4298000 r-xp /usr/lib/libappsvc.so.0.1.0
b42a8000 b42aa000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42bb000 b42c0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42d7000 b42d9000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42e9000 b42f0000 r-xp /usr/lib/libsensord-share.so
b4300000 b4318000 r-xp /usr/lib/libsensor.so.1.1.0
b4329000 b432c000 r-xp /usr/lib/libXv.so.1.0.0
b433c000 b4341000 r-xp /usr/lib/libutilX.so.1.1.0
b4351000 b4356000 r-xp /usr/lib/libappcore-common.so.1.1
b4366000 b436d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4380000 b4384000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4395000 b445f000 r-xp /usr/lib/libCOREGL.so.4.0
b4476000 b4479000 r-xp /usr/lib/libuuid.so.1.3.0
b448a000 b44a1000 r-xp /usr/lib/libblkid.so.1.1.0
b44b2000 b44b4000 r-xp /usr/lib/libXau.so.6.0.0
b44c4000 b44c7000 r-xp /usr/lib/libEGL.so.1.4
b44cf000 b44d5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44e5000 b44e7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b44f8000 b4506000 r-xp /usr/lib/libGLESv2.so.2.0
b450f000 b4571000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4586000 b459e000 r-xp /usr/lib/libmount.so.1.1.0
b45af000 b45c3000 r-xp /usr/lib/libxcb.so.1.1.0
b45d4000 b45db000 r-xp /lib/libcrypt-2.20-2014.11.so
b4613000 b4624000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4635000 b4637000 r-xp /usr/lib/libiri.so
b4647000 b4652000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4663000 b4678000 r-xp /lib/libexpat.so.1.5.2
b468a000 b4748000 r-xp /usr/lib/libcairo.so.2.11200.14
b475b000 b4763000 r-xp /usr/lib/libdrm.so.2.4.0
b4773000 b4776000 r-xp /usr/lib/libdri2.so.0.0.0
b4787000 b47d5000 r-xp /usr/lib/libssl.so.1.0.0
b47ea000 b47f6000 r-xp /usr/lib/libeeze.so.1.13.0
b4806000 b480f000 r-xp /usr/lib/libethumb.so.1.13.0
b481f000 b4822000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4832000 b49e9000 r-xp /usr/lib/libcrypto.so.1.0.0
b5640000 b5649000 r-xp /usr/lib/libXi.so.6.1.0
b5659000 b565b000 r-xp /usr/lib/libXgesture.so.7.0.0
b566b000 b566f000 r-xp /usr/lib/libXtst.so.6.1.0
b567f000 b5685000 r-xp /usr/lib/libXrender.so.1.3.0
b5695000 b569b000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ac000 b56ae000 r-xp /usr/lib/libXinerama.so.1.0.0
b56be000 b56c1000 r-xp /usr/lib/libXfixes.so.3.1.0
b56d1000 b56dc000 r-xp /usr/lib/libXext.so.6.4.0
b56ec000 b56ee000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fe000 b5700000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5711000 b57f3000 r-xp /usr/lib/libX11.so.6.3.0
b5806000 b580d000 r-xp /usr/lib/libXcursor.so.1.0.2
b581d000 b5835000 r-xp /usr/lib/libudev.so.1.6.0
b5837000 b583a000 r-xp /lib/libattr.so.1.1.0
b584a000 b586a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b586c000 b5871000 r-xp /usr/lib/libffi.so.6.0.2
b5881000 b5899000 r-xp /lib/libz.so.1.2.8
b58a9000 b58ab000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58bb000 b5990000 r-xp /usr/lib/libxml2.so.2.9.2
b59a5000 b5a40000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a5c000 b5a5f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6f000 b5a88000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a99000 b5aaa000 r-xp /lib/libresolv-2.20-2014.11.so
b5abe000 b5b38000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4d000 b5b4f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5f000 b5b66000 r-xp /usr/lib/libembryo.so.1.13.0
b5b76000 b5b8e000 r-xp /usr/lib/libpng12.so.0.50.0
b5b9f000 b5bc2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5be3000 b5bf7000 r-xp /usr/lib/libector.so.1.13.0
b5c08000 b5c20000 r-xp /usr/lib/liblua-5.1.so
b5c31000 b5c88000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c9c000 b5cc4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cd5000 b5ce8000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf9000 b5d30000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d41000 b5d4f000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d5f000 b5d67000 r-xp /usr/lib/libtbm.so.1.0.0
b5d77000 b5d84000 r-xp /usr/lib/libeio.so.1.13.0
b5d94000 b5d96000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da6000 b5dab000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dbb000 b5dd2000 r-xp /usr/lib/libefreet.so.1.13.0
b5de4000 b5e04000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e14000 b5e34000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e36000 b5e3c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e4c000 b5e5d000 r-xp /usr/lib/libemotion.so.1.13.0
b5e6e000 b5e75000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e85000 b5e94000 r-xp /usr/lib/libeo.so.1.13.0
b5ea5000 b5eb7000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ec8000 b5ecd000 r-xp /usr/lib/libecore_file.so.1.13.0
b5edd000 b5ef6000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f06000 b5f23000 r-xp /usr/lib/libeet.so.1.13.0
b5f3c000 b5f84000 r-xp /usr/lib/libeina.so.1.13.0
b5f95000 b5fa5000 r-xp /usr/lib/libefl.so.1.13.0
b5fb6000 b609b000 r-xp /usr/lib/libicuuc.so.51.1
b60b8000 b61f8000 r-xp /usr/lib/libicui18n.so.51.1
b620f000 b6247000 r-xp /usr/lib/libecore_x.so.1.13.0
b6259000 b625c000 r-xp /lib/libcap.so.2.21
b626c000 b6295000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a6000 b62ad000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62bf000 b62f6000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6307000 b63f2000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6405000 b647e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6490000 b6495000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a5000 b64af000 r-xp /usr/lib/libvconf.so.0.2.45
b64bf000 b64c1000 r-xp /usr/lib/libvasum.so.0.3.1
b64d1000 b64d3000 r-xp /usr/lib/libttrace.so.1.1
b64e3000 b64e6000 r-xp /usr/lib/libiniparser.so.0
b64f6000 b651c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b652c000 b6531000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6542000 b6559000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b656a000 b65d5000 r-xp /lib/libm-2.20-2014.11.so
b65e6000 b65ec000 r-xp /lib/librt-2.20-2014.11.so
b65fd000 b660a000 r-xp /usr/lib/libunwind.so.8.0.1
b6640000 b6764000 r-xp /lib/libc-2.20-2014.11.so
b6779000 b6792000 r-xp /lib/libgcc_s-4.9.so.1
b67a2000 b6884000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6895000 b68bf000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68d0000 b690c000 r-xp /usr/lib/libsystemd.so.0.4.0
b690e000 b6990000 r-xp /usr/lib/libedje.so.1.13.0
b69a3000 b69c1000 r-xp /usr/lib/libecore.so.1.13.0
b69e1000 b6b68000 r-xp /usr/lib/libevas.so.1.13.0
b6b9d000 b6bb1000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc5000 b6dfa000 r-xp /usr/lib/libelementary.so.1.13.0
b6e28000 b6e2c000 r-xp /usr/lib/libsmack.so.1.0.0
b6e3c000 b6e43000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e53000 b6e55000 r-xp /usr/lib/libdlog.so.0.0.0
b6e65000 b6e68000 r-xp /usr/lib/libbundle.so.0.1.22
b6e78000 b6e7a000 r-xp /lib/libdl-2.20-2014.11.so
b6e8b000 b6ea3000 r-xp /usr/lib/libaul.so.0.1.0
b6eb7000 b6ebc000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ecd000 b6eda000 r-xp /usr/lib/liblptcp.so
b6eec000 b6ef0000 r-xp /usr/lib/libsys-assert.so
b6f01000 b6f21000 r-xp /lib/ld-2.20-2014.11.so
b6f32000 b6f37000 r-xp /usr/bin/launchpad-loader
b7cd3000 b8005000 rw-p [heap]
bef5f000 bef80000 rw-p [stack]
b7cd3000 b8005000 rw-p [heap]
bef5f000 bef80000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4395)
Call Stack Count: 1
 0: (0xb66b56f0) [/lib/libc.so.6] + 0x756f0
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
88): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 17:33:55.157+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:33:55.157+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:33:55.157+0600 I/MESSAGE_PORT( 4388): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:33:55.157+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 17:33:55.157+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 17:33:55.157+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:33:55.167+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:33:55.167+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:33:55.167+0600 E/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 17:33:55.167+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 17:33:55.167+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:33:55.167+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 4388): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 17:33:55.177+0600 I/MESSAGE_PORT( 4388): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:33:55.177+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:33:55.187+0600 E/MESSAGE_PORT( 4388): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 17:33:55.187+0600 E/weather-common( 4388): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 17:33:55.187+0600 E/weather-agent( 4388): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 17:33:55.187+0600 E/weather-agent( 4388): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 17:33:55.187+0600 I/MESSAGE_PORT( 4388): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:33:55.187+0600 I/MESSAGE_PORT( 4388): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:33:55.217+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:33:55.247+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 17:33:55.247+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 17:33:55.417+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb834aed8]
09-10 17:33:55.417+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:33:55.417+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:33:55.417+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:33:55.417+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb834aed8
09-10 17:33:55.417+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:33:55.427+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:33:55.427+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:33:55.427+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 17:33:55.437+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:33:55.437+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:33:55.447+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:33:55.477+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8016d2b2 is not stable during recalc loop
09-10 17:33:55.547+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8016d2b2 is not stable during recalc loop
09-10 17:33:55.547+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:33:55.557+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:33:55.598+0600 E/rpm-installer( 4406): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 17:33:55.598+0600 E/rpm-installer( 4406): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 17:33:55.598+0600 E/rpm-installer( 4406): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 17:33:55.628+0600 E/PKGMGR_SERVER( 4403): pkgmgr-server.c: sighandler(417) > child NORMAL exit [4406]
09-10 17:33:56.068+0600 I/UXT     ( 4395): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 17:33:56.188+0600 E/weather-agent( 4388): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:33:56.188+0600 I/CAPI_APPFW_APPLICATION( 4388): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:33:56.188+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:33:56.188+0600 E/weather-agent( 4388): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:33:56.188+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:33:56.308+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:33:56.318+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 4388
09-10 17:33:56.318+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[4388] terminate event is forwarded
09-10 17:33:56.318+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:33:56.318+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 4388, ]
09-10 17:33:56.318+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:33:56.318+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:33:56.318+0600 I/Tizen::App( 1366): (512) > Not registered pid(4388)
09-10 17:33:56.318+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:33:56.318+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:33:56.318+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 4388
09-10 17:33:56.318+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:33:56.328+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:33:56.328+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 4388.
09-10 17:33:56.448+0600 E/PKGMGR_SERVER( 4403): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 17:33:56.448+0600 E/PKGMGR_SERVER( 4403): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 17:33:57.640+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:33:57.640+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:33:57.660+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 17:33:57.660+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 17:33:57.660+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 17:33:57.670+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 17:33:57.700+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 17:33:57.700+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 17:33:57.700+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 17:33:57.700+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:14d2ce8
09-10 17:33:57.700+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 17:33:57.700+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => WILL PAUSE
09-10 17:33:57.800+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:33:57.800+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:33:57.800+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:33:57.800+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:33:57.800+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:33:57.800+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_set(725) > [_lcd_timeout_timer_set:725:W] lcd off timer set:30.000000
09-10 17:33:58.240+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:33:58.240+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:33:58.240+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 17:33:58.240+0600 W/APP_CORE( 3957): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 17:33:58.240+0600 I/APP_CORE( 3957): appcore-efl.c: __do_app(520) > [APP 3957] Event: PAUSE State: RUNNING
09-10 17:33:58.270+0600 W/APP_CORE(  869): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 17:33:58.270+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 17:33:58.270+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:33:58.270+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:33:58.270+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 17:33:58.270+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 17:33:58.270+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 17:33:58.270+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 17:33:58.270+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 17:33:58.280+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 17:33:58.280+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 17:33:58.280+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 17:33:58.280+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 17:33:58.280+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 17:33:58.280+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 17:33:58.320+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 17:33:59.211+0600 E/PKGMGR  ( 4481): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
09-10 17:33:59.321+0600 E/PKGMGR_SERVER( 4484): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:33:59.371+0600 E/PKGMGR_SERVER( 4484): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk]
09-10 17:33:59.391+0600 E/PKGMGR_INFO( 4484): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] not found in DB
09-10 17:33:59.391+0600 E/BACKEND_LIB( 4484): librpm.c: __installer_util_delete_dir(179) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
09-10 17:33:59.401+0600 E/PKGMGR_SERVER( 4484): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
09-10 17:33:59.401+0600 E/PKGMGR  ( 4481): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[44810002]
09-10 17:33:59.481+0600 E/rpm-installer( 4490): rpm-appcore-intf.c: main(104) > ------------------------------------------------
09-10 17:33:59.481+0600 E/rpm-installer( 4490): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
09-10 17:33:59.481+0600 E/rpm-installer( 4490): rpm-appcore-intf.c: main(106) > ------------------------------------------------
09-10 17:33:59.541+0600 E/PKGMGR_INSTALLER( 4490): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
09-10 17:33:59.541+0600 E/rpm-installer( 4490): rpm-appcore-intf.c: main(191) > [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] is tpk package.
09-10 17:33:59.561+0600 E/rpm-installer( 4490): coretpk-parser.c: _coretpk_parser_is_svc_app(1225) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
09-10 17:33:59.561+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [install-location] is empty.
09-10 17:33:59.561+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 17:33:59.561+0600 E/rpm-installer( 4490): coretpk-parser.c: _coretpk_parser_is_widget(1191) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
09-10 17:33:59.561+0600 E/rpm-installer( 4490): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 17:33:59.682+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: start, val: install
09-10 17:33:59.682+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [start], Value = [install], install = [1]
09-10 17:33:59.702+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 30
09-10 17:33:59.702+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [30]
09-10 17:33:59.702+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [30], install = [1]
09-10 17:33:59.712+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:33:59.712+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:33:59.712+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:33:59.712+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:33:59.712+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:33:59.712+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:33:59.802+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_check_vip_tag(474) > (ret == 1) metadata(watchface) is empty.
09-10 17:33:59.802+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [ui-gadget] is empty.
09-10 17:33:59.812+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_get_dpi_type(778) > key for dpi is found, get the dpi.
09-10 17:33:59.812+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_get_dpi_type(787) > device dpi is [233]
09-10 17:33:59.812+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_append_path(343) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
09-10 17:33:59.812+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
09-10 17:33:59.812+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_allow_onboot(582) > (ret == 1) metadata is empty.
09-10 17:33:59.812+0600 E/rpm-installer( 4490): coretpk-parser.c: __coretpk_parser_allow_autorestart(644) > (ret == 1) metadata is empty.
09-10 17:33:59.822+0600 E/PKGMGR_PARSER( 4490): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2682) > Manifest is Valid
09-10 17:33:59.832+0600 E/PKGMGR_PARSER( 4490): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
09-10 17:33:59.842+0600 E/PKGMGR_PARSER( 4490): pkgmgr_parser_db.c: __verify_label_cb(353) > package_label is PKGMGR_PARSER_EMPTY_STR
09-10 17:33:59.882+0600 I/PRIVACY-MANAGER-CLIENT( 4490): SocketClient.cpp: SocketClient(37) > Client created
09-10 17:34:00.142+0600 E/PKGMGR_PARSER( 4490): pkgmgr_parser.c: __check_theme(146) > theme for installation.
09-10 17:34:00.162+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-10 17:34:00.162+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 100
09-10 17:34:00.162+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 100
09-10 17:34:00.162+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 25 1
09-10 17:34:00.162+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 26 1
09-10 17:34:00.162+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 27 1
09-10 17:34:00.162+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 28 1
09-10 17:34:00.172+0600 E/PKGMGR_CERT( 4490): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
09-10 17:34:00.182+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 60
09-10 17:34:00.182+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [60]
09-10 17:34:00.182+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [60], install = [1]
09-10 17:34:00.192+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.192+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.192+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.192+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(154) > Enter
09-10 17:34:00.192+0600 I/SHAREDRULE_CLIENT(  592): SocketConnection.h: SocketConnection(47) > Created
09-10 17:34:00.192+0600 I/SHAREDRULE_SERVER(  589): SocketService.cpp: mainloop(234) > Got incoming connection
09-10 17:34:00.192+0600 I/SHAREDRULE_SERVER(  589): SocketConnection.h: SocketConnection(47) > Created
09-10 17:34:00.212+0600 I/SHAREDRULE_CLIENT(  592): SharedruleClient.cpp: addSharedrule(190) > return result : 0
09-10 17:34:00.212+0600 E/rpm-installer( 4490): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
09-10 17:34:00.242+0600 E/rpm-installer( 4490): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
09-10 17:34:00.252+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: install_percent, val: 100
09-10 17:34:00.252+0600 I/Tizen::App( 1366): (119) > InstallationInProgress [100]
09-10 17:34:00.252+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [install_percent], Value = [100], install = [1]
09-10 17:34:00.252+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.252+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.252+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.893+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
09-10 17:34:00.893+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
09-10 17:34:00.893+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
09-10 17:34:00.903+0600 I/Tizen::App( 1366): (1894) > PackageEventHandler - req: 13660002, pkg_type: tpk, pkg_name: org.example.bluetooth, key: end, val: ok
09-10 17:34:00.903+0600 I/Tizen::App( 1366): (78) > Installation is Completed. [Package = org.example.bluetooth]
09-10 17:34:00.903+0600 I/Tizen::App( 1366): (671) > Enter. package(org.example.bluetooth), installationResult(0)
09-10 17:34:00.943+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.953+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.bluetooth]
09-10 17:34:00.953+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.bluetooth]
09-10 17:34:00.953+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
09-10 17:34:00.953+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
09-10 17:34:00.953+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.bluetooth]
09-10 17:34:00.963+0600 I/Tizen::App( 1366): (1360) > package(org.example.bluetooth), version(1.0.0), type(tpk), displayName(Timer Messenger), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.bluetooth), storeClient(), appRootPath(/opt/usr/apps/org.example.bluetooth)
09-10 17:34:00.973+0600 W/ISF_PANEL_EFL(  805): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
09-10 17:34:00.973+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.973+0600 E/PKGMGR  ( 1572): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
09-10 17:34:00.983+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[Timer Messenger] enable[1] system[0]
09-10 17:34:00.983+0600 E/HOME_APPS(  873): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.bluetooth] mdm is not enabled
09-10 17:34:00.983+0600 I/Tizen::App( 1366): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.bluetooth]
09-10 17:34:00.983+0600 E/cluster-home(  873): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[Timer Messenger] enable[1] system[0]
09-10 17:34:00.983+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: UpdateBoxData(1330) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], New icon path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png]!!!!!
09-10 17:34:00.993+0600 E/util-view(  873): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=22 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
09-10 17:34:00.993+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 17:34:00.993+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 17:34:01.003+0600 E/PKGMGR_INFO( 1366): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-10 17:34:01.003+0600 I/Tizen::App( 1366): (683) > Application count(1) in this package
09-10 17:34:01.003+0600 I/Tizen::App( 1366): (840) > Enter.
09-10 17:34:01.003+0600 I/Tizen::App( 1366): (703) > Exit.
09-10 17:34:01.003+0600 I/Tizen::App( 1366): (1584) > Package = [org.example.bluetooth], Key = [end], Value = [ok], install = [1]
09-10 17:34:01.023+0600 I/Tizen::App( 1366): (416) > appName = [babu]
09-10 17:34:01.023+0600 I/Tizen::App( 1366): (509) > exe = [/opt/usr/apps/org.example.bluetooth/bin/babu], displayName = [Timer Messenger], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-10 17:34:01.023+0600 I/Tizen::App( 1366): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.bluetooth.info]
09-10 17:34:01.023+0600 I/Tizen::App( 1366): (131) > Enter
09-10 17:34:01.033+0600 W/HOME_APPS(  873): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/BM.png], Loading state:[1]
09-10 17:34:01.033+0600 I/Tizen::App( 1366): (137) > org.example.bluetooth does not have launch condition
09-10 17:34:01.033+0600 I/Tizen::App( 1366): (883) > Exit.
09-10 17:34:01.043+0600 E/rpm-installer( 4490): rpm-appcore-intf.c: main(260) > ------------------------------------------------
09-10 17:34:01.043+0600 E/rpm-installer( 4490): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
09-10 17:34:01.043+0600 E/rpm-installer( 4490): rpm-appcore-intf.c: main(262) > ------------------------------------------------
09-10 17:34:01.073+0600 E/PKGMGR_SERVER( 4484): pkgmgr-server.c: sighandler(417) > child NORMAL exit [4490]
09-10 17:34:01.193+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:34:01.453+0600 E/PKGMGR_SERVER( 4484): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-10 17:34:01.453+0600 E/PKGMGR_SERVER( 4484): pkgmgr-server.c: main(2471) > package manager server terminated.
09-10 17:34:03.245+0600 I/APP_CORE( 3957): appcore-efl.c: __do_app(520) > [APP 3957] Event: MEM_FLUSH State: PAUSED
09-10 17:34:03.265+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 17:34:06.698+0600 W/AUL     ( 4579): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.bluetooth)
09-10 17:34:06.708+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:34:06.718+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
09-10 17:34:06.718+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
09-10 17:34:06.718+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 17:34:06.718+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 4579
09-10 17:34:06.718+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 17:34:06.738+0600 E/RESOURCED(15587): block.c: block_prelaunch_state(138) > insert data org.example.bluetooth, table num : 1
09-10 17:34:06.738+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:34:06.738+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 17:34:06.738+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:34:06.738+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.bluetooth has already loaded
09-10 17:34:06.738+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:34:06.738+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 17:34:06.738+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 17:34:06.738+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 17:34:06.758+0600 I/CAPI_APPFW_APPLICATION( 4395): app_main.c: ui_app_main(789) > app_efl_main
09-10 17:34:06.758+0600 I/CAPI_APPFW_APPLICATION( 4395): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 17:34:06.788+0600 E/TBM     ( 4395): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
09-10 17:34:06.839+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 4395, appid: org.example.bluetooth
09-10 17:34:06.839+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 17:34:06.849+0600 W/AUL     ( 4579): launch.c: app_request_to_launchpad(425) > request cmd(0) result(4395)
09-10 17:34:06.859+0600 E/CAPI_NETWORK_WIFI( 4395): net_wifi.c: wifi_deactivate(148) > Not initialized
09-10 17:34:06.899+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
09-10 17:34:07.069+0600 I/CAPI_NETWORK_WIFI( 4395): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
09-10 17:34:07.069+0600 D/bluetooth( 4395): [wifi_initialize] Success.
09-10 17:34:07.269+0600 I/APP_CORE( 4395): appcore-efl.c: __do_app(520) > [APP 4395] Event: RESET State: CREATED
09-10 17:34:07.269+0600 I/CAPI_APPFW_APPLICATION( 4395): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 17:34:07.269+0600 E/EFL     ( 4395): edje<4395> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:34:07.269+0600 E/EFL     ( 4395): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:34:07.279+0600 E/EFL     ( 4395): edje<4395> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:34:07.279+0600 E/EFL     ( 4395): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:34:07.289+0600 E/EFL     ( 4395): edje<4395> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:34:07.289+0600 E/EFL     ( 4395): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:34:07.379+0600 W/APP_CORE( 4395): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
09-10 17:34:07.379+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 17:34:07.469+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77268a0), gem(32), surface(0xb78ae510)
09-10 17:34:07.469+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77f5590), gem(13), surface(0xb78a7f18)
09-10 17:34:07.479+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77268a0), gem(32), surface(0xb78a0ba0)
09-10 17:34:07.479+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775e358), gem(15), surface(0xb7891948)
09-10 17:34:07.479+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77c98c0), gem(21), surface(0xb7889440)
09-10 17:34:07.489+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 17:34:07.489+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 17:34:07.489+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 17:34:07.499+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(4395) status(4)
09-10 17:34:07.529+0600 I/APP_CORE( 4395): appcore-efl.c: __do_app(520) > [APP 4395] Event: PAUSE State: CREATED
09-10 17:34:07.529+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 4395): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 17:34:07.529+0600 E/APP_CORE( 4395): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 17:34:07.529+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb789b068), gem(31), surface(0xb7877090)
09-10 17:34:07.529+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:34:07.679+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7850178), gem(33), surface(0xb78ae1a0)
09-10 17:34:07.839+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:34:07.839+0600 W/AUL_AMD (  648): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
09-10 17:34:07.859+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb77f5590), gem(33), surface(0xb7877090)
09-10 17:34:07.880+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(4395) status(0)
09-10 17:34:07.890+0600 I/Tizen::App( 1366): (499) > LaunchedApp(org.example.bluetooth)
09-10 17:34:07.890+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for org.example.bluetooth, 4395.
09-10 17:34:07.900+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:34:08.250+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7873418), gem(31), surface(0xb78ae1a0)
09-10 17:34:08.780+0600 I/UXT     ( 4588): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
09-10 17:34:11.843+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(4395)
09-10 17:34:11.843+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 4395, appid: org.example.bluetooth, status: bg
09-10 17:34:48.059+0600 E/PKGMGR_SERVER( 4752): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:34:48.129+0600 E/PKGMGR  ( 4750): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 17:34:48.169+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:34:48.169+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 4395
09-10 17:34:48.169+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:34:48.169+0600 W/AUL     ( 4756): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4395)
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(4395), cmd(4)
09-10 17:34:48.179+0600 W/AUL     ( 4756): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 17:34:48.179+0600 I/APP_CORE( 4395): appcore-efl.c: __do_app(520) > [APP 4395] Event: TERMINATE State: CREATED
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 4395
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:34:48.179+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 4395): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
09-10 17:34:48.179+0600 E/APP_CORE( 4395): appcore-efl.c: _capture_and_make_file(1631) > win[5e00002] widget[480] height[800]
09-10 17:34:48.179+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:34:48.179+0600 E/APP_CORE( 4395): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:34:48.179+0600 I/CAPI_APPFW_APPLICATION( 4395): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:34:48.179+0600 E/CAPI_NETWORK_BLUETOOTH( 4395): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:34:48.249+0600 E/CAPI_NETWORK_BLUETOOTH( 4395): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:34:48.249+0600 E/CAPI_NETWORK_BLUETOOTH( 4395): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:34:48.249+0600 E/bluetooth( 4395): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:34:48.249+0600 I/CAPI_NETWORK_WIFI( 4395): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:34:48.249+0600 E/bluetooth( 4395): [wifi_deinitialize] Success.
09-10 17:34:48.259+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7850178), gem(18), surface(0xb78ae510)
09-10 17:34:48.279+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7850178), gem(18), surface(0xb78a7f18)
09-10 17:34:48.279+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:34:48.279+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 17:34:48.279+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77f5590), gem(33), surface(0xb78b9638)
09-10 17:34:48.289+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb775e358), gem(15), surface(0xb78c5f58)
09-10 17:34:48.289+0600 E/PKGMGR_SERVER( 4752): pkgmgr-server.c: sighandler(417) > child NORMAL exit [4756]
09-10 17:34:48.299+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77c98c0), gem(21), surface(0xb78a4a60)
09-10 17:34:48.299+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:34:48.309+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:34:48.309+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:34:48.309+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:34:48.309+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:34:48.309+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:34:48.349+0600 E/EFL     ( 4395): elementary<4395> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 17:34:48.529+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 4395 pgid = 4395
09-10 17:34:48.529+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(4395)
09-10 17:34:48.599+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:34:48.599+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:34:48.599+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:34:48.599+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[4395] terminate event is forwarded
09-10 17:34:48.599+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:34:48.599+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 4395, ]
09-10 17:34:48.599+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:34:48.599+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:34:48.599+0600 I/Tizen::App( 1366): (512) > Not registered pid(4395)
09-10 17:34:48.599+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:34:48.599+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:34:48.599+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 4395
09-10 17:34:48.599+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 4395
09-10 17:34:48.609+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2754
09-10 17:34:48.609+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:34:48.609+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:34:48.609+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 4395.
09-10 17:34:48.649+0600 W/CRASH_MANAGER( 4762): worker.c: worker_job(1199) > 1104395626162147350728
