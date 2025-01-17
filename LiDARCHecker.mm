#import <ARKit/ARKit.h>

extern "C" {

    bool isLiDARSupported() {
        // Check if ARKit supports the frame semantics for scene depth
        if ([ARWorldTrackingConfiguration supportsFrameSemantics:ARFrameSemanticSceneDepth]) {
            return YES;
        } else {
            return NO;
        }
    }
}
