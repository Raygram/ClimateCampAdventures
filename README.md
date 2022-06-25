# ClimateCampAdventures
## A Simulator for Climate Activists that is both fun and can prepare you for action
This project was part of the Introduction to Unity course. Our first project working with Unity and C#. In the final game you can experience some of the problems you might face when going to a climate camp. In our chosen scenario the player finds herself in a base camp with the final goal to find the coal mine and stop the diggers, while encountering some further tasks on the way. An extension to the game might likely happen in the future

<p align="center">
  <img src="ClimateCampAdventures.JPG" alt="Start image from game" width = 600 height=350/>
</p>


## Repository structure and how to use
- `model.py` contains the GAN as well as the Discriminator and Generator class
- `training_utilities.py` contains the training loop and utility functions used during training to obtain sheet music and audio of the generated samples
- `preprocessing.py` contains functions to prepare new datasets in the same format used by the model
- `models` contains the trained models
- `datasets` contains the preprocessed datasets as one tensorflow dataset
- `Training.ipynb` contains code to run the training while logging to tensorboard
- `GenerateSamples.ipynb` can be used to load a stored model and generate new samples from it

To easily run these things in Colab there are additional "InColab" notebooks, which contain specific setup sections in the beginning of the notebooks.
There is also the `SimpleDriveSetupForColab.ipynb`, which can be opened in Colab via the button at its top and then used to clone this repo into your drive and start notebooks for training or sample generation.


Some parts of the training, generation of samples, and preprocessing require certain libraries and software to be installed. We provide an environment.txt file for hassle-free setup of an environment containing the necessary python libraries. However, to generate the sheet music a recent version of Musescore also needs to be installed, which can be done using the following commands.
```
sudo add-apt-repository ppa:mscore-ubuntu/mscore-stable -y
sudo apt-get update
sudo apt-get install musescore
```
It is possible that the music21 library cannot find the musescore installation, in that case running this python code should solve the issue:
```
import music21
us = music21.environment.UserSettings()
us['musescoreDirectPNGPath'] = '/usr/bin/mscore'
us['directoryScratch'] = '/tmp'
```



