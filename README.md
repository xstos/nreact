# NReact
React/Flux principles in C#/Xaml application. Experimental playground. 
See various demos.

Please check official React/Flux resources to undestand underlying concepts.

Implemented:
* CSX - C# syntax extension (aka React JSX). CSX -> C# transform MSBuild task and standalone executable (NReact.Csx)
* Async Virtual Xaml (aka VirtualDOM) including simple patching mechanism (no diff based on Key yet) (NElement)
* Dynamic typing for Component's Props and State (NDynamic)
* Several Type Converters including enums, colors, brushes and resources (NConverters)
* Simple Flux Dispatcher (NDispatcher)
* Nuget Package including support for Store, WPF and Silverlight apps and CSX -> C# transform MSBuild task (NReact)

To to:
* Dynamic in-app CSX compilation using embeddable compiler (Mono.CSharp, Roslyn) 
* Xaml-like Visual Studio CSX syntax transform including syntax highlighting and debugging.
* Optimise Diff-algorythm for Virtual Xaml
* Experiment with statically typed Component's Props and State 
* More type converters

Existence questions:
* Why do one need NReact?

How to install:
* Build from these sources
* Install Nuget NReact Package (install-package nreact -pre)
