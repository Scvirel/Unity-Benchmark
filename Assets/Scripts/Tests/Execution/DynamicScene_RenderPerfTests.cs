﻿using UnityEngine;
using System.Collections;
using Unity.PerformanceTesting;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class DynamicScene_RenderPerfTests : RenderPerformanceTestsBase
{
    private readonly string basicSceneName = "RenderPerformance";
    private readonly string spiralSceneName = "PerformanceTest";
    private readonly string setTargetBufferMaterialTestSceneName = "SetTargetBuffer_MaterialTest";
    private readonly string renderTextureMaterialTestSceneName = "RenderTexture_MaterialTest";
    private readonly string stencilMaterialTestSceneName = "Stencil_MaterialTest";
    private readonly string transparentMaterialTestSceneName = "Transparent_MaterialTest";
    private readonly string gpuInstancingMaterialTestSceneName = "GPUInstancing_MaterialTest";
    private readonly string standardMaterialTestSceneName = "Standard_MaterialTest";
    private readonly string realTimeLightingDirectionalTestSceneName = "RealtimeLighting_Directional";
    private readonly string realTimeLightingPointLightTestSceneName = "RealtimeLighting_PointLight";
    private readonly string realTimeLightingSpotlightTestSceneName = "RealtimeLighting_SpotLight";
    private readonly string terrainTestSceneName = "TerrainTest";

    protected SampleGroupDefinition[] SamplerNames = {
        new SampleGroupDefinition("Camera.Render", SampleUnit.Millisecond, AggregationType.Min),
        new SampleGroupDefinition("Render.Mesh", SampleUnit.Millisecond, AggregationType.Min)
    };

    [UnityTest, Performance]
    public IEnumerator Terrain()
    {
        yield return SceneManager.LoadSceneAsync(terrainTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(terrainTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(terrainTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator RealtimeLighting_Directional()
    {
        yield return SceneManager.LoadSceneAsync(realTimeLightingDirectionalTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(realTimeLightingDirectionalTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(realTimeLightingDirectionalTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator RealtimeLighting_Point()
    {
        yield return SceneManager.LoadSceneAsync(realTimeLightingPointLightTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(realTimeLightingPointLightTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(realTimeLightingPointLightTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator RealtimeLighting_Spot()
    {
        yield return SceneManager.LoadSceneAsync(realTimeLightingSpotlightTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(realTimeLightingSpotlightTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(realTimeLightingSpotlightTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator SpiralFlame_RenderPerformance()
    {
        yield return SceneManager.LoadSceneAsync(spiralSceneName, LoadSceneMode.Additive);

        SetActiveScene(spiralSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {

            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(spiralSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator SetTargetBufferMaterial()
    {
        yield return SceneManager.LoadSceneAsync(setTargetBufferMaterialTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(setTargetBufferMaterialTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(setTargetBufferMaterialTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator RenderTextureMaterial()
    {
        yield return SceneManager.LoadSceneAsync(renderTextureMaterialTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(renderTextureMaterialTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(renderTextureMaterialTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator StencilMaterial()
    {
        yield return SceneManager.LoadSceneAsync(stencilMaterialTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(stencilMaterialTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(stencilMaterialTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator TransparentMaterial()
    {
        yield return SceneManager.LoadSceneAsync(transparentMaterialTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(transparentMaterialTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(transparentMaterialTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator GpuInstacingMaterial()
    {
        yield return SceneManager.LoadSceneAsync(gpuInstancingMaterialTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(gpuInstancingMaterialTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(gpuInstancingMaterialTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator StandardMaterial()
    {
        yield return SceneManager.LoadSceneAsync(standardMaterialTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(standardMaterialTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<DynamicRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(standardMaterialTestSceneName);
    }
}