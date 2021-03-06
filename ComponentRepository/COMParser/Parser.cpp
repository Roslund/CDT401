// Parser.cpp : Implementation of CParser

#include "stdafx.h"
#include "Parser.h"
#include <comutil.h>
#include <string.h>
#include <windows.h>
#include <iostream>

#define _CRT_SECURE_NO_WARNINGS

// CParser

STDMETHODIMP CParser::parseComponentFile(BSTR * fileName, BSTR * json) {
	ITypeLib * ptlb = NULL;
	ITypeInfo * ppTInfo = NULL;

	CComBSTR aux = "{'classes' : {";

	if (LoadTypeLibEx(*fileName, REGKIND_REGISTER, &ptlb) == S_OK) {
		for (UINT i = 0; i < ptlb->GetTypeInfoCount(); ++i) {
			TYPEKIND typeKind;

			ptlb->GetTypeInfoType(i, &typeKind);

			if (typeKind == TKIND_COCLASS) {
				CComBSTR className;
				TYPEATTR * typeattr;
				ptlb->GetTypeInfo(i, &ppTInfo);
				ppTInfo->GetDocumentation(MEMBERID_NIL, &className, NULL, NULL, NULL);
				ppTInfo->GetTypeAttr(&typeattr);

				GUID classGUID = typeattr->guid;


				aux.Append("'");
				aux.Append(className);
				aux.Append("': []");
				if (i < ptlb->GetTypeInfoCount() - 2) {
					aux.Append(", ");
				}
			}
		}

		aux.Append("}, 'interfaces' : {");


		for (UINT i = 0; i < ptlb->GetTypeInfoCount(); ++i) {
			TYPEKIND typeKind;

			ptlb->GetTypeInfoType(i, &typeKind);

			if (typeKind == TKIND_COCLASS) {
				CComBSTR className;
				TYPEATTR * typeattr;
				ptlb->GetTypeInfo(i, &ppTInfo);
				ppTInfo->GetDocumentation(MEMBERID_NIL, &className, NULL, NULL, NULL);
				ppTInfo->GetTypeAttr(&typeattr);

				for (UINT j = 0; j < typeattr->cImplTypes; ++j) {
					CComBSTR interfaceName;
					HREFTYPE hreftype;

					ITypeInfo * classtypeinfo;


					ppTInfo->GetRefTypeOfImplType(j, &hreftype);
					ppTInfo->GetRefTypeInfo(hreftype, &classtypeinfo);
					classtypeinfo->GetDocumentation(MEMBERID_NIL, &interfaceName, NULL, NULL, NULL);

					TYPEATTR * typeattr2;
					classtypeinfo->GetTypeAttr(&typeattr2);

					aux.Append("'");
					aux.Append(interfaceName);
					aux.Append("' : [");

					for (UINT k = 0; k < typeattr2->cFuncs; ++k) {
						CComBSTR functionName;
						FUNCDESC * funcDesc;

						classtypeinfo->GetFuncDesc(k, &funcDesc);

						UINT pcNames = 0;

						if (classtypeinfo->GetNames(funcDesc->memid, &functionName, 1, &pcNames) == S_OK) {

							aux.Append("'func ");
							aux.Append(functionName);
							aux.Append("(");

							BSTR paramName[100];

							if (classtypeinfo->GetNames(funcDesc->memid, paramName, funcDesc->cParams + 1, &pcNames) == S_OK) {
								for (UINT l = 1; l <= funcDesc->cParams; l++) {
									aux.Append(paramName[l]);
									aux.Append(": ");

									ELEMDESC elemDesc = funcDesc->lprgelemdescParam[l - 1];
									TYPEDESC typeDesc = elemDesc.tdesc;
									int x = typeDesc.vt;

									switch (x) {
										case 0:
											aux.Append("VT_EMPTY");
											break;
										case 1:
											aux.Append("VT_NULL");
											break;
										case 2:
											aux.Append("VT_I2");
											break;
										case 3:
											aux.Append("VT_I4");
											break;
										case 4:
											aux.Append("VT_R4");
											break;
										case 5:
											aux.Append("VT_R8");
											break;
										case 6:
											aux.Append("VT_CY");
											break;
										case 7:
											aux.Append("VT_DATE");
											break;
										case 8:
											aux.Append("VT_BSTR");
											break;
										case 9:
											aux.Append("VT_DISPATCH");
											break;
										case 10:
											aux.Append("VT_ERROR");
											break;
										case 11:
											aux.Append("VT_BOOL");
											break;
										case 12:
											aux.Append("VT_VARIANT");
											break;
										case 13:
											aux.Append("VT_UNKNOWN");
											break;
										case 14:
											aux.Append("VT_DECIMAL");
											break;
										case 15:
											aux.Append("VT_I1");
											break;
										case 16:
											aux.Append("VT_UI1");
											break;
										case 17:
											aux.Append("VT_UI2");
											break;
										case 18:
											aux.Append("VT_UI4");
											break;
										case 19:
											aux.Append("VT_I8");
											break;
										case 20:
											aux.Append("VT_UI8");
											break;
										case 21:
											aux.Append("VT_INT");
											break;
										case 22:
											aux.Append("VT_UINT");
											break;
										case 23:
											aux.Append("VT_VOID");
											break;
										case 24:
											aux.Append("VT_HRESULT");
											break;
										case 25:
											aux.Append("VT_PTR");
											break;
										case 26:
											aux.Append("VT_SAFEARRAY");
											break;
										case 27:
											aux.Append("VT_CARRAY");
											break;
										case 28:
											aux.Append("VT_USERDEFINED");
											break;
										case 29:
											aux.Append("VT_LPSTR");
											break;
										case 30:
											aux.Append("VT_LPWSTR");
											break;
										case 31:
											aux.Append("VT_RECORD");
											break;
										case 32:
											aux.Append("VT_INT_PTR");
											break;
										case 33:
											aux.Append("VT_UINT_PTR");
											break;
										case 34:
											aux.Append("VT_FILETIME");
											break;
										case 35:
											aux.Append("VT_BLOB");
											break;
										case 36:
											aux.Append("VT_STREAM");
											break;
										case 37:
											aux.Append("VT_STORAGE");
											break;
										case 38:
											aux.Append("VT_STREAMED_OBJECT");
											break;
										case 39:
											aux.Append("VT_STORED_OBJECT");
											break;
										case 40:
											aux.Append("VT_BLOB_OBJECT");
											break;
										case 41:
											aux.Append("VT_CF");
											break;
										case 42:
											aux.Append("VT_CLSID");
											break;
										case 43:
											aux.Append("VT_VERSIONED_STREAM");
											break;
										case 44:
											aux.Append("VT_BSTR_BLOB");
											break;
										case 45:
											aux.Append("VT_VECTOR");
											break;
										case 46:
											aux.Append("VT_ARRAY");
											break;
										case 47:
											aux.Append("VT_BYREF");
											break;
										case 48:
											aux.Append("VT_RESERVED");
											break;
										case 49:
											aux.Append("VT_ILLEGAL");
											break;
										case 50:
											aux.Append("VT_ILLEGALMASKED");
											break;
										case 51:
											aux.Append("VT_TYPEMASK");
											break;
										default:
											break;
									}

									if (l < funcDesc->cParams) {
										aux.Append(", ");
									}
								}
							}

							aux.Append(") -> ");

							ELEMDESC elemDescReturn = funcDesc->elemdescFunc;
							TYPEDESC typeDescReturn = elemDescReturn.tdesc;
							int y = typeDescReturn.vt;

							switch (y) {
							case 0:
								aux.Append("VT_EMPTY");
								break;
							case 1:
								aux.Append("VT_NULL");
								break;
							case 2:
								aux.Append("VT_I2");
								break;
							case 3:
								aux.Append("VT_I4");
								break;
							case 4:
								aux.Append("VT_R4");
								break;
							case 5:
								aux.Append("VT_R8");
								break;
							case 6:
								aux.Append("VT_CY");
								break;
							case 7:
								aux.Append("VT_DATE");
								break;
							case 8:
								aux.Append("VT_BSTR");
								break;
							case 9:
								aux.Append("VT_DISPATCH");
								break;
							case 10:
								aux.Append("VT_ERROR");
								break;
							case 11:
								aux.Append("VT_BOOL");
								break;
							case 12:
								aux.Append("VT_VARIANT");
								break;
							case 13:
								aux.Append("VT_UNKNOWN");
								break;
							case 14:
								aux.Append("VT_DECIMAL");
								break;
							case 15:
								aux.Append("VT_I1");
								break;
							case 16:
								aux.Append("VT_UI1");
								break;
							case 17:
								aux.Append("VT_UI2");
								break;
							case 18:
								aux.Append("VT_UI4");
								break;
							case 19:
								aux.Append("VT_I8");
								break;
							case 20:
								aux.Append("VT_UI8");
								break;
							case 21:
								aux.Append("VT_INT");
								break;
							case 22:
								aux.Append("VT_UINT");
								break;
							case 23:
								aux.Append("VT_VOID");
								break;
							case 24:
								aux.Append("VT_HRESULT");
								break;
							case 25:
								aux.Append("VT_PTR");
								break;
							case 26:
								aux.Append("VT_SAFEARRAY");
								break;
							case 27:
								aux.Append("VT_CARRAY");
								break;
							case 28:
								aux.Append("VT_USERDEFINED");
								break;
							case 29:
								aux.Append("VT_LPSTR");
								break;
							case 30:
								aux.Append("VT_LPWSTR");
								break;
							case 31:
								aux.Append("VT_RECORD");
								break;
							case 32:
								aux.Append("VT_INT_PTR");
								break;
							case 33:
								aux.Append("VT_UINT_PTR");
								break;
							case 34:
								aux.Append("VT_FILETIME");
								break;
							case 35:
								aux.Append("VT_BLOB");
								break;
							case 36:
								aux.Append("VT_STREAM");
								break;
							case 37:
								aux.Append("VT_STORAGE");
								break;
							case 38:
								aux.Append("VT_STREAMED_OBJECT");
								break;
							case 39:
								aux.Append("VT_STORED_OBJECT");
								break;
							case 40:
								aux.Append("VT_BLOB_OBJECT");
								break;
							case 41:
								aux.Append("VT_CF");
								break;
							case 42:
								aux.Append("VT_CLSID");
								break;
							case 43:
								aux.Append("VT_VERSIONED_STREAM");
								break;
							case 44:
								aux.Append("VT_BSTR_BLOB");
								break;
							case 45:
								aux.Append("VT_VECTOR");
								break;
							case 46:
								aux.Append("VT_ARRAY");
								break;
							case 47:
								aux.Append("VT_BYREF");
								break;
							case 48:
								aux.Append("VT_RESERVED");
								break;
							case 49:
								aux.Append("VT_ILLEGAL");
								break;
							case 50:
								aux.Append("VT_ILLEGALMASKED");
								break;
							case 51:
								aux.Append("VT_TYPEMASK");
								break;
							default:
								break;
							}

							aux.Append("'");

							if (k < (typeattr2->cFuncs - 1)) {
								aux.Append(", ");
							}
						}
					}

					aux.Append("]");

				}

				if (i < ptlb->GetTypeInfoCount() - 2) {
					aux.Append(", ");
				}
			}
		}

		ptlb->Release();
	}

	aux.Append("}}");
	*json = aux.Detach();

	return S_OK;
}