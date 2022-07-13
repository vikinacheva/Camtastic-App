# Camtastic App

# Overview
Camtastic is an application that provides statistics for camera usage by photographers and the success of the photos based on user views and likes.

# Specifications
The Camtastic application should work with the data from https://photo-forum.net/. The application should automatically find and save photo URLs from the platform to a database as well as information about the camera brand, camera model and the photo rating (consider only rating A). If there isn’t any information about the camera used then the photo should be skipped. See examples below.
Users should be able to receive reports for the usage of camera brands and certain camera models by photographers on the platform. The reports should also consider the rating of each photo.

# Entities
-Photo
Represents information about a photo. It consists of the photo url, rating and camera.
-Camera
Represents information about a camera. Should consist of brand name and model.

# Output
The output has to be in the following format: Dictionary<string,List<Picture>> where the Key is the name of the camera brand and the List is all pictures stored in the database.

# Milestones
Infrastructure setup
-Application skeleton


# Examples
-Input
  https://photo-forum.net/i/2422936
-Output
This is a valid URL with picture, rating(get only rating “A”) and camera info. If you click “Info” button a modal will shows up metadata, get camera brand programmatically. Get and store data only if camera brand is not empty.

  https://photo-forum.net/i/163882
A valid Url but no metadata. This url must be skipped
https://photo-forum.net/i/161882
An invalid Url. Skip and go ahead


