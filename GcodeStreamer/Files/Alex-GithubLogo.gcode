(Scribbled version of C:\Users\alex\AppData\Local\Temp\ink_ext_XXXXXX.svgWXMBWZ @ 3500.00)
( unicorn.py --tab="plotter_setup" --pen-up-angle=50 --pen-down-angle=30 --start-delay=150 --stop-delay=150 --xy-feedrate=3500 --z-feedrate=150 --z-height=0 --finished-height=0 --register-pen=true --x-home=0 --y-home=0 --num-copies=1 --continuous=false --pause-on-layer-change=false C:\Users\alex\AppData\Local\Temp\ink_ext_XXXXXX.svgWXMBWZ )
G21 (metric ftw)
G90 (absolute mode)
G92 X0.00 Y0.00 Z0.00 (you are here)

M300 S30 (pen down)
G4 P150 (wait 150ms)
M300 S50 (pen up)
G4 P150 (wait 150ms)
M18 (disengage drives)
M01 (Was registration test successful?)
M17 (engage drives if YES, and continue)

(Polyline consisting of 1 segments.)
G1 X-8.76 Y48.28 F3500.00
M300 S30.00 (pen down)
G4 P150 (wait 150ms)
G1 X4.66 Y48.28 F3500.00
G1 X4.66 Y46.63 F3500.00
G1 X-8.76 Y46.63 F3500.00
G1 X-8.76 Y48.28 F3500.00
M300 S50.00 (pen up)
G4 P150 (wait 150ms)

(Polyline consisting of 1 segments.)
G1 X-6.44 Y52.02 F3500.00
M300 S30.00 (pen down)
G4 P150 (wait 150ms)
G1 X-4.84 Y52.02 F3500.00
G1 X-4.84 Y38.37 F3500.00
G1 X-6.44 Y38.37 F3500.00
G1 X-6.44 Y52.02 F3500.00
M300 S50.00 (pen up)
G4 P150 (wait 150ms)

(Polyline consisting of 1 segments.)
G1 X37.34 Y-10.00 F3500.00
M300 S30.00 (pen down)
G4 P150 (wait 150ms)
G1 X50.86 Y-10.00 F3500.00
G1 X50.86 Y-11.92 F3500.00
G1 X37.34 Y-11.92 F3500.00
G1 X37.34 Y-10.00 F3500.00
M300 S50.00 (pen up)
G4 P150 (wait 150ms)

(Polyline consisting of 1 segments.)
G1 X45.64 Y0.38 F3500.00
M300 S30.00 (pen down)
G4 P150 (wait 150ms)
G1 X47.24 Y0.38 F3500.00
G1 X47.24 Y-14.86 F3500.00
G1 X45.64 Y-14.86 F3500.00
G1 X45.64 Y0.38 F3500.00
M300 S50.00 (pen up)
G4 P150 (wait 150ms)

(Polyline consisting of 2 segments.)
G1 X11.99 Y8.54 F3500.00
M300 S30.00 (pen down)
G4 P150 (wait 150ms)
G1 X11.99 Y11.90 F3500.00
G1 X21.96 Y11.90 F3500.00
G1 X31.94 Y11.90 F3500.00
G1 X31.94 Y8.54 F3500.00
G1 X31.94 Y5.18 F3500.00
G1 X21.96 Y5.18 F3500.00
G1 X11.99 Y5.18 F3500.00
G1 X11.99 Y8.54 F3500.00
M300 S50.00 (pen up)
G4 P150 (wait 150ms)

(Polyline consisting of 2 segments.)
G1 X11.99 Y21.73 F3500.00
M300 S30.00 (pen down)
G4 P150 (wait 150ms)
G1 X11.99 Y25.04 F3500.00
G1 X8.68 Y25.04 F3500.00
G1 X5.37 Y25.04 F3500.00
G1 X5.37 Y28.40 F3500.00
G1 X5.37 Y31.75 F3500.00
G1 X8.68 Y31.75 F3500.00
G1 X11.99 Y31.75 F3500.00
G1 X11.99 Y35.06 F3500.00
G1 X11.99 Y38.37 F3500.00
G1 X21.96 Y38.37 F3500.00
G1 X31.94 Y38.37 F3500.00
G1 X31.94 Y35.06 F3500.00
G1 X31.94 Y31.75 F3500.00
G1 X35.25 Y31.75 F3500.00
G1 X38.56 Y31.75 F3500.00
G1 X38.56 Y28.40 F3500.00
G1 X38.56 Y25.04 F3500.00
G1 X35.25 Y25.04 F3500.00
G1 X31.94 Y25.04 F3500.00
G1 X31.94 Y21.73 F3500.00
G1 X31.94 Y18.42 F3500.00
G1 X28.58 Y18.42 F3500.00
G1 X25.22 Y18.42 F3500.00
G1 X25.22 Y21.73 F3500.00
G1 X25.22 Y25.04 F3500.00
G1 X21.96 Y25.04 F3500.00
G1 X18.70 Y25.04 F3500.00
G1 X18.70 Y21.73 F3500.00
G1 X18.70 Y18.42 F3500.00
G1 X15.34 Y18.42 F3500.00
G1 X11.99 Y18.42 F3500.00
G1 X11.99 Y21.73 F3500.00
M300 S50.00 (pen up)
G4 P150 (wait 150ms)


(end of print job)
M300 S50.00 (pen up)
G4 P150 (wait 150ms)
M300 S255 (turn off servo)
G1 X0 Y0 F3500.00
G1 Z0.00 F150.00 (go up to finished level)
G1 X0.00 Y0.00 F3500.00 (go home)
M18 (drives off)
