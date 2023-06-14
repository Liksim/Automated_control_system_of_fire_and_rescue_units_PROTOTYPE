import sys
import time
import os
from gtts import gTTS
from pydub import AudioSegment


def create_gtts_audio(text):
    project_file_path = "D:\\Study\\DIPLOM\\Prototip\\Prototip\\audios\\"

    filename_mp3 = project_file_path + str(time.time() * 1000) + ".mp3"
    filename_wav = project_file_path + str(time.time() * 1000) + ".wav"

    audio_mp3 = gTTS(text=text, lang="ru", slow=False)
    audio_mp3.save(filename_mp3)

    audio_wav = AudioSegment.from_mp3(filename_mp3)
    audio_wav.export(filename_wav, format="wav")

    os.remove(filename_mp3)

    return filename_wav


print(create_gtts_audio(sys.argv[1]))
