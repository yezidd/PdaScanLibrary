
# react-native-pda-scan-library

## Getting started

`$ npm install react-native-pda-scan-library --save`

### Mostly automatic installation

`$ react-native link react-native-pda-scan-library`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-pda-scan-library` and add `RNPdaScanLibrary.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNPdaScanLibrary.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNPdaScanLibraryPackage;` to the imports at the top of the file
  - Add `new RNPdaScanLibraryPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-pda-scan-library'
  	project(':react-native-pda-scan-library').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-pda-scan-library/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-pda-scan-library')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNPdaScanLibrary.sln` in `node_modules/react-native-pda-scan-library/windows/RNPdaScanLibrary.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Pda.Scan.Library.RNPdaScanLibrary;` to the usings at the top of the file
  - Add `new RNPdaScanLibraryPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNPdaScanLibrary from 'react-native-pda-scan-library';

// TODO: What to do with the module?
RNPdaScanLibrary;
```
  # PdaScanLibrary
