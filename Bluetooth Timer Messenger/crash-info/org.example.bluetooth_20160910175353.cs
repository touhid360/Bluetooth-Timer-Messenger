S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 9384
Date: 2016-09-10 17:53:53+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9384, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb79136c8
r2   = 0xb437d000, r3   = 0xb437d000
r4   = 0xbec6d5bc, r5   = 0xb6a7c0f4
r6   = 0xb6a7b310, r7   = 0xbec6d41c
r8   = 0xb6a7c0f4, r9   = 0xb6a7c0f4
r10  = 0xb6a8a20c, fp   = 0x00000000
ip   = 0xb2a7030c, sp   = 0xbec6c798
lr   = 0xb2a65afb, pc   = 0xb675f6f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     50240 KB
Buffers:     44556 KB
Cached:     290512 KB
VmPeak:     110984 KB
VmSize:     104612 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25268 KB
VmRSS:       25268 KB
VmData:      34708 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36216 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9384 TID = 9384
9384 9387 10227 

Maps Information
b1dbc000 b25bb000 rw-p [stack:10227]
b25bb000 b25cc000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25dc000 b25e1000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b266d000 b2675000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2686000 b2687000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2697000 b26ab000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26bf000 b26c0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26d0000 b26d3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26e4000 b26e5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26f5000 b26f7000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2707000 b2709000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2719000 b2729000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2739000 b2745000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2956000 b296d000 r-xp /usr/lib/libnetwork.so.0.0.0
b297e000 b29bc000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29cd000 b29d4000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29e5000 b29f4000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a04000 b2a39000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a4c000 b2a52000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a62000 b2a68000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b8a000 b2c6d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ca4000 b2ccc000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cde000 b34dd000 rw-p [stack:9387]
b34dd000 b34df000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34ef000 b34f9000 r-xp /lib/libnss_files-2.20-2014.11.so
b350a000 b3513000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3524000 b3535000 r-xp /lib/libnsl-2.20-2014.11.so
b3548000 b354e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b355f000 b3560000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3588000 b358f000 r-xp /usr/lib/libminizip.so.1.0.0
b359f000 b35a4000 r-xp /usr/lib/libstorage.so.0.1
b35b4000 b3609000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b361f000 b3633000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3643000 b3687000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3697000 b369f000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36af000 b36df000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36f2000 b37ab000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37bf000 b3813000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3824000 b383f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b384f000 b3910000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3923000 b3935000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3945000 b3949000 r-xp /usr/lib/libogg.so.0.7.1
b3959000 b397b000 r-xp /usr/lib/libvorbis.so.0.4.3
b398b000 b3a6f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a8b000 b3a98000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3aa9000 b3aec000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b01000 b3b48000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b59000 b3b5f000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b70000 b3b77000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b87000 b3bc7000 r-xp /usr/lib/libmdm.so.1.2.10
b3bd7000 b3bdf000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bee000 b3bfe000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c1f000 b3c7f000 r-xp /usr/lib/libasound.so.2.0.0
b3c91000 b3cc7000 r-xp /usr/lib/libpulse.so.0.16.2
b3cd8000 b3cdb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3ceb000 b3cee000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cfe000 b3d03000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d13000 b3d14000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d24000 b3d2f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d43000 b3d4a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d5a000 b3d60000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d70000 b3d75000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d85000 b3da0000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3db0000 b3db7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dc7000 b3dca000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3ddb000 b3e09000 r-xp /usr/lib/libidn.so.11.5.44
b3e19000 b3e2f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e40000 b3e4a000 r-xp /usr/lib/libcares.so.2.1.0
b3e5a000 b3e64000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e74000 b3e76000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e86000 b3e87000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e97000 b3e9b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eac000 b3ed4000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ee5000 b3f0e000 r-xp /usr/lib/libturbojpeg.so
b3f2e000 b3f34000 r-xp /usr/lib/libgif.so.4.1.6
b3f44000 b3f8a000 r-xp /usr/lib/libcurl.so.4.3.0
b3f9b000 b3fbc000 r-xp /usr/lib/libexif.so.12.3.3
b3fd7000 b3fec000 r-xp /usr/lib/libtts.so
b3ffd000 b4005000 r-xp /usr/lib/libfeedback.so.0.1.4
b4015000 b40d5000 r-xp /usr/lib/libdali-core.so.0.0.0
b40e0000 b41d3000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41f3000 b42cd000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42e4000 b42e6000 r-xp /usr/lib/libboost_system.so.1.51.0
b42f6000 b42fc000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b430c000 b432f000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4340000 b4342000 r-xp /usr/lib/libappsvc.so.0.1.0
b4352000 b4354000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4365000 b436a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4381000 b4383000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4393000 b439a000 r-xp /usr/lib/libsensord-share.so
b43aa000 b43c2000 r-xp /usr/lib/libsensor.so.1.1.0
b43d3000 b43d6000 r-xp /usr/lib/libXv.so.1.0.0
b43e6000 b43eb000 r-xp /usr/lib/libutilX.so.1.1.0
b43fb000 b4400000 r-xp /usr/lib/libappcore-common.so.1.1
b4410000 b4417000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b442a000 b442e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b443f000 b4509000 r-xp /usr/lib/libCOREGL.so.4.0
b4520000 b4523000 r-xp /usr/lib/libuuid.so.1.3.0
b4534000 b454b000 r-xp /usr/lib/libblkid.so.1.1.0
b455c000 b455e000 r-xp /usr/lib/libXau.so.6.0.0
b456e000 b4571000 r-xp /usr/lib/libEGL.so.1.4
b4579000 b457f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b458f000 b4591000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45a2000 b45b0000 r-xp /usr/lib/libGLESv2.so.2.0
b45b9000 b461b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4630000 b4648000 r-xp /usr/lib/libmount.so.1.1.0
b4659000 b466d000 r-xp /usr/lib/libxcb.so.1.1.0
b467e000 b4685000 r-xp /lib/libcrypt-2.20-2014.11.so
b46bd000 b46ce000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46df000 b46e1000 r-xp /usr/lib/libiri.so
b46f1000 b46fc000 r-xp /usr/lib/libgpg-error.so.0.15.0
b470d000 b4722000 r-xp /lib/libexpat.so.1.5.2
b4734000 b47f2000 r-xp /usr/lib/libcairo.so.2.11200.14
b4805000 b480d000 r-xp /usr/lib/libdrm.so.2.4.0
b481d000 b4820000 r-xp /usr/lib/libdri2.so.0.0.0
b4831000 b487f000 r-xp /usr/lib/libssl.so.1.0.0
b4894000 b48a0000 r-xp /usr/lib/libeeze.so.1.13.0
b48b0000 b48b9000 r-xp /usr/lib/libethumb.so.1.13.0
b48c9000 b48cc000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48dc000 b4a93000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ea000 b56f3000 r-xp /usr/lib/libXi.so.6.1.0
b5703000 b5705000 r-xp /usr/lib/libXgesture.so.7.0.0
b5715000 b5719000 r-xp /usr/lib/libXtst.so.6.1.0
b5729000 b572f000 r-xp /usr/lib/libXrender.so.1.3.0
b573f000 b5745000 r-xp /usr/lib/libXrandr.so.2.2.0
b5756000 b5758000 r-xp /usr/lib/libXinerama.so.1.0.0
b5768000 b576b000 r-xp /usr/lib/libXfixes.so.3.1.0
b577b000 b5786000 r-xp /usr/lib/libXext.so.6.4.0
b5796000 b5798000 r-xp /usr/lib/libXdamage.so.1.1.0
b57a8000 b57aa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57bb000 b589d000 r-xp /usr/lib/libX11.so.6.3.0
b58b0000 b58b7000 r-xp /usr/lib/libXcursor.so.1.0.2
b58c7000 b58df000 r-xp /usr/lib/libudev.so.1.6.0
b58e1000 b58e4000 r-xp /lib/libattr.so.1.1.0
b58f4000 b5914000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5916000 b591b000 r-xp /usr/lib/libffi.so.6.0.2
b592b000 b5943000 r-xp /lib/libz.so.1.2.8
b5953000 b5955000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5965000 b5a3a000 r-xp /usr/lib/libxml2.so.2.9.2
b5a4f000 b5aea000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b06000 b5b09000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b19000 b5b32000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b43000 b5b54000 r-xp /lib/libresolv-2.20-2014.11.so
b5b68000 b5be2000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bf7000 b5bf9000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c09000 b5c10000 r-xp /usr/lib/libembryo.so.1.13.0
b5c20000 b5c38000 r-xp /usr/lib/libpng12.so.0.50.0
b5c49000 b5c6c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c8d000 b5ca1000 r-xp /usr/lib/libector.so.1.13.0
b5cb2000 b5cca000 r-xp /usr/lib/liblua-5.1.so
b5cdb000 b5d32000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d46000 b5d6e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d7f000 b5d92000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da3000 b5dda000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5deb000 b5df9000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e09000 b5e11000 r-xp /usr/lib/libtbm.so.1.0.0
b5e21000 b5e2e000 r-xp /usr/lib/libeio.so.1.13.0
b5e3e000 b5e40000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e50000 b5e55000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e65000 b5e7c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e8e000 b5eae000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ebe000 b5ede000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee0000 b5ee6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ef6000 b5f07000 r-xp /usr/lib/libemotion.so.1.13.0
b5f18000 b5f1f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f2f000 b5f3e000 r-xp /usr/lib/libeo.so.1.13.0
b5f4f000 b5f61000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f72000 b5f77000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f87000 b5fa0000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb0000 b5fcd000 r-xp /usr/lib/libeet.so.1.13.0
b5fe6000 b602e000 r-xp /usr/lib/libeina.so.1.13.0
b603f000 b604f000 r-xp /usr/lib/libefl.so.1.13.0
b6060000 b6145000 r-xp /usr/lib/libicuuc.so.51.1
b6162000 b62a2000 r-xp /usr/lib/libicui18n.so.51.1
b62b9000 b62f1000 r-xp /usr/lib/libecore_x.so.1.13.0
b6303000 b6306000 r-xp /lib/libcap.so.2.21
b6316000 b633f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6350000 b6357000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6369000 b63a0000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b1000 b649c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64af000 b6528000 r-xp /usr/lib/libsqlite3.so.0.8.6
b653a000 b653f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b654f000 b6559000 r-xp /usr/lib/libvconf.so.0.2.45
b6569000 b656b000 r-xp /usr/lib/libvasum.so.0.3.1
b657b000 b657d000 r-xp /usr/lib/libttrace.so.1.1
b658d000 b6590000 r-xp /usr/lib/libiniparser.so.0
b65a0000 b65c6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65d6000 b65db000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ec000 b6603000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6614000 b667f000 r-xp /lib/libm-2.20-2014.11.so
b6690000 b6696000 r-xp /lib/librt-2.20-2014.11.so
b66a7000 b66b4000 r-xp /usr/lib/libunwind.so.8.0.1
b66ea000 b680e000 r-xp /lib/libc-2.20-2014.11.so
b6823000 b683c000 r-xp /lib/libgcc_s-4.9.so.1
b684c000 b692e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b693f000 b6969000 r-xp /usr/lib/libdbus-1.so.3.8.12
b697a000 b69b6000 r-xp /usr/lib/libsystemd.so.0.4.0
b69b8000 b6a3a000 r-xp /usr/lib/libedje.so.1.13.0
b6a4d000 b6a6b000 r-xp /usr/lib/libecore.so.1.13.0
b6a8b000 b6c12000 r-xp /usr/lib/libevas.so.1.13.0
b6c47000 b6c5b000 r-xp /lib/libpthread-2.20-2014.11.so
b6c6f000 b6ea4000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed2000 b6ed6000 r-xp /usr/lib/libsmack.so.1.0.0
b6ee6000 b6eed000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6efd000 b6eff000 r-xp /usr/lib/libdlog.so.0.0.0
b6f0f000 b6f12000 r-xp /usr/lib/libbundle.so.0.1.22
b6f22000 b6f24000 r-xp /lib/libdl-2.20-2014.11.so
b6f35000 b6f4d000 r-xp /usr/lib/libaul.so.0.1.0
b6f61000 b6f66000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f77000 b6f84000 r-xp /usr/lib/liblptcp.so
b6f96000 b6f9a000 r-xp /usr/lib/libsys-assert.so
b6fab000 b6fcb000 r-xp /lib/ld-2.20-2014.11.so
b6fdc000 b6fe1000 r-xp /usr/bin/launchpad-loader
b789c000 b7bcb000 rw-p [heap]
bec4d000 bec6e000 rw-p [stack]
b789c000 b7bcb000 rw-p [heap]
bec4d000 bec6e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9384)
Call Stack Count: 1
 0: (0xb675f6f0) [/lib/libc.so.6] + 0x756f0
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
48): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 10673
09-10 17:50:34.412+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 10673, appid: com.samsung.weather-m-agent
09-10 17:50:34.412+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 17:50:34.422+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:50:34.432+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10673)
09-10 17:50:34.432+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 17:50:34.432+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 17:50:34.432+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 17:50:34.432+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 17:50:34.432+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 17:50:34.432+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 17:50:34.442+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:50:34.442+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:50:34.442+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:50:34.442+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:50:34.442+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:50:34.452+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 17:50:34.452+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 10673.
09-10 17:50:34.532+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb776de68), gem(13), surface(0xb78bb990)
09-10 17:50:34.532+0600 W/INDICATOR(  685): main.c: _indicator_lock_status_cb(413) > Hide Clock
09-10 17:50:34.642+0600 E/weather-agent(10673): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 17:50:34.652+0600 E/weather-common(10673): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 17:50:34.652+0600 E/weather-agent(10673): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 17:50:34.662+0600 I/MESSAGE_PORT(10673): message-port.c: __initialize(872) > initialize
09-10 17:50:34.672+0600 I/MESSAGE_PORT(10673): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 17:50:34.702+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:50:34.702+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:50:34.702+0600 I/MESSAGE_PORT(10673): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:34.702+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 17:50:34.702+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 17:50:34.702+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:50:34.712+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:50:34.712+0600 E/MESSAGE_PORT(10673): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 17:50:34.712+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 17:50:34.712+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:50:34.722+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:50:34.722+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:50:34.722+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:50:34.722+0600 E/MESSAGE_PORT(10673): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 17:50:34.722+0600 E/weather-common(10673): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 17:50:34.722+0600 E/weather-agent(10673): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 17:50:34.722+0600 E/weather-agent(10673): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:50:34.722+0600 I/MESSAGE_PORT(10673): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:50:34.732+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:50:34.752+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:50:34.792+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 17:50:34.792+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 17:50:34.973+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb82e53d0]
09-10 17:50:34.973+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:50:34.973+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:50:34.973+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:50:34.973+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb82e53d0
09-10 17:50:34.983+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:50:34.983+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:50:34.983+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:50:34.983+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 17:50:34.993+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:50:34.993+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:50:35.003+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:50:35.023+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80088fd1 is not stable during recalc loop
09-10 17:50:35.083+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80088fd1 is not stable during recalc loop
09-10 17:50:35.093+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:50:35.093+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:50:35.733+0600 E/weather-agent(10673): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:50:35.733+0600 I/CAPI_APPFW_APPLICATION(10673): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:50:35.733+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:50:35.733+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:50:35.733+0600 E/weather-agent(10673): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:50:35.863+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:50:35.873+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10673
09-10 17:50:35.873+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[10673] terminate event is forwarded
09-10 17:50:35.873+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:50:35.873+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10673, ]
09-10 17:50:35.873+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:50:35.873+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:50:35.873+0600 I/Tizen::App( 1366): (512) > Not registered pid(10673)
09-10 17:50:35.873+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:50:35.873+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:50:35.873+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 10673
09-10 17:50:35.873+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:50:35.873+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:50:35.873+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10673.
09-10 17:50:38.636+0600 I/APP_CORE( 9384): appcore-efl.c: __do_app(520) > [APP 9384] Event: MEM_FLUSH State: PAUSED
09-10 17:50:40.738+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:50:54.422+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
09-10 17:50:54.422+0600 W/LOCKSCREEN(  869): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
09-10 17:50:54.422+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30001:LCD_ON
09-10 17:50:54.422+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30001 event_info:0
09-10 17:50:54.422+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
09-10 17:50:54.422+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
09-10 17:50:54.422+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:50:54.432+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 17:50:54.432+0600 E/LOCKSCREEN(  869): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
09-10 17:50:54.442+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 5:50 p.m.
09-10 17:50:54.442+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 5:50 p.m."
09-10 17:50:54.442+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 5:50 p.m."
09-10 17:50:54.442+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 17:50:54.442+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146610647 Time: <font_size=31> </font_size> <font_size=31> 5:50 p.m.</font_size></font>"
09-10 17:50:54.442+0600 E/INDICATOR(  685): battery.c: show_digits(405) > show_digits[405]	 "Show digits: 100"
09-10 17:50:54.442+0600 I/INDICATOR(  685): battery.c: show_battery_icon(376) > "Percentage:(1) / Level:(10) / batt_Full:(1) / battery_charging(0)"
09-10 17:50:54.442+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
09-10 17:50:54.442+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:50:54.442+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:50:54.442+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
09-10 17:50:54.442+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:50:54.442+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
09-10 17:50:54.942+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:4
09-10 17:50:54.942+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
09-10 17:50:54.942+0600 W/APP_CORE(  869): appcore-efl.c: __cmsg_cb(1046) > LCD On. Resume the topmost app
09-10 17:50:54.942+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: RESUME State: PAUSED
09-10 17:50:54.942+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:50:54.942+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20004:APP_RESUME
09-10 17:50:54.942+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20004 event_info:0
09-10 17:50:54.942+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_set(725) > [_lcd_timeout_timer_set:725:W] lcd off timer set:30.000000
09-10 17:50:54.952+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
09-10 17:50:54.952+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:50:54.952+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 869
09-10 17:50:54.952+0600 I/AUL_AMD (  648): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
09-10 17:50:54.962+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
09-10 17:50:54.962+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:50:54.962+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
09-10 17:50:54.962+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:50:54.962+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 10769
09-10 17:50:54.972+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:50:55.012+0600 I/Tizen::System( 1366): (280) > The screen has been turned on.
09-10 17:50:55.012+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:50:55.012+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 10769
09-10 17:50:55.012+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 10769, appid: com.samsung.weather-m-agent
09-10 17:50:55.032+0600 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10769)
09-10 17:50:55.052+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
09-10 17:50:55.062+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:50:55.072+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.weather-m-agent)
09-10 17:50:55.072+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 10769.
09-10 17:50:55.282+0600 E/weather-agent(10769): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
09-10 17:50:55.282+0600 E/weather-common(10769): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
09-10 17:50:55.282+0600 E/weather-agent(10769): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
09-10 17:50:55.302+0600 I/MESSAGE_PORT(10769): message-port.c: __initialize(872) > initialize
09-10 17:50:55.312+0600 I/MESSAGE_PORT(10769): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:50:55.362+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
09-10 17:50:55.362+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
09-10 17:50:55.372+0600 E/MESSAGE_PORT(10769): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
09-10 17:50:55.372+0600 I/MESSAGE_PORT(  869): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:50:55.372+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
09-10 17:50:55.372+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:50:55.372+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:50:55.372+0600 I/MESSAGE_PORT(10769): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:55.372+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
09-10 17:50:55.372+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
09-10 17:50:55.372+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
09-10 17:50:55.372+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:50:55.372+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:50:55.372+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: __message_port_send_message(972) > port exist check !!
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:50:55.382+0600 E/MESSAGE_PORT(10769): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 17:50:55.382+0600 E/weather-common(10769): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 17:50:55.382+0600 E/weather-agent(10769): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 17:50:55.382+0600 E/weather-agent(10769): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:50:55.382+0600 I/MESSAGE_PORT(10769): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:50:55.382+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:50:55.402+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:50:55.453+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 17:50:55.453+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 17:50:55.653+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83ad900]
09-10 17:50:55.653+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:50:55.653+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:50:55.653+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:50:55.653+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83ad900
09-10 17:50:55.653+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:50:55.663+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:50:55.663+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:50:55.663+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 17:50:55.663+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:50:55.663+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:50:55.683+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:50:55.703+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800d68e6 is not stable during recalc loop
09-10 17:50:55.773+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800d68e6 is not stable during recalc loop
09-10 17:50:55.773+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:50:55.783+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:50:56.383+0600 E/weather-agent(10769): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:50:56.383+0600 I/CAPI_APPFW_APPLICATION(10769): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:50:56.383+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:50:56.383+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:50:56.383+0600 E/weather-agent(10769): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:50:56.584+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:50:56.584+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10769
09-10 17:50:56.584+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[10769] terminate event is forwarded
09-10 17:50:56.584+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:50:56.584+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10769, ]
09-10 17:50:56.584+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:50:56.584+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:50:56.584+0600 I/Tizen::App( 1366): (512) > Not registered pid(10769)
09-10 17:50:56.584+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:50:56.584+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:50:56.584+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 10769
09-10 17:50:56.604+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:50:56.604+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:50:56.604+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10769.
09-10 17:51:00.427+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
09-10 17:51:00.437+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 5:51 p.m.
09-10 17:51:00.437+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 5:51 p.m."
09-10 17:51:00.437+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 5:51 p.m."
09-10 17:51:00.447+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
09-10 17:51:00.447+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145749944 Time: <font_size=31> </font_size> <font_size=31> 5:51 p.m.</font_size></font>"
09-10 17:51:01.388+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
09-10 17:51:04.411+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:51:04.411+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:1432420
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => WILL PAUSE
09-10 17:51:04.431+0600 W/APP_CORE(  869): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
09-10 17:51:04.431+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 17:51:04.431+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:51:04.431+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:51:04.431+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 17:51:04.431+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 17:51:04.431+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 17:51:04.471+0600 I/APP_CORE(  685): appcore-efl.c: __do_app(520) > [APP 685] Event: MEM_FLUSH State: RUNNING
09-10 17:51:04.531+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:51:04.531+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:51:04.531+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:51:04.531+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:51:04.531+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:51:04.992+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:51:04.992+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:51:05.012+0600 W/LOCKSCREEN(  869): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
09-10 17:51:05.012+0600 W/LOCKSCREEN(  869): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
09-10 17:51:05.012+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
09-10 17:51:05.012+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
09-10 17:51:05.012+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
09-10 17:51:05.012+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
09-10 17:51:09.436+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 17:52:18.544+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 6620): media_content.c: media_content_disconnect(940) > [32m[6620]ref count changed to: 0
09-10 17:52:18.544+0600 I/CAPI_NETWORK_WIFI( 6620): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:52:18.564+0600 E/ALARM_MANAGER( 6620): alarm-lib-stub.c: _send_alarm_delete_all(434) > alarm_manager_call_alarm_delete_all_sync() failed. return_code[0]
09-10 17:52:18.564+0600 E/ALARM_MANAGER( 6620): alarm-lib-stub.c: _send_alarm_delete_all(436) > dbus error message: The connection is closed
09-10 17:53:52.986+0600 E/PKGMGR_SERVER(11383): pkgmgr-server.c: main(2414) > package manager server start
09-10 17:53:53.046+0600 E/PKGMGR  (11381): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
09-10 17:53:53.086+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:53:53.086+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 9384
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:53:53.096+0600 W/AUL     (11386): launch.c: app_request_to_launchpad(396) > request cmd(5) to(9384)
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 5
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(9384), cmd(4)
09-10 17:53:53.096+0600 W/AUL     (11386): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 9384
09-10 17:53:53.096+0600 I/APP_CORE( 9384): appcore-efl.c: __do_app(520) > [APP 9384] Event: TERMINATE State: PAUSED
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:53:53.096+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 9384): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 0
09-10 17:53:53.096+0600 E/APP_CORE( 9384): appcore-efl.c: _capture_and_make_file(1631) > win[6200002] widget[480] height[800]
09-10 17:53:53.096+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:53:53.096+0600 E/APP_CORE( 9384): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:53:53.106+0600 I/CAPI_APPFW_APPLICATION( 9384): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:53:53.106+0600 E/CAPI_NETWORK_BLUETOOTH( 9384): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:53:53.186+0600 E/CAPI_NETWORK_BLUETOOTH( 9384): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:53:53.186+0600 E/CAPI_NETWORK_BLUETOOTH( 9384): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:53:53.186+0600 E/bluetooth( 9384): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:53:53.186+0600 I/CAPI_NETWORK_WIFI( 9384): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:53:53.196+0600 E/bluetooth( 9384): [wifi_deinitialize] Success.
09-10 17:53:53.196+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:53:53.196+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
09-10 17:53:53.206+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(18), surface(0xb78ae510)
09-10 17:53:53.206+0600 E/PKGMGR_SERVER(11383): pkgmgr-server.c: sighandler(417) > child NORMAL exit [11386]
09-10 17:53:53.226+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78448e8), gem(18), surface(0xb7877090)
09-10 17:53:53.226+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:53:53.226+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:53:53.226+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:53:53.226+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:53:53.226+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:53:53.226+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7823e00), gem(10), surface(0xb789f458)
09-10 17:53:53.236+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78144a0), gem(15), surface(0xb78a7f18)
09-10 17:53:53.266+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:53:53.286+0600 E/EFL     ( 9384): elementary<9384> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 17:53:53.426+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9384 pgid = 9384
09-10 17:53:53.426+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(9384)
09-10 17:53:53.526+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:53:53.526+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:53:53.526+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:53:53.536+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[9384] terminate event is forwarded
09-10 17:53:53.536+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:53:53.536+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 9384, ]
09-10 17:53:53.536+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:53:53.536+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:53:53.536+0600 I/Tizen::App( 1366): (512) > Not registered pid(9384)
09-10 17:53:53.536+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:53:53.536+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:53:53.536+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 9384
09-10 17:53:53.536+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9384
09-10 17:53:53.556+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:53:53.556+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:53:53.556+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 9384.
09-10 17:53:53.596+0600 W/CRASH_MANAGER(11393): worker.c: worker_job(1199) > 1109384626162147350843
