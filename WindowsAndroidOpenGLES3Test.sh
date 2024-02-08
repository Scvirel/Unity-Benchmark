#!/usr/bin/env bash
#This file must be located at the project root.
echo Start testing process!

#The default quit timeout is 300 seconds (5 mins). The full tesing process could take more time, that's why we set this value bigger
QUIT_TIMEOUT=100000

#This is a current project directory.
PROJECT_PATH=$(pwd)

#Parse the Unity version from the ProjectVersion.txt file
UNITY_VERSION=$(awk '{ print $2 ; exit}' "$PROJECT_PATH/ProjectSettings/ProjectVersion.txt")

#Path to the Unity Editor executable
UNITY_PATH="C:/PROGRA~1/Unity/Hub/Editor/$UNITY_VERSION/Editor/Unity"

$UNITY_PATH -runTests -batchmode -projectPath $PROJECT_PATH -testPlatform Win64 -buildTarget Win64 -playergraphicsapi=OpenGLES3 -mtRendering -scriptingb D:\UnityProjects\UnityBenchmarking\PerfBenchmark_Android_OpenGLES3_MtRendering_Mono.xml -logfile D:\UnityProjects\UnityBenchmarking\PerfBenchmark_Android_OpenGLES3_MtRendering_Mono.txt