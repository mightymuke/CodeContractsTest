CodeContractsTest
=================

Tests designed to show an obscure error when using code contracts with merged assemblies.

To run double click *ClickToBuild.bat*.

This will build *BaseLibrary* which contains the following projects:

* BaseLibrary.Common (contains working contracts for reference)
* BaseLibrary.Core (contains failing contracts)
* BaseLibrary.Unittests (Tests all contracts to ensure they all work at this stage)

The tests will automatically be run on the Unittests project, and all should pass.
The first assemblies are then merged, using Common as the base.

The *ContractTester* is then built and tested. This tests objects derived from the interfaces in the BaseLibrary to ensure the contracts have been applied correctly.

