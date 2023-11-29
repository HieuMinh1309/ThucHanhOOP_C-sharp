using InterfaceCSharp;

SomeFile file = new();
file.WriteBinaryFile(); //của itextfile
file.WriteTextFile(); //của ibinaryfile
file.ReadFile(); //mặc định là của chung 2 thằng
((IBinaryFile)file).ReadFile(); //của binaryfile, c# old

(file as ITextFile).ReadFile(); // của textfile c# new

AnyFile anyFile = new();
anyFile.WriteBinaryFile();
anyFile.WriteTextFile();
(anyFile as ITextFile).ReadFile();
(anyFile as IBinaryFile).ReadFile();
(anyFile as IBinaryFile).ShowInfo();