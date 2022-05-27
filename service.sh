NEW_NAME=$1
PORT=$2

OLD_NAME=ServiceStarter

mkdir ./$NEW_NAME

# Rename solution file
cp ./$OLD_NAME.sln ./$NEW_NAME/$NEW_NAME.sln

# Rename api directory
cp -r ./$OLD_NAME.Api ./$NEW_NAME/$NEW_NAME.Api
mv ./$NEW_NAME/$NEW_NAME.Api/$OLD_NAME.Api.csproj ./$NEW_NAME/$NEW_NAME.Api/$NEW_NAME.Api.csproj

# Rename contracts directory
cp -r ./$OLD_NAME.Contracts ./$NEW_NAME/$NEW_NAME.Contracts
mv ./$NEW_NAME/$NEW_NAME.Contracts/$OLD_NAME.Contracts.csproj ./$NEW_NAME/$NEW_NAME.Contracts/$NEW_NAME.Contracts.csproj

# Rename core directory
cp -r ./$OLD_NAME.Core ./$NEW_NAME/$NEW_NAME.Core
mv ./$NEW_NAME/$NEW_NAME.Core/$OLD_NAME.Core.csproj ./$NEW_NAME/$NEW_NAME.Core/$NEW_NAME.Core.csproj

# Rename domain directory
cp -r ./$OLD_NAME.Domain ./$NEW_NAME/$NEW_NAME.Domain
mv ./$NEW_NAME/$NEW_NAME.Domain/$OLD_NAME.Domain.csproj ./$NEW_NAME/$NEW_NAME.Domain/$NEW_NAME.Domain.csproj

# Rename infrastructure directory
cp -r ./$OLD_NAME.Infrastructure ./$NEW_NAME/$NEW_NAME.Infrastructure
mv ./$NEW_NAME/$NEW_NAME.Infrastructure/$OLD_NAME.Infrastructure.csproj ./$NEW_NAME/$NEW_NAME.Infrastructure/$NEW_NAME.Infrastructure.csproj

grep -rl $OLD_NAME.Api ./ServiceStarter | xargs sed -i "s/$OLD_NAME.Api/$NEW_NAME.Api/g"
grep -rl $OLD_NAME.Contracts ./ServiceStarter | xargs sed -i "s/$OLD_NAME.Contracts/$NEW_NAME.Contracts/g"
grep -rl $OLD_NAME.Core ./ServiceStarter | xargs sed -i "s/$OLD_NAME.Core/$NEW_NAME.Core/g"
grep -rl $OLD_NAME.Domain ./ServiceStarter | xargs sed -i "s/$OLD_NAME.Domain/$NEW_NAME.Domain/g"
grep -rl $OLD_NAME.Infrastructure ./ServiceStarter | xargs sed -i "s/$OLD_NAME.Infrastructure/$NEW_NAME.Infrastructure/g"
grep -rl 0.0.0.0:5005 ./ServiceStarter | xargs sed -i "s/0.0.0.0:5005/0.0.0.0:$PORT/g"

cp .gitignore ./$NEW_NAME/.gitignore



