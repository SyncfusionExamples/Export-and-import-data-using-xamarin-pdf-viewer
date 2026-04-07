# Export-and-import-data-using-xamarin-pdf-viewer

This repository contains a sample application that demonstrates how to export and import annotations and form data using the Xamarin PDF Viewer.

## Overview

This repository provides Xamarin sample applications that demonstrate how to export and import annotations and form field data using the Xamarin PDF Viewer. These samples help developers understand how to persist user interactions with PDF documents and restore them later without modifying the original PDF file.

PDF documents often contain interactive elements such as annotations (highlights, shapes, text notes, and ink drawings) and form fields (text boxes, checkboxes, radio buttons, and signatures). This repository focuses on extracting these elements, storing them externally, and reapplying them to the same or another PDF document.

These techniques are useful for preserving document state across app restarts, synchronizing data across devices, and enabling collaborative document workflows.

## Supported Platforms

The sample supports the following platforms:

- Android  
- iOS  
- UWP (Universal Windows Platform)

All export and import functionalities are implemented consistently across the supported platforms.

## Export and Import Annotations

This sample demonstrates how annotations added to a PDF document using the Xamarin PDF Viewer can be exported programmatically. The exported annotation data can be saved as a file or stream and stored locally or remotely.

The import functionality allows previously exported annotation data to be reapplied to the PDF document. After import, annotations appear in their original positions with the same properties, such as color, size, opacity, and type.

This workflow is commonly used in document review systems, feedback tools, and collaborative applications where annotations need to be preserved or shared.

## Export and Import Form Data

This sample focuses on interactive PDF form fields. Users can fill out form fields within the PDF Viewer, and the application can export the entered values independently of the original PDF document.

The exported form data can later be imported to automatically populate the corresponding fields. This enables applications to save partially completed forms, restore form data after app restarts, or transfer form information across devices.

This scenario is especially useful for business forms, surveys, and data collection workflows.

## Key Capabilities Demonstrated

The sample demonstrates the following capabilities:

- Integrating Xamarin PDF Viewer into applications  
- Exporting user-created PDF annotations  
- Importing previously saved annotations  
- Exporting PDF form field data  
- Importing and auto-filling form data  
- Preserving user input across application sessions  
- Working with PDF streams and external storage  

## Prerequisites

To run and explore these samples, ensure you have the following:

- Visual Studio with Xamarin development support  
- Basic knowledge of Xamarin.Forms development  
- Xamarin PDF Viewer properly configured in the project  
- A supported platform environment (Android, iOS, or UWP)  

## Additional Notes

- The original PDF document remains unchanged during export and import operations  
- Annotation and form data can be stored in files, databases, or transmitted over a network  
- These samples are intended for learning and demonstration purposes  

## Conclusion

This repository provides practical examples of implementing annotation and form data persistence in Xamarin applications using the PDF Viewer. The samples demonstrate how to retain user interactions with PDF documents and deliver a reliable and consistent document experience across platforms.

For more details, refer to the official Syncfusion [documentation](https://help.syncfusion.com/document-processing/pdf/pdf-viewer/xamarin/overview) and [API reference](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.html)
