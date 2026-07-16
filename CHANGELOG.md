# Change Log

## 3.7.0

### Added

- Added new API methods and enhanced models with additional properties
- Added tag Rooms / Groups
- Added Apps API for managing portal applications
- Added Privacy Room API and encryption key management (encryption keys, file encryption info, file keys, access request keys, room privacy filter)
- Added `GetAiUserSettings` / `SetAiUserSettings` methods and related models (`AiUserSettingsDto`, `AiUserSettingsWrapper`, `SetAiUserSettingsRequestDto`) for per-user AI settings
- Added `RecommendedModelForForms` property to `AiSettingsDto`
- Added AI model pricing models (chat, embedding, and image prices) and AI image model support
- Added AI credit balance request model
- Added customer usage reporting (monthly usage and service usage reports)
- Added subscription balance and upcoming payment models
- Added backups count result models
- Added external database sync task models
- Added generated file models
- Added external sharing settings models
- Added two-factor authentication confirmation data models
- Added user existence check models
- Added webhook trigger models
- Added rate limiting documentation (`X-RateLimit-Limit`, `X-RateLimit-Remaining`, `X-RateLimit-Reset`, `Retry-After` headers) and 429/502/503 responses across API methods
- Added NuGet package README

### Changed

- Updated from System.Text to Newtonsoft
- Updated SDK OpenAPI specification v3.7.0
- Updated example values, added email length validation, and adjusted method return types in API models and methods
- Updated model fields and enums across the SDK

### Fixed

- Fixed & / ' issues
- Fixed ApiDateTimeConverter
- Fixed descriptions

### Improved / Enhanced

- Enhanced API models with detailed parameter descriptions, updated example values, and added validation for required fields
- .NET 10 update

## 3.6.0

- Fixed enum formatting and corrected data types in generated models
- Updated method descriptions and added missing/new fields
- Regenerated SDK based on OpenAPI specification v3.6.0

## 3.5.0

- Initial release
