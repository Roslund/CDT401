package javacomponent;

import java.io.ByteArrayInputStream;
import java.io.FileWriter;
import java.io.IOException;

import java.util.jar.JarEntry;
import java.util.jar.JarInputStream;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

public class JavaParser implements IComponentParser
{
	
	public String parseComponent(byte[] jarFile)
	{
		// This object contains the main structure of the resulting JSON file
		JSONObject obj = new JSONObject();
		
		/*
		 * This object is structured to be a dictionary having the class name as key 
		 * and the list of its methods signature as value
		 */
		JSONObject classesDictionary = new JSONObject();
		JSONObject interfacesDictionary = new JSONObject();
		JSONArray contentArray;
		
		
		// JarInputStream is needed to read the content of a JAR File 
		JarInputStream jis = null;
		// The JarEntry class represents a file contained in a JAR File
		JarEntry entry;
		
		String className;
		Class<?> classObject;
        FileWriter file;
        
		try 
		{
			jis = new JarInputStream(new ByteArrayInputStream(jarFile));

			while((entry = jis.getNextJarEntry()) != null)
			{
				contentArray = new JSONArray();
				className = entry.getName();
				
				if(className.endsWith(".class"))
				{
					// The two statements are needed to get class name
					className = className.replaceAll("/", "\\.");
					className = className.substring(0, className.lastIndexOf('.'));
					
					// The method Clss.forName is used to retrieve the Class instance corresponding to the className
					classObject = Class.forName(className);
					
					// The following check is done to know if there is at least one field or method
					if(classObject.getDeclaredFields().length > 0)
							contentArray.put(classObject.getDeclaredFields());
					if(classObject.getDeclaredMethods().length > 0)
						contentArray.put(classObject.getDeclaredMethods());
					
					if(classObject.isInterface())
						interfacesDictionary.put(className, contentArray);
					else
						classesDictionary.put(className, contentArray);
				}
				
			}
					
		} catch (ClassNotFoundException | JSONException | SecurityException | IOException e) 
		{
			System.out.println("Exception occurred during the analysis of the JAR File");
			e.printStackTrace();
		}
		
        obj.put("classes", classesDictionary);
        obj.put("interfaces", interfacesDictionary);
             
		try 
		{
			// These statements are needed to create the JSON file 
			file = new FileWriter("C:\\Users\\cautionContent\\Desktop\\file1.json");
			file.write(obj.toString());  
			file.close();
			
		} catch (IOException e)
		{
			System.out.println("Exception occurred during the creation of the JSON File");
			e.printStackTrace();
		}
		
		return obj.toString();
	}
}
