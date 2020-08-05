using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    [SerializeField] AudioMixer _audioMixer;
    [SerializeField]  Slider _bgVolumeSlider;
    [SerializeField]  Slider _effectsVolumeSlider;
    [SerializeField] TextMeshProUGUI _bgVolumeValue;
    public  TextMeshProUGUI _effectsVolumeValue;
    [SerializeField] string mixerChannelName;

    private void OnEnable()
    {
        _audioMixer.GetFloat("Bg_Volume", out var bgVal);
        _bgVolumeValue.text = bgVal.ToString("F0");
        _audioMixer.GetFloat("Effects_Volume", out var soundsVal);
        _effectsVolumeValue.text = soundsVal.ToString("F0");
        _bgVolumeSlider.value = bgVal;
        _effectsVolumeSlider.value = soundsVal;
        _bgVolumeSlider.onValueChanged.AddListener(onChangeBGVolumeValue);
        _effectsVolumeSlider.onValueChanged.AddListener(onChangeEffectVolumeValue);
    }

    private void OnDisable()
    {
        _bgVolumeSlider.onValueChanged.RemoveListener(onChangeBGVolumeValue);
        _bgVolumeSlider.onValueChanged.RemoveListener(onChangeEffectVolumeValue);
    }

    private void onChangeBGVolumeValue(float arg0)
    {
        _audioMixer.SetFloat("Bg_Volume", arg0);
        _bgVolumeValue.text = arg0.ToString("F0");
    }

    private void onChangeEffectVolumeValue(float arg0)
    {
        _audioMixer.SetFloat("Effects_Volume", arg0);
        _effectsVolumeValue.text = arg0.ToString("F0");
    }

}
