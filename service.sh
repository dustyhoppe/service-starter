NEW_NAME=ServiceStarter
OLD_NAME=PlaylistManager

mkdir ./$NEW_NAME

# Rename solution file
mv ./$OLD_NAME.sln ./$NEW_NAME/$NEW_NAME.sln

# Rename api directory
mv -v ./$OLD_NAME.Api ./$NEW_NAME/$NEW_NAME.Api

# Rename contracts directory
mv -v ./$OLD_NAME.Contracts ./$NEW_NAME/$NEW_NAME.Contracts

# Rename core directory
mv -v ./$OLD_NAME.Core ./$NEW_NAME/$NEW_NAME.Core

# Rename domain directory
mv -v ./$OLD_NAME.Domain ./$NEW_NAME/$NEW_NAME.Domain

# Rename infrastructure directory
mv -v ./$OLD_NAME.Infrastructure ./$NEW_NAME/$NEW_NAME.Infrastructure