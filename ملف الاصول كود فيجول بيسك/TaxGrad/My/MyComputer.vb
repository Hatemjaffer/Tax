System.NullReferenceException: لم يتم تعيين مرجع كائن لمثيل كائن.
   عند Reflector.CodeModel.Assembly.TableReader.get_Item(Int32 tableType)
   عند Reflector.CodeModel.Assembly.Module.DecodeFieldPointerTable()
   عند Reflector.CodeModel.Assembly.Module.DecodeMetaData()
   عند Reflector.CodeModel.Assembly.Module.ReadCustomAttribute(Int32 constructor, Int32 value)
   عند Reflector.CodeModel.Assembly.Module.DecodeAssemblyCustomAttributes()
   عند Reflector.CodeModel.Assembly.Assembly.LoadAttributesIfNeeded()
   عند Reflector.CodeModel.Assembly.Assembly.get_TypeForwardedTo()
   عند Reflector.CodeModel.Assembly.Equality.ResolveTypeReference(ITypeReference typeReference, HashSet`1 alreadyChecked)
   عند Reflector.CodeModel.Assembly.TypeReference.Resolve(HashSet`1 alreadyChecked)
   عند Reflector.CodeModel.Assembly.MethodReference.Resolve()
   عند Reflector.Disassembler.Instructions.CallInstruction.AnalyzeExpression(NewTranslator translator, Object value)
   عند Reflector.Disassembler.TranslatorBase.NodeAnalyzer.Analyze(CodeNode node)
   عند Reflector.Disassembler.TranslatorBase.NodeAnalyzer.AnalyzeAll()
   عند Reflector.Disassembler.TranslatorBase.NodeAnalyzer.AnalyzeAll(NewTranslator translator)
   عند Reflector.Disassembler.NewTranslator.TranslateMethodDeclaration(IMethodDeclaration mD, IMethodBody mB)
   عند Reflector.Disassembler.Disassembler.TransformMethodDeclaration(IMethodDeclaration value)
   عند Reflector.CodeModel.Visitor.Transformer.TransformMethodDeclarationCollection(IMethodDeclarationCollection methods)
   عند Reflector.Disassembler.Disassembler.TransformTypeDeclaration(ITypeDeclaration value)
   عند Reflector.Application.Translator.TranslateTypeDeclaration(ITypeDeclaration value, Boolean memberDeclarationList, Boolean methodDeclarationBody)
   عند Reflector.Application.FileDisassembler.WriteTypeDeclaration(ITypeDeclaration typeDeclaration, String sourceFile, ILanguageWriterConfiguration languageWriterConfiguration)
Namespace TaxGrad.My
End Namespace

