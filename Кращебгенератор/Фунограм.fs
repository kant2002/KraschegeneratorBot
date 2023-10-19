namespace Фунограм

open Funogram.Telegram.Bot
open Funogram.Telegram
open Funogram.Types

module Апі =
    let апі = Funogram.Api.api
module Типи =
    type ПомилкаВідповідіАпі = ApiResponseError

module Телеграм =
    module Апі =
  
      let answerCallbackQuery = Api.answerCallbackQuery
  
      let answerInlineQueryBase = Api.answerInlineQueryBase
  
      let answerPreCheckoutQuery = Api.answerPreCheckoutQuery
    
      let answerPreCheckoutQueryError = Api.answerPreCheckoutQueryError
  
      let answerShippingQuery = Api.answerShippingQuery
    
      let answerShippingQueryError = Api.answerShippingQueryError
  
      let banChatMember = Api.banChatMember
  
      let banChatMemberByChatName = Api.banChatMemberByChatName
  
      let banChatMemberByChatNameUntil = Api.banChatMemberByChatNameUntil
  
      let banChatMemberUntil = Api.banChatMemberUntil
  
      let deleteChatPhoto = Api.deleteChatPhoto
  
      let deleteChatPhotoByChatName = Api.deleteChatPhotoByChatName
  
      let deleteChatStickerSet = Api.deleteChatStickerSet
  
      let deleteMessage = Api.deleteMessage
    
      let deleteMessageByChatName = Api.deleteMessageByChatName
  
      let видалитиБазуВебхука = Api.deleteWebhookBase
  
      let editMessageMediaBase = Api.editMessageMediaBase
  
      let editMessageReplyMarkupBase = Api.editMessageReplyMarkupBase
  
      let exportChatInviteLink = Api.exportChatInviteLink
  
      let exportChatInviteLinkByChatName = Api.exportChatInviteLinkByChatName
  
      let forwardMessage = Api.forwardMessage
  
      let getChat = Api.getChat
  
      let getChatAdministrators = Api.getChatAdministrators
  
      let getChatAdministratorsByChatName = Api.getChatAdministratorsByChatName
  
      let getChatByName = Api.getChatByName
  
      let getChatMember = Api.getChatMember
  
      let getChatMemberByChatName = Api.getChatMemberByChatName
  
      let getChatMembersCount = Api.getChatMembersCount
  
      let getChatMembersCountByChatName = Api.getChatMembersCountByChatName
  
      let getFile = Api.getFile
  
      let getGameHighScores = Api.getGameHighScores
    
      let getGameHighScoresInline = Api.getGameHighScoresInline
  
      let getMe = Api.getMe
  
      let getStickerSet = Api.getStickerSet
  
      let getUserProfilePhotos = Api.getUserProfilePhotos
  
      let getUserProfilePhotosAll = Api.getUserProfilePhotosAll
    
      let leaveChat = Api.leaveChat
  
      let leaveChatByChatName = Api.leaveChatByChatName
  
      let pinChatMessage = Api.pinChatMessage
  
      let pinChatMessageByName = Api.pinChatMessageByName
  
      let pinChatMessageByNameNotify = Api.pinChatMessageByNameNotify
  
      let pinChatMessageNotify = Api.pinChatMessageNotify
  
      let restrictChatMember = Api.restrictChatMember
  
      let sendAnimation = Api.sendAnimation
  
      let sendAudio = Api.sendAudio
  
      let sendChatAction = Api.sendChatAction
  
      let sendChatActionByChatName = Api.sendChatActionByChatName
  
      let sendContact = Api.sendContact
  
      let sendDocument = Api.sendDocument
  
      let sendLocation = Api.sendLocation
  
      let sendMediaGroup = Api.sendMediaGroup
  
      let відправитиПовідомлення = Api.sendMessage
  
      let sendMessageByChatName = Api.sendMessageByChatName
  
      let sendMessageMarkup = Api.sendMessageMarkup
  
      let sendMessageReply = Api.sendMessageReply
  
      let sendPhoto = Api.sendPhoto
  
      let sendPoll = Api.sendPoll
  
      let sendSticker = Api.sendSticker
  
      let sendVenue = Api.sendVenue
  
      let sendVideo = Api.sendVideo
  
      let sendVideoNote = Api.sendVideoNote
  
      let sendVoice = Api.sendVoice
  
      let setChatDescription = Api.setChatDescription
  
      let setChatDescriptionByChatName = Api.setChatDescriptionByChatName
  
      let setChatPermission = Api.setChatPermission
  
      let setChatPhoto = Api.setChatPhoto
  
      let setChatPhotoByChatName = Api.setChatPhotoByChatName
  
      let setChatStickerSet = Api.setChatStickerSet
  
      let setChatTitle = Api.setChatTitle
  
      let setChatTitleByChatName = Api.setChatTitleByChatName
  
      let setGameScoreBase = Api.setGameScoreBase
  
      let setPassportDataErrors = Api.setPassportDataErrors
  
      let setStickerPositionInSet = Api.setStickerPositionInSet
  
      let stopPollBase = Api.stopPollBase
  
      let unbanChatMember = Api.unbanChatMember
  
      let unbanChatMemberByChatName = Api.unbanChatMemberByChatName
  
      let unpinChatMessage = Api.unpinChatMessage
  
      let unpinChatMessageByChatName = Api.unpinChatMessageByChatName
  
      let uploadStickerFile = Api.uploadStickerFile

    module Бот =

        [<RequireQualifiedAccess>]
        module Конфігурація =
  
            let конфігЗаЗамовчанням = Config.defaultConfig
  
            let ізЧитаннямТокенуІзСереди = Config.withReadTokenFromEnv
  
            let ізЧитаннямТокенуІзФайла = Config.withReadTokenFromFile
  
        type КонтекстОновлення = UpdateContext
  
        [<Literal>]
        let Ім'яФайлаТокену = "token"
  
        let перевіритиКоманду = checkCommand
  
        let кмд = cmd
  
        let сканКмд = cmdScan
  
        let взятиТекстДляКоманди = getTextForCommand
    
        let обробитиКоманди = processCommands
  
        let запуститиБота = startBot

