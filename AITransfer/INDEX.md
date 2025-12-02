# AITransfer Directory - File Index

**Purpose**: Transfer AI configuration and coding standards to new C# / .NET repositories.

---

## 📖 Documentation (Start Here!)

Read these files to understand how to use the templates:

| File | Purpose | When to Read |
|------|---------|--------------|
| **QUICK_REFERENCE.md** | Fast overview, essential commands | **START HERE** for quick setup |
| **README.md** | Comprehensive overview and detailed usage | For full understanding |
| **SETUP_GUIDE.md** | Step-by-step PowerShell commands | When copying files |
| **CUSTOMIZATION_CHECKLIST.md** | Complete customization checklist | After copying files |
| **TROUBLESHOOTING.md** | Solutions to common issues | When something goes wrong |
| **BOM_ENCODING_NOTE.md** | Important JSON encoding fix | **READ THIS** - prevents .NET CLI errors |
| **INDEX.md** | This file - navigation guide | Anytime you need orientation |

---

## 🤖 AI Configuration Files

Templates for AI assistants - customize for your project:

### GitHub Copilot
| File | Destination | Required? | Notes |
|------|-------------|-----------|-------|
| copilot-instructions.md | `.github/` | ✅ Recommended | Main Copilot coding standards |
| global-copilot-instructions.md | `.github/` | ⚪ Optional | General app development guidelines |
| CSharpStudies.md | `.github/` | ⚪ Optional | For learning/training projects only |

### Other AI Assistants
| File | Destination | Required? | Notes |
|------|-------------|-----------|-------|
| junie-guidelines.md | `.junie/` | If using Junie | Junie-specific project guidelines |

---

## ⚙️ Configuration Files

Standard .NET project configuration:

| File | Destination | Required? | Notes |
|------|-------------|-----------|-------|
| .editorconfig | Root | ✅ Recommended | Code style and formatting rules |
| .gitignore | Root | ✅ Recommended | Git ignore patterns for .NET |
| .gitattributes | Root | ✅ Recommended | Git line ending configuration |
| global.json | Root | ✅ Required | .NET SDK version specification |

---

## 🚀 Quick Start Workflow

```
1. Read QUICK_REFERENCE.md
   ↓
2. Copy AITransfer folder to new repo
   ↓
3. Run setup commands from SETUP_GUIDE.md
   ↓
4. ⚠️ FIX BOM in global.json (CRITICAL!)
   ↓
5. Work through CUSTOMIZATION_CHECKLIST.md
   ↓
6. Test build: dotnet build
   ↓
7. Commit to git
   ↓
8. Create GitHub repo (see SETUP_GUIDE.md)
   ↓
9. Push to GitHub
```

**⚠️ Critical Step**: Always fix BOM encoding in `global.json` after copying! See `BOM_ENCODING_NOTE.md` or `TROUBLESHOOTING.md`.

---

## 🔄 Maintaining AITransfer Files (Important!)

**This repository serves as the source of truth for AI configuration templates.**

### Synchronization Rule

When AI instructions or configuration files evolve in **this repository's active directories** (`.github/`, `.junie/`, root config files), you **must also update** the corresponding template files in the **`AITransfer/` directory**.

**Why?** The `AITransfer/` directory is copied to new repositories. If templates become outdated, new projects will start with old conventions and patterns.

### Files That Must Stay Synchronized

| Active File (This Repo) | Template File (AITransfer) | When to Sync |
|------------------------|----------------------------|--------------|
| `.github/copilot-instructions.md` | `AITransfer/copilot-instructions.md` | After major updates to coding standards, patterns, or build commands |
| `.github/global-copilot-instructions.md` | `AITransfer/global-copilot-instructions.md` | After updates to general guidelines |
| `.junie/guidelines.md` | `AITransfer/junie-guidelines.md` | After updates to Junie AI instructions |
| `.editorconfig` | `AITransfer/.editorconfig` | After changes to code style rules |
| `.gitignore` | `AITransfer/.gitignore` | After adding new ignore patterns |
| `.gitattributes` | `AITransfer/.gitattributes` | After changes to git attributes |
| `global.json` | `AITransfer/global.json` | After .NET SDK version updates |

### Synchronization Workflow

1. **Make changes** to active files (e.g., `.github/copilot-instructions.md`)
2. **Test changes** in this repository
3. **Update template** in `AITransfer/` directory:
   - Replace project-specific values with placeholders (e.g., `Learning_AdvancedCSharpStudies` → `[PROJECT_NAME]`)
   - Keep generic patterns and standards intact
   - Add comments for required customizations
