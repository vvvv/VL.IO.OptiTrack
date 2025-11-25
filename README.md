# VL.IO.OptiTrack

Support for Marker, Rigid Body and Skeleton tracking by [OptiTrack](https://optitrack.com). 

For use with vvvv, the visual live-programming environment for .NET: http://vvvv.org

In [Motive](https://optitrack.com/support/downloads/motive.html) make sure to enable NatNet in the [Streaming Settings](https://docs.optitrack.com/motive-ui-panes/settings/settings-streaming) and configure the options matching with settings in vvvv. Most notably:

- Skeleton Coordinates: Local
- Skeleton as Rigid Bodies: Off
- Bone Naming Convention: FBX
- Up Axis: Y-Axis

## Getting started
- Install as [described here](https://thegraybook.vvvv.org/reference/hde/managing-nugets.html) via commandline:

    `nuget install VL.IO.OptiTrack -pre`

- Usage examples and more information are included in the pack and can be found via the [Help Browser](https://thegraybook.vvvv.org/reference/hde/findinghelp.html)

## Contributing
- Report issues on [the vvvv forum](https://forum.vvvv.org/c/vvvv-gamma/28)
- For custom development requests, please [get in touch](mailto:devvvvs@vvvv.org)
- When making a pull-request, please make sure to read the general [guidelines on contributing to vvvv libraries](https://thegraybook.vvvv.org/reference/extending/contributing.html)

## Credits
Based on [NatNetSDK 4.4](https://optitrack.com/software/natnet-sdk)