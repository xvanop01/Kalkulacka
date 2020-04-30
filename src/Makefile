all: build

build:
	cd math_library && dotnet msbuild math_library.sln

run:
	cd bin\Debug && pokus.exe 

pack:
	

clean:
	

test:
	cd math_library\MathLibraryTest && MathLibraryTest.csproj

doc: Doxyfile
	doxygen $<

help:
	

profile:
	cd math_library\Profiler\bin\Debug\netcoreapp3.1 && Profiler.exe

