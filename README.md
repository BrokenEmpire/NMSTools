# NMSTools

A .Net Serialization/Deserialization framework for viewing No Man's Sky save games.  All properties are properly attributed with the obscured NMS key name and all classes inherit INotifyPropertyChanged for easy WPF/XAML binding.

The framework uses Newtonsoft.Json for Json parsing.

Save file schema is based on No Man's Sky version 3.13 [Next Generation Update]

The project is currently undergoing active development and is not ready for public use.

Todo:
 - Complete the hashing function for the mf_save.hg file.
