# ProtractorTask

## Automation framework levels:

- **Tests** - NUnit tests which are built as a chain of reusable Contexts inside each test.
- **Contexts** - classes with methods which reflect business flows on the page (i.e. select something, search for something etc) by making actions with elements on the page using Page objects.
- **Pages** - classes with web elements of particular page whcih implement PageObject pattern.

## Additional Automation framework parts:

- **Elements** - classes that reflect custom elements from web pages.
- **Logging** - classes for logging implementation.

### Current implementation allows to run tests in parallel (in 2 threads) on two browsers: Chrome and Firefox.

## Tests

- **SearchForTrendInCountryAndVerifySubRegionRelatedQueriesCount** test verifies if a trend in a sub-region of a country contains exact number of related queries. **Search trend, country, sub-region and expected number of related queries** are passed as parameters from NUnit TestCase attribute. Number of expected related queries is passed as the last parameter and sometime needs to be **changed**, as search results are changed dynamically based on activity of Google users in a sub-region of a country.
