# unit-tests-sample

Sample project of a simple implementation of unit tests in Unity

 ## About the project

This project is a very simple calculator that does only elementary arithmetic operations. It is possible to test it playing the scene `SampleScene`.

## About Unity Test Framework

Unit tests allows to test logic and implementation of code both in the `editor` and `play` mode. 

> To read more about the Test Framework, please refer to the Unity oficial documentation: https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/index.html

### Setup

To use the `Unity Test Framework` (UTF) all scripts that are going to be tested needs to be included in a Assembly Definition. To create a new one right click the folder containing the scripts and go to `Create -> Assembly Definition`.

> To read more about the Assembly Definitions, please refer to the Unity oficial documentation: https://docs.unity3d.com/Manual/ScriptCompilationAssemblyDefinitionFiles.html

After downloading the UTF package, create a folder called `Tests`.

With the Tests folder selected, open the `TestRunner` window and in EditMode click on the button "Create EditMode Test Assembly Folder". Do the same for PlayMode and add the assembly created previously in the Assembly Definition References list in each test assembly.

To create a new test either click the button "Create Test Script in current folder" or right click on the folder and go to `Create -> Testing -> C# Test Script`.

### Usage

To run a test, open the Test Runner window and right click on it, then select Run. It is possible to run all existing tests clicking on the button Run All.
