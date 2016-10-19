S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPG1
Build-Date: 2016.07.11 18:05:34

Crash Information
Process Name: babu
PID: 27618
Date: 2016-09-10 17:11:53+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/babu
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 27618, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb8a6bfd8
r2   = 0xb437f000, r3   = 0xb437f000
r4   = 0xbeaa05bc, r5   = 0xb6a7e0f4
r6   = 0xb6a7d310, r7   = 0xbeaa041c
r8   = 0xb6a7e0f4, r9   = 0xb6a7e0f4
r10  = 0xb6a8c20c, fp   = 0x00000000
ip   = 0xb2a72d30, sp   = 0xbea9f798
lr   = 0xb2a683b7, pc   = 0xb67616f0
cpsr = 0x800f0030

Memory Information
MemTotal:   730440 KB
MemFree:     43976 KB
Buffers:     43816 KB
Cached:     293944 KB
VmPeak:     105680 KB
VmSize:     103128 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25016 KB
VmRSS:       25016 KB
VmData:      34720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36220 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 27618 TID = 27618
27618 27631 29011 29013 

Maps Information
b1401000 b1c00000 rw-p [stack:29013]
b1dbe000 b25bd000 rw-p [stack:29011]
b25bd000 b25ce000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25de000 b25e3000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b266f000 b2677000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2688000 b2689000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2699000 b26ad000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26c1000 b26c2000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26d2000 b26d5000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26e6000 b26e7000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26f7000 b26f9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2709000 b270b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b271b000 b272b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b273b000 b2747000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2958000 b296f000 r-xp /usr/lib/libnetwork.so.0.0.0
b2980000 b29be000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29cf000 b29d6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29e7000 b29f6000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a06000 b2a3b000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a4e000 b2a54000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a64000 b2a6b000 r-xp /opt/usr/apps/org.example.bluetooth/bin/babu
b2b8c000 b2c6f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ca6000 b2cce000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ce0000 b34df000 rw-p [stack:27631]
b34df000 b34e1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34f1000 b34fb000 r-xp /lib/libnss_files-2.20-2014.11.so
b350c000 b3515000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3526000 b3537000 r-xp /lib/libnsl-2.20-2014.11.so
b354a000 b3550000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3561000 b3562000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b358a000 b3591000 r-xp /usr/lib/libminizip.so.1.0.0
b35a1000 b35a6000 r-xp /usr/lib/libstorage.so.0.1
b35b6000 b360b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3621000 b3635000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3645000 b3689000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3699000 b36a1000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36b1000 b36e1000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36f4000 b37ad000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37c1000 b3815000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3826000 b3841000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3851000 b3912000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3925000 b3937000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3947000 b394b000 r-xp /usr/lib/libogg.so.0.7.1
b395b000 b397d000 r-xp /usr/lib/libvorbis.so.0.4.3
b398d000 b3a71000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a8d000 b3a9a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3aab000 b3aee000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b03000 b3b4a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b5b000 b3b61000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b72000 b3b79000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b89000 b3bc9000 r-xp /usr/lib/libmdm.so.1.2.10
b3bd9000 b3be1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bf0000 b3c00000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c21000 b3c81000 r-xp /usr/lib/libasound.so.2.0.0
b3c93000 b3cc9000 r-xp /usr/lib/libpulse.so.0.16.2
b3cda000 b3cdd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3ced000 b3cf0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d00000 b3d05000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d15000 b3d16000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d26000 b3d31000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d45000 b3d4c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d5c000 b3d62000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d72000 b3d77000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d87000 b3da2000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3db2000 b3db9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dc9000 b3dcc000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3ddd000 b3e0b000 r-xp /usr/lib/libidn.so.11.5.44
b3e1b000 b3e31000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e42000 b3e4c000 r-xp /usr/lib/libcares.so.2.1.0
b3e5c000 b3e66000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e76000 b3e78000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e88000 b3e89000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e99000 b3e9d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eae000 b3ed6000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ee7000 b3f10000 r-xp /usr/lib/libturbojpeg.so
b3f30000 b3f36000 r-xp /usr/lib/libgif.so.4.1.6
b3f46000 b3f8c000 r-xp /usr/lib/libcurl.so.4.3.0
b3f9d000 b3fbe000 r-xp /usr/lib/libexif.so.12.3.3
b3fd9000 b3fee000 r-xp /usr/lib/libtts.so
b3fff000 b4007000 r-xp /usr/lib/libfeedback.so.0.1.4
b4017000 b40d7000 r-xp /usr/lib/libdali-core.so.0.0.0
b40e2000 b41d5000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41f5000 b42cf000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42e6000 b42e8000 r-xp /usr/lib/libboost_system.so.1.51.0
b42f8000 b42fe000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b430e000 b4331000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4342000 b4344000 r-xp /usr/lib/libappsvc.so.0.1.0
b4354000 b4356000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4367000 b436c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4383000 b4385000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4395000 b439c000 r-xp /usr/lib/libsensord-share.so
b43ac000 b43c4000 r-xp /usr/lib/libsensor.so.1.1.0
b43d5000 b43d8000 r-xp /usr/lib/libXv.so.1.0.0
b43e8000 b43ed000 r-xp /usr/lib/libutilX.so.1.1.0
b43fd000 b4402000 r-xp /usr/lib/libappcore-common.so.1.1
b4412000 b4419000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b442c000 b4430000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4441000 b450b000 r-xp /usr/lib/libCOREGL.so.4.0
b4522000 b4525000 r-xp /usr/lib/libuuid.so.1.3.0
b4536000 b454d000 r-xp /usr/lib/libblkid.so.1.1.0
b455e000 b4560000 r-xp /usr/lib/libXau.so.6.0.0
b4570000 b4573000 r-xp /usr/lib/libEGL.so.1.4
b457b000 b4581000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4591000 b4593000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45a4000 b45b2000 r-xp /usr/lib/libGLESv2.so.2.0
b45bb000 b461d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4632000 b464a000 r-xp /usr/lib/libmount.so.1.1.0
b465b000 b466f000 r-xp /usr/lib/libxcb.so.1.1.0
b4680000 b4687000 r-xp /lib/libcrypt-2.20-2014.11.so
b46bf000 b46d0000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46e1000 b46e3000 r-xp /usr/lib/libiri.so
b46f3000 b46fe000 r-xp /usr/lib/libgpg-error.so.0.15.0
b470f000 b4724000 r-xp /lib/libexpat.so.1.5.2
b4736000 b47f4000 r-xp /usr/lib/libcairo.so.2.11200.14
b4807000 b480f000 r-xp /usr/lib/libdrm.so.2.4.0
b481f000 b4822000 r-xp /usr/lib/libdri2.so.0.0.0
b4833000 b4881000 r-xp /usr/lib/libssl.so.1.0.0
b4896000 b48a2000 r-xp /usr/lib/libeeze.so.1.13.0
b48b2000 b48bb000 r-xp /usr/lib/libethumb.so.1.13.0
b48cb000 b48ce000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48de000 b4a95000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ec000 b56f5000 r-xp /usr/lib/libXi.so.6.1.0
b5705000 b5707000 r-xp /usr/lib/libXgesture.so.7.0.0
b5717000 b571b000 r-xp /usr/lib/libXtst.so.6.1.0
b572b000 b5731000 r-xp /usr/lib/libXrender.so.1.3.0
b5741000 b5747000 r-xp /usr/lib/libXrandr.so.2.2.0
b5758000 b575a000 r-xp /usr/lib/libXinerama.so.1.0.0
b576a000 b576d000 r-xp /usr/lib/libXfixes.so.3.1.0
b577d000 b5788000 r-xp /usr/lib/libXext.so.6.4.0
b5798000 b579a000 r-xp /usr/lib/libXdamage.so.1.1.0
b57aa000 b57ac000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57bd000 b589f000 r-xp /usr/lib/libX11.so.6.3.0
b58b2000 b58b9000 r-xp /usr/lib/libXcursor.so.1.0.2
b58c9000 b58e1000 r-xp /usr/lib/libudev.so.1.6.0
b58e3000 b58e6000 r-xp /lib/libattr.so.1.1.0
b58f6000 b5916000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5918000 b591d000 r-xp /usr/lib/libffi.so.6.0.2
b592d000 b5945000 r-xp /lib/libz.so.1.2.8
b5955000 b5957000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5967000 b5a3c000 r-xp /usr/lib/libxml2.so.2.9.2
b5a51000 b5aec000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b08000 b5b0b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b1b000 b5b34000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b45000 b5b56000 r-xp /lib/libresolv-2.20-2014.11.so
b5b6a000 b5be4000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bf9000 b5bfb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c0b000 b5c12000 r-xp /usr/lib/libembryo.so.1.13.0
b5c22000 b5c3a000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4b000 b5c6e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c8f000 b5ca3000 r-xp /usr/lib/libector.so.1.13.0
b5cb4000 b5ccc000 r-xp /usr/lib/liblua-5.1.so
b5cdd000 b5d34000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d48000 b5d70000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d81000 b5d94000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da5000 b5ddc000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5ded000 b5dfb000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e0b000 b5e13000 r-xp /usr/lib/libtbm.so.1.0.0
b5e23000 b5e30000 r-xp /usr/lib/libeio.so.1.13.0
b5e40000 b5e42000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e52000 b5e57000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e67000 b5e7e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e90000 b5eb0000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec0000 b5ee0000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee2000 b5ee8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ef8000 b5f09000 r-xp /usr/lib/libemotion.so.1.13.0
b5f1a000 b5f21000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f31000 b5f40000 r-xp /usr/lib/libeo.so.1.13.0
b5f51000 b5f63000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f74000 b5f79000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f89000 b5fa2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb2000 b5fcf000 r-xp /usr/lib/libeet.so.1.13.0
b5fe8000 b6030000 r-xp /usr/lib/libeina.so.1.13.0
b6041000 b6051000 r-xp /usr/lib/libefl.so.1.13.0
b6062000 b6147000 r-xp /usr/lib/libicuuc.so.51.1
b6164000 b62a4000 r-xp /usr/lib/libicui18n.so.51.1
b62bb000 b62f3000 r-xp /usr/lib/libecore_x.so.1.13.0
b6305000 b6308000 r-xp /lib/libcap.so.2.21
b6318000 b6341000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6352000 b6359000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b636b000 b63a2000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b3000 b649e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b1000 b652a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b653c000 b6541000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6551000 b655b000 r-xp /usr/lib/libvconf.so.0.2.45
b656b000 b656d000 r-xp /usr/lib/libvasum.so.0.3.1
b657d000 b657f000 r-xp /usr/lib/libttrace.so.1.1
b658f000 b6592000 r-xp /usr/lib/libiniparser.so.0
b65a2000 b65c8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65d8000 b65dd000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ee000 b6605000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6616000 b6681000 r-xp /lib/libm-2.20-2014.11.so
b6692000 b6698000 r-xp /lib/librt-2.20-2014.11.so
b66a9000 b66b6000 r-xp /usr/lib/libunwind.so.8.0.1
b66ec000 b6810000 r-xp /lib/libc-2.20-2014.11.so
b6825000 b683e000 r-xp /lib/libgcc_s-4.9.so.1
b684e000 b6930000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6941000 b696b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b697c000 b69b8000 r-xp /usr/lib/libsystemd.so.0.4.0
b69ba000 b6a3c000 r-xp /usr/lib/libedje.so.1.13.0
b6a4f000 b6a6d000 r-xp /usr/lib/libecore.so.1.13.0
b6a8d000 b6c14000 r-xp /usr/lib/libevas.so.1.13.0
b6c49000 b6c5d000 r-xp /lib/libpthread-2.20-2014.11.so
b6c71000 b6ea6000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed4000 b6ed8000 r-xp /usr/lib/libsmack.so.1.0.0
b6ee8000 b6eef000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eff000 b6f01000 r-xp /usr/lib/libdlog.so.0.0.0
b6f11000 b6f14000 r-xp /usr/lib/libbundle.so.0.1.22
b6f24000 b6f26000 r-xp /lib/libdl-2.20-2014.11.so
b6f37000 b6f4f000 r-xp /usr/lib/libaul.so.0.1.0
b6f63000 b6f68000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f79000 b6f86000 r-xp /usr/lib/liblptcp.so
b6f98000 b6f9c000 r-xp /usr/lib/libsys-assert.so
b6fad000 b6fcd000 r-xp /lib/ld-2.20-2014.11.so
b6fde000 b6fe3000 r-xp /usr/bin/launchpad-loader
b8a08000 b8d3a000 rw-p [heap]
bea80000 beaa1000 rw-p [stack]
b8a08000 b8d3a000 rw-p [heap]
bea80000 beaa1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27618)
Call Stack Count: 1
 0: (0xb67616f0) [/lib/libc.so.6] + 0x756f0
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
: [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
09-10 17:11:50.605+0600 I/MESSAGE_PORT(29020): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
09-10 17:11:50.605+0600 I/MESSAGE_PORT(29020): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
09-10 17:11:50.605+0600 I/MESSAGE_PORT( 1522): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
09-10 17:11:50.615+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:11:50.615+0600 E/MESSAGE_PORT(29020): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 31.100000[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 33.200000[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1473486109[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
09-10 17:11:50.615+0600 E/weather-common(29020): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
09-10 17:11:50.615+0600 E/weather-agent(29020): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
09-10 17:11:50.615+0600 E/weather-agent(29020): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
09-10 17:11:50.615+0600 I/MESSAGE_PORT(29020): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
09-10 17:11:50.615+0600 I/MESSAGE_PORT(29020): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
09-10 17:11:50.635+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:11:50.675+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
09-10 17:11:50.675+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
09-10 17:11:50.835+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:2 event_info:0
09-10 17:11:50.835+0600 W/LOCKSCREEN(  869): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:7
09-10 17:11:50.835+0600 W/LOCKSCREEN(  869): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
09-10 17:11:50.835+0600 E/LOCKSCREEN(  869): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
09-10 17:11:50.835+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:11:50.835+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:11:50.835+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:11:50.835+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:11:50.835+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_set(725) > [_lcd_timeout_timer_set:725:W] lcd off timer set:30.000000
09-10 17:11:50.845+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:50.855+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:50.855+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(869) status(4)
09-10 17:11:50.855+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(869)
09-10 17:11:50.855+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 869, appid: com.samsung.lockscreen, status: bg
09-10 17:11:50.855+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(27618) status(3)
09-10 17:11:50.855+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:11:50.855+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:11:50.855+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(27618)
09-10 17:11:50.855+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27618, appid: org.example.bluetooth, status: fg
09-10 17:11:50.855+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:11:50.865+0600 I/APP_CORE(27618): appcore-efl.c: __do_app(520) > [APP 27618] Event: RESUME State: CREATED
09-10 17:11:50.875+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:11:50.885+0600 I/Tizen::System( 1366): (259) > Active app [org.exampl], current [com.samsun] 
09-10 17:11:50.885+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:11:50.895+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:11:50.895+0600 W/LOCKSCREEN(  869): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x2E00007] is [invisible]
09-10 17:11:50.895+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10002:WIN_BECOME_INVISIBLE
09-10 17:11:50.895+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:10002 event_info:0
09-10 17:11:50.895+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:11:50.895+0600 E/VCONF   (25767): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
09-10 17:11:50.895+0600 E/LOCKSCREEN(  869): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
09-10 17:11:50.895+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: PAUSE State: RUNNING
09-10 17:11:50.895+0600 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:11:50.895+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:11:50.895+0600 E/LOCKSCREEN(  869): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
09-10 17:11:50.895+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
09-10 17:11:50.895+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
09-10 17:11:50.895+0600 W/LOCKSCREEN(  869): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
09-10 17:11:50.895+0600 E/LOCKSCREEN(  869): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
09-10 17:11:50.895+0600 I/APP_CORE(27618): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 17:11:50.895+0600 I/APP_CORE(27618): appcore-efl.c: __do_app(637) > [APP 27618] Initial Launching, call the resume_cb
09-10 17:11:50.895+0600 I/CAPI_APPFW_APPLICATION(27618): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:11:50.905+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
09-10 17:11:50.935+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83612a0]
09-10 17:11:50.935+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:11:50.935+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:11:50.935+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:11:50.935+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83612a0
09-10 17:11:50.945+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:11:50.945+0600 W/LOCATION( 1522): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
09-10 17:11:50.945+0600 E/weather-common( 1522): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
09-10 17:11:50.945+0600 E/weather-widget( 1522): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
09-10 17:11:50.955+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
09-10 17:11:50.955+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_update_cb(287) > received updating signal
09-10 17:11:50.955+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:11:50.985+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80187522 is not stable during recalc loop
09-10 17:11:50.995+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
09-10 17:11:50.995+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
09-10 17:11:50.995+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
09-10 17:11:50.995+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
09-10 17:11:50.995+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
09-10 17:11:50.995+0600 E/LOCKSCREEN(  869): background-view.c: background_image_next_set(309) > [background_image_next_set:309:E] fopen wallpaper txt file failed.
09-10 17:11:51.055+0600 E/EFL     ( 1522): evas_main<1522> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80187522 is not stable during recalc loop
09-10 17:11:51.055+0600 E/EFL     ( 1522): edje<1522> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-10 17:11:51.065+0600 E/cluster-home(  873): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
09-10 17:11:51.536+0600 E/EFL     (27618): ecore_x<27618> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16675089
09-10 17:11:51.616+0600 E/weather-agent(29020): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
09-10 17:11:51.616+0600 I/CAPI_APPFW_APPLICATION(29020): service_app_main.c: service_app_exit(446) > service_app_exit
09-10 17:11:51.646+0600 E/EFL     (27618): ecore_x<27618> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16675179
09-10 17:11:51.646+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:11:51.646+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:11:51.646+0600 E/VCONF   (27618): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
09-10 17:11:51.646+0600 E/VCONF   (27618): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
09-10 17:11:51.646+0600 E/VCONF   (27618): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
09-10 17:11:51.646+0600 E/VCONF   (27618): vconf.c: vconf_get_bool(2729) > vconf_get_bool(27618) : db/ise/keysound error
09-10 17:11:51.646+0600 E/VCONF   (27618): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
09-10 17:11:51.646+0600 E/VCONF   (27618): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
09-10 17:11:51.666+0600 E/weather-agent(29020): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
09-10 17:11:51.846+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
09-10 17:11:51.846+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 29020
09-10 17:11:51.846+0600 I/Tizen::App( 1366): (243) > App[com.samsung.weather-m-agent] pid[29020] terminate event is forwarded
09-10 17:11:51.846+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:11:51.846+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 29020, ]
09-10 17:11:51.846+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:11:51.846+0600 I/Tizen::App( 1366): (506) > TerminatedApp(com.samsung.weather-m-agent)
09-10 17:11:51.846+0600 I/Tizen::App( 1366): (512) > Not registered pid(29020)
09-10 17:11:51.846+0600 I/Tizen::System( 1366): (246) > Terminated app [com.samsung.weather-m-agent]
09-10 17:11:51.846+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:11:51.846+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 29020
09-10 17:11:51.856+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:11:51.856+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:11:51.856+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 29020.
09-10 17:11:51.926+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16675482
09-10 17:11:51.926+0600 W/STARTER (  763): hw_key.c: _key_press_cb(766) > [_key_press_cb:766] Home Key is pressed
09-10 17:11:51.926+0600 W/STARTER (  763): hw_key.c: _key_press_cb(787) > [_key_press_cb:787] homekey count : 1
09-10 17:11:51.926+0600 E/EFL     (27618): ecore_x<27618> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16675482
09-10 17:11:51.926+0600 E/AUL     (  763): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:11:52.006+0600 E/EFL     (27618): ecore_x<27618> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16675561
09-10 17:11:52.086+0600 E/EFL     (27618): ecore_x<27618> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16675639
09-10 17:11:52.086+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:11:52.086+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:11:52.086+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:11:52.086+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:11:52.086+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:11:52.096+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:11:52.096+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb776de68), gem(18), surface(0xb78ae1a0)
09-10 17:11:52.116+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 36
09-10 17:11:52.116+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78aa360), gem(23), surface(0xb787e520)
09-10 17:11:52.146+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7898660), gem(10), surface(0xb78b0690)
09-10 17:11:52.146+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7898660), gem(10), surface(0xb78a62a8)
09-10 17:11:52.156+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:52.156+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:52.176+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [org.exampl] 
09-10 17:11:52.176+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:11:52.176+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 17:11:52.176+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:11:52.176+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 17:11:52.186+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb776de68), gem(18), surface(0xb78ba300)
09-10 17:11:52.196+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:11:52.226+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 17:11:52.236+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 17:11:52.236+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 17:11:52.236+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 17:11:52.236+0600 E/STARTER (  763): )
09-10 17:11:52.236+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 17:11:52.236+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:11:52.236+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:11:52.236+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 17:11:52.286+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76a1d50), gem(13), surface(0xb78b0690)
09-10 17:11:52.297+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76a1d50), gem(13), surface(0xb78bee98)
09-10 17:11:52.297+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
09-10 17:11:52.297+0600 I/APP_CORE(27618): appcore-efl.c: __do_app(520) > [APP 27618] Event: PAUSE State: RUNNING
09-10 17:11:52.297+0600 I/CAPI_APPFW_APPLICATION(27618): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:11:52.297+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
09-10 17:11:52.307+0600 I/TIZEN_N_SOUND_MANAGER(28857): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
09-10 17:11:52.307+0600 E/TIZEN_N_SOUND_MANAGER(28857): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:11:52.307+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
09-10 17:11:52.307+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
09-10 17:11:52.307+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 763
09-10 17:11:52.307+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
09-10 17:11:52.317+0600 I/TIZEN_N_SOUND_MANAGER(28857): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x0
09-10 17:11:52.317+0600 E/TIZEN_N_SOUND_MANAGER(28857): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
09-10 17:11:52.327+0600 E/RESOURCED(15587): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-10 17:11:52.327+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
09-10 17:11:52.327+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
09-10 17:11:52.327+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.task-mgr has already loaded
09-10 17:11:52.327+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
09-10 17:11:52.327+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
09-10 17:11:52.327+0600 W/AUL_PAD ( 1521): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
09-10 17:11:52.327+0600 W/AUL_PAD ( 1521): launchpad.c: __send_result_to_caller(267) > Check app launching
09-10 17:11:52.337+0600 I/GXT_SIB (  283): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 17:11:52.347+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bd2b21 in class 'Edje_Object'.
09-10 17:11:52.347+0600 E/UXT     (  283): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
09-10 17:11:52.347+0600 I/TIZEN_N_EFL_UTIL_WINDOW(27618): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 43
09-10 17:11:52.347+0600 E/APP_CORE(27618): appcore-efl.c: _capture_and_make_file(1631) > win[6800002] widget[480] height[800]
09-10 17:11:52.357+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 17:11:52.367+0600 E/CAPI_APPFW_APPLICATION(27741): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:11:52.367+0600 E/CAPI_APPFW_APPLICATION(27741): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:11:52.367+0600 E/CAPI_APPFW_APPLICATION(27741): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:11:52.367+0600 E/CAPI_APPFW_APPLICATION(27741): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:11:52.367+0600 E/CAPI_APPFW_APPLICATION(27741): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
09-10 17:11:52.367+0600 I/CAPI_APPFW_APPLICATION(27741): app_main.c: ui_app_main(789) > app_efl_main
09-10 17:11:52.367+0600 I/CAPI_APPFW_APPLICATION(27741): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
09-10 17:11:52.387+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_create(442) > New handle created[0xb83e0240]
09-10 17:11:52.387+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_get_type(496) > Connected Network = 0
09-10 17:11:52.387+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
09-10 17:11:52.387+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
09-10 17:11:52.387+0600 I/CAPI_NETWORK_CONNECTION( 1522): connection.c: connection_destroy(460) > Destroy handle: 0xb83e0240
09-10 17:11:52.397+0600 E/weather-common( 1522): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
09-10 17:11:52.397+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
09-10 17:11:52.397+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
09-10 17:11:52.397+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
09-10 17:11:52.397+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
09-10 17:11:52.397+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: fg
09-10 17:11:52.427+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 27741, appid: com.samsung.task-mgr
09-10 17:11:52.427+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
09-10 17:11:52.427+0600 W/AUL     (  763): launch.c: app_request_to_launchpad(425) > request cmd(0) result(27741)
09-10 17:11:52.437+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:11:52.457+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:11:52.457+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:11:52.497+0600 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16676051
09-10 17:11:52.497+0600 W/STARTER (  763): hw_key.c: _key_release_cb(586) > [_key_release_cb:586] Home Key is released
09-10 17:11:52.507+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
09-10 17:11:52.507+0600 E/STARTER (  763): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
09-10 17:11:52.507+0600 E/STARTER (  763): )
09-10 17:11:52.517+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-10 17:11:52.517+0600 I/SYSPOPUP( 1005): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-10 17:11:52.517+0600 E/VOLUME  ( 1005): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-10 17:11:52.517+0600 E/VOLUME  ( 1005): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
09-10 17:11:52.597+0600 E/RESOURCED(15587): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
09-10 17:11:52.607+0600 W/TASK_MGR_LITE(27741): task-mgr-lite.c: create_win(197) > changeable ui enabled success
09-10 17:11:52.677+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:52.677+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:52.697+0600 I/GXT_SIB (27741): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
09-10 17:11:52.697+0600 E/EFL     (27618): ecore_x<27618> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16676051
09-10 17:11:52.707+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:11:52.727+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 17:11:52.727+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 17:11:52.767+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:11:52.777+0600 E/RUA     (27741): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 19, ncols : 5
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
09-10 17:11:52.777+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:11:52.777+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 27618
09-10 17:11:52.777+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 12
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.bt-syspopup) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (ug-bluetooth-efl-single) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
09-10 17:11:52.777+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
09-10 17:11:52.837+0600 I/APP_CORE(27741): appcore-efl.c: __do_app(520) > [APP 27741] Event: RESET State: CREATED
09-10 17:11:52.837+0600 I/CAPI_APPFW_APPLICATION(27741): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
09-10 17:11:52.847+0600 E/EFL     (27741): edje<27741> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:11:52.847+0600 E/EFL     (27741): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:11:52.847+0600 E/EFL     (27741): edje<27741> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
09-10 17:11:52.847+0600 E/EFL     (27741): By the power of Grayskull, your previous Embryo stack is now broken!
09-10 17:11:52.847+0600 W/APP_CORE(27741): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000003
09-10 17:11:52.847+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
09-10 17:11:52.917+0600 I/MALI    (27741): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb80e5880)
09-10 17:11:52.937+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb787b088), gem(32), surface(0xb78b6eb8)
09-10 17:11:52.937+0600 I/MALI    (27741): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:11:52.957+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(27741) status(0)
09-10 17:11:52.957+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:11:52.957+0600 I/APP_CORE(27741): appcore-efl.c: __do_app(520) > [APP 27741] Event: RESUME State: CREATED
09-10 17:11:52.967+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: PAUSE State: RUNNING
09-10 17:11:52.967+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:11:52.967+0600 E/cluster-home(  873): homescreen.cpp: OnPause(260) >  app pause
09-10 17:11:52.967+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(4)
09-10 17:11:52.967+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(873)
09-10 17:11:52.967+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: bg
09-10 17:11:52.967+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(27741) status(3)
09-10 17:11:52.967+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:11:52.967+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:11:52.977+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(27741)
09-10 17:11:52.977+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27741, appid: com.samsung.task-mgr, status: fg
09-10 17:11:52.977+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb774f620), gem(30), surface(0xb787e520)
09-10 17:11:52.987+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:11:52.987+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78756b0), gem(18), surface(0xb78a62a8)
09-10 17:11:52.987+0600 I/APP_CORE(27741): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
09-10 17:11:52.987+0600 I/APP_CORE(27741): appcore-efl.c: __do_app(637) > [APP 27741] Initial Launching, call the resume_cb
09-10 17:11:52.987+0600 I/CAPI_APPFW_APPLICATION(27741): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:11:53.007+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __provider_pause_cb(304) > widget obj was paused
09-10 17:11:53.007+0600 I/CAPI_WIDGET_APPLICATION( 1522): widget_app.c: __check_status_for_cgroup(152) > enter background group
09-10 17:11:53.007+0600 W/AUL     ( 1522): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1522, appid: com.samsung.weather-m-widget, status: bg
09-10 17:11:53.408+0600 E/EFL     (27741): ecore_x<27741> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16676966
09-10 17:11:53.448+0600 E/EFL     (27741): ecore_x<27741> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16677005
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 14
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 27618
09-10 17:11:53.458+0600 W/AUL     (27741): launch.c: app_request_to_launchpad(396) > request cmd(4) to(27618)
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 4
09-10 17:11:53.458+0600 I/APP_CORE(27618): appcore-efl.c: __do_app(520) > [APP 27618] Event: TERMINATE State: PAUSED
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_launch.c: __reply_handler(1102) > listen fd(27) , send fd(26), pid(27618), cmd(4)
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:11:53.458+0600 I/TIZEN_N_EFL_UTIL_WINDOW(27618): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
09-10 17:11:53.458+0600 E/APP_CORE(27618): appcore-efl.c: _capture_and_make_file(1631) > win[6800002] widget[480] height[800]
09-10 17:11:53.458+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
09-10 17:11:53.468+0600 E/APP_CORE(27618): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
09-10 17:11:53.468+0600 I/CAPI_APPFW_APPLICATION(27618): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:11:53.468+0600 E/CAPI_NETWORK_BLUETOOTH(27618): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
09-10 17:11:53.468+0600 W/AUL     (27741): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
09-10 17:11:53.498+0600 I/MALI    (27741): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:11:53.518+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2509
09-10 17:11:53.518+0600 I/MALI    (27741): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:11:53.538+0600 I/MALI    (27741): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
09-10 17:11:53.538+0600 I/Tizen::App( 1366): (499) > LaunchedApp(com.samsung.task-mgr)
09-10 17:11:53.538+0600 I/Tizen::App( 1366): (733) > Finished invoking application event listener for com.samsung.task-mgr, 27741.
09-10 17:11:53.678+0600 E/CAPI_NETWORK_BLUETOOTH(27618): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
09-10 17:11:53.678+0600 E/CAPI_NETWORK_BLUETOOTH(27618): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
09-10 17:11:53.678+0600 E/bluetooth(27618): [bt_adapter_le_destroy_advertiser] Failed.
09-10 17:11:53.678+0600 I/CAPI_NETWORK_WIFI(27618): net_wifi.c: wifi_deinitialize(98) > Wi-Fi successfully de-initialized
09-10 17:11:53.678+0600 E/bluetooth(27618): [wifi_deinitialize] Success.
09-10 17:11:53.738+0600 E/EFL     (27618): elementary<27618> elm_entry.c:4757 _elm_entry_elm_layout_text_get() text=NULL for edje 0x80041e11, part 'elm.text'
09-10 17:11:53.748+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
09-10 17:11:53.748+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
09-10 17:11:53.748+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(27741)
09-10 17:11:53.748+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 27741, appid: com.samsung.task-mgr, status: bg
09-10 17:11:53.748+0600 I/CAPI_APPFW_APPLICATION(27741): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
09-10 17:11:53.748+0600 W/TASK_MGR_LITE(27741): task-mgr-lite.c: _pause_app(406) > 
09-10 17:11:53.748+0600 I/CAPI_APPFW_APPLICATION(27741): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
09-10 17:11:53.768+0600 E/TASK_MGR_LITE(27741): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
09-10 17:11:53.778+0600 E/APP_CORE(27741): appcore.c: appcore_flush_memory(803) > Appcore not initialized
09-10 17:11:53.778+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:53.788+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(873) status(3)
09-10 17:11:53.788+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-10 17:11:53.788+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
09-10 17:11:53.788+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(873)
09-10 17:11:53.788+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 873, appid: com.samsung.homescreen, status: fg
09-10 17:11:53.798+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
09-10 17:11:53.818+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb78756b0), gem(18), surface(0xb78ae1a0)
09-10 17:11:53.868+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b28e8), gem(30), surface(0xb787e520)
09-10 17:11:53.868+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb77b28e8), gem(30), surface(0xb78b0690)
09-10 17:11:53.888+0600 I/APP_CORE(  873): appcore-efl.c: __do_app(520) > [APP 873] Event: RESUME State: PAUSED
09-10 17:11:53.888+0600 I/CAPI_APPFW_APPLICATION(  873): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
09-10 17:11:53.888+0600 E/cluster-home(  873): homescreen.cpp: OnResume(233) >  app resume
09-10 17:11:53.898+0600 E/EFL     (  283): eo<283> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
09-10 17:11:53.918+0600 I/MALI    (27741): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-10 17:11:53.918+0600 I/MALI    (27741): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=27741   close drm_fd=29 
09-10 17:11:53.918+0600 I/MALI    (27741): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-10 17:11:53.928+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
09-10 17:11:53.928+0600 I/Tizen::System( 1366): (259) > Active app [com.samsun], current [com.samsun] 
09-10 17:11:53.928+0600 I/Tizen::System( 1366): (273) > Current App[com.samsun] is already actived.
09-10 17:11:53.938+0600 I/MALI    (  283): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb768eb50), gem(23), surface(0xb787e520)
09-10 17:11:53.978+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 27618 pgid = 27618
09-10 17:11:53.978+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(143) > dead_pid(27618)
09-10 17:11:54.018+0600 E/weather-widget( 1522): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
09-10 17:11:54.078+0600 E/weather-widget( 1522): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
09-10 17:11:54.098+0600 I/AUL_PAD ( 1521): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
09-10 17:11:54.098+0600 I/AUL_PAD ( 1521): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
09-10 17:11:54.098+0600 E/AUL_PAD ( 1521): launchpad.c: main(698) > error reading sigchld info
09-10 17:11:54.108+0600 I/Tizen::App( 1366): (243) > App[org.example.bluetooth] pid[27618] terminate event is forwarded
09-10 17:11:54.108+0600 I/Tizen::System( 1366): (256) > osp.accessorymanager.service provider is found.
09-10 17:11:54.108+0600 I/Tizen::System( 1366): (196) > Accessory Owner is removed [org.example.bluetooth, 27618, ]
09-10 17:11:54.108+0600 I/Tizen::System( 1366): (256) > osp.system.service provider is found.
09-10 17:11:54.108+0600 I/Tizen::App( 1366): (506) > TerminatedApp(org.example.bluetooth)
09-10 17:11:54.108+0600 I/Tizen::App( 1366): (512) > Not registered pid(27618)
09-10 17:11:54.108+0600 I/Tizen::System( 1366): (246) > Terminated app [org.example.bluetooth]
09-10 17:11:54.108+0600 I/Tizen::Io( 1366): (729) > Entry not found
09-10 17:11:54.108+0600 I/ESD     (  915): esd_main.c: __esd_app_dead_handler(1773) > pid: 27618
09-10 17:11:54.108+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 27618
09-10 17:11:54.118+0600 E/RESOURCED(15587): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2510
09-10 17:11:54.128+0600 E/RESOURCED(15587): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
09-10 17:11:54.128+0600 I/Tizen::System( 1366): (157) > change brightness system value.
09-10 17:11:54.128+0600 I/Tizen::App( 1366): (782) > Finished invoking application event listener for org.example.bluetooth, 27618.
09-10 17:11:54.158+0600 E/weather-common( 1522): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
09-10 17:11:54.168+0600 W/CRASH_MANAGER(29041): worker.c: worker_job(1199) > 1127618626162147350591
