# Creating a Book Library App with WPF Data Grid

This sample demonstrates how to build a Book Library App using WPF and Syncfusion’s WPF Data Grid control. The application follows the MVVM design pattern and provides a user-friendly interface for managing a digital book collection.

## Overview

The Book Library App allows users to:

- View and manage a list of books
- Search for books by name or other data
- Add, edit, and delete book records
- Filter books by genre using a navigation drawer
- Export the collection to Excel or PDF
- Toggle filtering and case-sensitive search behavior

The application uses the Syncfusion `WPF Data Grid`, `SfNavigationDrawer`, and WPF layout features to create a modern, interactive library management UI.

## Features

- MVVM-based architecture
- Search box for quick filtering
- Editable data grid for book records
- Add and delete operations
- Genre-based navigation drawer
- Excel export support
- PDF export support
- Syncfusion WPF theme support

## Project Structure

```text
BookLibraryDemoWithWPFDataGrid/
├── App.xaml
├── App.xaml.cs
├── AssemblyInfo.cs
├── Behavior.cs
├── BookLibraryDemoWithWPFDataGrid.csproj
├── BookLibraryDemoWithWPFDataGrid.sln
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── Model.cs
├── ViewModel.cs
└── README.md