4. **Document changes** in `AITransfer/README.md` or relevant documentation
5. **Commit both files** together with a clear message

### Example Synchronization

```powershell
# After updating .github/copilot-instructions.md with new patterns:

# 1. Copy to AITransfer (manual editing required)
Copy-Item -Path ".github\copilot-instructions.md" -Destination "AITransfer\copilot-instructions-temp.md"

# 2. Edit AITransfer\copilot-instructions-temp.md:
#    - Replace "Learning_AdvancedCSharpStudies" with "[PROJECT_NAME]"
#    - Replace specific versions with "[version]" placeholders
#    - Keep new patterns and standards

# 3. Review differences
code --diff AITransfer\copilot-instructions.md AITransfer\copilot-instructions-temp.md

# 4. Replace template if changes are good
Move-Item -Path "AITransfer\copilot-instructions-temp.md" -Destination "AITransfer\copilot-instructions.md" -Force

# 5. Commit both files
git add .github\copilot-instructions.md AITransfer\copilot-instructions.md
git commit -m "Update coding standards and sync AITransfer template"
```

### AI Assistant Reminder

**For AI Assistants**: When you modify files in `.github/`, `.junie/`, or root configuration files in this repository, **you must also check and update** the corresponding template files in the `AITransfer/` directory. Replace project-specific values with appropriate placeholders before committing.

---

## 📋 Customization Requirements

**All template files require customization!** Key placeholders to replace:

### In copilot-instructions.md:
- `[PROJECT_NAME]` — Your project name
- `[ProjectFolder]` — Main project folder
- `[TestFolder]` — Test project folder
- `[SolutionName]` — Solution file name
- `[version]` — .NET/C# versions
- `[Enabled/Disabled]` — Feature flags

### In junie-guidelines.md:
- `[DATE]` — Current date
- `[ProjectName]` — Main project name
- `[TestProjectName]` — Test project name
- `[SolutionName]` — Solution name
- `[VERSION]` — .NET/C# versions
- `[Test framework name]` — xUnit/NUnit/MSTest
- `[Brief description]` — Project description

### In global.json:
- SDK version number
- Remove "comment" field

---

## 🎯 Project Type Compatibility

These templates support:

- ✅ Console Applications
- ✅ Class Libraries
- ✅ Web Applications (ASP.NET Core, Blazor, MVC)
- ✅ Desktop Applications (WPF, WinForms, MAUI)
- ✅ Azure Functions / Serverless
- ✅ Worker Services
- ✅ Test Projects

**Note**: Adjust content for your specific project type.

---

## 🔍 What Each File Does

### Documentation Files

- **QUICK_REFERENCE.md**: 3-step quick start + common mistakes
- **README.md**: Full overview, file descriptions, usage guide
- **SETUP_GUIDE.md**: PowerShell commands, verification steps
- **CUSTOMIZATION_CHECKLIST.md**: Comprehensive checklist with checkboxes
- **INDEX.md**: This navigation guide

### AI Configuration Files

- **copilot-instructions.md**: GitHub Copilot coding standards, build commands, patterns
- **global-copilot-instructions.md**: Mission canvas, architecture, general dev guidelines
- **CSharpStudies.md**: C# learning/lesson planning template
- **junie-guidelines.md**: Junie AI test/build/style instructions

### Standard Config Files

- **.editorconfig**: Code formatting, style enforcement, naming conventions
- **.gitignore**: Build artifacts, IDE files, OS files to ignore
- **.gitattributes**: Line ending normalization, diff/merge settings
- **global.json**: .NET SDK version for dotnet CLI

---

## ⚠️ Important Reminders

- ❌ **DO NOT** use these files without customization
- ❌ **DO NOT** leave placeholders like `[PROJECT_NAME]` in final files
- ✅ **DO** replace all `[...]` placeholders with actual values
- ✅ **DO** review and adjust .editorconfig for team preferences
- ✅ **DO** update global.json with correct SDK version
- ✅ **DO** commit customized files to version control

---

## 🔗 Navigation Quick Links

**Need to...**
- Get started fast? → `QUICK_REFERENCE.md`
- Understand everything? → `README.md`
- Copy files? → `SETUP_GUIDE.md`
- Customize templates? → `CUSTOMIZATION_CHECKLIST.md`
- Find your way? → `INDEX.md` (you are here)

---

**Version**: 1.0  
**Last Updated**: December 2, 2025  
**Source Repository**: Solution_Learning_BasicCSharpFeatures