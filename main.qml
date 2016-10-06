import QtQuick 2.7
import QtQuick.Window 2.2
import QtPositioning 5.2

Window {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    MainForm {
        Map {
            id: map
            zoomLevel: (maximumZoomLevel - minimumZoomLevel)/2
            center {
                // The Qt Company in Oslo
                latitude: 59.9485
                longitude: 10.7686
            }
        }
        }
    }
}
