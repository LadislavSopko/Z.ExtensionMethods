
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_103

	''' <summary>
	'''     Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant
	'''     culture.
	''' </summary>
	''' <param name="c">The Unicode character to convert.</param>
	''' <returns>
	'''     The lowercase equivalent of the  parameter, or the unchanged value of , if  is already lowercase or not
	'''     alphabetic.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToLowerInvariant(c As [Char]) As [Char]
		Return [Char].ToLowerInvariant(c)
	End Function
End Module


