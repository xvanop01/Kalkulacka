all: build

build:
	cd math_library && dotnet msbuild math_library.sln

run: build
	cd bin\Debug && pokus.exe 

pack: clean
	mkdir ..\..\calc
	mkdir ..\..\calc\install
	mkdir ..\..\calc\repo
	mkdir ..\..\calc\doc
	xcopy /E ..\..\Kalkulacka ..\..\calc\repo
	copy ..\Calculator.exe ..\..\calc\install
	make doc
	xcopy /E ..\doc ..\..\calc\doc
	powershell "Compress-Archive ..\..\calc ..\calculator.zip"
	del ..\..\calc

clean:
	del .\bin
	del .\obj
	del .\.vs
	del .\math_library\.vs
	del .\math_library\math_library\bin
	del .\math_library\math_library\obj
	del .\math_library\MathLibraryTest\bin
	del .\math_library\MathLibraryTest\obj
	del .\math_library\Profiler\bin
	del .\math_library\Profiler\obj
	del ..\doc

test:
	cd math_library\MathLibraryTest && MathLibraryTest.csproj

doc: Doxyfile
	doxygen $<

help:
	echo Welcome to our help for this Makefile!
	echo Possible uses are:
	echo 'make'         - same as 'make all'
	echo 'make all'     - will build project from sourcefiles using dotnet
	echo 'make run'     - launch calculator
	echo 'make pack'    - packs to release archive
	echo 'make clean'   - removes unnecesary files
	echo 'make test'    - launches library tests
	echo 'make doc'     - creates program documentation using doxygen
	echo 'make profile' - launch profiler
	echo 'make help'    - show this text

profile: build
	cd math_library\Profiler\bin\Debug\netcoreapp3.1 && Profiler.exe

