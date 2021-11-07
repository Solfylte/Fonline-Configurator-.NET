# Fonline Configurator .NET
Third-party and open source configurator for FOnline.

Originally, it was created for the server "TLA mk2". At the moment it is completely rewritten for common FOnline.
Can be a good base for your modifications. Or for  work with any configuration file.

## Localization
Unlike the original, this one has an external localization, and can support any number of languages.
The approach to localization is identical to working with a configuration file (see Release/Localization.cfg). 
For adding your own language, just copy-paste any section and modificate. For example, polsk.:
```
[pols]
checkBoxLoggingTime = Rejestrowanie ze znacznikiem czasu.
checkBoxLogging = Logowanie do 'Fonline.log'.
...
```
e.t.c.

##Project structure
FOConfigForm - windows form implementation.
Configurator.dll - common library for work with .cfg files. 
FonlineConfigurator.dll - narrowly focused library for working FOnline.
/Release/ folder - already compiled project with *.cfg examples.

## Others

You can also add your own configuration sections and use them. For example:
```
[MyOwnSection]
customValue1 = 1
customValue2 = True
```

The configurator is resistant to incorrect data. In case of incorrect values, it simply uses the default value.
