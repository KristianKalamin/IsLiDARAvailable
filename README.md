# IsLiDARAvailable
Unity plugin to check if LiDAR is available on iPhone/iPad 

Copy LiDARChecker.mm into Plugins/iOS folder and LiDARChecker.cs into Scripts folder

## Usage

```c#

if LiDARChecker.IsLiDARSupported() {
   // LiDAR is available
}

```